
namespace McSkinMaker
{
    partial class output
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
            this.openFileExplorer = new System.Windows.Forms.Button();
            this.openMinecraftEdu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileExplorer
            // 
            this.openFileExplorer.Location = new System.Drawing.Point(82, 131);
            this.openFileExplorer.Name = "openFileExplorer";
            this.openFileExplorer.Size = new System.Drawing.Size(231, 56);
            this.openFileExplorer.TabIndex = 0;
            this.openFileExplorer.Text = "Open in file explorer";
            this.openFileExplorer.UseVisualStyleBackColor = true;
            this.openFileExplorer.Click += new System.EventHandler(this.openFileExplorer_Click);
            // 
            // openMinecraftEdu
            // 
            this.openMinecraftEdu.Location = new System.Drawing.Point(32, 193);
            this.openMinecraftEdu.Name = "openMinecraftEdu";
            this.openMinecraftEdu.Size = new System.Drawing.Size(342, 107);
            this.openMinecraftEdu.TabIndex = 1;
            this.openMinecraftEdu.Text = "Open in Minecraft Education Edition";
            this.openMinecraftEdu.UseVisualStyleBackColor = true;
            this.openMinecraftEdu.Click += new System.EventHandler(this.openMinecraftEdu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pack created! What would you like to do with it?";
            // 
            // copyDirectory
            // 
            this.copyDirectory.Location = new System.Drawing.Point(82, 52);
            this.copyDirectory.Name = "copyDirectory";
            this.copyDirectory.Size = new System.Drawing.Size(231, 56);
            this.copyDirectory.TabIndex = 3;
            this.copyDirectory.Text = "Copy directory";
            this.copyDirectory.UseVisualStyleBackColor = true;
            this.copyDirectory.Click += new System.EventHandler(this.copyDirectory_Click);
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 312);
            this.Controls.Add(this.copyDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openMinecraftEdu);
            this.Controls.Add(this.openFileExplorer);
            this.Name = "output";
            this.Text = "output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileExplorer;
        private System.Windows.Forms.Button openMinecraftEdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyDirectory;
    }
}