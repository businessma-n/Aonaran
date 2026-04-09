namespace Aonaran_Archiver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.availablePanel = new System.Windows.Forms.Panel();
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showAlphasBox = new System.Windows.Forms.CheckBox();
            this.showBetasBox = new System.Windows.Forms.CheckBox();
            this.showSnapshotsBox = new System.Windows.Forms.CheckBox();
            this.showReleasesBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deselectButton = new System.Windows.Forms.Button();
            this.selLatestButton = new System.Windows.Forms.Button();
            this.selAlphasButton = new System.Windows.Forms.Button();
            this.selBetasButton = new System.Windows.Forms.Button();
            this.selSnapshotsButton = new System.Windows.Forms.Button();
            this.selReleasesButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.GroupBox();
            this.overwriteBox = new System.Windows.Forms.CheckBox();
            this.compressBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.currentTaskLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.createArchiveButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.javaComboBox = new System.Windows.Forms.ComboBox();
            this.openOutput = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Output.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.availablePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectedPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.createArchiveButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Selected";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availablePanel
            // 
            this.availablePanel.AutoScroll = true;
            this.availablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availablePanel.Location = new System.Drawing.Point(3, 23);
            this.availablePanel.Name = "availablePanel";
            this.availablePanel.Size = new System.Drawing.Size(389, 469);
            this.availablePanel.TabIndex = 0;
            // 
            // selectedPanel
            // 
            this.selectedPanel.AutoScroll = true;
            this.selectedPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPanel.Location = new System.Drawing.Point(398, 23);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(389, 469);
            this.selectedPanel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(389, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Available";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Output, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(793, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(193, 469);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showAlphasBox);
            this.groupBox1.Controls.Add(this.showBetasBox);
            this.groupBox1.Controls.Add(this.showSnapshotsBox);
            this.groupBox1.Controls.Add(this.showReleasesBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // showAlphasBox
            // 
            this.showAlphasBox.AutoSize = true;
            this.showAlphasBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showAlphasBox.Checked = true;
            this.showAlphasBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAlphasBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showAlphasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAlphasBox.Location = new System.Drawing.Point(3, 73);
            this.showAlphasBox.Name = "showAlphasBox";
            this.showAlphasBox.Size = new System.Drawing.Size(181, 19);
            this.showAlphasBox.TabIndex = 3;
            this.showAlphasBox.Text = "Show alphas";
            this.showAlphasBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAlphasBox.UseVisualStyleBackColor = true;
            this.showAlphasBox.CheckedChanged += new System.EventHandler(this.showAlphasBox_CheckedChanged);
            // 
            // showBetasBox
            // 
            this.showBetasBox.AutoSize = true;
            this.showBetasBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showBetasBox.Checked = true;
            this.showBetasBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBetasBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showBetasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBetasBox.Location = new System.Drawing.Point(3, 54);
            this.showBetasBox.Name = "showBetasBox";
            this.showBetasBox.Size = new System.Drawing.Size(181, 19);
            this.showBetasBox.TabIndex = 2;
            this.showBetasBox.Text = "Show betas";
            this.showBetasBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showBetasBox.UseVisualStyleBackColor = true;
            this.showBetasBox.CheckedChanged += new System.EventHandler(this.showBetasBox_CheckedChanged);
            // 
            // showSnapshotsBox
            // 
            this.showSnapshotsBox.AutoSize = true;
            this.showSnapshotsBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showSnapshotsBox.Checked = true;
            this.showSnapshotsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSnapshotsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSnapshotsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSnapshotsBox.Location = new System.Drawing.Point(3, 35);
            this.showSnapshotsBox.Name = "showSnapshotsBox";
            this.showSnapshotsBox.Size = new System.Drawing.Size(181, 19);
            this.showSnapshotsBox.TabIndex = 1;
            this.showSnapshotsBox.Text = "Show snapshots";
            this.showSnapshotsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showSnapshotsBox.UseVisualStyleBackColor = true;
            this.showSnapshotsBox.CheckedChanged += new System.EventHandler(this.showSnapshotsBox_CheckedChanged);
            // 
            // showReleasesBox
            // 
            this.showReleasesBox.AutoSize = true;
            this.showReleasesBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showReleasesBox.Checked = true;
            this.showReleasesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showReleasesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showReleasesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showReleasesBox.Location = new System.Drawing.Point(3, 16);
            this.showReleasesBox.Name = "showReleasesBox";
            this.showReleasesBox.Size = new System.Drawing.Size(181, 19);
            this.showReleasesBox.TabIndex = 0;
            this.showReleasesBox.Text = "Show releases";
            this.showReleasesBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showReleasesBox.UseVisualStyleBackColor = true;
            this.showReleasesBox.CheckedChanged += new System.EventHandler(this.showReleasesBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deselectButton);
            this.groupBox2.Controls.Add(this.selLatestButton);
            this.groupBox2.Controls.Add(this.selAlphasButton);
            this.groupBox2.Controls.Add(this.selBetasButton);
            this.groupBox2.Controls.Add(this.selSnapshotsButton);
            this.groupBox2.Controls.Add(this.selReleasesButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(187, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select";
            // 
            // deselectButton
            // 
            this.deselectButton.AutoSize = true;
            this.deselectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deselectButton.Location = new System.Drawing.Point(5, 177);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(177, 23);
            this.deselectButton.TabIndex = 5;
            this.deselectButton.Text = "Deselect All";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // selLatestButton
            // 
            this.selLatestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selLatestButton.Location = new System.Drawing.Point(5, 110);
            this.selLatestButton.Name = "selLatestButton";
            this.selLatestButton.Size = new System.Drawing.Size(177, 23);
            this.selLatestButton.TabIndex = 4;
            this.selLatestButton.Text = "Select Latest";
            this.selLatestButton.UseVisualStyleBackColor = true;
            this.selLatestButton.Click += new System.EventHandler(this.selLatestButton_Click);
            // 
            // selAlphasButton
            // 
            this.selAlphasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selAlphasButton.Location = new System.Drawing.Point(5, 87);
            this.selAlphasButton.Name = "selAlphasButton";
            this.selAlphasButton.Size = new System.Drawing.Size(177, 23);
            this.selAlphasButton.TabIndex = 3;
            this.selAlphasButton.Text = "Select Alphas";
            this.selAlphasButton.UseVisualStyleBackColor = true;
            this.selAlphasButton.Click += new System.EventHandler(this.selAlphasButton_Click);
            // 
            // selBetasButton
            // 
            this.selBetasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selBetasButton.Location = new System.Drawing.Point(5, 64);
            this.selBetasButton.Name = "selBetasButton";
            this.selBetasButton.Size = new System.Drawing.Size(177, 23);
            this.selBetasButton.TabIndex = 2;
            this.selBetasButton.Text = "Select Betas";
            this.selBetasButton.UseVisualStyleBackColor = true;
            this.selBetasButton.Click += new System.EventHandler(this.selBetasButton_Click);
            // 
            // selSnapshotsButton
            // 
            this.selSnapshotsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selSnapshotsButton.Location = new System.Drawing.Point(5, 41);
            this.selSnapshotsButton.Name = "selSnapshotsButton";
            this.selSnapshotsButton.Size = new System.Drawing.Size(177, 23);
            this.selSnapshotsButton.TabIndex = 1;
            this.selSnapshotsButton.Text = "Select Snapshots";
            this.selSnapshotsButton.UseVisualStyleBackColor = true;
            this.selSnapshotsButton.Click += new System.EventHandler(this.selSnapshotsButton_Click);
            // 
            // selReleasesButton
            // 
            this.selReleasesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selReleasesButton.Location = new System.Drawing.Point(5, 18);
            this.selReleasesButton.Name = "selReleasesButton";
            this.selReleasesButton.Size = new System.Drawing.Size(177, 23);
            this.selReleasesButton.TabIndex = 0;
            this.selReleasesButton.Text = "Select Releases";
            this.selReleasesButton.UseVisualStyleBackColor = true;
            this.selReleasesButton.Click += new System.EventHandler(this.selReleasesButton_Click);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.openOutput);
            this.Output.Controls.Add(this.overwriteBox);
            this.Output.Controls.Add(this.compressBox);
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(3, 354);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(187, 112);
            this.Output.TabIndex = 2;
            this.Output.TabStop = false;
            this.Output.Text = "Output";
            // 
            // overwriteBox
            // 
            this.overwriteBox.AutoSize = true;
            this.overwriteBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.overwriteBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.overwriteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteBox.Location = new System.Drawing.Point(3, 35);
            this.overwriteBox.Name = "overwriteBox";
            this.overwriteBox.Size = new System.Drawing.Size(181, 19);
            this.overwriteBox.TabIndex = 1;
            this.overwriteBox.Text = "Overwrite";
            this.overwriteBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.overwriteBox.UseVisualStyleBackColor = true;
            // 
            // compressBox
            // 
            this.compressBox.AutoSize = true;
            this.compressBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compressBox.Checked = true;
            this.compressBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.compressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressBox.Location = new System.Drawing.Point(3, 16);
            this.compressBox.Name = "compressBox";
            this.compressBox.Size = new System.Drawing.Size(181, 19);
            this.compressBox.TabIndex = 0;
            this.compressBox.Text = "Compress";
            this.compressBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.compressBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 498);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 49);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.currentTaskLabel);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 29);
            this.panel5.TabIndex = 1;
            // 
            // currentTaskLabel
            // 
            this.currentTaskLabel.AutoEllipsis = true;
            this.currentTaskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTaskLabel.Location = new System.Drawing.Point(41, 0);
            this.currentTaskLabel.Name = "currentTaskLabel";
            this.currentTaskLabel.Size = new System.Drawing.Size(348, 29);
            this.currentTaskLabel.TabIndex = 1;
            this.currentTaskLabel.Text = "Nothing";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Task:";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // createArchiveButton
            // 
            this.createArchiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createArchiveButton.Location = new System.Drawing.Point(795, 500);
            this.createArchiveButton.Margin = new System.Windows.Forms.Padding(5);
            this.createArchiveButton.Name = "createArchiveButton";
            this.createArchiveButton.Size = new System.Drawing.Size(189, 45);
            this.createArchiveButton.TabIndex = 7;
            this.createArchiveButton.Text = "Create Archive";
            this.createArchiveButton.UseVisualStyleBackColor = true;
            this.createArchiveButton.Click += new System.EventHandler(this.createArchiveButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(398, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 49);
            this.panel4.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.javaComboBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(389, 49);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Java Source";
            // 
            // javaComboBox
            // 
            this.javaComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.javaComboBox.FormattingEnabled = true;
            this.javaComboBox.Items.AddRange(new object[] {
            "None",
            "Mojang",
            "Mojang + Adoptium",
            "Adoptium"});
            this.javaComboBox.Location = new System.Drawing.Point(10, 23);
            this.javaComboBox.Name = "javaComboBox";
            this.javaComboBox.Size = new System.Drawing.Size(369, 21);
            this.javaComboBox.TabIndex = 0;
            this.javaComboBox.Text = "None";
            // 
            // openOutput
            // 
            this.openOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openOutput.Location = new System.Drawing.Point(3, 86);
            this.openOutput.Name = "openOutput";
            this.openOutput.Size = new System.Drawing.Size(181, 23);
            this.openOutput.TabIndex = 2;
            this.openOutput.Text = "Open Output";
            this.openOutput.UseVisualStyleBackColor = true;
            this.openOutput.Click += new System.EventHandler(this.openOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Aonaran Archiver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel availablePanel;
        private System.Windows.Forms.Panel selectedPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox showBetasBox;
        private System.Windows.Forms.CheckBox showSnapshotsBox;
        private System.Windows.Forms.CheckBox showReleasesBox;
        private System.Windows.Forms.CheckBox showAlphasBox;
        private System.Windows.Forms.Button selReleasesButton;
        private System.Windows.Forms.Button selLatestButton;
        private System.Windows.Forms.Button selAlphasButton;
        private System.Windows.Forms.Button selBetasButton;
        private System.Windows.Forms.Button selSnapshotsButton;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox javaComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label currentTaskLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.Button createArchiveButton;
        private System.Windows.Forms.CheckBox compressBox;
        private System.Windows.Forms.CheckBox overwriteBox;
        private System.Windows.Forms.Button openOutput;
    }
}

