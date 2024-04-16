
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


using System.Data.OleDb;

namespace HBRS
{
	public partial class frmCheckout
	{
		public frmCheckout()
		{
			InitializeComponent();
			
			
		}
		
#region Default Instance
		
		private static frmCheckout defaultInstance;
		
		public static frmCheckout Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmCheckout();
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
		
		public void bttnSearchGuest_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckinList.Default.ShowDialog();
		}
		
		public void txtRoomNumber_TextChanged(System.Object sender, System.EventArgs e)
		{
			if ( String.IsNullOrEmpty(txtRoomNumber.Text.ToString()))
			{
			}
			else
			{
				Module1.con.Open();
				DataTable dt = new DataTable("tblRoom");
				Module1.rs = new OleDbDataAdapter("SELECT * FROM tblRoom WHERE RoomNumber = " + txtRoomNumber.Text + "", Module1.con);
				Module1.rs.Fill(dt);
				txtRoomType.Text = (string) (dt.Rows[0]["RoomType"]);
				txtRoomRate.Text = (string) (Conversion.Val(dt.Rows[0]["RoomRate"]).ToString("N"));
				Module1.rs.Dispose();
				Module1.con.Close();
			}
			
		}
		
		public void txtCash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0'|| e.KeyChar > '9') && e.KeyChar != ControlChars.Back && e.KeyChar != '.')
			{
				//cancel keys
				e.Handled = true;
			}
		}
		
		public void txtCash_TextChanged(System.Object sender, System.EventArgs e)
		{
			txtCash.Text = System.Convert.ToString(txtCash.Text.ToString());
			string balance = txtTotal.Text.Replace(",","");
			string cash = txtCash.Text.Replace(",","");
			if (Conversion.Val(cash) < Conversion.Val(balance))
			{
				txtChange.Text = "0.00";
			}
			else
			{
				txtChange.Text = System.Convert.ToString((Conversion.Val(cash) - Conversion.Val(balance)).ToString("N"));
			}
		}
		
		public void bttnCheckout_Click(System.Object sender, System.EventArgs e)
		{
			if (txtTransID.Text == null)
			{
				Interaction.MsgBox("Выберите транзакцию для выселения!", Constants.vbExclamation, "Внимание");
			}
			else
			{
				if (Conversion.Val(txtCash.Text) < Conversion.Val(txtTotal.Text))
				{
					Interaction.MsgBox("Есть задолженность!", Constants.vbExclamation, "Внимание");
				}
				else
				{
					string @out = System.Convert.ToString(Interaction.MsgBox("Утвердить ", (int) Constants.vbQuestion + Constants.vbYesNo, "Выселение"));
					if (@out == Constants.vbYes.ToString())
					{
						Module1.con.Open();
						OleDbCommand update_trans = new OleDbCommand("UPDATE tblTransaction SET Remarks = \'Checkout\' WHERE TransID = " + lblTransID.Text + "", Module1.con);
						update_trans.ExecuteNonQuery();
						
						OleDbCommand update_guest = new OleDbCommand("UPDATE tblGuest SET Remarks = \'Available\' WHERE ID = " + lblGuestID.Text + "", Module1.con);
						update_guest.ExecuteNonQuery();
						
						OleDbCommand update_room = new OleDbCommand("UPDATE tblRoom SET Status = \'Available\' WHERE RoomNumber = " + txtRoomNumber.Text + "", Module1.con);
						update_room.ExecuteNonQuery();
						
						Interaction.MsgBox("Гость выселен!", Constants.vbInformation, "Выселение");
						Module1.con.Close();
						clear_text();
					}
				}
			}
		}
		
		public void clear_text()
		{
			txtTransID.Clear();
			txtGuestName.Clear();
			txtRoomNumber.Clear();
			txtRoomRate.Clear();
			txtRoomType.Clear();
			txtCheckin.Clear();
			txtCheckout.Clear();
			txtChildren.Clear();
			txtAdult.Clear();
			txtAdvance.Clear();
			txtDiscountType.Clear();
			txtTotal.Clear();
			txtSubTotal.Clear();
			txtDays.Clear();
			txtCash.Clear();
			txtChange.Clear();
		}
		
		public void lblTransID_TextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		public void frmCheckout_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			clear_text();
		}
		
		public void frmCheckout_Load(System.Object sender, System.EventArgs e)
		{
			txtRoomNumber.Clear();
			dtOut.Value = DateTime.Now;
		}
		
		public void txtAdvance_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void txtTotal_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
		
		
		public void txtDiscountType_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
	}
}
