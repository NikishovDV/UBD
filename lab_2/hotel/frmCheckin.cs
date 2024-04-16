
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
using System.IO;

namespace HBRS
{
	public partial class frmCheckin
	{
		public frmCheckin()
		{
			InitializeComponent();
		}
		
#region Default Instance
		
		private static frmCheckin defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmCheckin Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmCheckin();
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
		int guestID;
		int roomID;
		int trans_ID;
		
		public void frmCheckin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			string a = System.Convert.ToString(Interaction.MsgBox("Отменить транзакцию?", (int) Constants.vbQuestion + Constants.vbYesNo, "Отмена"));
			if (a == Constants.vbNo.ToString())
			{
				e.Cancel = true;
			}
			else
			{
				clear_text();
			}
		}
        public void frmCheckin_Load(System.Object sender, System.EventArgs e)
        {
            clear_text();
            DateTime time = DateTime.Now;
            string format = "MM/d/yyyy";
            txtCheckInDate.Text = time.ToString(format);
            dtCheckOutDate.Text = System.Convert.ToString(DateTime.Now.AddDays(1));
            transID();
            pop_discount();
            display_checkin();
        }

        public void transID()
		{
			Module1.con.Open();
			DataTable dt = new DataTable("tblTransaction");
			Module1.rs = new OleDbDataAdapter("SELECT * FROM tblTransaction ORDER BY TransID DESC", Module1.con);
			Module1.rs.Fill(dt);
			
			if (dt.Rows.Count == 0)
			{
				txtTransID.Text = "TransID - 0001";
			}
			else
			{
				int value = (int) (Conversion.Val(dt.Rows[0]["TransID"]));
				value++;
				txtTransID.Text = "TransID - " + value.ToString("0000");
				trans_ID = value;
			}
			Module1.rs.Dispose();
			Module1.con.Close();
		}
		
		public void bttnCheckIn_Click_1(System.Object sender, System.EventArgs e)
		{
			int children = (int) (Conversion.Val(txtChildren.Text));
			int adult = (int) (Conversion.Val(txtAdults.Text));
			int advance = (int) (Conversion.Val(txtAdvance.Text));
			int discount = (int) (Conversion.Val(lblDiscountID.Text));
			string reserve = "0";
			string remarks = "Checkin";
			string stat = "Active";
			
			if (lblGuestID.Text == "GuestID" || lblGuestID.Text == null || txtRoomNumber.Text == null || Conversion.Val(System.Convert.ToString(children + adult)) == null || advance == null || discount == null)
			{
				Interaction.MsgBox("Заполните все поля!", Constants.vbInformation, "Внимание!");
			}
			else
			{
				if (Conversion.Val(System.Convert.ToString(Conversion.Val(txtSubTotal.Text) * 0.5)) > Conversion.Val(txtAdvance.Text))
				{
					MessageBox.Show("Попробуйте ещё раз");
					return;
				}
				string a = System.Convert.ToString(Interaction.MsgBox("Проверить транзакцию?", (int) Constants.vbQuestion + Constants.vbYesNo, "Заселение"));
				if (a == Constants.vbYes.ToString())
				{
					Module1.con.Open();
					OleDbCommand checkin = new OleDbCommand("INSERT INTO tblTransaction(GuestID,RoomNum,CheckInDate,CheckOutDate,NoOfChild,NoOfAdult,AdvancePayment,DiscountID,Remarks,Status) values (\'" +
					lblGuestID.Text + "\',\'" +
					txtRoomNumber.Text + "\',\'" +
					txtCheckInDate.Text + "\',\'" +
					dtCheckOutDate.Text + "\',\'" +
					txtChildren.Text + "\',\'" +
					txtAdults.Text + "\',\'" +
					txtAdvance.Text + "\',\'" +
					lblDiscountID.Text + "\',\'" +
					remarks + "\',\'" +
					stat + "\')", Module1.con);
					checkin.ExecuteNonQuery();
					
					OleDbCommand update_guest = new OleDbCommand("UPDATE tblGuest SET Remarks = \'Checkin\' WHERE ID = " + lblGuestID.Text + "", Module1.con);
					update_guest.ExecuteNonQuery();
					
					OleDbCommand update_room = new OleDbCommand("UPDATE tblRoom SET Status = \'Occupied\' WHERE RoomNumber = " + txtRoomNumber.Text + "", Module1.con);
					update_room.ExecuteNonQuery();
					
					if (Conversion.Val(txtSubTotal.Text) < Conversion.Val(txtAdvance.Text) || Conversion.Val(txtSubTotal.Text) == Conversion.Val(txtAdvance.Text))
					{
						Interaction.MsgBox("Гость успешно заселен! " + "Сдача: " + Conversion.Val(System.Convert.ToString(Conversion.Val(txtAdvance.Text) - Conversion.Val(txtSubTotal.Text))).ToString("00.00"), Constants.vbInformation, "Check In");
						string change = System.Convert.ToString(Interaction.MsgBox("Очистить форму?", (int) Constants.vbQuestion + Constants.vbYesNo, "Изменения"));
						if (change == Constants.vbYes.ToString())
						{
							OleDbCommand update_trans = new OleDbCommand("UPDATE tblTransaction SET AdvancePayment = " + Conversion.Val(txtSubTotal.Text) + " WHERE TransID = " + trans_ID.ToString() + "", Module1.con);
							update_trans.ExecuteNonQuery();
						}
					}
					else
					{
						Interaction.MsgBox("Гость успешно заселен!", Constants.vbInformation, "Заселение");
					}
					
					clear_text();
					Module1.con.Close();
					transID();
					display_checkin();
				}
			}
		}
		
		public void bttnCancel_Click(System.Object sender, System.EventArgs e)
		{
			clear_text();
		}
		
		public void dtCheckOutDate_ValueChanged_1(System.Object sender, System.EventArgs e)
		{
			TimeSpan T = dtCheckOutDate.Value - DateTime.Now;
			if (T.Days < 1)
			{
				dtCheckOutDate.Text = System.Convert.ToString(DateTime.Now.AddDays(1));
				txtDaysNumber.Text = "1";
			}
			else
			{
				txtDaysNumber.Text = System.Convert.ToString(T.Days + 1);
			}
			lblTotal.Text = System.Convert.ToString(Conversion.Val(txtRoomRate.Text) * Conversion.Val(txtDaysNumber.Text));
			txtSubTotal.Text = System.Convert.ToString(Conversion.Val(txtRoomRate.Text) * Conversion.Val(txtDaysNumber.Text));
		}
		
		public void bttnSearchGuest_Click(System.Object sender, System.EventArgs e)
		{
			frmSelectGuest.Default.ShowDialog();
		}
		
		public void bttnSearchRoom_Click(System.Object sender, System.EventArgs e)
		{
			frmSelectRoom.Default.ShowDialog();
		}
		
		public void txtRoomRate_TextChanged(System.Object sender, System.EventArgs e)
		{
			lblTotal.Text = System.Convert.ToString(Conversion.Val(txtRoomRate.Text) * Conversion.Val(txtDaysNumber.Text));
			txtSubTotal.Text = System.Convert.ToString((Conversion.Val(txtRoomRate.Text) * Conversion.Val(txtDaysNumber.Text)).ToString("00.00"));
		}
		
		public void bttnAddAdult_Click(System.Object sender, System.EventArgs e)
		{
			int tao;
			tao = (int) (Conversion.Val(txtAdults.Text) + Conversion.Val(txtChildren.Text));
			if (tao == Conversion.Val(lblNoOfOccupancy.Text))
			{
				
			}
			else
			{
				txtAdults.Text = System.Convert.ToString(Conversion.Val(txtAdults.Text) + 1);
			}
		}
		
		public void bttnAddChildren_Click(System.Object sender, System.EventArgs e)
		{
			int tao;
			tao = (int) (Conversion.Val(txtAdults.Text) + Conversion.Val(txtChildren.Text));
			if (tao == Conversion.Val(lblNoOfOccupancy.Text))
			{
				
			}
			else
			{
				txtChildren.Text = System.Convert.ToString(Conversion.Val(txtChildren.Text) + 1);
			}
		}
		
		public void bttnSubAdult_Click(System.Object sender, System.EventArgs e)
		{
			if (Conversion.Val(txtAdults.Text) == 0)
			{
				txtAdults.Text = System.Convert.ToString(Conversion.Val(txtAdults.Text));
			}
			else
			{
				txtAdults.Text = System.Convert.ToString(Conversion.Val(txtAdults.Text) - 1);
			}
		}
		
		public void bttnSubChildren_Click(System.Object sender, System.EventArgs e)
		{
			if (Conversion.Val(txtChildren.Text) == 0)
			{
				txtChildren.Text = System.Convert.ToString(Conversion.Val(txtChildren.Text));
			}
			else
			{
				txtChildren.Text = System.Convert.ToString(Conversion.Val(txtChildren.Text) - 1);
			}
		}
		
		private void pop_discount()
		{
			Module1.con.Open();
			DataTable dt = new DataTable();
			Module1.rs = new OleDbDataAdapter("SELECT * FROM tblDiscount", Module1.con);
			Module1.rs.Fill(dt);
			
			cboDiscount.Items.Clear();
			int i = default(int);
			for (i = 0; i <= dt.Rows.Count - 1; i++)
			{
				cboDiscount.Items.Add(dt.Rows[i]["DiscountType"]);
			}
			Module1.rs.Dispose();
			Module1.con.Close();
		}
		
		public void cboDiscount_TextChanged(object sender, System.EventArgs e)
		{
			Module1.con.Open();
			DataTable dt = new DataTable();
			Module1.rs = new OleDbDataAdapter("SELECT * FROM tblDiscount WHERE DiscountType = \'" + cboDiscount.Text + "\'", Module1.con);
			Module1.rs.Fill(dt);
			
			lblDiscountID.Text = (string) (dt.Rows[0]["ID"].ToString());
			lblDiscountRate.Text = (string) (dt.Rows[0]["DiscountRate"]);
			
			//lblTotal.Text = Val(txtSubTotal.Text) - (Val(txtSubTotal.Text) * Val(lblDiscountRate.Text))
			txtSubTotal.Text = System.Convert.ToString((Conversion.Val(lblTotal.Text) - (Conversion.Val(lblTotal.Text) * Conversion.Val(lblDiscountRate.Text))).ToString("00.00"));
			//lblAdvancePayment.Text = "Авансовый платеж должен быть минимум " + (Conversion.Val(txtSubTotal.Text) * 0.5).ToString("00.00");
			Module1.rs.Dispose();
			Module1.con.Close();
		}
		
		public void txtAdvance_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0'|| e.KeyChar > '9') && e.KeyChar != ControlChars.Back && e.KeyChar != '.')
			{
				//cancel keys
				e.Handled = true;
			}
		}
		
		public void txtAdvance_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (Conversion.Val(txtSubTotal.Text) < Conversion.Val(txtAdvance.Text) || Conversion.Val(txtSubTotal.Text) == Conversion.Val(txtAdvance.Text))
			{
				txtTotal.Text = "0.00";
			}
			else
			{
				txtTotal.Text = System.Convert.ToString((Conversion.Val(txtSubTotal.Text) - Conversion.Val(txtAdvance.Text)).ToString("00.00"));
			}
		}

        private void clear_text()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            txtRoomType.Clear();
            txtRoomRate.Clear();
            txtChildren.Text = "0";
            txtAdults.Text = "0";
            cboDiscount.Refresh();
            txtAdvance.Clear();
            txtSubTotal.Clear();
            txtTotal.Clear();
            lblDiscountID.Text = "";
            lblDiscountRate.Text = "";
            lblGuestID.Text = "";
            lblAdvancePayment.Text = "";
            lblNoOfOccupancy.Text = "0";

            DateTime time = DateTime.Now;
            string format = "MM/d/yyyy";
            txtCheckInDate.Text = time.ToString(format);
            dtCheckOutDate.Text = System.Convert.ToString(DateTime.Now.AddDays(1));
        }

        private void display_checkin()
		{
			Module1.con.Open();
			DataTable Dt = new DataTable("tblGuest");
			OleDbDataAdapter rs = default(OleDbDataAdapter);
			
			rs = new OleDbDataAdapter("Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = \'Checkin\' AND tblTransaction.Status = \'Active\'", Module1.con);
			
			rs.Fill(Dt);
			int indx = default(int);
			lvlcheckin.Items.Clear();
			for (indx = 0; indx <= Dt.Rows.Count - 1; indx++)
			{
				ListViewItem lv = new ListViewItem();
				TimeSpan getdate = new TimeSpan();
				int days = default(int);
				int subtotal = default(int);
				int total = default(int);
				int rate = default(int);
				double discount = default(double);
				
				int value = (int) (Conversion.Val(Dt.Rows[indx]["TransID"]));
				
				lv.Text = "TransID - " + value.ToString("0000");
				lv.SubItems.Add(Dt.Rows[indx]["GuestFName"] + " " + Dt.Rows[indx]["GuestLName"]);
				lv.SubItems.Add(Dt.Rows[indx]["RoomNum"].ToString());
				
				rate = System.Convert.ToInt32(Dt.Rows[indx]["RoomRate"]);
				
				lv.SubItems.Add(Dt.Rows[indx]["CheckInDate"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["CheckOutDate"].ToString());
				
				dtIn.Value = System.Convert.ToDateTime(Dt.Rows[indx]["CheckOutDate"]);
				dtOut.Value = System.Convert.ToDateTime(Dt.Rows[indx]["CheckInDate"]);
				
				getdate = dtIn.Value - dtOut.Value;
				days = getdate.Days;
				
				lv.SubItems.Add(days.ToString());
				lv.SubItems.Add(Dt.Rows[indx]["NoOfChild"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["NoOfAdult"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["AdvancePayment"].ToString());
				lv.SubItems.Add(Dt.Rows[indx]["DiscountType"].ToString());
				
				discount = Conversion.Val(Dt.Rows[indx]["DiscountRate"].ToString());
				
				subtotal = (int) ((days * rate) - ((days * rate) * discount));
				total = System.Convert.ToInt32(((Conversion.Val(subtotal.ToString()) - Conversion.Val(Dt.Rows[indx]["AdvancePayment"])).ToString()));
				
				if (Conversion.Val(subtotal.ToString()) > Conversion.Val(Dt.Rows[indx]["AdvancePayment"]))
				{
					lv.SubItems.Add(System.Convert.ToString(Conversion.Val(total.ToString())));
				}
				else
				{
					lv.SubItems.Add("0");
				}
				
				lvlcheckin.Items.Add(lv);
			}
			rs.Dispose();
			Module1.con.Close();
		}
		
		public void cboDiscount_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
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
            foreach (ListViewItem item in lvlcheckin.Items)
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

            foreach (ListViewItem item in lvlcheckin.Items)
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

            foreach (ListViewItem item in lvlcheckin.Items)
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
                foreach (ColumnHeader column in lvlcheckin.Columns)
                {
                    writer.Write(column.Text + ",");
                }
                writer.WriteLine();

                foreach (ListViewItem item in lvlcheckin.Items)
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

        private void txtCheckInDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
