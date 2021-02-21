
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
            this.SkinPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SkinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // skinpackname
            // 
            this.skinpackname.Location = new System.Drawing.Point(21, 80);
            this.skinpackname.Name = "skinpackname";
            this.skinpackname.Size = new System.Drawing.Size(230, 31);
            this.skinpackname.TabIndex = 1;
            this.skinpackname.Text = "texture pack name";
            this.skinpackname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinpackname.TextChanged += new System.EventHandler(this.skinpackname_TextChanged);
            // 
            // texturepackdescription
            // 
            this.texturepackdescription.Location = new System.Drawing.Point(279, 80);
            this.texturepackdescription.Name = "texturepackdescription";
            this.texturepackdescription.Size = new System.Drawing.Size(230, 31);
            this.texturepackdescription.TabIndex = 2;
            this.texturepackdescription.Text = "texture pack description";
            this.texturepackdescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texturepackdescription.TextChanged += new System.EventHandler(this.texturepackdescription_TextChanged);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.Location = new System.Drawing.Point(407, 773);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(143, 45);
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
            this.ImageSelectButton.Location = new System.Drawing.Point(226, 230);
            this.ImageSelectButton.Name = "ImageSelectButton";
            this.ImageSelectButton.Size = new System.Drawing.Size(241, 57);
            this.ImageSelectButton.TabIndex = 4;
            this.ImageSelectButton.Text = "Select image";
            this.ImageSelectButton.UseVisualStyleBackColor = false;
            this.ImageSelectButton.Click += new System.EventHandler(this.ImageSelectButton_Click);
            // 
            // moreOptions
            // 
            this.moreOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moreOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moreOptions.Location = new System.Drawing.Point(21, 493);
            this.moreOptions.Margin = new System.Windows.Forms.Padding(0);
            this.moreOptions.Name = "moreOptions";
            this.moreOptions.Size = new System.Drawing.Size(529, 65);
            this.moreOptions.TabIndex = 8;
            this.moreOptions.Text = "Advanced Options";
            this.moreOptions.UseVisualStyleBackColor = false;
            this.moreOptions.Click += new System.EventHandler(this.moreOptions_Click);
            // 
            // imageName
            // 
            this.imageName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageName.Location = new System.Drawing.Point(226, 290);
            this.imageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(241, 57);
            this.imageName.TabIndex = 9;
            this.imageName.Text = "(Default Image)";
            this.imageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkinPictureBox
            // 
            this.SkinPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SkinPictureBox.Image")));
            this.SkinPictureBox.Location = new System.Drawing.Point(21, 188);
            this.SkinPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SkinPictureBox.Name = "SkinPictureBox";
            this.SkinPictureBox.Size = new System.Drawing.Size(192, 192);
            this.SkinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SkinPictureBox.TabIndex = 10;
            this.SkinPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texture Pack Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, -26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 69);
            this.label2.TabIndex = 12;
            this.label2.Text = "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(188, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 69);
            this.label3.TabIndex = 14;
            this.label3.Text = "____________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Skin Settings";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(557, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 890);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(89, 393);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(657, 69);
            this.label7.TabIndex = 17;
            this.label7.Text = "___________________\r\n";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(254, 773);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 45);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(-21, 847);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(616, 2);
            this.label8.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 498);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 235);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 851);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(567, 890);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "main";
            this.Text = "Skin Pack Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

