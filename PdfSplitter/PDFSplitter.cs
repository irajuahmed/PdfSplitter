using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
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
           string txtFinalMessage = string.Empty;
            //progressBar1.Minimum = 0;
            //progressBar1.Value = 0;
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
           string txtFinalMessage = string.Empty;
            //progressBar1.Minimum = 0;
            //progressBar1.Value = 0;
            SplitSelectFile();            
        }

        private void SplitSelectFile()
        {
            try
            {
                //progressBar1.Minimum = 0;
                //progressBar1.Value = 0;
                txtRangeFrom.BackColor = Color.White;
                txtRangeTo.BackColor = Color.White;

                var isSinglePageSplit = radioButtonSinglePageSplit.Checked;
                var isSelectedIntoOneFileSplit = radioButtonSelectedIntoOne.Checked;
                var isOddPagesSplit = radioButtonOddPages.Checked;
                var isEvenPagesSplit = radioButtonEvenPages.Checked;
                var isRangeWisePagesSplit = radioButtonRange.Checked;

                string sourcePdfPath = btnBrowsedFile.Text;
                string outputFolder = btnSelectedFilePath.Text;

                string txtFinalMessage = string.Empty;  

                if (!File.Exists(sourcePdfPath))
                {
                    txtFinalMessage = "PDF file not found.";
                    return;
                }

                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                using (PdfDocument inputDocument = PdfReader.Open(sourcePdfPath, PdfDocumentOpenMode.Import))
                {
                    txtFinalMessage = "";
                    int pageCount = inputDocument.PageCount;
                    string fileName = !string.IsNullOrEmpty(txtSelectedFileName.Text) ? txtSelectedFileName.Text : "Untitled";
                    if (pageCount <= 1)
                    {
                        txtFinalMessage = $"File '{fileName}' has only one page and cannot be split.";
                        return;
                    }

                    

                    // 🟢 SINGLE PAGE SPLIT
                    if (isSinglePageSplit)
                    {
                        //progressBar1.Maximum = pageCount;

                        for (int idx = 0; idx < pageCount; idx++)
                        {
                            PdfDocument outputDocument = new PdfDocument();
                            outputDocument.AddPage(inputDocument.Pages[idx]);
                            string outputFilePath = Path.Combine(outputFolder, $"Page_{idx + 1}.pdf");
                            outputDocument.Save(outputFilePath);
                           // progressBar1.Value = idx + 1;
                            Application.DoEvents();
                        }

                        txtFinalMessage = $"File '{fileName}' split successfully into {pageCount} pages!";
                    }

                    // 🟢 SELECTED INTO ONE FILE SPLIT
                    else if (isSelectedIntoOneFileSplit)
                    {
                        List<int> selectedPages = GetSelectedPages();
                        if (selectedPages.Count == 0)
                        {
                            selectedPages = Enumerable.Range(1, pageCount).ToList();
                        }

                        PdfDocument outputDocument = new PdfDocument();
                        //progressBar1.Maximum = selectedPages.Count;

                        foreach (int page in selectedPages)
                        {
                            outputDocument.AddPage(inputDocument.Pages[page - 1]);
                            //progressBar1.Value += 1;
                            Application.DoEvents();
                        }

                        string outputFilePath = Path.Combine(outputFolder, string.Format("{0}_{1}_{2}.pdf",fileName, "SelectedPages",DateTime.Now.ToString("ddMMyyyyHHmmss")));
                        outputDocument.Save(outputFilePath);

                        txtFinalMessage = $"File '{fileName}' selected pages saved as '{Path.GetFileName(outputFilePath)}'";
                    }

                    // 🟢 ODD PAGES SPLIT
                    else if (isOddPagesSplit)
                    {
                        var oddPages = Enumerable.Range(1, pageCount).Where(p => p % 2 != 0).ToList();
                        PdfDocument outputDocument = new PdfDocument();
                        //progressBar1.Maximum = oddPages.Count;

                        foreach (int page in oddPages)
                        {
                            outputDocument.AddPage(inputDocument.Pages[page - 1]);
                            // progressBar1.Value += 1;
                            Application.DoEvents();
                        }

                        string outputFilePath = Path.Combine(outputFolder, "OddPages.pdf");
                        outputDocument.Save(outputFilePath);

                        txtFinalMessage = $"Odd pages successfully saved as '{Path.GetFileName(outputFilePath)}'";
                    }

                    // 🟢 EVEN PAGES SPLIT
                    else if (isEvenPagesSplit)
                    {
                        var evenPages = Enumerable.Range(1, pageCount).Where(p => p % 2 == 0).ToList();
                        PdfDocument outputDocument = new PdfDocument();
                        //progressBar1.Maximum = evenPages.Count;

                        foreach (int page in evenPages)
                        {
                            outputDocument.AddPage(inputDocument.Pages[page - 1]);
                            //progressBar1.Value += 1;
                            Application.DoEvents();
                        }

                        string outputFilePath = Path.Combine(outputFolder, "EvenPages.pdf");
                        outputDocument.Save(outputFilePath);

                        txtFinalMessage = $"Even pages successfully saved as '{Path.GetFileName(outputFilePath)}'";
                    }

                    // 🟡 RANGE-WISE SPLIT
                    else if (isRangeWisePagesSplit)
                    {
                        // --- Validation Section ---
                        if (string.IsNullOrWhiteSpace(txtRangeFrom.Text) || string.IsNullOrWhiteSpace(txtRangeTo.Text))
                        {
                            txtRangeFrom.BackColor = Color.Red;
                            txtRangeTo.BackColor = Color.Red;

                            MessageBox.Show("Please provide both 'From' and 'To' page numbers.",
                                            "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!int.TryParse(txtRangeFrom.Text, out int fromPage) || !int.TryParse(txtRangeTo.Text, out int toPage))
                        {
                            txtRangeFrom.BackColor = Color.Red;
                            txtRangeTo.BackColor = Color.Red;

                            MessageBox.Show("Please enter valid numeric values for the range.",
                                            "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (fromPage < 1 || toPage > seletedFilePageCount || fromPage > toPage)
                        {
                            txtRangeFrom.BackColor = Color.Red;
                            txtRangeTo.BackColor = Color.Red;

                            MessageBox.Show($"Page range must be between 1 and {seletedFilePageCount}, and 'From' must be ≤ 'To'.",
                                            "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        txtRangeFrom.BackColor = Color.White;
                        txtRangeTo.BackColor = Color.White;

                        // --- Splitting Section ---
                        PdfDocument outputDocument = new PdfDocument();
                        //progressBar1.Maximum = toPage - fromPage + 1;
                        //progressBar1.Value = 0;

                        for (int page = fromPage; page <= toPage; page++)
                        {
                            outputDocument.AddPage(inputDocument.Pages[page - 1]);
                            //progressBar1.Value += 1;
                            Application.DoEvents(); // keeps UI responsive
                        }

                        string outputFilePath = Path.Combine(outputFolder, $"Pages_{fromPage}_to_{toPage}.pdf");
                        outputDocument.Save(outputFilePath);

                        // ✅ Success message in txtFinalMessage (not MessageBox)
                        txtFinalMessage = $"Pages {fromPage}-{toPage} successfully saved as '{Path.GetFileName(outputFilePath)}'";
                    }
                    MessageBox.Show(txtFinalMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

                //txtFinalMessage = string.Empty;
                //progressBar1.Minimum = 0;
                //progressBar1.Value = 0;
                //btnSplitPdf.Enabled = false;
                //btnSaveLocation.Enabled = false;
                //txtRangeFrom.Enabled = false;
                //txtRangeTo.Enabled = false;
                //checkBoxGroup.Controls.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                chk.Tag = i+1; 

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
            txtRangeFrom.Enabled = false;
            txtRangeTo.Enabled = false;

            if (radioButtonSelectedIntoOne.Checked)
                RenderPageCheckboxes(seletedFilePageCount, true);
        }

        private void radioButtonSinglePageSplit_CheckedChanged(object sender, EventArgs e)
        {
            txtRangeFrom.Enabled = false;
            txtRangeTo.Enabled = false;

            if (radioButtonSinglePageSplit.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }

        private void radioButtonOddPages_CheckedChanged(object sender, EventArgs e)
        {
            txtRangeFrom.Enabled = false;
            txtRangeTo.Enabled = false;

            if (radioButtonOddPages.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }

        private void radioButtonEvenPages_CheckedChanged(object sender, EventArgs e)
        {
            txtRangeFrom.Enabled = false;
            txtRangeTo.Enabled = false;

            if (radioButtonEvenPages.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }

        private void radioButtonRange_CheckedChanged(object sender, EventArgs e)
        {
            txtRangeFrom.Enabled = true;
            txtRangeTo.Enabled = true;

            if (radioButtonRange.Checked)
                RenderPageCheckboxes(seletedFilePageCount, false);
        }
    }
}
