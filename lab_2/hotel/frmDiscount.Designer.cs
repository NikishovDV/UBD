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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmDiscount : System.Windows.Forms.Form
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
            this.lvlDiscount = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtType = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvlDiscount
            // 
            this.lvlDiscount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lvlDiscount.FullRowSelect = true;
            this.lvlDiscount.GridLines = true;
            this.lvlDiscount.HideSelection = false;
            this.lvlDiscount.Location = new System.Drawing.Point(436, 70);
            this.lvlDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.lvlDiscount.Name = "lvlDiscount";
            this.lvlDiscount.Size = new System.Drawing.Size(267, 195);
            this.lvlDiscount.TabIndex = 0;
            this.lvlDiscount.UseCompatibleStateImageBehavior = false;
            this.lvlDiscount.View = System.Windows.Forms.View.Details;
            this.lvlDiscount.DoubleClick += new System.EventHandler(this.lvlDiscount_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 30;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Type";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 100;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Rate";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(222, 108);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(193, 30);
            this.txtType.TabIndex = 76;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 111);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 20);
            this.Label4.TabIndex = 77;
            this.Label4.Text = "Тип скидки";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(222, 146);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(87, 30);
            this.txtRate.TabIndex = 78;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 149);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(198, 20);
            this.Label1.TabIndex = 79;
            this.Label1.Text = "Стоимость скидки (%)";
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(178, 223);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(113, 36);
            this.bttnSave.TabIndex = 80;
            this.bttnSave.Text = "&Сохранить";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(298, 223);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(113, 36);
            this.bttnCancel.TabIndex = 81;
            this.bttnCancel.Text = "&Отменить";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 26);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 29);
            this.Label2.TabIndex = 82;
            this.Label2.Text = "Скидки";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 297);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lvlDiscount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.ListView lvlDiscount;
		internal System.Windows.Forms.TextBox txtType;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtRate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.Button bttnSave;
		internal System.Windows.Forms.Button bttnCancel;
		internal System.Windows.Forms.Label Label2;
	}
	
}
