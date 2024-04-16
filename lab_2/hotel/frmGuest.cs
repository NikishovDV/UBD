
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

using System.Data.OleDb;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace HBRS
{
	public partial class frmGuest
	{
		public frmGuest()
		{
			InitializeComponent();
			
			
		}
		
#region Default Instance
		
		private static frmGuest defaultInstance;

		public static frmGuest Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmGuest();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		public void bttnSave_Click(System.Object sender, System.EventArgs e)
		{
			Module1.con.Open();
			string fname = txtFName.Text.Trim();
			string mname = txtMName.Text.Trim();
			string lname = txtLName.Text.Trim();
			string add = txtAddress.Text.Trim();
			string num = txtNumber.Text.Trim();
			string email = txtEmail.Text.Trim();
			string stat = "Active";
			string remark = "Available";
			
			if (fname == null || mname == null || lname == null || add == null || num == null)
			{
				Interaction.MsgBox("Заполните все поля", Constants.vbInformation, "Внимание");
			}
			else
			{
				OleDbCommand add_guest = new OleDbCommand("INSERT INTO tblGuest(GuestFName,GuestMName,GuestLName,GuestAddress,GuestContactNumber,GuestGender,GuestEmail,Status,Remarks) values (\'" +
				fname + "\',\'" +
				mname + "\',\'" +
				lname + "\',\'" +
				add + "\',\'" +
				num + "\',\'" +
				cboGender.Text + "\',\'" +
				email + "\',\'" +
				stat + "\',\'" +
				remark + "\')", Module1.con);
				add_guest.ExecuteNonQuery();
				add_guest.Dispose();
				Interaction.MsgBox("Гость добавлен!", Constants.vbInformation, "Внимание");
				txtFName.Clear();
				txtMName.Clear();
				txtLName.Clear();
				txtAddress.Clear();
				txtNumber.Clear();
				txtEmail.Clear();
			}
			Module1.con.Close();
			display_guest();
		}
		
		public void frmGuest_Load(System.Object sender, System.EventArgs e)
		{
			display_guest();
			TabControl1.SelectTab(0);
		}
		
		private void display_guest()
		{
			Module1.con.Open();
            System.Data.DataTable Dt = new System.Data.DataTable("tblGuest");
			OleDbDataAdapter rs = default(OleDbDataAdapter);
			
			rs = new OleDbDataAdapter("Select * from tblGuest", Module1.con);
			
			rs.Fill(Dt);
			int indx = default(int);
			lvGuest.Items.Clear();
			for (indx = 0; indx <= Dt.Rows.Count - 1; indx++)
			{
				ListViewItem lv = new ListViewItem();
				lv.Text = (string) (Dt.Rows[indx]["ID"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["GuestFName"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["GuestMName"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["GuestLName"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["GuestAddress"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["GuestContactNumber"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["Status"].ToString());
				lvGuest.Items.Add(lv);
			}
			rs.Dispose();
			Module1.con.Close();
		}
		
		public void bttnCancel_Click(System.Object sender, System.EventArgs e)
		{
			txtFName.Clear();
			txtMName.Clear();
			txtLName.Clear();
			txtAddress.Clear();
			txtNumber.Clear();
			txtEmail.Clear();
		}

        private void buttExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Word Files (*.docx)|*.docx|PDF Files (*.pdf)|*.pdf|CSV Files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".xlsx")
                    {
                        ExportToExcel(filePath);
                    }
                    else if (extension == ".docx")
                    {
                        ExportToWord(filePath);
                    }
                    else if (extension == ".pdf")
                    {
                        ExportToPdf(filePath);
                    }
                    else if (extension == ".csv")
                    {
                        ExportToCsv(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Выберите поддерживаемый формат для экспорта данных.");
                    }
                }
            }
        }

        private void ExportToExcel(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            int row = 1;
            foreach (ListViewItem item in lvGuest.Items)
            {
                int col = 1;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    worksheet.Cells[row, col] = subItem.Text;
                    col++;
                }
                row++;
            }

            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в Excel.");
        }

        private void ExportToWord(string filePath)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document document = wordApp.Documents.Add();

            Word.Paragraph paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = "Exported Data";
            paragraph.Range.InsertParagraphAfter();

            foreach (ListViewItem item in lvGuest.Items)
            {
                string rowText = "";
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    rowText += subItem.Text + "\t";
                }
                paragraph.Range.Text += rowText + "\n";
            }

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в Word.");
        }

        private void ExportToPdf(string filePath)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;
            Word.Document document = wordApp.Documents.Add();

            foreach (ListViewItem item in lvGuest.Items)
            {
                string rowText = "";
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    rowText += subItem.Text + "\t";
                }
                document.Content.InsertAfter(rowText + "\n");
            }

            document.SaveAs2(filePath, Word.WdSaveFormat.wdFormatPDF);
            document.Close();
            wordApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в PDF.");
        }

        private void ExportToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ColumnHeader column in lvGuest.Columns)
                {
                    writer.Write(column.Text + ",");
                }
                writer.WriteLine();

                foreach (ListViewItem item in lvGuest.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        writer.Write(subItem.Text + ",");
                    }
                    writer.WriteLine();
                }
            }

            MessageBox.Show("Данные успешно экспортированы в CSV.");
        }
    
    }
}
