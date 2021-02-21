using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace McSkinMaker
{
    public partial class output : Form
    {
        public output()
        {
            InitializeComponent();
            if (FileDirs.packFullDir.StartsWith(".\\"))
            {
                //If this is called, we know that it has to be the default path, .\temp\packs\packname.mcpack
                string i = FileDirs.packFullDir.Remove(0, 1);
                FileDirs.packsPathDir = Application.StartupPath + i;
            }

        }

        public static class FileDirs
        {
            public static String packFullDir = main.Globals.packsPath;
            public static String packsPathDir = main.Globals.packsPathDir;
        }


        private void openMinecraftEdu_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo(McSkinMaker.main.Globals.packsPath)
                {
                    UseShellExecute = true
                }
            }.Start();
            //System.Diagnostics.Process.Start(McSkinMaker.main.Globals.packsPath); //Old code, didnt work (but i didnt import the namespace on accident, so worth a try later?)
        }

        private void openFileExplorer_Click(object sender, EventArgs e)
        {
            McSkinMaker.main.OpenFolder(FileDirs.packsPathDir);
        }

        private void copyDirectory_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FileDirs.packsPathDir);
        }
    }
}
