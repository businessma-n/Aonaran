using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aonaran_Launcher
{
    public partial class Form1 : Form
    {
        private string dataFolder;
        private class InstanceIndexEntry
        {
            public string name { get; set; }
            public string path { get; set; }
            public string iconPath { get; set; }
            public bool isPinned { get; set; }
        }

        private List<InstanceIndexEntry> GetAvailableInstances(string instancesIndexPath)
        {
            Console.WriteLine(instancesIndexPath);
            InstanceIndexEntry myEntry = new InstanceIndexEntry();
            List<InstanceIndexEntry> myList = new List<InstanceIndexEntry>();

            myEntry.name = "myname";
            myEntry.path = "mypath";
            myEntry.iconPath = "myiconpath";
            myEntry.isPinned = true;

            myList.Add(myEntry);

            Console.WriteLine(JsonSerializer.Serialize<List<InstanceIndexEntry>>(myList));


            if (!File.Exists(instancesIndexPath))
            {
                return new List<InstanceIndexEntry>();
            }
            string instancesIndexRawJSON = File.ReadAllText(instancesIndexPath);
            return JsonSerializer.Deserialize<List<InstanceIndexEntry>>(instancesIndexRawJSON);
        }

        private void DisplayAvailableInstances(List<InstanceIndexEntry> instances)
        {
            Console.WriteLine(instances.Count);
            foreach (InstanceIndexEntry entry in instances)
            {
                Console.WriteLine(entry.name);
                Panel entryPanel = new Panel();
                PictureBox entryPictureBox = new PictureBox();
                Label entryLabel = new Label();

                entryPanel.AutoSize = false;
                entryPanel.Size = new Size(130, 150);
                entryPanel.BorderStyle = BorderStyle.FixedSingle;
                entryPanel.Margin = new Padding(0);

                entryPictureBox.Dock = DockStyle.Top;
                entryPictureBox.Location = new Point(0, 0);
                entryPictureBox.Margin = new Padding(1);
                entryPictureBox.Size = new Size(128, 128);
                entryPictureBox.ImageLocation = entry.iconPath;

                entryLabel.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                entryLabel.TextAlign = ContentAlignment.MiddleCenter;
                entryLabel.Dock = DockStyle.Bottom;
                entryLabel.Margin = new Padding(3, 0, 3, 0);
                entryLabel.Location = new Point(0, 128);
                entryLabel.Size = new Size(128, 20);
                entryLabel.AutoSize = false;
                entryLabel.Text = entry.name;

                entryPanel.Tag = entry.path;

                entryPanel.Controls.Add(entryPictureBox);
                entryPanel.Controls.Add(entryLabel);
                if (entry.isPinned)
                {
                    pinnedPanel.Controls.Add(entryPanel);
                } else
                {
                    instancesPanel.Controls.Add(entryPanel);
                }
                return;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aonaran");
            string instancesFolder = Path.Combine(dataFolder, "instances");

            Directory.CreateDirectory(instancesFolder);

            DisplayAvailableInstances(GetAvailableInstances(Path.Combine(instancesFolder, "instances.json")));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
