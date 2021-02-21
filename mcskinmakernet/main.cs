using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;

namespace McSkinMaker
{

    public partial class main : Form
    {

        //Global Variables
        public static class Globals
        {
            public static String tempPath = @".\temp\"; //Default folders path, changed in advanced settings
            public static String packsPath = tempPath + @"packs\"; //default .mcpack path, same jazz as folders
            public static String folderPath; //default folders path, the user defined folder name is added on to the end later
            public static String zipsPath; //default zips path, same jazz as folders
            public static String skinpackname;
            public static String skinpackdescription;
            public static String skinName;
            public static String pathToImage;
            public static String packsPathDir;
            public static String versionNumber = "1.0.0";
            public static String skiningameName = null;
            public static String logName = ".\\temp\\logs\\";
        }



        //Main function

        private void startCreation()
        {
            //Check for errors
            if (Globals.pathToImage == null)
            {
                MessageBox.Show("You need to select at least one image to make a texture pack.", "Undefined variable!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (skinpackname.Text.Contains("?"))
            {
                MessageBox.Show("Folder paths cannot contain a \"?\"", "Invalid string!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Set global variables
            Globals.skinpackdescription = texturepackdescription.Text;
            Globals.skinpackname = skinpackname.Text;
            Globals.folderPath = Globals.tempPath + @"folders\";
            Globals.zipsPath = Globals.tempPath + @"zips\";

            //Set up folders to store temp data if they do not exist already
            if (!(Directory.Exists(Globals.folderPath) & Directory.Exists(Globals.zipsPath) & Directory.Exists(Globals.packsPath)))
            {
                System.IO.Directory.CreateDirectory(Globals.folderPath);
                System.IO.Directory.CreateDirectory(Globals.zipsPath);
            }
            if (!Directory.Exists(Globals.packsPath) & Globals.packsPath == Globals.tempPath + @"packs\")
            {
                System.IO.Directory.CreateDirectory(Globals.packsPath);
            }
            Globals.folderPath = Globals.folderPath + Globals.skinpackname + @"\"; //result will look like .\temp\folders\skinpackname\
            Globals.zipsPath = Globals.zipsPath + Globals.skinpackname + ".zip"; //result will look like .\temp\zips\skinpackname.zip
            Globals.packsPathDir = Globals.packsPath;
            Globals.packsPath = Globals.packsPath + Globals.skinpackname + ".mcpack"; //Just adds on skinpackname.mcpack to packsPath


            string[] fileName = { "manifestJson", "packManifestJson", "skinsJson", "langFile" };

            foreach (string i in fileName)
            {
                DumpIntoFile(GetFiles(Globals.skinpackname, Globals.skinpackdescription, Globals.skinName, i), Globals.skinpackname, i); //Calls dumpinto file with the file pulled from getFiles
            }
            DumpImages();

            zipFile(Globals.folderPath);

            //Finished program here

            
            McSkinMaker.output outputDialog = new McSkinMaker.output();
            outputDialog.ShowDialog();
            this.Close(); //closes form after the output dialog has been shut

        }



        //Other functions



        //Folder zipper/mcpack creator
        public static void zipFile(string startPath)
        {

            ZipFile.CreateFromDirectory(startPath, Globals.zipsPath);
            System.IO.File.Copy(Globals.zipsPath, (Globals.packsPath));
        }

        //Guid genetator
        public static string GetGuid()
        {
            Guid g = Guid.NewGuid();
            return g.ToString();
        }



        //Logger

        public static void Log(string logMessage)
        {
            using (StreamWriter w = File.AppendText(Globals.logName))
            {
                LogToFile(logMessage, w);
            }
        }

        //Logs message
        public static void LogToFile(string logMessage, TextWriter w)
        {
            //w.Write("\r\nLog Entry : ");
            //w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            //w.WriteLine("  :");
            w.WriteLine($"{logMessage}");
            //w.WriteLine("-------------------------------");


        }

        //Dumps log to string
        public static string DumpLog(StreamReader r)
        {
            string line;
            string output = "";
            while ((line = r.ReadLine()) != null)
            {
                output = output + Environment.NewLine + line;
            }
            return output;
        }

        //Random string
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890123456789"; //Adding more number gen because i don't like it when there is only letters in the log file
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        //Opens a given folder path in file explorer
        public static void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        //Opens a url in browser
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        //Selects an image for pack
        public void imageSelection()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = "Images (*.png; *jpg; *.jpeg)|*.png; *.jpg;*.jpeg|All files (*.*)|*.*";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string pathtoPNG = dialog.FileName;
                Globals.pathToImage = pathtoPNG;
                string[] textSplit = pathtoPNG.Split('\\');
                string lastItem = textSplit[textSplit.Length - 1];
                Globals.skinName = lastItem;
                imageName.Text = lastItem;
                SkinPictureBox.Image = Image.FromFile(pathtoPNG);
            }

        }




        //Main file creation and dumping

        public void DumpImages()
        {
            if (!System.IO.File.Exists(System.IO.Path.Combine(Globals.folderPath, Globals.skinName)))
            {
                System.IO.File.Copy(Globals.pathToImage, System.IO.Path.Combine(Globals.folderPath, Globals.skinName));
            }
            return;
        }

        public static void DumpIntoFile(string fileText, string skinpackName, string fileName)
        {


            string textsSubFolder = System.IO.Path.Combine(Globals.folderPath, "Texts");
            System.IO.Directory.CreateDirectory(textsSubFolder);
            string newFileDirectory;


            switch (fileName)
            {
                case "manifestJson":
                    newFileDirectory = System.IO.Path.Combine(Globals.folderPath, "manifest.json");
                    break;
                case "packManifestJson":
                    newFileDirectory = System.IO.Path.Combine(Globals.folderPath, "pack_manifest.json");
                    break;
                case "skinsJson":
                    newFileDirectory = System.IO.Path.Combine(Globals.folderPath, "skins.json");
                    break;
                case "langFile":
                    newFileDirectory = System.IO.Path.Combine(textsSubFolder, "en_US.lang");
                    break;
                default:
                    newFileDirectory = fileName + ".json";
                    newFileDirectory = System.IO.Path.Combine(Globals.folderPath, newFileDirectory);
                    break;
            }
            if (!System.IO.File.Exists(newFileDirectory))
            {
                System.IO.File.WriteAllText(newFileDirectory, fileText);
            }
            return;
        }

        public static string GetFiles(string packName, string packDescription, string skinNamePng, string Type)
        {
            string[] skinNameSplit = skinNamePng.Split('.');
            string skinName = skinNameSplit[0];
            string packVersion = Globals.versionNumber;
            if (Globals.skiningameName == null)
            {
                Globals.skiningameName = skinName;
            }



            //String dumps
            string ManifestJson = $@"{{
    ""format_version"": 1,
    ""header"": {{
        ""name"": ""{packName}"",
        ""uuid"": ""{Guid.NewGuid()}"",
        ""version"": [
            1,
            0,
            0
        ]
    }},
       ""modules"": [
        {{
            ""type"": ""skin_pack"",
            ""uuid"": ""{Guid.NewGuid()}"",
            ""version"": [
                1,
                0,
                0
            ]
        }}
    ]
}}";

            string PackManifestJson = $@"{{
    ""header"": {{
      ""pack_id"": ""{Guid.NewGuid()}"",
      ""name"": ""{packName}"",
      ""pack_version"": ""{packVersion}"",
      ""description"": ""{packDescription}"",
      ""modules"": [
        {{
          ""description"": ""{packDescription}"",
          ""version"": ""1.0.0"",
          ""uuid"": ""{Guid.NewGuid()}"",
          ""type"": ""skin_pack""
        }}
      ]
    }}
}}";
            string SkinsJson = $@"{{
    ""geometry"": ""skinpacks/skins.json"",
    ""skins"": [
      {{
        ""localization_name"": ""{skinName}"",
        ""geometry"": ""geometry.humanoid.custom"",
        ""texture"": ""{skinNamePng}"",
        ""type"": ""free""
      }}
      
    ],
    ""serialize_name"": ""{packName}"",
    ""localization_name"": ""{packName}""
  }}";
            string langFile = $@"
skin.{packName}.{skinName}={Globals.skiningameName}

skinpack.{packName}={packName}";
            switch (Type)
            {
                case "manifestJson":
                    return ManifestJson;
                case "packManifestJson":
                    return PackManifestJson;
                case "skinsJson":
                    return SkinsJson;
                case "langFile":
                    return langFile;
                default:
                    break;

            }
            return "Not a valid type";


        }





        //On load

        public main()
        {
            InitializeComponent();
            if (!Directory.Exists(Globals.logName))
            {
                System.IO.Directory.CreateDirectory(Globals.logName);

            }
            Globals.logName = Globals.logName + "log" + RandomString(5) + ".log";
            toolTip1.SetToolTip(startbutton, "Start creation of the skin pack");
            toolTip1.SetToolTip(ImageSelectButton, "Select texture pack skin image");
            toolTip1.SetToolTip(pictureBox3, "Github page");
            toolTip1.SetToolTip(moreOptions, "More options for creation of pack");

            Log("Log Entry : ");
            Log($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            Log("-------------------------------");
            Log("Program start");


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //Buttoms

        private void startbutton_Click(object sender, EventArgs e)
        {
            startCreation();
        }

        private void ImageSelectButton_Click(object sender, EventArgs e)
        {
            imageSelection();
        }
        private void moreOptions_Click(object sender, EventArgs e)
        {
            advancedSettings settings = new advancedSettings();
            settings.ShowDialog();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/ssparkee/mcskinmaker");
        }



        //Text boxes

        private void skinpackname_TextChanged(object sender, EventArgs e)
        {
            Globals.skinpackname = skinpackname.Text;
        }

        private void texturepackdescription_TextChanged(object sender, EventArgs e)
        {
            Globals.skinpackdescription = texturepackdescription.Text;

        }


    }
}
