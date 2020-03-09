using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;



namespace GeoLab
{
    public partial class Converter : Form
    {
        readonly List<string> listFiles = new List<string>();

        public Converter()
        {
            InitializeComponent();
        }

        private void SearchTXT_Click(object sender, EventArgs e)//folder selection and inserting name of the file with.txt extension by default
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _ = openFileDialog.FileName;
                    webBrowser1.Url = new Uri(openFileDialog.FileName);

                    //opens txt file directly into webBrowser1 component
                }
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }



        private void SearchFolder_Click(object sender, EventArgs e) //method for listing all the files into listView1 component
        {
            /*  using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" }) //listing all the folders and files in webBrowser1 component
              {
                  if (fbd.ShowDialog() == DialogResult.OK)
                      webBrowser1.Url = new Uri(fbd.SelectedPath);

              }
              listFiles.Clear();
              listView1.Items.Clear();*/

            using (FolderBrowserDialog fbd1 = new FolderBrowserDialog() { Description = "path" }) //listing all the files into listView1 component


                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    listView1.Text = fbd1.SelectedPath;
                    foreach (string item in Directory.GetFiles(fbd1.SelectedPath))
                    {

                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView1.Items.Add(fi.Name);

                    }

                }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)// using ShellExecute function
        {
            /* if (listView1.FocusedItem != null)
                 System.Diagnostics.Process.Start(listFiles[listView1.FocusedItem.Index]);*/

            if (listView1.FocusedItem != null)
                _ = listFiles[listView1.FocusedItem.Index];
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            while (listView1.FocusedItem == null)
            {
                MessageBox.Show("Please select appropriate total station textual format");
                return;
            }

            string[] InputCoordinates = File.ReadAllLines(listFiles[listView1.FocusedItem.Index]);

            StringBuilder builder = new StringBuilder();

            foreach (string value in InputCoordinates)
            {
                builder.Append(value);
            }
            string coord = builder.ToString();
            string[] niz = coord.Split(';');

            //take action to create excel workbook
            excel.Application oXl;
            excel._Workbook oWB;
            excel._Worksheet oSheet;
            excel.Range oRng;

            object misvalue = System.Reflection.Missing.Value;

            try
            {
                //start Excell and get Application object
                oXl = new excel.Application
                {
                    Visible = true
                };

                //get a new workbook
                oWB = oXl.Workbooks.Add("");
                oSheet = (excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell
                oSheet.Cells[1, 1] = "No";
                oSheet.Cells[1, 2] = "X";
                oSheet.Cells[1, 3] = "Y";
                oSheet.Cells[1, 4] = "Z";

                //Format A1:C1 as bold, vertical alignment=center
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment = excel.XlVAlign.xlVAlignCenter;

                int k = 0;
                //for loop for inserting values in cells

                for (int j = 1; j < niz.Length; j++)
                {

                    if (j + k < niz.Length)
                    {
                        oSheet.Cells[1][j + 1] = j;
                        oSheet.Cells[2][j + 1] = niz[(j + 1 + k) - 1];
                        oSheet.Cells[3][j + 1] = niz[(j + 2 + k) - 1];
                        oSheet.Cells[4][j + 1] = niz[(j + 3 + k) - 1];
                        k += 2;
                    }

                }

                Thread.Sleep(5000);

                //AutoFit column A:C
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();
                oXl.Visible = false;

                oWB.SaveAs(@"C:\Coordinates.xls", excel.XlFileFormat.xlWorkbookDefault, Type.Missing,
                    Type.Missing, false, false, excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                oWB.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void Coordinates(object sender, EventArgs e)
        {
            Coordinates newForm = new Coordinates();
            newForm.Show();
        }
    }
}