// --------------------------------
// Copyright 2026 Anthony van Leeuwen
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// ---------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;

namespace DocxViewer2
{
    public partial class Viewer : Form, IViewer
    {
        // _filePath holds the path and name of the document to be viewed
        private string _filePath;
        private string _outputPath;

        private string docxFilter = "Word Documents (*.docx)|*.docx|";
        private string htmlFilter = "HTML Files (*.htm;*.html)|*.htm;*.html|";
        private string xpsFilter = "XPS Files (*.xps)|*.xps|";
        private string allFilesFilter = "All Files (*.*)|*.*";

        private List<string> supportedExtensions = new List<string> { ".docx", ".doc", ".html", ".htm", ".xps" };

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Viewer"/> class.
        /// </summary>
        public Viewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FileName))
            {
                string _ext = Path.GetExtension(FileName).ToLower();

                if (_ext == ".docx")
                {
                    ConvertDocxToHtml(FileName);
                    ViewerWebBrowser.Navigate(_outputPath);
                }
                else if (!supportedExtensions.Contains(_ext))
                {
                    MessageBox.Show("Unsupported file format.");
                    FileName = string.Empty;
                    ViewerStatusStripShowFileName.Text = string.Empty;
                }
                else
                {
                    ViewerWebBrowser.Url = new Uri(FileName);
                    ViewerStatusStripShowFileName.Text = FileName.ToString();
                }
                ViewerStatusStripShowFileName.Text = FileName.ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the OpenFileMenuStripItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenFileMenuStripItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = docxFilter + htmlFilter + xpsFilter + allFilesFilter;
            openFileDialog.Title = "Open Document File";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                string _ext = Path.GetExtension(FileName).ToLower();

                if (_ext == ".docx")
                {
                    ConvertDocxToHtml(FileName);
                    ViewerWebBrowser.Navigate(_outputPath);
                }
                else if (!supportedExtensions.Contains(_ext))
                {
                    MessageBox.Show("Unsupported file format.");
                    FileName = string.Empty;
                    ViewerStatusStripShowFileName.Text = string.Empty;
                }
                else
                {
                    ViewerWebBrowser.Url = new Uri(FileName);
                    ViewerStatusStripShowFileName.Text = FileName.ToString();
                }

            }
            ViewerStatusStripShowFileName.Text = FileName.ToString();
        }

        /// <summary>
        /// Handles the Click event of the CloseFileMenuStripItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseFileMenuStripItem_Click(object sender, EventArgs e)
        {
            ViewerWebBrowser.Navigate("about:blank");
            _outputPath = string.Empty;
            ViewerStatusStripShowFileName.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the ExitMenuStripItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitMenuStripItem_Click(object sender, EventArgs e)
        {
            CloseViewer();
        }

        /// <summary>
        /// Closes the viewer.
        /// </summary>
        public void CloseViewer()
        {
            Close();
        }

        /// <summary>
        /// Converts the docx to HTML.
        /// </summary>
        /// <param name="docxFilePath">The docx file path.</param>
        private void ConvertDocxToHtml(string docxFilePath)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(docxFilePath, true))
            {
                HtmlConverterSettings settings = new HtmlConverterSettings()
                {
                    PageTitle = Path.GetFileNameWithoutExtension(docxFilePath),
                    FabricateCssClasses = true,
                    CssClassPrefix = "docx-",
                    RestrictToSupportedLanguages = false,
                    RestrictToSupportedNumberingFormats = false,
                };

                var htmlElement = HtmlConverter.ConvertToHtml(wordDoc, settings);

                string htmlString = htmlElement.ToString(System.Xml.Linq.SaveOptions.DisableFormatting);
                _outputPath = Path.ChangeExtension(docxFilePath, ".html");
                File.WriteAllText(_outputPath, htmlString, System.Text.Encoding.UTF8);
            }
        }
    }
}
