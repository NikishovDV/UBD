namespace Tyuiu.NikishovDV.Task1.V4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddBook_NDV = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewBooks_NDV = new System.Windows.Forms.DataGridView();
            this.buttonDeleteBook_NDV = new System.Windows.Forms.Button();
            this.textBoxBookName_NDV = new System.Windows.Forms.TextBox();
            this.textBoxBookAutor_NDV = new System.Windows.Forms.TextBox();
            this.textBoxYearRelease_NDV = new System.Windows.Forms.TextBox();
            this.buttonCountAllBooks_NDV = new System.Windows.Forms.Button();
            this.buttonOpenDB_NDV = new System.Windows.Forms.Button();
            this.buttonWriteDB_NDV = new System.Windows.Forms.Button();
            this.labelAutor_NDV = new System.Windows.Forms.Label();
            this.labelNameBook_NDV = new System.Windows.Forms.Label();
            this.labelYearRelease_NDV = new System.Windows.Forms.Label();
            this.buttonBuildGraphs_NDV = new System.Windows.Forms.Button();
            this.checkBoxInStock_NDV = new System.Windows.Forms.CheckBox();
            this.buttonSortBooks_NDV = new System.Windows.Forms.Button();
            this.labelProgramName_NDV = new System.Windows.Forms.Label();
            this.buttonCancelSearch_NDV = new System.Windows.Forms.Button();
            this.buttonSearch_NDV = new System.Windows.Forms.Button();
            this.buttonOpenReaders_NDV = new System.Windows.Forms.Button();
            this.comboBoxReader_NDV = new System.Windows.Forms.ComboBox();
            this.labelReader_NDV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_NDV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddBook_NDV
            // 
            this.buttonAddBook_NDV.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.buttonAddBook_NDV, "buttonAddBook_NDV");
            this.buttonAddBook_NDV.Name = "buttonAddBook_NDV";
            this.buttonAddBook_NDV.UseVisualStyleBackColor = false;
            this.buttonAddBook_NDV.Click += new System.EventHandler(this.buttonAddBook_NDV_Click);
            // 
            // dataGridViewBooks_NDV
            // 
            this.dataGridViewBooks_NDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewBooks_NDV, "dataGridViewBooks_NDV");
            this.dataGridViewBooks_NDV.Name = "dataGridViewBooks_NDV";
            this.dataGridViewBooks_NDV.RowTemplate.Height = 41;
            // 
            // buttonDeleteBook_NDV
            // 
            this.buttonDeleteBook_NDV.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.buttonDeleteBook_NDV, "buttonDeleteBook_NDV");
            this.buttonDeleteBook_NDV.Name = "buttonDeleteBook_NDV";
            this.buttonDeleteBook_NDV.UseVisualStyleBackColor = false;
            this.buttonDeleteBook_NDV.Click += new System.EventHandler(this.buttonDeleteBook_NDV_Click);
            // 
            // textBoxBookName_NDV
            // 
            resources.ApplyResources(this.textBoxBookName_NDV, "textBoxBookName_NDV");
            this.textBoxBookName_NDV.Name = "textBoxBookName_NDV";
            // 
            // textBoxBookAutor_NDV
            // 
            resources.ApplyResources(this.textBoxBookAutor_NDV, "textBoxBookAutor_NDV");
            this.textBoxBookAutor_NDV.Name = "textBoxBookAutor_NDV";
            // 
            // textBoxYearRelease_NDV
            // 
            resources.ApplyResources(this.textBoxYearRelease_NDV, "textBoxYearRelease_NDV");
            this.textBoxYearRelease_NDV.Name = "textBoxYearRelease_NDV";
            // 
            // buttonCountAllBooks_NDV
            // 
            resources.ApplyResources(this.buttonCountAllBooks_NDV, "buttonCountAllBooks_NDV");
            this.buttonCountAllBooks_NDV.Name = "buttonCountAllBooks_NDV";
            this.buttonCountAllBooks_NDV.UseVisualStyleBackColor = true;
            this.buttonCountAllBooks_NDV.Click += new System.EventHandler(this.buttonCountAllBooks_NDV_Click);
            // 
            // buttonOpenDB_NDV
            // 
            resources.ApplyResources(this.buttonOpenDB_NDV, "buttonOpenDB_NDV");
            this.buttonOpenDB_NDV.Name = "buttonOpenDB_NDV";
            this.buttonOpenDB_NDV.UseVisualStyleBackColor = true;
            this.buttonOpenDB_NDV.Click += new System.EventHandler(this.buttonOpenDB_NDV_Click);
            // 
            // buttonWriteDB_NDV
            // 
            resources.ApplyResources(this.buttonWriteDB_NDV, "buttonWriteDB_NDV");
            this.buttonWriteDB_NDV.Name = "buttonWriteDB_NDV";
            this.buttonWriteDB_NDV.UseVisualStyleBackColor = true;
            this.buttonWriteDB_NDV.Click += new System.EventHandler(this.buttonWriteDB_NDV_Click);
            // 
            // labelAutor_NDV
            // 
            resources.ApplyResources(this.labelAutor_NDV, "labelAutor_NDV");
            this.labelAutor_NDV.Name = "labelAutor_NDV";
            // 
            // labelNameBook_NDV
            // 
            resources.ApplyResources(this.labelNameBook_NDV, "labelNameBook_NDV");
            this.labelNameBook_NDV.Name = "labelNameBook_NDV";
            // 
            // labelYearRelease_NDV
            // 
            resources.ApplyResources(this.labelYearRelease_NDV, "labelYearRelease_NDV");
            this.labelYearRelease_NDV.Name = "labelYearRelease_NDV";
            // 
            // buttonBuildGraphs_NDV
            // 
            resources.ApplyResources(this.buttonBuildGraphs_NDV, "buttonBuildGraphs_NDV");
            this.buttonBuildGraphs_NDV.Name = "buttonBuildGraphs_NDV";
            this.buttonBuildGraphs_NDV.UseVisualStyleBackColor = true;
            this.buttonBuildGraphs_NDV.Click += new System.EventHandler(this.buttonBuildGraphs_NDV_Click);
            // 
            // checkBoxInStock_NDV
            // 
            resources.ApplyResources(this.checkBoxInStock_NDV, "checkBoxInStock_NDV");
            this.checkBoxInStock_NDV.Name = "checkBoxInStock_NDV";
            this.checkBoxInStock_NDV.UseVisualStyleBackColor = true;
            // 
            // buttonSortBooks_NDV
            // 
            resources.ApplyResources(this.buttonSortBooks_NDV, "buttonSortBooks_NDV");
            this.buttonSortBooks_NDV.Name = "buttonSortBooks_NDV";
            this.buttonSortBooks_NDV.UseVisualStyleBackColor = true;
            this.buttonSortBooks_NDV.Click += new System.EventHandler(this.buttonSortBooks_NDV_Click);
            // 
            // labelProgramName_NDV
            // 
            resources.ApplyResources(this.labelProgramName_NDV, "labelProgramName_NDV");
            this.labelProgramName_NDV.Name = "labelProgramName_NDV";
            // 
            // buttonCancelSearch_NDV
            // 
            resources.ApplyResources(this.buttonCancelSearch_NDV, "buttonCancelSearch_NDV");
            this.buttonCancelSearch_NDV.Name = "buttonCancelSearch_NDV";
            this.buttonCancelSearch_NDV.UseVisualStyleBackColor = true;
            this.buttonCancelSearch_NDV.Click += new System.EventHandler(this.buttonCancelSearch_NDV_Click);
            // 
            // buttonSearch_NDV
            // 
            resources.ApplyResources(this.buttonSearch_NDV, "buttonSearch_NDV");
            this.buttonSearch_NDV.Name = "buttonSearch_NDV";
            this.buttonSearch_NDV.UseVisualStyleBackColor = true;
            this.buttonSearch_NDV.Click += new System.EventHandler(this.buttonSearch_NDV_Click);
            // 
            // buttonOpenReaders_NDV
            // 
            resources.ApplyResources(this.buttonOpenReaders_NDV, "buttonOpenReaders_NDV");
            this.buttonOpenReaders_NDV.Name = "buttonOpenReaders_NDV";
            this.buttonOpenReaders_NDV.UseVisualStyleBackColor = true;
            this.buttonOpenReaders_NDV.Click += new System.EventHandler(this.buttonOpenReaders_NDV_Click);
            // 
            // comboBoxReader_NDV
            // 
            this.comboBoxReader_NDV.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxReader_NDV, "comboBoxReader_NDV");
            this.comboBoxReader_NDV.Name = "comboBoxReader_NDV";
            this.comboBoxReader_NDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxReader_NDV_SelectedIndexChanged);
            // 
            // labelReader_NDV
            // 
            resources.ApplyResources(this.labelReader_NDV, "labelReader_NDV");
            this.labelReader_NDV.Name = "labelReader_NDV";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxReader_NDV);
            this.Controls.Add(this.buttonOpenReaders_NDV);
            this.Controls.Add(this.buttonSearch_NDV);
            this.Controls.Add(this.buttonCancelSearch_NDV);
            this.Controls.Add(this.labelProgramName_NDV);
            this.Controls.Add(this.buttonSortBooks_NDV);
            this.Controls.Add(this.checkBoxInStock_NDV);
            this.Controls.Add(this.buttonBuildGraphs_NDV);
            this.Controls.Add(this.labelReader_NDV);
            this.Controls.Add(this.labelYearRelease_NDV);
            this.Controls.Add(this.labelNameBook_NDV);
            this.Controls.Add(this.labelAutor_NDV);
            this.Controls.Add(this.buttonWriteDB_NDV);
            this.Controls.Add(this.buttonOpenDB_NDV);
            this.Controls.Add(this.buttonCountAllBooks_NDV);
            this.Controls.Add(this.textBoxYearRelease_NDV);
            this.Controls.Add(this.textBoxBookAutor_NDV);
            this.Controls.Add(this.textBoxBookName_NDV);
            this.Controls.Add(this.buttonDeleteBook_NDV);
            this.Controls.Add(this.dataGridViewBooks_NDV);
            this.Controls.Add(this.buttonAddBook_NDV);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_NDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddBook_NDV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridViewBooks_NDV;
        private Button buttonDeleteBook_NDV;
        private TextBox textBoxBookName_NDV;
        private TextBox textBoxBookAutor_NDV;
        private TextBox textBoxYearRelease_NDV;
        private Button buttonCountAllBooks_NDV;
        private Button buttonOpenDB_NDV;
        private Button buttonWriteDB_NDV;
        private Label labelAutor_NDV;
        private Label labelNameBook_NDV;
        private Label labelYearRelease_NDV;
        private Button buttonBuildGraphs_NDV;
        private CheckBox checkBoxInStock_NDV;
        private Button buttonSortBooks_NDV;
        private Label labelProgramName_NDV;
        private Button buttonCancelSearch_NDV;
        private Button buttonSearch_NDV;
        private Button buttonOpenReaders_NDV;
        private ComboBox comboBoxReader_NDV;
        private Label labelReader_NDV;
    }
}