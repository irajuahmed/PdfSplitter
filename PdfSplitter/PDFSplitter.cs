using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PdfSplitter
{
    public partial class PDFSplitter : Form
    {
        private int seletedFilePageCount;
        public PDFSplitter()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.pdf|";
            btnSaveLocation.Enabled = true;
            txtFinalMessage.Text = string.Empty;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnBrowsedFile.Text = openFileDialog.FileName;
                txtSelectedFileName.Text = openFileDialog.SafeFileName;
                using (PdfDocument inputDocument = PdfReader.Open(btnBrowsedFile.Text, PdfDocumentOpenMode.Import))
                {
                    txtSelectedFileTitle.Text = inputDocument.Info.Title;
                    txtSelectedFileToatlPage.Text = inputDocument.PageCount.ToString();
                    seletedFilePageCount = inputDocument.PageCount;
                    if (inputDocument.PageCount <= 1)
                    {
                        btnSaveLocation.Enabled = false;
                    }
                    else
                    {
                        RenderPageCheckboxes(inputDocument.PageCount,false);
                    }

                    txtAuthor.Text = inputDocument.Info.Author;
                    txtSelectedFileSize.Text = (inputDocument.FileSize / 1024.0 / 1024.0).ToString("0.00") + " MB";
                    txtCreationDate.Text = inputDocument.Info.CreationDate.ToString("dd/MM/yyyy hh:mm:ss tt");
                    txtLastModifyDate.Text = inputDocument.Info.ModificationDate.ToString("dd/MM/yyyy hh:mm:ss tt");
                }
            }
            else
            {
                btnBrowsedFile.Text = string.Empty;
                txtSelectedFileName.Text = string.Empty;
            }
        }

        private void btnSplitPdf_Click(object sender, EventArgs e)
        {
            txtFinalMessage.Text = string.Empty;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            SplitSelectFile();
            btnBrowsedFile.Text = string.Empty;
            txtSelectedFileName.Text = string.Empty;
            txtSelectedFileTitle.Text = string.Empty;
            txtSelectedFileToatlPage.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtSelectedFileSize.Text = string.Empty;
            txtCreationDate.Text = string.Empty;
            txtLastModifyDate.Text = string.Empty;
            btnSelectedFilePath.Text = string.Empty;
            btnSplitPdf.Enabled = false;
            btnSaveLocation.Enabled = false;
        }

        private void SplitSelectFile()
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            var isSinglePageSplit = radioButtonSinglePageSplit.Checked;
            var isSelectedIntoOneFileSplit = radioButtonSelectedIntoOne.Checked;
            var isOddPagesSplit = radioButtonOddPages.Checked;
            var isEvenPagesSplit = radioButtonEvenPages.Checked;

            string sourcePdfPath = btnBrowsedFile.Text;
            string outputFolder = btnSelectedFilePath.Text;
            if (!File.Exists(sourcePdfPath))
            {
                MessageBox.Show("PDF file not found.");
                return;
            }

            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            using (PdfDocument inputDocument = PdfReader.Open(sourcePdfPath, PdfDocumentOpenMode.Import))
            {
                string finalMessage = string.Empty;
                int pageCount = inputDocument.PageCount;
                if (pageCount <= 1)
                {
                    txtFinalMessage.Text = $"File '{inputDocument.Info.Title}' has only one page and cannot be split.";
                    return;
                }

                string fileName = !string.IsNullOrEmpty(inputDocument.Info.Title) ? inputDocument.Info.Title : "Untitled";

                if (isSinglePageSplit)
                {
                    progressBar1.Maximum = pageCount;

                    for (int idx = 0; idx < pageCount; idx++)
                    {
                        PdfDocument outputDocument = new PdfDocument();
                        outputDocument.AddPage(inputDocument.Pages[idx]);
                        string outputFilePath = Path.Combine(outputFolder, $"Page_{idx + 1}.pdf");
                        outputDocument.Save(outputFilePath);
                        progressBar1.Value = idx + 1;
                    }
                }
                else if (isSelectedIntoOneFileSplit)
                {
                    List<int> selectedPages = GetSelectedPages();
                    if (selectedPages.Count == 0)
                    {
                        selectedPages = Enumerable.Range(1, pageCount).ToList();
                    }

                    PdfDocument outputDocument = new PdfDocument();
                    progressBar1.Maximum = selectedPages.Count;

                    foreach (int page in selectedPages)
                    {
                        /*-1 because PdfSharp is 0-based */
                        outputDocument.AddPage(inputDocument.Pages[page - 1]); 
                        progressBar1.Value += 1;
                    }

                    string outputFilePath = Path.Combine(outputFolder, "SelectedPages.pdf");
                    outputDocument.Save(outputFilePath);
                }
                else if (isOddPagesSplit)
                {
                    var oddPages = Enumerable.Range(1, pageCount).Where(p => p % 2 != 0).ToList();

                    PdfDocument outputDocument = new PdfDocument();
                    progressBar1.Maximum = oddPages.Count;

                    foreach (int page in oddPages)
                    {
                        outputDocument.AddPage(inputDocument.Pages[page - 1]);
                        progressBar1.Value += 1;
                    }

                    string outputFilePath = Path.Combine(outputFolder, "OddPages.pdf");
                    outputDocument.Save(outputFilePath);
                }
                else if (isEvenPagesSplit)
                {
                    var evenPages = Enumerable.Range(1, pageCount).Where(p => p % 2 == 0).ToList();

                    PdfDocument outputDocument = new PdfDocument();
                    progressBar1.Maximum = evenPages.Count;

                    foreach (int page in evenPages)
                    {
                        outputDocument.AddPage(inputDocument.Pages[page - 1]);
                        progressBar1.Value += 1;
                    }

                    string outputFilePath = Path.Combine(outputFolder, "EvenPages.pdf");
                    outputDocument.Save(outputFilePath);
                }

                txtFinalMessage.Text = $"File '{fileName}' split successfully!";
            }
        }


        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select folder to save the PDF";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    btnSelectedFilePath.Text = folderDialog.SelectedPath;
                    btnSplitPdf.Enabled = true;
                }
                else
                {
                    btnSelectedFilePath.Text = string.Empty;
                    btnSplitPdf.Enabled = false;
                }
            }
        }

        private void PDFSplitter_Load(object sender, EventArgs e)
        {
            radioButtonSinglePageSplit.Checked = true;
        }

        private void RenderPageCheckboxes(int pageCount, bool isEnabled)
        {
            /* Clear previous checkboxes */
            checkBoxGroup.Controls.Clear();
            
            int startX = 10;
            int startY = 25;
            int checkBoxWidth = 80;
            int checkBoxHeight = 25;
            int spacingX = 60;
            int spacingY = 25;
            int maxPerRow = Math.Max(1, checkBoxGroup.Width / spacingX);

            for (int i = 0; i < pageCount; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Text = $"{i + 1}";
                chk.AutoSize = true;
                chk.Enabled = isEnabled;
                
                /*Position checkboxes in grid layout*/
                int row = i / maxPerRow;
                int col = i % maxPerRow;
                chk.Left = startX + (col * spacingX);
                chk.Top = startY + (row * spacingY);

                 /*store page number*/
                chk.Tag = i; 

                checkBoxGroup.Controls.Add(chk);
            }
        }

        private List<int> GetSelectedPages()
        {
            List<int> selectedPages = new List<int>();

            foreach (Control ctrl in checkBoxGroup.Controls)
            {
                if (ctrl is CheckBox chk && chk.Checked)
                {
                    selectedPages.Add((int)chk.Tag);
                }
            }

            return selectedPages;
        }

        private void radioButtonSelectedIntoOne_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSelectedIntoOne.Checked)
                RenderPageCheckboxes(seletedFilePageCount, true);
        }

        private void radioButtonSinglePageSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSinglePageSplit.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }

        private void radioButtonOddPages_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOddPages.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }

        private void radioButtonEvenPages_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEvenPages.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }
    }
}
