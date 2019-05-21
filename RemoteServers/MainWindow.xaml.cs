using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Added By Mehdi
using System.Management;
using System.IO;
using System.Net;
//

namespace RemoteServers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string stringUsername ;
        string stringPassword ;

        // Fill Combobox
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string stringUsername = "";
            string stringPassword = "";
            //comboBox1.Items.Add("Customized");
            foreach (UIElement UIElement in Grid1.Children)
            {
                if (UIElement.GetType().ToString() == "System.Windows.Controls.ComboBox")
                {
                    //MessageBox.Show("Hi, This is Alien from the space. How do you do.");
                    ComboBox ComboBoxX = (ComboBox)UIElement;
                    ComboBoxX.Items.Add("Customized");
                    foreach (string stringWin32class in stringWin32classes)
                    {
                        ComboBoxX.Items.Add(stringWin32class);
                    }
                    ComboBoxX.SelectedIndex = 0;
                }
            }
        }



        #region Server Info Buttons
        // Barid Recieve All Button
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.33", listBox3, comboBox4.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.34", listBox4, comboBox5.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.35", listBox5, comboBox6.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "85.185.187.107", listBox6, comboBox7.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.111", listBox7, comboBox8.SelectedValue.ToString());
        }

        // New Server Recieve Button
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(textBox2.Text, PasswordBox1.Password , textBox1.Text, listBox10, comboBox3.SelectedValue.ToString());
        }

        // PalizAfzar Recieve Button 
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.31", listBox1, comboBox1.SelectedValue.ToString());
        }
        // STS Recieve Button
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "85.185.187.108", listBox2, comboBox2.SelectedValue.ToString());
        }

        // Save STS Database
        private void button20_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.36", listBox9, comboBox14.SelectedValue.ToString());
        }

        // ACC
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.29", listBox11, comboBox9.SelectedValue.ToString());
        }
        // OT
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo("", "", "10.3.8.30", listBox12, comboBox10.SelectedValue.ToString());
        }
        // Samix
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.32", listBox13, comboBox11.SelectedValue.ToString());
        }
        //Remote Server
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "85.185.187.109", listBox14, comboBox12.SelectedValue.ToString());
        }
        //Camp
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //ServerInfo("10.3.8.109\\administrator", "P3eez@OSCAMP_mng", "10.3.8.109", listBox15, comboBox13.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.109", listBox15, comboBox13.SelectedValue.ToString());
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            // Barid Recieve All Button           
            ServerInfo(stringUsername, stringPassword, "10.3.8.33", listBox3, comboBox4.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.34", listBox4, comboBox5.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.35", listBox5, comboBox6.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "85.185.187.107", listBox6, comboBox7.SelectedValue.ToString());
            ServerInfo(stringUsername, stringPassword, "10.3.8.111", listBox7, comboBox8.SelectedValue.ToString());
            // PalizAfzar Recieve Button 
            ServerInfo(stringUsername, stringPassword, "10.3.8.31", listBox1, comboBox1.SelectedValue.ToString());
            // STS Recieve Button
            ServerInfo(stringUsername, stringPassword, "85.185.187.108", listBox2, comboBox2.SelectedValue.ToString());
            // STS DataBase
            ServerInfo(stringUsername, stringPassword, "10.3.8.36", listBox9, comboBox14.SelectedValue.ToString());
            // ACC
            ServerInfo(stringUsername, stringPassword, "10.3.8.29", listBox11, comboBox9.SelectedValue.ToString());
            // OT
            ServerInfo("", "", "", listBox12, comboBox10.SelectedValue.ToString());
            // Samix
            ServerInfo(stringUsername, stringPassword, "10.3.8.32", listBox13, comboBox11.SelectedValue.ToString());
            //Remote Server
            ServerInfo(stringUsername, stringPassword, "85.185.187.109", listBox14, comboBox12.SelectedValue.ToString());
            //Camp
            ServerInfo(stringUsername, stringPassword, "10.3.8.109", listBox15, comboBox13.SelectedValue.ToString());
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.33", listBox3, comboBox4.SelectedValue.ToString());
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.34", listBox4, comboBox5.SelectedValue.ToString());
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.35", listBox5, comboBox6.SelectedValue.ToString());
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "85.185.187.107", listBox6, comboBox7.SelectedValue.ToString());
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            ServerInfo(stringUsername, stringPassword, "10.3.8.111", listBox7, comboBox8.SelectedValue.ToString());
        }
        #endregion

        #region Server Information Functions
        /*--------------------------------------------
 * Functions
 * -------------------------------------------
 */
        private void ServerInfo(string strUsername, string strPassword, string strIP, ListBox ListBoxIn, string stringWin32class)
        {
            if (stringWin32class == "Customized")
            {
                ServerInfoCustomized(strUsername, strPassword, strIP, ListBoxIn);
            }
            else
            {
                ServerInfoWin32class(strUsername, strPassword, strIP, ListBoxIn, stringWin32class);
            }
        }

        private void ServerInfoCustomized(string strUsername, string strPassword, string strIP, ListBox ListBoxIn)
        {
            ListBox ListBoxResult = ListBoxIn;
            ListBoxResult.Items.Clear();

            ConnectionOptions options = new ConnectionOptions();
            options.Username = strUsername;
            options.Password = strPassword;
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.EnablePrivileges = true;
            // Make a connection to a remote computer.
            // Replace the "FullComputerName" section of the
            // string "\\\\FullComputerName\\root\\cimv2" with
            // the full computer name or IP address of the
            // remote computer.
            try
            {
                ManagementScope ManagementScope1 = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", strIP), options);
                ManagementScope1.Connect();

                ObjectGetOptions objectGetOptions = new ObjectGetOptions();
                ManagementPath managementPath1 = new ManagementPath("Win32_OperatingSystem");
                ManagementClass ManagementClass1 = new ManagementClass(ManagementScope1, managementPath1, objectGetOptions);

                foreach (ManagementObject ManagementObject1 in ManagementClass1.GetInstances())
                {
                    // Display the remote computer information
                    ListBoxResult.Items.Add(string.Format("Computer Name : {0}", ManagementObject1["csname"]));
                    ListBoxResult.Items.Add(string.Format("Windows Directory : {0}", ManagementObject1["WindowsDirectory"]));
                    ListBoxResult.Items.Add(string.Format("Operating System: {0}", ManagementObject1["Caption"]));
                    ListBoxResult.Items.Add(string.Format("Version: {0}", ManagementObject1["Version"]));
                    ListBoxResult.Items.Add(string.Format("Manufacturer : {0}", ManagementObject1["Manufacturer"]));
                    ListBoxResult.Items.Add(string.Format("Latest bootup time : {0}", ManagementObject1["LastBootUpTime"]));
                }
            }
            catch
            {
                ListBoxResult.Items.Add(string.Format("Can't Connect to Server: {0}", strIP));
            }
        }

        private void ServerInfoWin32class(string strUsername, string strPassword, string strIP, ListBox ListBoxIn, string stringWin32class)
        {
            ListBox ListBoxResult = ListBoxIn;
            ListBoxResult.Items.Clear();

            ConnectionOptions options = new ConnectionOptions();
            options.Username = strUsername;
            options.Password = strPassword;
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.EnablePrivileges = true;
            // Make a connection to a remote computer.
            // Replace the "FullComputerName" section of the
            // string "\\\\FullComputerName\\root\\cimv2" with
            // the full computer name or IP address of the
            // remote computer.
            try
            {
                ManagementScope ManagementScope1 = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", strIP), options);
                ManagementScope1.Connect();

                ObjectGetOptions objectGetOptions = new ObjectGetOptions();
                ManagementPath managementPath1 = new ManagementPath(stringWin32class);
                ManagementClass ManagementClass1 = new ManagementClass(ManagementScope1, managementPath1, objectGetOptions);

                PropertyDataCollection PropertyDataCollection1 = ManagementClass1.Properties;

                foreach (ManagementObject ManagementObject1 in ManagementClass1.GetInstances())
                {
                    foreach (PropertyData property in PropertyDataCollection1)
                    {
                        // Display the remote computer information
                        try
                        {
                            //StringBuilder1.AppendLine(property.Name + ":  " + obj.Properties[property.Name].Value.ToString());
                            //ListBoxResult.Items.Add(string.Format("Laset bootup time : {0}", ManagementObject1["LastBootUpTime"]));
                            ListBoxResult.Items.Add(string.Format(property.Name + ":  " + ManagementObject1.Properties[property.Name].Value.ToString()));
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
                ListBoxResult.Items.Add(string.Format("Can't Connect to Server: {0}", strIP));
            }
        }
        #endregion

        #region Check Backup Databases with FTP (Buttons)
        /* --------------------------------------
         * --------------------------------------
         * Check Backup Databases with FTP (Buttons) 
         * --------------------------------------
         * --------------------------------------
         */

        // Check Full Backup
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            /* Get Contents of a Directory with Detailed File/Directory Info */
            string[] detailDirectoryListing = directoryListDetailed(@"ftp://85.185.187.109/", "FtpUser", "whitepenguin{!@DMIN5579%1","Backup/Full");
            for (int i = 0; i < detailDirectoryListing.Count(); i++)
            {
                listBox8.Items.Add(detailDirectoryListing[i]);
            }
        }
        // Check Differential Backup
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            /* Get Contents of a Directory with Detailed File/Directory Info */
            string[] detailDirectoryListing = directoryListDetailed(@"ftp://85.185.187.109/", "FtpUser", "whitepenguin{!@DMIN5579%1", "Backup/Differential");
            for (int i = 0; i < detailDirectoryListing.Count(); i++)
            {
                listBox16.Items.Add(detailDirectoryListing[i]);
            }
        }
        // Download Full Backup
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(SaveFileDialog1.FileName);
                FTPdownload(@"ftp://85.185.187.109/", "FtpUser", "whitepenguin{!@DMIN5579%1", "Backup/Full/Full1.txt", @"F:\testNEW.txt");
            }
        }
        // Download Differential Backup
        private void button19_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(SaveFileDialog1.FileName);
                FTPdownload(@"ftp://85.185.187.109/", "FtpUser", "whitepenguin{!@DMIN5579%1", "Backup/Differential/Diff1.txt", SaveFileDialog1.FileName);
            }
        }
        #endregion

        #region Check Backup Databases with FTP  (Functions)
        /*
         * --------------------------------------------------
         * --------------------------------------------------
         * Check Backup Databases with FTP  (Functions)
         * --------------------------------------------------
         * --------------------------------------------------
         */
        /* List Directory Contents in Detail (Name, Size, Created, etc.) */
        public string[] directoryListDetailed(string host, string user, string pass, string directory)
        {

            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            Stream ftpStream = null;
            try
            {
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + directory);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try { while (ftpReader.Peek() != -1) { directoryRaw += ftpReader.ReadLine() + "|"; } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try { string[] directoryList = directoryRaw.Split("|".ToCharArray()); return directoryList; }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Return an Empty string Array if an Exception Occurs */
            return new string[] { "" };
        }

        /* Download File */
        public void FTPdownload(string host, string user, string pass, string remoteFile, string localFile)
        {
            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            int bufferSize = 2048;
            Stream ftpStream = null;
            //    try
            //    {
            /* Create an FTP Request */
            ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
            /* Log in to the FTP Server with the User Name and Password Provided */
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            /* When in doubt, use these options */
            ftpRequest.UseBinary = true;
            ftpRequest.UsePassive = true;
            ftpRequest.KeepAlive = true;
            /* Specify the Type of FTP Request */
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            /* Establish Return Communication with the FTP Server */
            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            /* Get the FTP Server's Response Stream */
            ftpStream = ftpResponse.GetResponseStream();
            /* Open a File Stream to Write the Downloaded File */
            FileStream localFileStream = new FileStream(localFile, FileMode.Create);
            /* Buffer for the Downloaded Data */
            byte[] byteBuffer = new byte[bufferSize];
            int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
            /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
            try
            {
                while (bytesRead > 0)
                {
                    localFileStream.Write(byteBuffer, 0, bytesRead);
                    bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Resource Cleanup */
            localFileStream.Close();
            ftpStream.Close();
            ftpResponse.Close();
            ftpRequest = null;
            //    }
            //    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        } 
        #endregion

        #region stringWin32classes
        string[] stringWin32classes = {"Win32_1394Controller",
"Win32_1394ControllerDevice",
"Win32_AccountSID",
"Win32_ActionCheck",
"Win32_ActiveRoute",
"Win32_AllocatedResource",
"Win32_ApplicationCommandLine",
"Win32_ApplicationService",
"Win32_AssociatedBattery",
"Win32_AssociatedProcessorMemory",
"Win32_AutochkSetting",
"Win32_BaseBoard",
"Win32_Battery",
"Win32_Binary",
"Win32_BindImageAction",
"Win32_BIOS",
"Win32_BootConfiguration",
"Win32_Bus"+
"Win32_CacheMemory",
"Win32_CDROMDrive",
"Win32_CheckCheck",
"Win32_CIMLogicalDeviceCIMDataFile",
"Win32_ClassicCOMApplicationClasses",
"Win32_ClassicCOMClass",
"Win32_ClassicCOMClassSetting",
"Win32_ClassicCOMClassSettings",
"Win32_ClassInforAction",
"Win32_ClientApplicationSetting",
"Win32_CodecFile",
"Win32_COMApplicationSettings",
"Win32_COMClassAutoEmulator",
"Win32_ComClassEmulator",
"Win32_CommandLineAccess",
"Win32_ComponentCategory",
"Win32_ComputerSystem",
"Win32_ComputerSystemProcessor",
"Win32_ComputerSystemProduct",
"Win32_ComputerSystemWindowsProductActivationSetting",
"Win32_Condition",
"Win32_ConnectionShare",
"Win32_ControllerHastHub",
"Win32_CreateFolderAction",
"Win32_CurrentProbe",
"Win32_DCOMApplication",
"Win32_DCOMApplicationAccessAllowedSetting",
"Win32_DCOMApplicationLaunchAllowedSetting",
"Win32_DCOMApplicationSetting",
"Win32_DependentService",
"Win32_Desktop",
"Win32_DesktopMonitor",
"Win32_DeviceBus",
"Win32_DeviceMemoryAddress",
"Win32_Directory",
"Win32_DirectorySpecification",
"Win32_DiskDrive",
"Win32_DiskDrivePhysicalMedia",
"Win32_DiskDriveToDiskPartition",
"Win32_DiskPartition",
"Win32_DiskQuota",
"Win32_DisplayConfiguration",
"Win32_DisplayControllerConfiguration",
"Win32_DMAChanner",
"Win32_DriverForDevice",
"Win32_DriverVXD",
"Win32_DuplicateFileAction",
"Win32_Environment",
"Win32_EnvironmentSpecification",
"Win32_ExtensionInfoAction",
"Win32_Fan",
"Win32_FileSpecification",
"Win32_FloppyController",
"Win32_FloppyDrive",
"Win32_FontInfoAction",
"Win32_Group",
"Win32_GroupDomain",
"Win32_GroupUser",
"Win32_HeatPipe",
"Win32_IDEController",
"Win32_IDEControllerDevice",
"Win32_ImplementedCategory",
"Win32_InfraredDevice",
"Win32_IniFileSpecification",
"Win32_InstalledSoftwareElement",
"Win32_IP4PersistedRouteTable",
"Win32_IP4RouteTable",
"Win32_IRQResource",
"Win32_Keyboard",
"Win32_LaunchCondition",
"Win32_LoadOrderGroup",
"Win32_LoadOrderGroupServiceDependencies",
"Win32_LoadOrderGroupServiceMembers",
"Win32_LocalTime",
"Win32_LoggedOnUser",
"Win32_LogicalDisk",
"Win32_LogicalDiskRootDirectory",
"Win32_LogicalDiskToPartition",
"Win32_LogicalFileAccess",
"Win32_LogicalFileAuditing",
"Win32_LogicalFileGroup",
"Win32_LogicalFileOwner",
"Win32_LogicalFileSecuritySetting",
"Win32_LogicalMemoryConfiguration",
"Win32_LogicalProgramGroup",
"Win32_LogicalProgramGroupDirectory",
"Win32_LogicalProgramGroupItem",
"Win32_LogicalProgramGroupItemDataFile",
"Win32_LogicalShareAccess",
"Win32_LogicalShareAuditing",
"Win32_LogicalShareSecuritySetting",
"Win32_LogonSession",
"Win32_LogonSessionMappedDisk",
"Win32_MappedLogicalDisk",
"Win32_MemoryArray",
"Win32_MemoryArrayLocation",
"Win32_MemoryDevice",
"Win32_MemoryDeviceArray",
"Win32_MemoryDeviceLocation",
"Win32_MIMEInfoAction",
"Win32_MotherboardDevice",
"Win32_MoveFileAction",
"Win32_NamedJobObject",
"Win32_NamedJobObjectActgInfo",
"Win32_NamedJobObjectLimit",
"Win32_NamedJobObjectLimitSetting",
"Win32_NamedJobObjectProcess",
"Win32_NamedJobObjectSecLimit",
"Win32_NamedJobObjectSecLimitSetting",
"Win32_NamedJobObjectStatistics",
"Win32_NetworkAdapter",
"Win32_NetworkAdapterConfiguration",
"Win32_NetworkAdapterSetting",
"Win32_NetworkClient",
"Win32_NetworkConnection",
"Win32_NetworkLoginProfile",
"Win32_NetworkProtocol",
"Win32_NTDomain",
"Win32_NTEventlogFile",
"Win32_NTLogEvent",
"Win32_NTLogEventComputer",
"Win32_NTLogEvnetLog",
"Win32_NTLogEventUser",
"Win32_ODBCAttribute",
"Win32_ODBCDataSourceAttribute",
"Win32_ODBCDataSourceSpecification",
"Win32_ODBCDriverAttribute",
"Win32_ODBCDriverSoftwareElement",
"Win32_ODBCDriverSpecification",
"Win32_ODBCSourceAttribute",
"Win32_ODBCTranslatorSpecification",
"Win32_OnBoardDevice",
"Win32_OperatingSystem",
"Win32_OperatingSystemAutochkSetting",
"Win32_OperatingSystemQFE",
"Win32_OSRecoveryConfiguration",
"Win32_PageFile",
"Win32_PageFileElementSetting",
"Win32_PageFileSetting",
"Win32_PageFileUsage",
"Win32_ParallelPort",
"Win32_Patch",
"Win32_PatchFile",
"Win32_PatchPackage",
"Win32_PCMCIAControler",
"Win32_PerfFormattedData_ASP_ActiveServerPages",
"Win32_PerfFormattedData_ASPNET_114322_ASPNETAppsv114322",
"Win32_PerfFormattedData_ASPNET_114322_ASPNETv114322",
"Win32_PerfFormattedData_ASPNET_2040607_ASPNETAppsv2040607",
"Win32_PerfFormattedData_ASPNET_2040607_ASPNETv2040607",
"Win32_PerfFormattedData_ASPNET_ASPNET",
"Win32_PerfFormattedData_ASPNET_ASPNETApplications",
"Win32_PerfFormattedData_aspnet_state_ASPNETStateService",
"Win32_PerfFormattedData_ContentFilter_IndexingServiceFilter",
"Win32_PerfFormattedData_ContentIndex_IndexingService",
"Win32_PerfFormattedData_DTSPipeline_SQLServerDTSPipeline",
"Win32_PerfFormattedData_Fax_FaxServices",
"Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal",
"Win32_PerfFormattedData_ISAPISearch_HttpIndexingService",
"Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator",
"Win32_PerfFormattedData_NETCLRData_NETCLRData",
"Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking",
"Win32_PerfFormattedData_NETDataProviderforOracle_NETCLRData",
"Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
"Win32_PerfFormattedData_NETFramework_NETCLRExceptions",
"Win32_PerfFormattedData_NETFramework_NETCLRInterop",
"Win32_PerfFormattedData_NETFramework_NETCLRJit",
"Win32_PerfFormattedData_NETFramework_NETCLRLoading",
"Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads",
"Win32_PerfFormattedData_NETFramework_NETCLRMemory",
"Win32_PerfFormattedData_NETFramework_NETCLRRemoting",
"Win32_PerfFormattedData_NETFramework_NETCLRSecurity",
"Win32_PerfFormattedData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
"Win32_PerfFormattedData_Outlook_Outlook",
"Win32_PerfFormattedData_PerfDisk_LogicalDisk",
"Win32_PerfFormattedData_PerfDisk_PhysicalDisk",
"Win32_PerfFormattedData_PerfNet_Browser",
"Win32_PerfFormattedData_PerfNet_Redirector",
"Win32_PerfFormattedData_PerfNet_Server",
"Win32_PerfFormattedData_PerfNet_ServerWorkQueues",
"Win32_PerfFormattedData_PerfOS_Cache",
"Win32_PerfFormattedData_PerfOS_Memory",
"Win32_PerfFormattedData_PerfOS_Objects",
"Win32_PerfFormattedData_PerfOS_PagingFile",
"Win32_PerfFormattedData_PerfOS_Processor",
"Win32_PerfFormattedData_PerfOS_System",
"Win32_PerfFormattedData_PerfProc_FullImage_Costly",
"Win32_PerfFormattedData_PerfProc_Image_Costly",
"Win32_PerfFormattedData_PerfProc_JobObject",
"Win32_PerfFormattedData_PerfProc_JobObjectDetails",
"Win32_PerfFormattedData_PerfProc_Process",
"Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly",
"Win32_PerfFormattedData_PerfProc_Thread",
"Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly",
"Win32_PerfFormattedData_RemoteAccess_RASPort",
"Win32_PerfFormattedData_RemoteAccess_RASTotal",
"Win32_PerfFormattedData_RSVP_RSVPInterfaces",
"Win32_PerfFormattedData_RSVP_RSVPService",
"Win32_PerfFormattedData_Spooler_PrintQueue",
"Win32_PerfFormattedData_TapiSrv_Telephony",
"Win32_PerfFormattedData_Tcpip_ICMP",
"Win32_PerfFormattedData_Tcpip_IP",
"Win32_PerfFormattedData_Tcpip_NBTConnection",
"Win32_PerfFormattedData_Tcpip_NetworkInterface",
"Win32_PerfFormattedData_Tcpip_TCP",
"Win32_PerfFormattedData_Tcpip_UDP",
"Win32_PerfFormattedData_TermService_TerminalServices",
"Win32_PerfFormattedData_TermService_TerminalServicesSession",
"Win32_PerfFormattedData_W3SVC_WebService",
"Win32_PerfRawData_ASP_ActiveServerPages",
"Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322",
"Win32_PerfRawData_ASPNET_114322_ASPNETv114322",
"Win32_PerfRawData_ASPNET_2040607_ASPNETAppsv2040607",
"Win32_PerfRawData_ASPNET_2040607_ASPNETv2040607",
"Win32_PerfRawData_ASPNET_ASPNET",
"Win32_PerfRawData_ASPNET_ASPNETApplications",
"Win32_PerfRawData_aspnet_state_ASPNETStateService",
"Win32_PerfRawData_ContentFilter_IndexingServiceFilter",
"Win32_PerfRawData_ContentIndex_IndexingService",
"Win32_PerfRawData_DTSPipeline_SQLServerDTSPipeline",
"Win32_PerfRawData_Fax_FaxServices",
"Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal",
"Win32_PerfRawData_ISAPISearch_HttpIndexingService",
"Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator",
"Win32_PerfRawData_NETCLRData_NETCLRData",
"Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking",
"Win32_PerfRawData_NETDataProviderforOracle_NETCLRData",
"Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
"Win32_PerfRawData_NETFramework_NETCLRExceptions",
"Win32_PerfRawData_NETFramework_NETCLRInterop",
"Win32_PerfRawData_NETFramework_NETCLRJit",
"Win32_PerfRawData_NETFramework_NETCLRLoading",
"Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads",
"Win32_PerfRawData_NETFramework_NETCLRMemory",
"Win32_PerfRawData_NETFramework_NETCLRRemoting",
"Win32_PerfRawData_NETFramework_NETCLRSecurity",
"Win32_PerfRawData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
"Win32_PerfRawData_Outlook_Outlook",
"Win32_PerfRawData_PerfDisk_LogicalDisk",
"Win32_PerfRawData_PerfDisk_PhysicalDisk",
"Win32_PerfRawData_PerfNet_Browser",
"Win32_PerfRawData_PerfNet_Redirector",
"Win32_PerfRawData_PerfNet_Server",
"Win32_PerfRawData_PerfNet_ServerWorkQueues",
"Win32_PerfRawData_PerfOS_Cache",
"Win32_PerfRawData_PerfOS_Memory",
"Win32_PerfRawData_PerfOS_Objects",
"Win32_PerfRawData_PerfOS_PagingFile",
"Win32_PerfRawData_PerfOS_Processor",
"Win32_PerfRawData_PerfOS_System",
"Win32_PerfRawData_PerfProc_FullImage_Costly",
"Win32_PerfRawData_PerfProc_Image_Costly",
"Win32_PerfRawData_PerfProc_JobObject",
"Win32_PerfRawData_PerfProc_JobObjectDetails",
"Win32_PerfRawData_PerfProc_Process",
"Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly",
"Win32_PerfRawData_PerfProc_Thread",
"Win32_PerfRawData_PerfProc_ThreadDetails_Costly",
"Win32_PerfRawData_RemoteAccess_RASPort",
"Win32_PerfRawData_RemoteAccess_RASTotal",
"Win32_PerfRawData_RSVP_RSVPInterfaces",
"Win32_PerfRawData_RSVP_RSVPService",
"Win32_PerfRawData_Spooler_PrintQueue",
"Win32_PerfRawData_TapiSrv_Telephony",
"Win32_PerfRawData_Tcpip_ICMP",
"Win32_PerfRawData_Tcpip_IP",
"Win32_PerfRawData_Tcpip_NBTConnection",
"Win32_PerfRawData_Tcpip_NetworkInterface",
"Win32_PerfRawData_Tcpip_TCP",
"Win32_PerfRawData_Tcpip_UDP",
"Win32_PerfRawData_TermService_TerminalServices",
"Win32_PerfRawData_TermService_TerminalServicesSession",
"Win32_PerfRawData_W3SVC_WebService",
"Win32_PhysicalMedia",
"Win32_PhysicalMemory",
"Win32_PhysicalMemoryArray",
"Win32_PhysicalMemoryLocation",
"Win32_PingStatus",
"Win32_PNPAllocatedResource",
"Win32_PnPDevice",
"Win32_PnPEntity",
"Win32_PnPSignedDriver",
"Win32_PnPSignedDriverCIMDataFile",
"Win32_PointingDevice",
"Win32_PortableBattery",
"Win32_PortConnector",
"Win32_PortResource",
"Win32_POTSModem",
"Win32_POTSModemToSerialPort",
"Win32_Printer",
"Win32_PrinterConfiguration",
"Win32_PrinterController",
"Win32_PrinterDriver",
"Win32_PrinterDriverDll",
"Win32_PrinterSetting",
"Win32_PrinterShare",
"Win32_PrintJob",
"Win32_Process",
"Win32_Processor",
"Win32_Product",
"Win32_ProductCheck",
"Win32_ProductResource",
"Win32_ProductSoftwareFeatures",
"Win32_ProgIDSpecification",
"Win32_ProgramGroup",
"Win32_ProgramGroupContents",
"Win32_Property",
"Win32_ProtocolBinding",
"Win32_Proxy",
"Win32_PublishComponentAction",
"Win32_QuickFixEngineering",
"Win32_QuotaSetting",
"Win32_Refrigeration",
"Win32_Registry",
"Win32_RegistryAction",
"Win32_RemoveFileAction",
"Win32_RemoveIniAction",
"Win32_ReserveCost",
"Win32_ScheduledJob",
"Win32_SCSIController",
"Win32_SCSIControllerDevice",
"Win32_SecuritySettingOfLogicalFile",
"Win32_SecuritySettingOfLogicalShare",
"Win32_SelfRegModuleAction",
"Win32_SerialPort",
"Win32_SerialPortConfiguration",
"Win32_SerialPortSetting",
"Win32_ServerConnection",
"Win32_ServerSession",
"Win32_Service",
"Win32_ServiceControl",
"Win32_ServiceSpecification",
"Win32_ServiceSpecificationService",
"Win32_SessionConnection",
"Win32_SessionProcess",
"Win32_Share",
"Win32_ShareToDirectory",
"Win32_ShortcutAction",
"Win32_ShortcutFile",
"Win32_ShortcutSAP",
"Win32_SID",
"Win32_SoftwareElement",
"Win32_SoftwareElementAction",
"Win32_SoftwareElementCheck",
"Win32_SoftwareElementCondition",
"Win32_SoftwareElementResource",
"Win32_SoftwareFeature",
"Win32_SoftwareFeatureAction",
"Win32_SoftwareFeatureCheck",
"Win32_SoftwareFeatureParent",
"Win32_SoftwareFeatureSoftwareElements",
"Win32_SoundDevice",
"Win32_StartupCommand",
"Win32_SubDirectory",
"Win32_SystemAccount",
"Win32_SystemBIOS",
"Win32_SystemBootConfiguration",
"Win32_SystemDesktop",
"Win32_SystemDevices",
"Win32_SystemDriver",
"Win32_SystemDriverPNPEntity",
"Win32_SystemEnclosure",
"Win32_SystemLoadOrderGroups",
"Win32_SystemLogicalMemoryConfiguration",
"Win32_SystemNetworkConnections",
"Win32_SystemOperatingSystem",
"Win32_SystemPartitions",
"Win32_SystemProcesses",
"Win32_SystemProgramGroups",
"Win32_SystemResources",
"Win32_SystemServices",
"Win32_SystemSlot",
"Win32_SystemSystemDriver",
"Win32_SystemTimeZone",
"Win32_SystemUsers",
"Win32_TapeDrive",
"Win32_TCPIPPrinterPort",
"Win32_TemperatureProbe",
"Win32_Terminal",
"Win32_TerminalService",
"Win32_TerminalServiceSetting",
"Win32_TerminalServiceToSetting",
"Win32_TerminalTerminalSetting",
"Win32_Thread",
"Win32_TimeZone",
"Win32_TSAccount",
"Win32_TSClientSetting",
"Win32_TSEnvironmentSetting",
"Win32_TSGeneralSetting",
"Win32_TSLogonSetting",
"Win32_TSNetworkAdapterListSetting",
"Win32_TSNetworkAdapterSetting",
"Win32_TSPermissionsSetting",
"Win32_TSRemoteControlSetting",
"Win32_TSSessionDirectory",
"Win32_TSSessionDirectorySetting",
"Win32_TSSessionSetting",
"Win32_TypeLibraryAction",
"Win32_UninterruptiblePowerSupply",
"Win32_USBController",
"Win32_USBControllerDevice",
"Win32_USBHub",
"Win32_UserAccount",
"Win32_UserDesktop",
"Win32_UserInDomain",
"Win32_UTCTime",
"Win32_VideoController",
"Win32_VideoSettings",
"Win32_VoltageProbe",
"Win32_VolumeQuotaSetting",
"Win32_WindowsProductActivation",
"Win32_WMIElementSetting",
"Win32_WMISetting"
};
        #endregion

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            stringUsername = textBox2.Text;
            
        }

        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            stringPassword = PasswordBox1.Password;
        }

    }
}
