using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace UWP_Multiplatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string UWPPATH = "";
        static string ModdedClients = "";
        Dictionary<string, string> ModdedClient = new Dictionary<string, string>
        {
            { "Path", "" },
            { "Name", "" },
            { "Int", "" },
        };

        public static void EnableDeveloperMode()
        {
            // Set the registry value to enable developer mode
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "reg.exe",
                Arguments = "add HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppModelUnlock /t REG_DWORD /f /v AllowAllTrustedApps /d 1",
                WindowStyle = ProcessWindowStyle.Hidden
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        static string[] PowerSheelArrayReturn(string command)
        {
            // Start a new process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-Command \"{command}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            // Start the process and read the output
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            // Return the output split into lines
            return result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        static string RunPowerShellCommand(string command)
        {
            // Start a new process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-Command \"{command}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            // Start the process and read the output
            process.Start();
            string result = process.StandardError.ReadToEnd();
            process.WaitForExit();

            // Return the output split into lines
            return result;
        }

        public void CopyDirectory(string sourceDirectory, string destinationDirectory)
        {
            // Create the destination directory if it doesn't exist
            Directory.CreateDirectory(destinationDirectory);

            // Get the files in the source directory
            string[] files = Directory.GetFiles(sourceDirectory);

            // Copy each file to the destination directory
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationPath = Path.Combine(destinationDirectory, fileName);
                File.Copy(file, destinationPath, true);
            }

            // Get the subdirectories in the source directory
            string[] subdirectories = Directory.GetDirectories(sourceDirectory);

            // Recursively copy each subdirectory to the destination directory
            foreach (string subdirectory in subdirectories)
            {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationSubdirectory = Path.Combine(destinationDirectory, subdirectoryName);
                CopyDirectory(subdirectory, destinationSubdirectory);
            }
        }

        private void CloneROBLOX() 
        {
            // Check if it exists, if so then create a new modded client folder and copy to new folder
            if (Directory.Exists(UWPPATH))
            {
                Random random = new Random();
                int randomInt = random.Next(1, 100000);
                ModdedClient["Int"] = randomInt.ToString();
                ModdedClient["Name"] = "ROBLOXCORPORATION.ROBLOX." + ModdedClient["Int"];
                ModdedClient["Path"] = ModdedClients + @"\" + ModdedClient["Name"];

                // If exists try again.. Lazy ik..
                while (Directory.Exists(ModdedClient["Path"]))
                {
                    randomInt = random.Next(1, 100000);
                    ModdedClient["Int"] = randomInt.ToString();
                    ModdedClient["Name"] = "ROBLOXCORPORATION.ROBLOX." + ModdedClient["Int"];
                    ModdedClient["Path"] = ModdedClients + @"\" + ModdedClient["Name"];
                }

                CopyDirectory(UWPPATH, ModdedClient["Path"]);
                GetModdedClientReady();
            }
            else 
            {
                MessageBox.Show("Unable to access the ROBLOX UWP path, try running the program as admin.", "ERROR");
                return;
            }
        }

        private void GetModdedClientReady()
        {
            if (Directory.Exists(ModdedClient["Path"]))
            {
                string Signature = ModdedClient["Path"] + @"\AppxSignature.p7x";
                if (File.Exists(Signature))
                {
                    File.Delete(Signature);
                }

                string XMLFile = ModdedClient["Path"] + @"\AppxManifest.xml";
                if (File.Exists(XMLFile))
                {
                    //try
                    //{
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(XMLFile);

                        XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
                        namespaceManager.AddNamespace("uap", "http://schemas.microsoft.com/appx/manifest/uap/windows10");
                        namespaceManager.AddNamespace("manifest", "http://schemas.microsoft.com/appx/manifest/foundation/windows10");

                        XmlNode identityNode = xmlDoc.SelectSingleNode("/manifest:Package/manifest:Identity", namespaceManager);
                        XmlNode visualElementsNode = xmlDoc.SelectSingleNode("//uap:VisualElements", namespaceManager);
                        XmlNode DefaultTitleNode = xmlDoc.SelectSingleNode("//uap:DefaultTile", namespaceManager);

                        if (identityNode != null && visualElementsNode != null && DefaultTitleNode != null)
                        {
                            string newTitle = "Roblox-MultiUWP-" + ModdedClient["Int"];
                            identityNode.Attributes["Name"].Value = "ROBLOXCORPORATION.ROBLOX." + ModdedClient["Int"];
                            visualElementsNode.Attributes["DisplayName"].Value = newTitle;
                            DefaultTitleNode.Attributes["ShortName"].Value = newTitle;
                            xmlDoc.Save(XMLFile);
                            RegisterModdedClient();
                        }
                        else
                        {
                            MessageBox.Show("Missing Nodes..");
                            throw new Exception("Missing nodes");
                        }
                    /*}
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to modify the AppxManifest.xml document, please try again.", "ERROR");
                        try
                        {
                            Directory.Delete(ModdedClient["Path"], true);
                        }
                        catch (Exception) { }
                        return;
                    }*/
                }
                else 
                {
                    MessageBox.Show("Unable to locate AppxManifest.xml inside modded client, please try again.", "ERROR");
                    try 
                    {
                        Directory.Delete(ModdedClient["Path"], true);
                    } catch(Exception) { }
                    return;
                }
            }
            else 
            {
                MessageBox.Show("Unable to locate the newly created modded folder. Please try again..", "ERROR");
                return;
            }
        }

        private void RegisterModdedClient()
        {
            string results = RunPowerShellCommand($"Add-AppxPackage -path \"" + ModdedClient["Path"] + @"\AppxManifest.xml" + "\" -register");
            
            if (results.Length != 0)
            {
                MessageBox.Show("There was an error while registering the modded client.", "ERROR");
                return;
            }
        }

        private void UnregisterModdedClient(string ModdedClientName)
        {
            string results = RunPowerShellCommand($"Get-AppxPackage -Name \"" + ModdedClientName + "\" | Remove-AppxPackage");

            if (results.Length != 0)
            {
                MessageBox.Show("There was an error while unregistering the modded client.", "ERROR");
                return;
            }

            if (Directory.Exists(ModdedClients + @"\" + ModdedClientName))
            {
                Directory.Delete(ModdedClients + @"\" + ModdedClientName, true);
            }
        }

        private void ScanForModdedROBLOX()
        {
            listBox1.Items.Clear();
            string[] results = PowerSheelArrayReturn($"Get-AppxPackage *ROBLOXCORPORATION.ROBLOX.* | Format-List -Property Name");

            foreach (string line in results)
            {
                if (line.StartsWith("Name"))
                {
                    listBox1.Items.Add(line.Substring(7).Trim()); // Skip "Name:" and trim the spaces
                }
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ModdedClients = baseDirectory + @"ModdedRobloxClients";

            if (!Directory.Exists(ModdedClients))
            {
                Directory.CreateDirectory(ModdedClients);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                EnableDeveloperMode();
            } catch (Exception)
            {
                MessageBox.Show("Unable to adjust Windows to allow developer settings. Ensure this application is running as admin.", "ERROR");
                Environment.Exit(0);
            }

            // We check for UWP starting up, this way we don't waste time checking later.
            string[] results = PowerSheelArrayReturn($"Get-AppxPackage *Roblox* | Format-List -Property InstallLocation");

            foreach (string line in results)
            {
                if (line.StartsWith("InstallLocation"))
                {
                    Console.WriteLine(line);
                    if (line.Contains(@"WindowsApps\ROBLOXCORPORATION.ROBLOX_"))
                    {
                        UWPPATH = line.Substring(line.IndexOf("C:")).Trim();
                    }
                }
            }

            // Let user know we couldn't find the path :(
            if (UWPPATH == string.Empty)
            {
                MessageBox.Show("Unable to locate ROBLOX UWP, this application won't work as intended. Please install ROBLOX from the Microsoft Store and try again.", "ERROR");
                Environment.Exit(0);
            }

            // We can now scan for all modded versions that may be installed.
            ScanForModdedROBLOX();
        }

        private void CreateInstance_Click(object sender, EventArgs e)
        {
            // Disable and check for ROBLOX at the UWP path
            CreateInstance.Enabled = false;
            BackgroundWorkanator.RunWorkerAsync();
        }

        private void RemoveInstance_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0) 
            {
                RemoveInstance.Enabled = false;
                BackgroundWorkanator2.RunWorkerAsync(listBox1.SelectedItem.ToString());
            }
        }

        private void BackgroundWorkanator_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CloneROBLOX();
        }

        private void BackgroundWorkanator_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ScanForModdedROBLOX();
            CreateInstance.Enabled = true;
        }

        private void BackgroundWorkanator2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UnregisterModdedClient((string)e.Argument);
        }

        private void BackgroundWorkanator2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ScanForModdedROBLOX();
            RemoveInstance.Enabled = true;
        }
    }
}
