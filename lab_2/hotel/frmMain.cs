
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


using Microsoft.VisualBasic.CompilerServices;

namespace HBRS
{
	public partial class frmMain
	{
		public frmMain()
		{
			InitializeComponent();

		}
		
#region Default Instance
		
		private static frmMain defaultInstance;

		public static frmMain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmMain();
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
		
		public void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			
		}
		
		public void frmMain_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void toolbarCheckIn_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckin.Default.ShowDialog();
		}
		
		public void ToolStripButton13_Click(System.Object sender, System.EventArgs e)
		{
			string exit_app = System.Convert.ToString(Interaction.MsgBox("Закрыть программу?", (int) Constants.vbQuestion + Constants.vbYesNo, "Выход"));
			if (exit_app == Constants.vbYes.ToString())
			{
				ProjectData.EndApp();
			}
		}
		
		public void ToolStripButton12_Click(System.Object sender, System.EventArgs e)
		{
			string out_app = System.Convert.ToString(Interaction.MsgBox("Выйти из аккаунта?", (int) Constants.vbQuestion + Constants.vbYesNo, "Выйти из аккаунта"));
			if (out_app == Constants.vbYes.ToString())
			{
				Module1.con.Close();
				this.Hide();
				frmLogin.Default.ShowDialog();
			}
		}
		
		public void ToolStripButton10_Click(System.Object sender, System.EventArgs e)
		{
			frmGuest.Default.ShowDialog();
		}
		
		public void toolbarRoom_Click(System.Object sender, System.EventArgs e)
		{
			frmRoom.Default.ShowDialog();
		}
		
		public void toolbarReserve_Click(System.Object sender, System.EventArgs e)
		{
			frmReserve.Default.ShowDialog();
		}
		
		public void NewCheckInToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckin.Default.ShowDialog();
		}
		
		public void NewReservationToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmReserve.Default.ShowDialog();
		}
		
		public void LogoutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			string out_app = System.Convert.ToString(Interaction.MsgBox("Выйти из аккаунта?", (int) Constants.vbQuestion + Constants.vbYesNo, "Выйти из аккаунта"));
			if (out_app == Constants.vbYes.ToString())
			{
				this.Hide();
				frmLogin.Default.UsernameTextBox.ResetText();
				frmLogin.Default.PasswordTextBox.ResetText();
				frmLogin.Default.UsernameTextBox.Focus();
				frmLogin.Default.Show();
			}
		}
		
		public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			string exit_app = System.Convert.ToString(Interaction.MsgBox("Закрыть программу?", (int)Constants.vbQuestion + Constants.vbYesNo, "Выход"));
			if (exit_app == Constants.vbYes.ToString())
			{ 
				ProjectData.EndApp();
			}
		}
		
		public void toolbarCheckOut_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckout.Default.ShowDialog();
		}
		
		public void SettingsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void FileToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void CheckedInListToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckinListMonitor.Default.ShowDialog();
		}
		
		public void RoomStatusToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmRoomListMonitor.Default.ShowDialog();
		}
		
		public void ReservedListToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmReserveListMonitor.Default.ShowDialog();
		}
		
		public void CheckedOutListToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmCheckOutList.Default.ShowDialog();
		}
		
		public void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			DateTime datenow = DateTime.Now;
			status.Items[2].Text = "Date and Time : " + datenow.ToString("MMMM dd, yyyy") + " " + DateAndTime.TimeOfDay;
		}
		
		public void DiscountToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmDiscount.Default.ShowDialog();
		}
		
		public void RoomToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmRoom.Default.ShowDialog();
			frmRoom.Default.TabPage2.Select();
		}
		
		public void GuestToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmGuest.Default.ShowDialog();
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void DiscountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDiscount.Default.ShowDialog();
        }
    }
	
}
