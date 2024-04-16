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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmCheckout : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.Label1 = new System.Windows.Forms.Label();
            this.bttnSearchGuest = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtCheckin = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCheckout = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtAdult = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtDiscountType = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.bttnCheckout = new System.Windows.Forms.Button();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblTransID = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(15, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(229, 29);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Выселение гостя";
            // 
            // bttnSearchGuest
            // 
            this.bttnSearchGuest.Location = new System.Drawing.Point(483, 114);
            this.bttnSearchGuest.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSearchGuest.Name = "bttnSearchGuest";
            this.bttnSearchGuest.Size = new System.Drawing.Size(40, 32);
            this.bttnSearchGuest.TabIndex = 71;
            this.bttnSearchGuest.Text = "...";
            this.bttnSearchGuest.UseVisualStyleBackColor = true;
            this.bttnSearchGuest.Click += new System.EventHandler(this.bttnSearchGuest_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(195, 116);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(279, 30);
            this.txtGuestName.TabIndex = 67;
            this.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(27, 122);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 20);
            this.Label3.TabIndex = 70;
            this.Label3.Text = "Имя гостя";
            // 
            // txtTransID
            // 
            this.txtTransID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTransID.Location = new System.Drawing.Point(195, 78);
            this.txtTransID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransID.Multiline = true;
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.ReadOnly = true;
            this.txtTransID.Size = new System.Drawing.Size(153, 31);
            this.txtTransID.TabIndex = 69;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(27, 84);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 20);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "ID транзакции";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(195, 154);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(112, 30);
            this.txtRoomNumber.TabIndex = 72;
            this.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtRoomNumber_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(27, 160);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(116, 20);
            this.Label4.TabIndex = 75;
            this.Label4.Text = "Номер гостя";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(195, 192);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(152, 30);
            this.txtRoomType.TabIndex = 76;
            this.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(27, 198);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 20);
            this.Label5.TabIndex = 77;
            this.Label5.Text = "Тип номера";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(195, 230);
            this.txtRoomRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(112, 30);
            this.txtRoomRate.TabIndex = 78;
            this.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(27, 236);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 20);
            this.Label6.TabIndex = 79;
            this.Label6.Text = "Стоимость";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape1,
            this.RectangleShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(980, 546);
            this.ShapeContainer1.TabIndex = 80;
            this.ShapeContainer1.TabStop = false;
            // 
            // LineShape1
            // 
            this.LineShape1.BorderColor = System.Drawing.SystemColors.MenuText;
            this.LineShape1.Name = "LineShape1";
            this.LineShape1.X1 = 13;
            this.LineShape1.X2 = 717;
            this.LineShape1.Y1 = 42;
            this.LineShape1.Y2 = 42;
            // 
            // RectangleShape1
            // 
            this.RectangleShape1.BorderColor = System.Drawing.Color.DarkGray;
            this.RectangleShape1.Location = new System.Drawing.Point(18, 328);
            this.RectangleShape1.Name = "RectangleShape1";
            this.RectangleShape1.Size = new System.Drawing.Size(697, 96);
            // 
            // txtCheckin
            // 
            this.txtCheckin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckin.Location = new System.Drawing.Point(195, 268);
            this.txtCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckin.Multiline = true;
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.ReadOnly = true;
            this.txtCheckin.Size = new System.Drawing.Size(152, 30);
            this.txtCheckin.TabIndex = 81;
            this.txtCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(27, 274);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(145, 20);
            this.Label7.TabIndex = 82;
            this.Label7.Text = "Дата заселения";
            // 
            // txtCheckout
            // 
            this.txtCheckout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckout.Location = new System.Drawing.Point(195, 306);
            this.txtCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckout.Multiline = true;
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.ReadOnly = true;
            this.txtCheckout.Size = new System.Drawing.Size(152, 30);
            this.txtCheckout.TabIndex = 83;
            this.txtCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(27, 313);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(131, 20);
            this.Label8.TabIndex = 84;
            this.Label8.Text = "Дата выбытия";
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(195, 345);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Multiline = true;
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(76, 30);
            this.txtDays.TabIndex = 85;
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(27, 351);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 20);
            this.Label9.TabIndex = 86;
            this.Label9.Text = "Дней";
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(783, 110);
            this.txtChildren.Margin = new System.Windows.Forms.Padding(4);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.ReadOnly = true;
            this.txtChildren.Size = new System.Drawing.Size(71, 30);
            this.txtChildren.TabIndex = 87;
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(608, 116);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 20);
            this.Label10.TabIndex = 88;
            this.Label10.Text = "Детей";
            // 
            // txtAdult
            // 
            this.txtAdult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdult.Location = new System.Drawing.Point(783, 148);
            this.txtAdult.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdult.Multiline = true;
            this.txtAdult.Name = "txtAdult";
            this.txtAdult.ReadOnly = true;
            this.txtAdult.Size = new System.Drawing.Size(71, 30);
            this.txtAdult.TabIndex = 89;
            this.txtAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(608, 154);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(89, 20);
            this.Label11.TabIndex = 90;
            this.Label11.Text = "Взрослых";
            // 
            // txtDiscountType
            // 
            this.txtDiscountType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiscountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountType.Location = new System.Drawing.Point(783, 186);
            this.txtDiscountType.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscountType.Multiline = true;
            this.txtDiscountType.Name = "txtDiscountType";
            this.txtDiscountType.ReadOnly = true;
            this.txtDiscountType.Size = new System.Drawing.Size(164, 30);
            this.txtDiscountType.TabIndex = 91;
            this.txtDiscountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountType.TextChanged += new System.EventHandler(this.txtDiscountType_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(608, 192);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(103, 20);
            this.Label12.TabIndex = 92;
            this.Label12.Text = "Тип скидки";
            // 
            // txtAdvance
            // 
            this.txtAdvance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(783, 262);
            this.txtAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdvance.Multiline = true;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(112, 30);
            this.txtAdvance.TabIndex = 93;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdvance.TextChanged += new System.EventHandler(this.txtAdvance_TextChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(608, 268);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(169, 20);
            this.Label13.TabIndex = 94;
            this.Label13.Text = "Авансовый платеж";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(783, 300);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 30);
            this.txtTotal.TabIndex = 95;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(608, 306);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(48, 20);
            this.Label14.TabIndex = 96;
            this.Label14.Text = "Итог";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.Red;
            this.txtCash.Location = new System.Drawing.Point(161, 438);
            this.txtCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(189, 46);
            this.txtCash.TabIndex = 97;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(27, 441);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(106, 36);
            this.Label15.TabIndex = 98;
            this.Label15.Text = "Догл:";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Red;
            this.txtChange.Location = new System.Drawing.Point(551, 439);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(189, 46);
            this.txtChange.TabIndex = 99;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(381, 444);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(132, 36);
            this.Label16.TabIndex = 100;
            this.Label16.Text = "Сумма:";
            // 
            // bttnCheckout
            // 
            this.bttnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCheckout.Location = new System.Drawing.Point(796, 433);
            this.bttnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCheckout.Name = "bttnCheckout";
            this.bttnCheckout.Size = new System.Drawing.Size(171, 62);
            this.bttnCheckout.TabIndex = 101;
            this.bttnCheckout.Text = "&Выселить";
            this.bttnCheckout.UseVisualStyleBackColor = true;
            this.bttnCheckout.Click += new System.EventHandler(this.bttnCheckout_Click);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(19, 612);
            this.lblGuestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(55, 16);
            this.lblGuestID.TabIndex = 102;
            this.lblGuestID.Text = "GuestID";
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.Location = new System.Drawing.Point(20, 636);
            this.lblTransID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(49, 16);
            this.lblTransID.TabIndex = 103;
            this.lblTransID.Text = "transID";
            this.lblTransID.TextChanged += new System.EventHandler(this.lblTransID_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(783, 224);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(112, 30);
            this.txtSubTotal.TabIndex = 104;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(608, 230);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(112, 20);
            this.Label17.TabIndex = 105;
            this.Label17.Text = "Итог скидки";
            // 
            // dtIn
            // 
            this.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIn.Location = new System.Drawing.Point(135, 612);
            this.dtIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(123, 22);
            this.dtIn.TabIndex = 106;
            // 
            // dtOut
            // 
            this.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOut.Location = new System.Drawing.Point(267, 612);
            this.dtOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(135, 22);
            this.dtOut.TabIndex = 107;
            // 
            // frmCheckout
            // 
            this.AcceptButton = this.bttnCheckout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 546);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.lblTransID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.bttnCheckout);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtDiscountType);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtAdult);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtChildren);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtCheckout);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtCheckin);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.bttnSearchGuest);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ShapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выселение гостя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckout_FormClosing);
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button bttnSearchGuest;
		internal System.Windows.Forms.TextBox txtGuestName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtTransID;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtRoomNumber;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtRoomType;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtRoomRate;
		internal System.Windows.Forms.Label Label6;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
		internal System.Windows.Forms.TextBox txtCheckin;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtCheckout;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtDays;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtChildren;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtAdult;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtDiscountType;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtAdvance;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtTotal;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtCash;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtChange;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Button bttnCheckout;
		internal System.Windows.Forms.Label lblGuestID;
		internal System.Windows.Forms.Label lblTransID;
		internal System.Windows.Forms.TextBox txtSubTotal;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.DateTimePicker dtIn;
		internal System.Windows.Forms.DateTimePicker dtOut;
		internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
	}
	
}
