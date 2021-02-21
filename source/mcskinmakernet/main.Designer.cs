
namespace McSkinMaker
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.skinpackname = new System.Windows.Forms.TextBox();
            this.texturepackdescription = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.ImageSelectButton = new System.Windows.Forms.Button();
            this.imageSelect = new System.Windows.Forms.OpenFileDialog();
            this.moreOptions = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SkinPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // skinpackname
            // 
            this.skinpackname.Location = new System.Drawing.Point(13, 42);
            this.skinpackname.Margin = new System.Windows.Forms.Padding(2);
            this.skinpackname.Name = "skinpackname";
            this.skinpackname.Size = new System.Drawing.Size(140, 20);
            this.skinpackname.TabIndex = 1;
            this.skinpackname.Text = "texture pack name";
            this.skinpackname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinpackname.TextChanged += new System.EventHandler(this.skinpackname_TextChanged);
            // 
            // texturepackdescription
            // 
            this.texturepackdescription.Location = new System.Drawing.Point(167, 42);
            this.texturepackdescription.Margin = new System.Windows.Forms.Padding(2);
            this.texturepackdescription.Name = "texturepackdescription";
            this.texturepackdescription.Size = new System.Drawing.Size(140, 20);
            this.texturepackdescription.TabIndex = 2;
            this.texturepackdescription.Text = "texture pack description";
            this.texturepackdescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texturepackdescription.TextChanged += new System.EventHandler(this.texturepackdescription_TextChanged);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.Location = new System.Drawing.Point(188, 402);
            this.startbutton.Margin = new System.Windows.Forms.Padding(2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(86, 23);
            this.startbutton.TabIndex = 3;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // ImageSelectButton
            // 
            this.ImageSelectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImageSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageSelectButton.FlatAppearance.BorderSize = 0;
            this.ImageSelectButton.Location = new System.Drawing.Point(136, 120);
            this.ImageSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImageSelectButton.Name = "ImageSelectButton";
            this.ImageSelectButton.Size = new System.Drawing.Size(145, 30);
            this.ImageSelectButton.TabIndex = 4;
            this.ImageSelectButton.Text = "Select image";
            this.ImageSelectButton.UseVisualStyleBackColor = false;
            this.ImageSelectButton.Click += new System.EventHandler(this.ImageSelectButton_Click);
            // 
            // moreOptions
            // 
            this.moreOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moreOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moreOptions.Location = new System.Drawing.Point(61, 251);
            this.moreOptions.Margin = new System.Windows.Forms.Padding(0);
            this.moreOptions.Name = "moreOptions";
            this.moreOptions.Size = new System.Drawing.Size(246, 34);
            this.moreOptions.TabIndex = 8;
            this.moreOptions.Text = "Advanced Options";
            this.moreOptions.UseVisualStyleBackColor = false;
            this.moreOptions.Click += new System.EventHandler(this.moreOptions_Click);
            // 
            // imageName
            // 
            this.imageName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageName.Location = new System.Drawing.Point(136, 151);
            this.imageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(145, 30);
            this.imageName.TabIndex = 9;
            this.imageName.Text = "(Default Image)";
            this.imageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texture Pack Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(180, -14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(113, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "____________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Skin Settings";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(334, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 463);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.Location = new System.Drawing.Point(53, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "___________________\r\n";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(98, 402);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(86, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(-13, 427);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 1);
            this.label8.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = global::mcskinmakernet.Properties.Resources.info_24;
            this.button1.Location = new System.Drawing.Point(3, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 122);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // SkinPictureBox
            // 
            this.SkinPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SkinPictureBox.Image")));
            this.SkinPictureBox.Location = new System.Drawing.Point(13, 98);
            this.SkinPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SkinPictureBox.Name = "SkinPictureBox";
            this.SkinPictureBox.Size = new System.Drawing.Size(115, 100);
            this.SkinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SkinPictureBox.TabIndex = 10;
            this.SkinPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Image = global::mcskinmakernet.Properties.Resources.log_24;
            this.button2.Location = new System.Drawing.Point(41, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(340, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SkinPictureBox);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.moreOptions);
            this.Controls.Add(this.ImageSelectButton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.texturepackdescription);
            this.Controls.Add(this.skinpackname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "Skin Pack Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox skinpackname;
        private System.Windows.Forms.TextBox texturepackdescription;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button ImageSelectButton;
        private System.Windows.Forms.OpenFileDialog imageSelect;
        private System.Windows.Forms.Button moreOptions;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.PictureBox SkinPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

