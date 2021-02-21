
namespace McSkinMaker
{
    partial class advancedSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(advancedSettings));
            this.applySettings = new System.Windows.Forms.Button();
            this.cancelSettings = new System.Windows.Forms.Button();
            this.selectTempFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.changeTempFolder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderLocation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changePackLocation = new System.Windows.Forms.Button();
            this.packsLocation = new System.Windows.Forms.Label();
            this.versionNumber = new System.Windows.Forms.Label();
            this.versionNumberText = new System.Windows.Forms.TextBox();
            this.skinIngameNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versionnumberReset = new System.Windows.Forms.Button();
            this.skiningamenameReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applySettings
            // 
            this.applySettings.Location = new System.Drawing.Point(216, 689);
            this.applySettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applySettings.Name = "applySettings";
            this.applySettings.Size = new System.Drawing.Size(139, 47);
            this.applySettings.TabIndex = 0;
            this.applySettings.Text = "Apply";
            this.applySettings.UseVisualStyleBackColor = true;
            this.applySettings.Click += new System.EventHandler(this.applySettings_Click);
            // 
            // cancelSettings
            // 
            this.cancelSettings.Location = new System.Drawing.Point(69, 689);
            this.cancelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelSettings.Name = "cancelSettings";
            this.cancelSettings.Size = new System.Drawing.Size(139, 47);
            this.cancelSettings.TabIndex = 1;
            this.cancelSettings.Text = "Cancel";
            this.cancelSettings.UseVisualStyleBackColor = true;
            this.cancelSettings.Click += new System.EventHandler(this.cancelSettings_Click);
            // 
            // changeTempFolder
            // 
            this.changeTempFolder.Location = new System.Drawing.Point(13, 117);
            this.changeTempFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeTempFolder.Name = "changeTempFolder";
            this.changeTempFolder.Size = new System.Drawing.Size(140, 72);
            this.changeTempFolder.TabIndex = 2;
            this.changeTempFolder.Text = "Temp folder location";
            this.changeTempFolder.UseVisualStyleBackColor = true;
            this.changeTempFolder.Click += new System.EventHandler(this.changeTempFolder_Click);
            // 
            // folderLocation
            // 
            this.folderLocation.Location = new System.Drawing.Point(174, 117);
            this.folderLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.folderLocation.Name = "folderLocation";
            this.folderLocation.Size = new System.Drawing.Size(307, 72);
            this.folderLocation.TabIndex = 3;
            this.folderLocation.Text = ".\\temp\\";
            this.folderLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folderLocation.Click += new System.EventHandler(this.folderLocation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(657, 69);
            this.label7.TabIndex = 18;
            this.label7.Text = "___________________\r\n";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(489, -58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 890);
            this.label5.TabIndex = 19;
            // 
            // changePackLocation
            // 
            this.changePackLocation.Location = new System.Drawing.Point(13, 22);
            this.changePackLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changePackLocation.Name = "changePackLocation";
            this.changePackLocation.Size = new System.Drawing.Size(140, 72);
            this.changePackLocation.TabIndex = 20;
            this.changePackLocation.Text = "Mcpack Location";
            this.changePackLocation.UseVisualStyleBackColor = true;
            this.changePackLocation.Click += new System.EventHandler(this.changePackLocation_Click);
            // 
            // packsLocation
            // 
            this.packsLocation.Location = new System.Drawing.Point(174, 22);
            this.packsLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.packsLocation.Name = "packsLocation";
            this.packsLocation.Size = new System.Drawing.Size(307, 72);
            this.packsLocation.TabIndex = 21;
            this.packsLocation.Text = ".\\temp\\packs\\";
            this.packsLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.packsLocation.Click += new System.EventHandler(this.packsLocation_Click);
            // 
            // versionNumber
            // 
            this.versionNumber.Location = new System.Drawing.Point(13, 217);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(119, 61);
            this.versionNumber.TabIndex = 22;
            this.versionNumber.Text = "Version number";
            // 
            // versionNumberText
            // 
            this.versionNumberText.Location = new System.Drawing.Point(151, 236);
            this.versionNumberText.Name = "versionNumberText";
            this.versionNumberText.Size = new System.Drawing.Size(246, 31);
            this.versionNumberText.TabIndex = 23;
            this.versionNumberText.Text = "1.0.0";
            // 
            // skinIngameNameText
            // 
            this.skinIngameNameText.Location = new System.Drawing.Point(151, 305);
            this.skinIngameNameText.Name = "skinIngameNameText";
            this.skinIngameNameText.Size = new System.Drawing.Size(246, 31);
            this.skinIngameNameText.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 61);
            this.label1.TabIndex = 24;
            this.label1.Text = "Skin in-game name";
            // 
            // versionnumberReset
            // 
            this.versionnumberReset.Location = new System.Drawing.Point(409, 229);
            this.versionnumberReset.Name = "versionnumberReset";
            this.versionnumberReset.Size = new System.Drawing.Size(73, 45);
            this.versionnumberReset.TabIndex = 26;
            this.versionnumberReset.Text = "Reset";
            this.versionnumberReset.UseVisualStyleBackColor = true;
            this.versionnumberReset.Click += new System.EventHandler(this.versionnumberReset_Click);
            // 
            // skiningamenameReset
            // 
            this.skiningamenameReset.Location = new System.Drawing.Point(409, 298);
            this.skiningamenameReset.Name = "skiningamenameReset";
            this.skiningamenameReset.Size = new System.Drawing.Size(73, 45);
            this.skiningamenameReset.TabIndex = 27;
            this.skiningamenameReset.Text = "Reset";
            this.skiningamenameReset.UseVisualStyleBackColor = true;
            this.skiningamenameReset.Click += new System.EventHandler(this.skiningamenameReset_Click);
            // 
            // advancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 750);
            this.Controls.Add(this.skiningamenameReset);
            this.Controls.Add(this.versionnumberReset);
            this.Controls.Add(this.skinIngameNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionNumberText);
            this.Controls.Add(this.versionNumber);
            this.Controls.Add(this.packsLocation);
            this.Controls.Add(this.changePackLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.folderLocation);
            this.Controls.Add(this.changeTempFolder);
            this.Controls.Add(this.cancelSettings);
            this.Controls.Add(this.applySettings);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "advancedSettings";
            this.Text = "Advanced Options";
            this.Load += new System.EventHandler(this.advancedSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applySettings;
        private System.Windows.Forms.Button cancelSettings;
        private System.Windows.Forms.FolderBrowserDialog selectTempFolder;
        private System.Windows.Forms.Button changeTempFolder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label folderLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changePackLocation;
        private System.Windows.Forms.Label packsLocation;
        private System.Windows.Forms.Label versionNumber;
        private System.Windows.Forms.TextBox versionNumberText;
        private System.Windows.Forms.TextBox skinIngameNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button versionnumberReset;
        private System.Windows.Forms.Button skiningamenameReset;
    }
}