using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aonaran_Archiver
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;
        private VersionManifest versionManifest;
        private string outputPath;
        private class LatestVersions
        {
            public string release { get; set; }
            public string snapshot { get; set; }
        }
        private class VersionEntry
        {
            public string id { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string time { get; set; }
            public string releaseTime { get; set; }
        }
        private class VersionManifest
        {
            public LatestVersions latest { get; set; }
            public List<VersionEntry> versions { get; set; }
        }
        private class AssetIndex
        {
            public string id { get; set; }
            public string sha1 { get; set; }
            public uint size { get; set; }
            public uint totalSize { get; set; }
            public string url { get; set; }
        }
        private class ClientDownload
        {
            public string sha1 { get; set; }
            public uint size { get; set; }
            public string url { get; set; }
        }
        private class VersionClientDownloads
        {
            public ClientDownload client { get; set; }
            public ClientDownload client_mappings { get; set; }
            public ClientDownload server  { get; set; }
            public ClientDownload server_mappings { get; set; }
        }
        private class VersionData
        {
            public AssetIndex assetIndex { get; set; }
            public string assets { get; set; }
            public int complianceLevel { get; set; }
            public string id { get; set; }

        }
        private class AssetDownload
        {
            public string hash { get; set; }
            public int size { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateAvailableVersionLabels();
        }

        private async Task<VersionManifest> GetVersionManifest()
        {
            outputPath = Path.Combine(Environment.CurrentDirectory, "output");
            string responseBody = String.Empty;
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://launchermeta.mojang.com/mc/game/version_manifest.json");
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            VersionManifest versionManifest = JsonSerializer.Deserialize<VersionManifest>(responseBody);
            return versionManifest;
        }

        private async Task CreateAvailableVersionLabels()
        {
            versionManifest = await GetVersionManifest();
            availablePanel.SuspendLayout();
            for (int i = 0; i < versionManifest.versions.Count; i++)
            {
                Label currentLabel = new Label
                {
                    Text = versionManifest.versions[i].id,
                    Tag = versionManifest.versions[i].type,
                    Font = new Font("Microsoft Sans Serif", 9),
                    Height = 19,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = false
                };
                currentLabel.Click += VersionLabel_Click;
                availablePanel.Controls.Add(currentLabel);
            }
            availablePanel.ResumeLayout();
        }
        private void SelectVersion(Label label)
        {
            bool labelNotPresent = true;
            foreach (object item in selectedPanel.Controls)
            {
                Label currentLabel = item as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Text == label.Text)
                    {
                        labelNotPresent = false;
                    }
                }
            }
            if (labelNotPresent)
            {
                Label createdLabel = new Label
                {
                    Text = label.Text,
                    Tag = label.Tag,
                    Font = new Font("Microsoft Sans Serif", 9),
                    Height = 19,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = false
                };
                createdLabel.Click += SelectedVersionLabel_Click;
                selectedPanel.Controls.Add(createdLabel);
            }
        }
        private void WriteOutputFile(string localPath, string toWrite)
        {
            string filePath = Path.Combine(outputPath, localPath);
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, toWrite);
        }
        private void WriteOutputFile(string localPath, byte[] toWrite)
        {
            string filePath = Path.Combine(outputPath, localPath);
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllBytes(Path.Combine(outputPath, localPath), toWrite);
        }
        private bool OutputFileExists(string localPath)
        {
            string filePath = Path.Combine(outputPath, localPath);
            return File.Exists(filePath);
        }
        private bool CompareSHA1(string toHash, string expectedHash)
        {
            SHA1 sha = SHA1.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(toHash);
            byte[] computedHash = sha.ComputeHash(inputBytes);

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < computedHash.Length; i++)
            {
                sBuilder.Append(computedHash[i].ToString("x2"));
            }
            if (sBuilder.ToString() == expectedHash.ToLower())
            {
                return true;
            }
            return false;
        }
        private bool CompareSHA1(byte[] toHash, string expectedHash)
        {
            SHA1 sha = SHA1.Create();
            byte[] computedHash = sha.ComputeHash(toHash);

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < computedHash.Length; i++)
            {
                sBuilder.Append(computedHash[i].ToString("x2"));
            }
            if (sBuilder.ToString() == expectedHash.ToLower())
            {
                return true;
            }
            return false;
        }
        private async Task DownloadVersionAssets(VersionData versionData)
        {
            string responseBody = String.Empty;
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(versionData.assetIndex.url);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            WriteOutputFile(Path.Combine("assets", "indexes", versionData.assetIndex.id+".json"), responseBody);

            JsonDocument assetsDocument = JsonDocument.Parse(responseBody);
            JsonElement assetsObjects = assetsDocument.RootElement.GetProperty("objects");

            Console.WriteLine(assetsObjects.GetPropertyCount());
            progressBar1.Maximum = assetsObjects.GetPropertyCount();

            foreach (JsonProperty jsonProperty in assetsObjects.EnumerateObject())
            {
                AssetDownload assetDownload = JsonSerializer.Deserialize<AssetDownload>(jsonProperty.Value);

                string assetFsPath = Path.Combine("assets", "objects", assetDownload.hash.Substring(0, 2), assetDownload.hash);

                if (OutputFileExists(assetFsPath))
                {
                    progressBar1.PerformStep();
                }
                else
                {
                    string assetUrl = "https://resources.download.minecraft.net/" + assetDownload.hash.Substring(0, 2) + "/" + assetDownload.hash;
                    byte[] responseBodyBytes = { };
                    try
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(assetUrl);
                        response.EnsureSuccessStatusCode();
                        responseBodyBytes = await response.Content.ReadAsByteArrayAsync();
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine("\nException Caught!");
                        Console.WriteLine("Message :{0} ", e.Message);
                    }

                    if (responseBodyBytes != null)
                    {
                        if (CompareSHA1(responseBodyBytes, assetDownload.hash))
                        {
                            WriteOutputFile(assetFsPath, responseBodyBytes);
                            progressBar1.PerformStep();
                        }
                        else
                        {
                            Console.WriteLine("asset {0} did not match hash", assetDownload);
                        }
                    }
                }
            }
        }
        private async Task DownloadVersionClient(VersionData versionData, JsonDocument versionDataDocument)
        {
            JsonElement versionDownloads = versionDataDocument.RootElement.GetProperty("downloads");
            progressBar1.Maximum = versionDownloads.GetPropertyCount();
            foreach (JsonProperty jsonProperty in versionDownloads.EnumerateObject())
            {
                ClientDownload clientDownload = JsonSerializer.Deserialize<ClientDownload>(jsonProperty.Value);

                Uri uri = new Uri(clientDownload.url);
                string downloadPath = Path.Combine("downloads", versionData.id, uri.Segments.Last());

                if (OutputFileExists(downloadPath))
                {
                    progressBar1.PerformStep();
                }
                else
                {
                    Console.WriteLine(downloadPath);

                    byte[] responseBodyBytes = { };
                    try
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(clientDownload.url);
                        response.EnsureSuccessStatusCode();
                        responseBodyBytes = await response.Content.ReadAsByteArrayAsync();
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine("\nException Caught!");
                        Console.WriteLine("Message :{0} ", e.Message);
                    }

                    if (CompareSHA1(responseBodyBytes, clientDownload.sha1))
                    {
                        WriteOutputFile(downloadPath, responseBodyBytes);
                        progressBar1.PerformStep();
                    }
                }
            }
        }
        private async void CreateArchive(List<string> versionIds)
        {
            Directory.CreateDirectory(Path.Combine(outputPath, "versiondata"));

            Console.WriteLine("creating archive with {0}", String.Join(", ",versionIds));
            foreach (string versionId in versionIds)
            {
                string versionUrl = null;
                foreach (VersionEntry version in versionManifest.versions)
                {
                    if (version.id == versionId)
                    {
                        versionUrl = version.url;
                    }
                }
                if (versionUrl == null)
                {
                    continue;
                }

                string responseBody = String.Empty;
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(versionUrl);
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                VersionData versionData = JsonSerializer.Deserialize<VersionData>(responseBody);
                JsonDocument versionDataDocument = JsonDocument.Parse(responseBody);

                File.WriteAllText(Path.Combine(outputPath, "versiondata", versionData.id + ".json"), responseBody);

                currentTaskLabel.Text = $"Downloading {versionData.id} assets";
                await DownloadVersionAssets(versionData);
                progressBar1.Value = 0;

                currentTaskLabel.Text = $"Downloading {versionData.id} client";
                await DownloadVersionClient(versionData, versionDataDocument);
                progressBar1.Value = 0;

                currentTaskLabel.Text = "Nothing";
            }
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                SelectVersion(clickedLabel);
            }
        }
        private void SelectedVersionLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                availablePanel.Controls.Remove(clickedLabel);
                clickedLabel.Dispose();
            }
        }

        private void showReleasesBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;
            
            if (checkedBox != null)
            {
                availablePanel.SuspendLayout();
                foreach (Control control in availablePanel.Controls)
                {
                    Label currentLabel = control as Label;
                    if (currentLabel != null)
                    {
                        if (currentLabel.Tag.ToString() == "release")
                        {
                            currentLabel.Visible = checkedBox.Checked;
                        }
                    }
                }
                availablePanel.PerformLayout();
                availablePanel.ResumeLayout();
            }
        }
        private void showSnapshotsBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox != null)
            {
                availablePanel.SuspendLayout();
                foreach (Control control in availablePanel.Controls)
                {
                    Label currentLabel = control as Label;
                    if (currentLabel != null)
                    {
                        if (currentLabel.Tag.ToString() == "snapshot")
                        {
                            currentLabel.Visible = checkedBox.Checked;
                        }
                    }
                }
                availablePanel.PerformLayout();
                availablePanel.ResumeLayout();
            }
        }
        private void showBetasBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox != null)
            {
                availablePanel.SuspendLayout();
                foreach (Control control in availablePanel.Controls)
                {
                    Label currentLabel = control as Label;
                    if (currentLabel != null)
                    {
                        if (currentLabel.Tag.ToString() == "old_beta")
                        {
                            currentLabel.Visible = checkedBox.Checked;
                        }
                    }
                }
                availablePanel.PerformLayout();
                availablePanel.ResumeLayout();
            }
        }
        private void showAlphasBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox != null)
            {
                availablePanel.SuspendLayout();
                foreach (Control control in availablePanel.Controls)
                {
                    Label currentLabel = control as Label;
                    if (currentLabel != null)
                    {
                        if (currentLabel.Tag.ToString() == "old_alpha")
                        {
                            currentLabel.Visible = checkedBox.Checked;
                        }
                    }
                }
                availablePanel.PerformLayout();
                availablePanel.ResumeLayout();
            }
        }

        private void selReleasesButton_Click(object sender, EventArgs e)
        {
            selectedPanel.SuspendLayout();
            foreach (Control control in availablePanel.Controls)
            {
                Label currentLabel = control as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Tag.ToString() == "release")
                    {
                        SelectVersion(currentLabel);
                    }
                }
            }
            selectedPanel.ResumeLayout();
        }

        private void selSnapshotsButton_Click(object sender, EventArgs e)
        {
            selectedPanel.SuspendLayout();
            foreach (Control control in availablePanel.Controls)
            {
                Label currentLabel = control as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Tag.ToString() == "snapshot")
                    {
                        SelectVersion(currentLabel);
                    }
                }
            }
            selectedPanel.ResumeLayout();
        }

        private void selBetasButton_Click(object sender, EventArgs e)
        {
            selectedPanel.SuspendLayout();
            foreach (Control control in availablePanel.Controls)
            {
                Label currentLabel = control as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Tag.ToString() == "old_beta")
                    {
                        SelectVersion(currentLabel);
                    }
                }
            }
            selectedPanel.ResumeLayout();
        }

        private void selAlphasButton_Click(object sender, EventArgs e)
        {
            selectedPanel.SuspendLayout();
            foreach (Control control in availablePanel.Controls)
            {
                Label currentLabel = control as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Tag.ToString() == "old_alpha")
                    {
                        SelectVersion(currentLabel);
                    }
                }
            }
            selectedPanel.ResumeLayout();
        }

        private void selLatestButton_Click(object sender, EventArgs e)
        {
            selectedPanel.SuspendLayout();
            foreach (Control control in availablePanel.Controls)
            {
                Label currentLabel = control as Label;
                if (currentLabel != null)
                {
                    if (currentLabel.Text == versionManifest.latest.release || currentLabel.Text == versionManifest.latest.snapshot)
                    {
                        SelectVersion(currentLabel);
                    }
                }
            }
            selectedPanel.ResumeLayout();
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            selectedPanel.Controls.Clear();
            selectedPanel.PerformLayout();
        }

        private void createArchiveButton_Click(object sender, EventArgs e)
        {
            if (selectedPanel.Controls.Count == 0)
            {
                MessageBox.Show("Please select a version first", "No versions selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            List<string> versions = new List<string>();
            foreach (Control control in selectedPanel.Controls)
            {
                Label currentLabel = control as Label;
                versions.Add(currentLabel.Text);
            }
            CreateArchive(versions);
        }
    }
}
