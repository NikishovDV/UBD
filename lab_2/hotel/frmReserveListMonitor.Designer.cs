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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmReserveListMonitor : System.Windows.Forms.Form
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
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.lvlreserve = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvlreserve
            // 
            this.lvlreserve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11,
            this.ColumnHeader12});
            this.lvlreserve.FullRowSelect = true;
            this.lvlreserve.GridLines = true;
            this.lvlreserve.HideSelection = false;
            this.lvlreserve.Location = new System.Drawing.Point(16, 27);
            this.lvlreserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvlreserve.Name = "lvlreserve";
            this.lvlreserve.Size = new System.Drawing.Size(1061, 335);
            this.lvlreserve.TabIndex = 1;
            this.lvlreserve.UseCompatibleStateImageBehavior = false;
            this.lvlreserve.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "TransID";
            this.ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Guest Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 200;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Room #";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.DisplayIndex = 4;
            this.ColumnHeader4.Text = "Checkin Date";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 100;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.DisplayIndex = 5;
            this.ColumnHeader5.Text = "Checkout Date";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 100;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.DisplayIndex = 6;
            this.ColumnHeader6.Text = "No. of Days";
            this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader6.Width = 80;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.DisplayIndex = 7;
            this.ColumnHeader7.Text = "Children";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.DisplayIndex = 8;
            this.ColumnHeader8.Text = "Adults";
            this.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.DisplayIndex = 9;
            this.ColumnHeader9.Text = "Advance Payment";
            this.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader9.Width = 120;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.DisplayIndex = 10;
            this.ColumnHeader10.Text = "Discount";
            this.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader10.Width = 80;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.DisplayIndex = 11;
            this.ColumnHeader11.Text = "Total";
            this.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader11.Width = 80;
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.DisplayIndex = 3;
            this.ColumnHeader12.Text = "Reservation Date";
            this.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader12.Width = 100;
            // 
            // dtOut
            // 
            this.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOut.Location = new System.Drawing.Point(149, 414);
            this.dtOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(137, 22);
            this.dtOut.TabIndex = 41;
            this.dtOut.Visible = false;
            // 
            // dtIn
            // 
            this.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIn.Location = new System.Drawing.Point(16, 414);
            this.dtIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(124, 22);
            this.dtIn.TabIndex = 40;
            this.dtIn.Visible = false;
            // 
            // frmReserveListMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 385);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.lvlreserve);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReserveListMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "������ ������";
            this.Load += new System.EventHandler(this.frmReserveListMonitor_Load);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ListView lvlreserve;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.DateTimePicker dtOut;
		internal System.Windows.Forms.DateTimePicker dtIn;
	}
	
}
