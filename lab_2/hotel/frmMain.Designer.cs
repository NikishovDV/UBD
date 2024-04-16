// VBConversions Note: VB project level imports
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
// End of VB project level imports


namespace HBRS
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmMain : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbarCheckIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarCheckOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarReserve = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarRoom = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.DiscountToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarCheckIn,
            this.ToolStripButton11,
            this.toolbarCheckOut,
            this.ToolStripSeparator6,
            this.toolbarReserve,
            this.ToolStripSeparator7,
            this.toolbarRoom,
            this.ToolStripSeparator8,
            this.ToolStripButton10,
            this.ToolStripSeparator9,
            this.DiscountToolStripMenuItem,
            this.toolStripSeparator11,
            this.ToolStripButton12,
            this.ToolStripSeparator10,
            this.ToolStripButton13});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1344, 31);
            this.ToolStrip1.TabIndex = 14;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolbarCheckIn
            // 
            this.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckIn.Name = "toolbarCheckIn";
            this.toolbarCheckIn.Size = new System.Drawing.Size(75, 28);
            this.toolbarCheckIn.Text = "Заселить";
            this.toolbarCheckIn.Click += new System.EventHandler(this.toolbarCheckIn_Click);
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(6, 31);
            // 
            // toolbarCheckOut
            // 
            this.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckOut.Name = "toolbarCheckOut";
            this.toolbarCheckOut.Size = new System.Drawing.Size(80, 28);
            this.toolbarCheckOut.Text = "Расчетать";
            this.toolbarCheckOut.Click += new System.EventHandler(this.toolbarCheckOut_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolbarReserve
            // 
            this.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarReserve.Name = "toolbarReserve";
            this.toolbarReserve.Size = new System.Drawing.Size(118, 28);
            this.toolbarReserve.Text = "Бронирование";
            this.toolbarReserve.Click += new System.EventHandler(this.toolbarReserve_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolbarRoom
            // 
            this.toolbarRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarRoom.Name = "toolbarRoom";
            this.toolbarRoom.Size = new System.Drawing.Size(69, 28);
            this.toolbarRoom.Text = "Номера";
            this.toolbarRoom.Click += new System.EventHandler(this.toolbarRoom_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButton10
            // 
            this.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton10.Name = "ToolStripButton10";
            this.ToolStripButton10.Size = new System.Drawing.Size(51, 28);
            this.ToolStripButton10.Text = "Гости";
            this.ToolStripButton10.Click += new System.EventHandler(this.ToolStripButton10_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // DiscountToolStripMenuItem
            // 
            this.DiscountToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem";
            this.DiscountToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.DiscountToolStripMenuItem.Text = "Скидки";
            this.DiscountToolStripMenuItem.Click += new System.EventHandler(this.DiscountToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButton12
            // 
            this.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton12.Name = "ToolStripButton12";
            this.ToolStripButton12.Size = new System.Drawing.Size(57, 28);
            this.ToolStripButton12.Text = "Выйти";
            this.ToolStripButton12.Click += new System.EventHandler(this.ToolStripButton12_Click);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButton13
            // 
            this.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton13.Name = "ToolStripButton13";
            this.ToolStripButton13.Size = new System.Drawing.Size(70, 28);
            this.ToolStripButton13.Text = "Закрыть";
            this.ToolStripButton13.Click += new System.EventHandler(this.ToolStripButton13_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.status.Location = new System.Drawing.Point(0, 762);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status.Size = new System.Drawing.Size(1344, 26);
            this.status.TabIndex = 15;
            this.status.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.AutoSize = false;
            this.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(662, 20);
            this.ToolStripStatusLabel4.Spring = true;
            this.ToolStripStatusLabel4.Text = "Пользователь :";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.AutoSize = false;
            this.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(662, 20);
            this.ToolStripStatusLabel5.Spring = true;
            this.ToolStripStatusLabel5.Text = "Гостиница";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel6.Text = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Visible = false;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(331, 19);
            this.ToolStripStatusLabel1.Spring = true;
            this.ToolStripStatusLabel1.Text = "Login as";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(331, 19);
            this.ToolStripStatusLabel2.Spring = true;
            this.ToolStripStatusLabel2.Text = "Hotel Billing and Reservation System v. 1";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(331, 19);
            this.ToolStripStatusLabel3.Spring = true;
            this.ToolStripStatusLabel3.Text = "Today is: ";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 788);
            this.Controls.Add(this.status);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гостиница";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStrip ToolStrip1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.StatusStrip status;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.ToolStripSeparator ToolStripButton5;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripButton toolbarCheckIn;
		internal System.Windows.Forms.ToolStripSeparator ToolStripButton11;
		internal System.Windows.Forms.ToolStripButton toolbarCheckOut;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
		internal System.Windows.Forms.ToolStripButton toolbarReserve;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
		internal System.Windows.Forms.ToolStripButton toolbarRoom;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.ToolStripButton ToolStripButton10;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
		internal System.Windows.Forms.ToolStripButton ToolStripButton12;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
		internal System.Windows.Forms.ToolStripButton ToolStripButton13;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        private System.ComponentModel.IContainer components;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripButton DiscountToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator11;
    }
	
}
