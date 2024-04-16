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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmGuest : System.Windows.Forms.Form
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.buttExport = new System.Windows.Forms.Button();
            this.lvGuest = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label9 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(13, 16);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(905, 469);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.bttnCancel);
            this.TabPage1.Controls.Add(this.bttnSave);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.txtEmail);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.cboGender);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.txtNumber);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txtAddress);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtMName);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.txtLName);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtFName);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage1.Size = new System.Drawing.Size(897, 440);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Новый гость";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(725, 370);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(133, 38);
            this.bttnCancel.TabIndex = 59;
            this.bttnCancel.Text = "&Очистить";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(584, 370);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(133, 38);
            this.bttnSave.TabIndex = 58;
            this.bttnSave.Text = "&Сохранить";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(27, 33);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(275, 29);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "Новый гость (форма)";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(225, 308);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 30);
            this.txtEmail.TabIndex = 55;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(53, 315);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(51, 20);
            this.Label7.TabIndex = 56;
            this.Label7.Text = "Email";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.cboGender.Location = new System.Drawing.Point(225, 274);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(195, 24);
            this.cboGender.TabIndex = 54;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(53, 276);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(42, 20);
            this.Label6.TabIndex = 53;
            this.Label6.Text = "Пол";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(225, 234);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(279, 30);
            this.txtNumber.TabIndex = 50;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(53, 241);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(168, 20);
            this.Label5.TabIndex = 51;
            this.Label5.Text = "Контактный номер";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(225, 196);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 30);
            this.txtAddress.TabIndex = 48;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(53, 203);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 20);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "Адрес";
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(225, 158);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Multiline = true;
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(279, 30);
            this.txtMName.TabIndex = 46;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(53, 165);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 20);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "Отчество";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(225, 119);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(279, 30);
            this.txtLName.TabIndex = 44;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(53, 127);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 20);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Фамилия";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(225, 81);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(279, 30);
            this.txtFName.TabIndex = 42;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(53, 89);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 20);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "Имя";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.buttExport);
            this.TabPage2.Controls.Add(this.lvGuest);
            this.TabPage2.Controls.Add(this.Label9);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage2.Size = new System.Drawing.Size(897, 440);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Список гостей";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // buttExport
            // 
            this.buttExport.Location = new System.Drawing.Point(710, 379);
            this.buttExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttExport.Name = "buttExport";
            this.buttExport.Size = new System.Drawing.Size(151, 43);
            this.buttExport.TabIndex = 67;
            this.buttExport.Text = "&Экспортировать";
            this.buttExport.UseVisualStyleBackColor = true;
            this.buttExport.Click += new System.EventHandler(this.buttExport_Click);
            // 
            // lvGuest
            // 
            this.lvGuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7});
            this.lvGuest.FullRowSelect = true;
            this.lvGuest.GridLines = true;
            this.lvGuest.HideSelection = false;
            this.lvGuest.Location = new System.Drawing.Point(32, 75);
            this.lvGuest.Margin = new System.Windows.Forms.Padding(4);
            this.lvGuest.Name = "lvGuest";
            this.lvGuest.Size = new System.Drawing.Size(829, 296);
            this.lvGuest.TabIndex = 59;
            this.lvGuest.UseCompatibleStateImageBehavior = false;
            this.lvGuest.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "First Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 150;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Middle Name";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 150;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Last Name";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 150;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Address";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 150;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Contact Number";
            this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader6.Width = 100;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Status";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader7.Width = 80;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(27, 33);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(195, 29);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "Список гостей";
            // 
            // frmGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гость";
            this.Load += new System.EventHandler(this.frmGuest_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TextBox txtLName;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtFName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtMName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtEmail;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.ComboBox cboGender;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtNumber;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ListView lvGuest;
		internal System.Windows.Forms.Button bttnCancel;
		internal System.Windows.Forms.Button bttnSave;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal Button buttExport;
    }
	
}
