using System;
using System.Windows.Forms;

namespace McSkinMaker
{
    public partial class advancedSettings : Form
    {
        public advancedSettings()
        {
            InitializeComponent();
        }

        private void advancedSettings_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(changeTempFolder, "Specify the folder to store temp files for the program to save files to");
            toolTip1.SetToolTip(changePackLocation, "Specify the folder to store the mcpacks after creation (in case you want to send it to other people)");
            toolTip1.SetToolTip(applySettings, "Apply settings and close");
            toolTip1.SetToolTip(cancelSettings, "Cancel without saving settings");
            toolTip1.SetToolTip(folderLocation, "./temp/");
            toolTip1.SetToolTip(packsLocation, "./temp/packs");
            toolTip1.SetToolTip(versionNumber, "Change pack version number (Makes no visible difference, pack number must be formatted correctly eg. \"1.0.0\"");
        }
        //to add - change ingame name of skin and version number

        private void applySettings_Click(object sender, EventArgs e)
        {

            //Pass settings through here
            if (!(packsLocation.Text == @".\temp\packs\"))
            {
                main.Globals.packsPath = packsLocation.Text + @"\";
            }
            if (!(folderLocation.Text == @".\temp\"))
            {
                main.Globals.tempPath = folderLocation.Text + @"\";
            }
            if (!(skinIngameNameText == null))
            {
                main.Globals.skiningameName = skinIngameNameText.Text;
            }
            main.Globals.versionNumber = versionNumberText.Text; //Will do nothing if not changed / reset
            this.Close();
        }

        private void cancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeTempFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectTempFolder = new FolderBrowserDialog();
            selectTempFolder.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = selectTempFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderLocation.Text = selectTempFolder.SelectedPath;
                toolTip1.SetToolTip(folderLocation, selectTempFolder.SelectedPath);
                Environment.SpecialFolder root = selectTempFolder.RootFolder;

            }
        }

        private void changePackLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectTempFolder = new FolderBrowserDialog();
            selectTempFolder.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = selectTempFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                packsLocation.Text = selectTempFolder.SelectedPath;
                toolTip1.SetToolTip(packsLocation, selectTempFolder.SelectedPath);
                Environment.SpecialFolder root = selectTempFolder.RootFolder;

            }
        }

        private void packsLocation_Click(object sender, EventArgs e)
        {
            main.OpenFolder(packsLocation.Text);
        }

        private void folderLocation_Click(object sender, EventArgs e)
        {
            main.OpenFolder(packsLocation.Text);
        }

        private void versionnumberReset_Click(object sender, EventArgs e)
        {
            versionNumberText.Text = "1.0.0";
        }

        private void skiningamenameReset_Click(object sender, EventArgs e)
        {
            skinIngameNameText.Text = null;
        }
    }
}
