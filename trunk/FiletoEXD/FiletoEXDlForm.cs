/*
This product includes software developed by Dennis Rand - CIRT.DK.
All use and distribution of the CIRT.DK developed software is subject to Version 2.0
of the Apache License (http://www.apache.org/licenses/LICENSE-2.0).
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Globalization;
using Watchfire.AppScan.Configuration;
using Watchfire.AppScan.ScanLog;
using Watchfire.AppScan;
using Watchfire.AppScan.Extensions;
using Watchfire.AppScan.Scan.Data;
using System.Net;

namespace FiletoEXD
{
   public partial class FiletoEXDlForm : Form
   {
      FiletoEXD _extension;

      public FiletoEXDlForm(FiletoEXD extension)
      {
         this._extension = extension;
         InitializeComponent();
      }

      public int ProgCount = 1;

      private void CancelBtn_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void BrowseLoadBtn_Click(object sender, EventArgs e)
      {
         try
         {
            openFileDialog1.FileName = ImportPathTB.Text;
            DialogResult res = openFileDialog1.ShowDialog(this);
            if (res == DialogResult.OK)
               ImportPathTB.Text = openFileDialog1.FileName;
         }
         catch (Exception)
         {
            MessageBox.Show("File Could not be found");
            ImportPathTB.Text = "C:\\*:*";
         }

      }

      private void BtnLoad_Click(object sender, EventArgs e)
      {
         lblStatus.Text = "Mangling file, please wait...";
         lblStatus.Update();
         richTextBox1.Text = "";
         CreateBtn.Enabled = false;
         BrowseLoadBtn.Enabled = false;
         richTextBox1.Enabled = false;
         ImportPathTB.Enabled = false;
         ExportPathTB.Enabled = false;

         String Path = ImportPathTB.Text;
         try
         {
            richTextBox1.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {


               String URL = null;
               while ((URL = sr.ReadLine()) != null)
               {
                  if (progressBar1.Value.Equals(200))
                  {
                     progressBar1.Value = ProgCount;
                     progressBar1.Refresh();
                  }
                  progressBar1.Value++;
                  bool ExFileType = true;
                  if (checkBoxExcludeFT.Checked == true)
                  {
                     foreach (IExcludedFileType excludedFileType in _extension._appScan.Scan.ScanData.Config.ExcludedFileTypes)
                     {
                        if (excludedFileType.Enabled)
                        {

                           foreach (string extension in excludedFileType.Extensions)
                           {
                              if (Regex.IsMatch(URL, "[^/]+\\." + extension.ToString() + "$"))
                              {
                                 ExFileType = false;
                              }
                           }
                        }
                     }
                  }
                  if (ExFileType)
                  {
                     if (WindowsRB.Checked == true)
                     {
                        if (txtVirtualDir.Text == "")
                        {
                           URL = Regex.Replace(URL, @"^.*:\\", comboBox1.Text.ToString() + "://" + txtURL.Text + ":" + txtPort.Text + "/");
                        }
                        else
                        {
                           URL = Regex.Replace(URL, @"^.*:\\", comboBox1.Text.ToString() + "://" + txtURL.Text + ":" + txtPort.Text + "/" + txtVirtualDir.Text + "/");
                        }
                        URL = Regex.Replace(URL, @"\\", @"/");
                        if (Regex.IsMatch(URL, "/[^/]+\\.[^/]+$", RegexOptions.IgnoreCase))
                        {
                           richTextBox1.AppendText(URL + "\r\n");
                        }
                        else
                        {
                           richTextBox1.AppendText(URL + "/\r\n");
                        }
                     }
                     if (LinuxRB.Checked == true)
                     {
                        if (txtVirtualDir.Text != "")
                        {
                           URL = "/" + txtVirtualDir.Text + URL;
                        }

                        if (Regex.IsMatch(URL, "/[^/]+\\.[^/]+$", RegexOptions.IgnoreCase))
                        {
                           richTextBox1.AppendText(comboBox1.Text.ToString() + "://" + txtURL.Text + ":" + txtPort.Text + URL + "\r\n");
                        }
                        else
                        {
                           richTextBox1.AppendText(comboBox1.Text.ToString() + "://" + txtURL.Text + ":" + txtPort.Text + URL + "/\r\n");
                        }
                     }
                  }
               }
            }
            if (ExportPathTB.Enabled == false)
            {
               ExportPathTB.Text = _extension._appScan.Config.ScanFilesFolder + @"\" + comboBox1.Text.ToString() + "-" + txtURL.Text + "-" + txtPort.Text + ".exd";
               ExportPathTB.Enabled = true;
            }

            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
            progressBar1.Value = 200;
            progressBar1.Refresh();
            string[] lines = this.richTextBox1.Text.Split('\n');
            int counter;
            counter = (lines.Length);
            BtnSearchNReplace.Enabled = true;
            CreateBtn.Enabled = true;
            lblStatus.Text = counter + " lines Mangled... ";
            lblStatus.Update();
            CreateBtn.Enabled = true;
            BrowseLoadBtn.Enabled = true;
            richTextBox1.Enabled = true;
            ImportPathTB.Enabled = true;
            ExportPathTB.Enabled = true;
         }
         catch (Exception)
         {
            MessageBox.Show("The file your trying to load does not exist");
            lblStatus.Text = "Mangling File Failed...";
            lblStatus.Update();
            BrowseLoadBtn.Enabled = true;
            richTextBox1.Enabled = true;
            ImportPathTB.Enabled = true;
            ExportPathTB.Enabled = true;
         }
      }

      private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
      {

      }

      private void ExportPathTB_TextChanged(object sender, EventArgs e)
      {

      }

      private void FiletoEXDlForm_Load(object sender, EventArgs e)
      {
         comboBox1.SelectedIndex = 0;
         ExportPathTB.Text = _extension._appScan.Config.ScanFilesFolder + @"\*.*";
      }

      private void CreateBtn_Click(object sender, EventArgs e)
      {
         lblStatus.Text = "Creating EXD File...";
         lblStatus.Update();

         BtnLoad.Enabled = false;
         BrowseLoadBtn.Enabled = false;
         richTextBox1.Enabled = false;
         ImportPathTB.Enabled = false;
         ExportPathTB.Enabled = false;

         string[] lines = this.richTextBox1.Text.Split('\n');
         int counter;
         string formattedDate;
         string Path;
         CultureInfo MyCultureInfo = new CultureInfo("en-US");
         formattedDate = DateTime.Now.ToString("ddd, dd MMM yyyy, HH:mm:ss", MyCultureInfo);
         counter = (lines.Length);

         if (progressBar1.Value.Equals(200))
         {
            progressBar1.Value = ProgCount;
            progressBar1.Refresh();
         }
         progressBar1.Value++;
         // create a writer and open the file
         bool FileExist = true;
         if (File.Exists(ExportPathTB.Text))
         {
            DialogResult drchk = MessageBox.Show("File: " + ExportPathTB.Text + " Allready exists" + "\r\n\r\nDo you want to overwrite?", "Save EXD file", MessageBoxButtons.OKCancel);
            switch (drchk)
            {
               case DialogResult.OK:
                  FileExist = true;
                  break;
               case DialogResult.Cancel:
                  FileExist = false;
                  lblStatus.Text = "Creation of EXD file Cancled by user...";
                  progressBar1.Value = 200;
                  break;
            }

         }
         try
         {
            if (FileExist)
            {
               TextWriter tw = new StreamWriter(ExportPathTB.Text);

               // write a line of text to the file
               // Sat, 24 Mar 2007, 10:37:28
               tw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
               tw.WriteLine("<!-- Automatically created by AppScan at " + formattedDate + " -->");
               tw.WriteLine("<!-- Number of Requests in file = " + counter.ToString() + " -->");
               tw.WriteLine("<!-- Do NOT Edit! -->");
               tw.WriteLine("<requests>");

               // Write each object into file, after being mangled
               foreach (object ob in richTextBox1.Text.Split('\n'))
               {
                  Path = Regex.Replace(ob.ToString(), comboBox1.Text.ToString() + @"://" + txtURL.Text + @":" + txtPort.Text + @"/", "/");

                  tw.WriteLine("<request method=\"GET\" scheme=\"" + comboBox1.Text.ToString() + "\" httpVersion=\"HTTP/1.1\" host=\"" + txtURL.Text + "\" port=\"" + txtPort.Text + "\" path=\"" + Path.ToString() + "\" boundary=\"\" pathQuerySeparator=\"?\" japEncoding=\"0\">");
                  tw.WriteLine("<header name=\"Accept\" value=\"image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, */*\"/>");
                  tw.WriteLine("<header name=\"Referer\" value=\"" + comboBox1.Text.ToString() + "://" + txtURL.Text + ":" + txtPort.Text + "/\"/>");
                  tw.WriteLine("<header name=\"Accept-Language\" value=\"en\"/>");
                  tw.WriteLine("<header name=\"UA-CPU\" value=\"x86\"/>");
                  tw.WriteLine("<header name=\"User-Agent\" value=\"Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)\"/>");
                  tw.WriteLine("<header name=\"Host\" value=\"" + txtURL.Text + "\"/>");
                  tw.WriteLine("<header name=\"Connection\" value=\"Keep-Alive\"/>");
                  tw.WriteLine("</request>");
               }

               tw.WriteLine("</requests>");
               // close the stream
               tw.Close();
               lblStatus.Text = "Creating EXD File Done - " + counter.ToString() + " URL's written...";
               progressBar1.Value = 200;
               if (checkBoxImportApp.Checked == true)
               {
                  try
                  {
                     HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(comboBox1.Text + "://" + txtURL.Text + ":" + txtPort.Text));
                     WebReq.Method = "GET";
                     HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                     _extension.ImportExploreData(ExportPathTB.Text);
                     this.WindowState = FormWindowState.Minimized;
                  }
                  catch (Exception)
                  {
                     DialogResult dr = MessageBox.Show("Could not connect to " + comboBox1.Text + "://" + txtURL.Text + ":" + txtPort.Text + "\r\n\r\nDo you want to continue importing?", "Import data into Appscan", MessageBoxButtons.YesNo);
                     switch (dr)
                     {
                        case DialogResult.Yes:
                           _extension.ImportExploreData(ExportPathTB.Text);
                           this.WindowState = FormWindowState.Minimized;
                           break;
                        case DialogResult.No:
                           lblStatus.Text = "Import of EXD file into AppScan Cancled by user...";
                           break;
                     }
                  }
               }
            }
         }
         catch (Exception)
         {
            lblStatus.Text = "Creation of EXD file failed...";
            progressBar1.Value = 200;
         }
         lblStatus.Update();
         BtnLoad.Enabled = true;
         BrowseLoadBtn.Enabled = true;
         richTextBox1.Enabled = true;
         ImportPathTB.Enabled = true;
         ExportPathTB.Enabled = true;

      }

      private void WindowsRB_CheckedChanged(object sender, EventArgs e)
      {
         LinuxRB.Checked = false;
      }

      private void LinuxRB_CheckedChanged(object sender, EventArgs e)
      {
         WindowsRB.Checked = false;
      }

      private void WindowsRB_Click(object sender, EventArgs e)
      {
         LinuxRB.Checked = false;
         WindowsRB.Checked = true;
      }

      private void LinuxRB_Click(object sender, EventArgs e)
      {
         WindowsRB.Checked = false;
         LinuxRB.Checked = true;
      }

      private void txtPort_Leave(object sender, EventArgs e)
      {
         try
         {
            int portnumber = Convert.ToInt32(txtPort.Text);
            if (portnumber < 1 || portnumber > 65535)
            {
               MessageBox.Show("FAILED: Has to be a number between 1 and 65535\r\nSetting to default port 80");
               txtPort.Text = "80";
            }
         }
         catch (Exception)
         {
            MessageBox.Show("FAILED: Has to be a number between 1 and 65535\r\nSetting to default port 80");
            txtPort.Text = "80";
         }
      }

      private void FiletoEXDlForm_Activated(object sender, EventArgs e)
      {
         comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      }

      private void BtnSearchNReplace_Click(object sender, EventArgs e)
      {
         richTextBox1.Text = Regex.Replace(richTextBox1.Text, textBoxSearch.Text, textBoxReplace.Text);
         richTextBox1.Update();
      }

      private void comboBox1_Click(object sender, EventArgs e)
      {
         comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

      }

      private void txtURL_TextChanged(object sender, EventArgs e)
      {

      }

      private void txtURL_Leave(object sender, EventArgs e)
      {
         if (txtURL.Text == "")
         {
            MessageBox.Show("You need to define a host\r\nSetting to default:127.0.0.1");
            txtURL.Text = "127.0.0.1";
         }
      }

      private void checkBoxEnableHelp_CheckStateChanged(object sender, EventArgs e)
      {
         if (checkBoxEnableHelp.Checked == true)
         {
            toolTip1.Active = true;
         }
         else
         {
            toolTip1.Active = false;
         }
      }

  
   }
}