/*
This product includes software developed by Dennis Rand - CIRT.DK.
All use and distribution of the CIRT.DK developed software is subject to Version 2.0
of the Apache License (http://www.apache.org/licenses/LICENSE-2.0).
*/

using System;
using System.Collections.Generic;
using System.Text;
using AppScan;
using Microsoft.Win32;
using System.Security.AccessControl;
using AppScan.Extensions;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FiletoEXD
{
    /// <summary>
    /// FiletoEXD main implementation class.
    /// implementing the IExtensionLogic interface
    /// </summary>
	public class FiletoEXD : IExtensionLogic
	{
		#region Constants
		private static readonly string _regPlugins = "Plugins";
		private static readonly string _regFiletoEXDPlugin = "FiletoEXD";
		private static string _regEnabled = "Enabled";
		private static string _regExportPath = "ExportPath";

		#endregion

		#region Members

		public IAppScan _appScan = null;

		private bool _enabled = false;
		private string _exportPath = "C:\\";
		#endregion

		#region Properties

		public bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; }
		}
		public string ExportPath
		{
			get { return _exportPath; }
			set { _exportPath = value; }
		}

		#endregion

		/// <summary>
		/// </summary>
		public FiletoEXD()
		{
        }

        private void RegisterToEvents(IAppScan appScan)
        {
            _appScan.Scan.ScanEnded += OnScanScanned;
        }

        #region IAppScanExtension Members

        /// <summary>
        /// extension initialization. typically called on AppScan's startup
        /// </summary>
        /// <param name="appScan">main application object the extension is loaded into</param>
        /// <param name="extensionDir">extension's working directory</param>
        public void Load(IAppScan appscan, IAppScanGui appScanGui, string extensionDir)
        {
            /*
             * perform actions required for the extension to start running.
             */

            // Store the AppScan Instance
            _appScan = appscan;

            // Register AppScan Events
            RegisterToEvents(_appScan);

            ReadSettings();

            // Register AppScan GUI hooks
            appScanGui.ExtensionsMenu.Add(new MenuItem<EventArgs>("File to EXD", ShowConfigScreen));
        }

        /// <summary>
        /// retrieves data about current available ext-version
        /// </summary>
        /// <param name="targetApp">app this extension is designated for</param>
        /// <param name="targetAppVersion">current version of targetApp</param>
        /// <returns>update data of most recent extension version, or null if no data was found, or feature isn't supported. it is valid to return update data of current version. extension-update will take place only if returned value indicaes a newer version</returns>
        public ExtensionVersionInfo GetUpdateData(Edition targetApp, System.Version targetAppVersion)
        {
            return null;
        }

        #endregion

        #region Registry
        
        public void ReadSettings()
		{
			// If the read fails, just don't load the settings
			try
			{
				RegistryKey AppScanKey = Registry.CurrentUser.OpenSubKey(_appScan.RegistryPath);
				RegistryKey PluginsKey = AppScanKey.OpenSubKey(_regPlugins);
				if (PluginsKey != null)
				{
					RegistryKey FiletoEXDPluginKey = PluginsKey.OpenSubKey(_regFiletoEXDPlugin);
					if (FiletoEXDPluginKey != null)
					{
						_enabled = bool.Parse(FiletoEXDPluginKey.GetValue(_regEnabled).ToString());
						_exportPath = FiletoEXDPluginKey.GetValue(_regExportPath).ToString();

						FiletoEXDPluginKey.Close();
					}
					PluginsKey.Close();
				}
				AppScanKey.Close();
			}
			catch (Exception ex)
			{
				Console.Out.Write(ex.ToString());
			}
		}

		public void WriteSettings()
		{
			// Write shouldn't fail, but a plugin shouldn't mess up the whole product
			try
			{
				RegistryKey AppScanKey = Registry.CurrentUser.OpenSubKey(_appScan.RegistryPath, true);
				RegistryKey PluginsKey = AppScanKey.OpenSubKey(_regPlugins, true);
				if (PluginsKey == null)
					PluginsKey = AppScanKey.CreateSubKey(_regPlugins, RegistryKeyPermissionCheck.ReadWriteSubTree);

				RegistryKey FiletoEXDPluginKey = PluginsKey.OpenSubKey(_regFiletoEXDPlugin, true);
				if (FiletoEXDPluginKey == null)
					FiletoEXDPluginKey = PluginsKey.CreateSubKey(_regFiletoEXDPlugin, RegistryKeyPermissionCheck.ReadWriteSubTree, AppScanKey.GetAccessControl());

				FiletoEXDPluginKey.SetValue(_regEnabled, _enabled);
				FiletoEXDPluginKey.SetValue(_regExportPath, _exportPath);

				FiletoEXDPluginKey.Close();
				PluginsKey.Close();
				AppScanKey.Close();
			}
			catch (Exception ex)
			{
				Console.Out.Write(ex.ToString());
			}
		}
	
		#endregion

		#region Event Handlers

        /// <summary>
        ///     Exports XML Report when the Scan is finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void OnScanScanned(object sender, EventArgs e)
		{
			if (Enabled)
			{
				// Check if the folder exists
				if (System.IO.Directory.Exists(ExportPath))
				{
                    AppScan.Utilities.IXmlExporter xml = AppScan.Utilities.XmlExporterFactory.CreateInstance();
                    xml.Export(_appScan.Scan.ScanData, "AutoExport", ExportPath + "\\Report.xml");
				}
			}
		}

		#endregion

        /// <summary>
        ///   Displays our setup screen.
        /// </summary>
        /// <param name="e"></param>
      public void ShowConfigScreen(EventArgs e)
      {
         // Components used in our Form require Threading in a Single-Thread appartment
         Thread t = new Thread(new ThreadStart(StartNewStaThread));
         t.SetApartmentState(ApartmentState.STA);
         t.Start();
      }

        /// <summary>
        ///   void() to start a new thread with
        /// </summary>
        private void StartNewStaThread() { 
            Application.Run(new FiletoEXDlForm(this));
		}

        public void ImportExploreData(string path)
        {

            bool conflicts;
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                conflicts = _appScan.Scan.RequestRecorder.ImportRecordedRequests(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                try
                {
                    fs.Close();
                }
                catch { }
            }
/*
            if (conflicts)
                MessageBox.Show("Links failed to be added. EXD file can be found in " + path);
            else
                MessageBox.Show("Links successfully added - continue with full scan for complete results");
*/
            _appScan.Scan.RequestRecorder.Analyse();
        }

	}
}
