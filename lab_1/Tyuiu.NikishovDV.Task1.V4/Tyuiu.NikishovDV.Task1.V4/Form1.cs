using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.NikishovDV.Task1.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddBook_NDV_Click(object sender, EventArgs e)
        {
            // �������� DataTable �� ��������� ������ dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("������: DataTable �� ���������������.");
                return;
            }

            // �������� ������ � ����� ����� �� ��������� �����
            string bookName = textBoxBookName_NDV.Text;
            string bookAuthor = textBoxBookAutor_NDV.Text;
            string yearRelease = textBoxYearRelease_NDV.Text;
            bool inStock = checkBoxInStock_NDV.Checked; // ���������� �������� Checked ��������

            // �������� ��������� �������� �� comboBoxReader_NDV
            string selectedReader = comboBoxReader_NDV.SelectedItem?.ToString();

            // ��������� ����� ������ � DataTable
            dataTable.Rows.Add(bookName, bookAuthor, yearRelease, inStock, selectedReader);

            // ������� ��������� ���� ����� ���������� �����
            textBoxBookName_NDV.Clear();
            textBoxBookAutor_NDV.Clear();
            textBoxYearRelease_NDV.Clear();
            checkBoxInStock_NDV.Checked = false; // ���������� �������� ��������
        }



        private void buttonDeleteBook_NDV_Click(object sender, EventArgs e)
        {
            // ���������, ������� �� �����-���� ������
            if (dataGridViewBooks_NDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ����� ��� ��������.");
                return;
            }

            // ����������� ������������� � ������������
            DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ��������� �����?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // ������� ��������� ������ �� DataTable
                DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
                if (dataTable != null)
                {
                    foreach (DataGridViewRow row in dataGridViewBooks_NDV.SelectedRows)
                    {
                        dataTable.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }


        private void buttonOpenDB_NDV_Click(object sender, EventArgs e)
        {
            LoadReadersToFIOComboBox();

            // ���� � ����� � ������� � ������
            string bookFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.txt");

            // �������� ������������� �����
            if (!File.Exists(bookFilePath))
            {
                MessageBox.Show("���� � ������� � ������ �� ������.");
                return;
            }

            // ������� DataTable ��� ����
            DataTable bookDataTable = new DataTable();
            bookDataTable.Columns.Add("�������� �����");
            bookDataTable.Columns.Add("�����");
            bookDataTable.Columns.Add("��� �������");
            bookDataTable.Columns.Add("� �������", typeof(bool));
            bookDataTable.Columns.Add("��������");

            // ������ ������ � ������ �� ����� � �������� �� � DataTable
            try
            {
                using (StreamReader reader = new StreamReader(bookFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 4)
                        {
                            bookDataTable.Rows.Add(parts);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������ ����� � ������� � ������: " + ex.Message);
                return;
            }

            // ���������� DataGridView
            dataGridViewBooks_NDV.DataSource = bookDataTable;
        }




        private void buttonWriteDB_NDV_Click(object sender, EventArgs e)
        {
            // ���� � ����� � �������
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.txt");

            // �������� DataTable �� ��������� ������ dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("��� ������ ��� ������.");
                return;
            }

            // ����� ������ �� DataTable � ����
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string line = string.Join(";", row.ItemArray);
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("������ ������� �������� � ����.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������ �����: " + ex.Message);
            }
        }

        private void buttonCountAllBooks_NDV_Click(object sender, EventArgs e)
        {
            // �������� DataTable �� ��������� ������ dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("������: DataTable �� ���������������.");
                return;
            }

            // ���������� ��� �������� ���������� ����
            int totalCount = 0;
            int inStockCount = 0;
            int notInStockCount = 0;

            // �������� �� ������ ������ � DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // ����������� ����� ���������� ����
                totalCount++;

                // ��������� �������� ������� "� �������"
                bool inStock = (bool)row["� �������"];
                if (inStock)
                {
                    // ���� ����� � �������, ����������� ������� ���� � �������
                    inStockCount++;
                }
                else
                {
                    // ���� ����� ��� � �������, ����������� ������� ����, ������� ��� � �������
                    notInStockCount++;
                }
            }

            // ������� ��������� � ������������� ����������
            MessageBox.Show($"����� ���������� ���� � ���� ������: {totalCount}\n���������� ���� � �������: {inStockCount}\n���������� ����, ������� ��� � �������: {notInStockCount}");
        }

        private void buttonBuildGraphs_NDV_Click(object sender, EventArgs e)
        {
            // ������� ����� ��������� ������� ��� ���������� ���������
            Chart columnChart = new Chart();
            columnChart.Dock = DockStyle.Fill;
            columnChart.ChartAreas.Add(new ChartArea("MainArea"));
            columnChart.Series.Add(new Series("BooksByYear"));

            // ������������� ��� ������� (���������� ���������)
            columnChart.Series["BooksByYear"].ChartType = SeriesChartType.Column;

            // �������� DataTable �� ��������� ������ dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("������: DataTable �� ���������������.");
                return;
            }

            // ���������� ����� �� ����� ������� � ������� ���������� ���� � ������ ������ ��� ���������� ���������
            var booksByYear = from row in dataTable.AsEnumerable()
                              group row by row.Field<string>("��� �������") into g
                              select new
                              {
                                  Year = g.Key,
                                  Count = g.Count()
                              };

            // ��������� ����� �� ���������� ���������
            foreach (var book in booksByYear)
            {
                columnChart.Series["BooksByYear"].Points.AddXY(book.Year, book.Count);
            }

            // ������� ����� ��� ����������� �������
            Form chartForm = new Form();
            chartForm.Text = "������ ���������� ���� �� ���� �������";
            chartForm.Controls.Add(columnChart);
            chartForm.Size = new System.Drawing.Size(520, 380);
            chartForm.Resize += (s, ev) =>
            {
                // ��������� ������ � ������� ������� ��� ��������� ������� �����
                columnChart.Size = new Size(chartForm.ClientSize.Width - 20, chartForm.ClientSize.Height - 20);
                columnChart.Location = new Point(10, 10);
            };

            // ���������� ������ � ����� ����
            chartForm.ShowDialog();
        }



        private void buttonSortBooks_NDV_Click(object sender, EventArgs e)
        {
            // ������� ���������� ���� ��� ������ ������� ����������
            Form sortDialog = new Form();
            sortDialog.Text = "�������� ������� ����������";
            sortDialog.Size = new System.Drawing.Size(400, 250);

            // ��������� ������ ��� ������ ������� ����������
            Button buttonSortByName = new Button();
            buttonSortByName.Text = "�� ��������";
            buttonSortByName.Size = new System.Drawing.Size(70, 50);
            buttonSortByName.Dock = DockStyle.Top;
            buttonSortByName.Click += (s, ev) =>
            {
                SortBooks("�������� �����");
                sortDialog.Close();
            };

            Button buttonSortByAuthor = new Button();
            buttonSortByAuthor.Text = "�� ������";
            buttonSortByAuthor.Size = new System.Drawing.Size(70, 50);
            buttonSortByAuthor.Dock = DockStyle.Top;
            buttonSortByAuthor.Click += (s, ev) =>
            {
                SortBooks("�����");
                sortDialog.Close();
            };

            Button buttonSortByYear = new Button();
            buttonSortByYear.Text = "�� ���� �������";
            buttonSortByYear.Size = new System.Drawing.Size(70, 50);
            buttonSortByYear.Dock = DockStyle.Top;
            buttonSortByYear.Click += (s, ev) =>
            {
                SortBooks("��� �������");
                sortDialog.Close();
            };

            Button buttonSortByStock = new Button();
            buttonSortByStock.Text = "�� �������";
            buttonSortByStock.Size = new System.Drawing.Size(70, 50);
            buttonSortByStock.Dock = DockStyle.Top;
            buttonSortByStock.Click += (s, ev) =>
            {
                SortBooks("� �������");
                sortDialog.Close();
            };

            // ��������� ������ �� �����
            sortDialog.Controls.Add(buttonSortByStock);
            sortDialog.Controls.Add(buttonSortByYear);
            sortDialog.Controls.Add(buttonSortByAuthor);
            sortDialog.Controls.Add(buttonSortByName);

            // ���������� ���������� ����
            sortDialog.ShowDialog();
        }

        // ����� ��� ���������� ���� �� ���������� �������
        private void SortBooks(string columnName)
        {
            // �������� DataTable �� ��������� ������ dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("������: DataTable �� ���������������.");
                return;
            }

            // ���������, ���� ���������� �� �������� ��� �� ������, �� ���������� ��������� ����������
            if (columnName == "�������� �����" || columnName == "�����")
            {
                dataTable.DefaultView.Sort = columnName;
            }
            else
            {
                // ��������� ����� �� ���������� �������
                DataView dv = dataTable.DefaultView;
                dv.Sort = columnName;
                dataTable = dv.ToTable();
            }

            // ��������� �������� ������ � DataGridView
            dataGridViewBooks_NDV.DataSource = dataTable;
        }

        private void buttonSortAutor_NDV_Click(object sender, EventArgs e)
        {
            // ������� ����� ��� ����� ������
            Form inputForm = new Form();
            inputForm.Text = "������� ������";
            inputForm.Size = new System.Drawing.Size(400, 220);

            // ��������� ��������� ���� ��� ����� ������ � �������� ������
            TextBox textBoxAuthor = new TextBox();
            textBoxAuthor.Dock = DockStyle.Top;
            textBoxAuthor.Multiline = false;
            textBoxAuthor.Width = 280;
            textBoxAuthor.Height = 90;
            textBoxAuthor.Top = 10;
            inputForm.Controls.Add(textBoxAuthor);

            // ��������� ������ "��" ��� ������������� �����
            Button buttonOK = new Button();
            buttonOK.Text = "�����";
            buttonOK.Width = 100;
            buttonOK.Height = 40;
            buttonOK.Top = textBoxAuthor.Bottom + 10;
            buttonOK.Left = (inputForm.ClientSize.Width - buttonOK.Width) / 2;
            inputForm.Controls.Add(buttonOK);

            // ��������� ���������� ������� ������� �� ������ "��"
            buttonOK.Click += (s, ev) =>
            {
                // �������� ��������� �����
                string author = textBoxAuthor.Text.Trim();

                // ���������, �� ������ �� ���� �����
                if (string.IsNullOrWhiteSpace(author))
                {
                    MessageBox.Show("������� ������!");
                    return;
                }

                // ��������� ������ � DataGridView �� ������
                DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
                if (dataTable != null)
                {
                    // ������� ��������� ���������� ��� ������� ����������
                    string filterExpression = $"����� = '{author}'";

                    // ��������� ������
                    dataTable.DefaultView.RowFilter = filterExpression;

                    // ���������, ���� �� ������ ����� ����������
                    if (dataTable.DefaultView.Count == 0)
                    {
                        MessageBox.Show("�� �������!");
                    }
                }

                // ��������� ����� ��� �����
                inputForm.Close();
            };

            // ���������� ����� ��� �����
            inputForm.ShowDialog();
        }

        private void buttonSortYear_NDV_Click(object sender, EventArgs e)
        {
            // ������� ����� ��� ����� ������
            Form inputForm = new Form();
            inputForm.Text = "������� ��� �������";
            inputForm.Size = new System.Drawing.Size(400, 220);

            // ��������� ��������� ���� ��� ����� ���� ������� � �������� ������
            TextBox textBoxYear = new TextBox();
            textBoxYear.Dock = DockStyle.Top;
            textBoxYear.Multiline = false;
            textBoxYear.Width = 280;
            textBoxYear.Height = 90;
            textBoxYear.Margin = new Padding(10, 30, 10, 10); // ������������� ������� ������, ������, ����� � �����
            inputForm.Controls.Add(textBoxYear);

            // ��������� ������ "��" ��� ������������� �����
            Button buttonOK = new Button();
            buttonOK.Text = "�����";
            buttonOK.Width = 100;
            buttonOK.Height = 40;
            buttonOK.Margin = new Padding(10);
            buttonOK.Top = textBoxYear.Bottom + 10;
            buttonOK.Left = (inputForm.ClientSize.Width - buttonOK.Width) / 2;
            inputForm.Controls.Add(buttonOK);

            // ��������� ���������� ������� ������� �� ������ "��"
            buttonOK.Click += (s, ev) =>
            {
                // �������� ��������� ��� �������
                string year = textBoxYear.Text.Trim();

                // ���������, �� ������ �� ���� �����
                if (string.IsNullOrWhiteSpace(year))
                {
                    MessageBox.Show("������� ��� �������!");
                    return;
                }

                // ��������� ������ � DataGridView �� ���� �������
                DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
                if (dataTable != null)
                {
                    // ������� ��������� ���������� ��� ������� ����������
                    string filterExpression = $"[��� �������] = '{year}'";

                    // ��������� ������
                    dataTable.DefaultView.RowFilter = filterExpression;

                    // ���������, ���� �� ������ ����� ����������
                    if (dataTable.DefaultView.Count == 0)
                    {
                        MessageBox.Show("�� �������!");
                    }
                }

                // ��������� ����� ��� �����
                inputForm.Close();
            };

            // ���������� ����� ��� �����
            inputForm.ShowDialog();
        }

        private void buttonCancelSearch_NDV_Click(object sender, EventArgs e)
        {
            // ������� ������
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("����� ���������!");
            // ������ ��������, ������� �� ������ ��������� ��� �������� �����
        }




        private void buttonSearch_NDV_Click(object sender, EventArgs e)
        {
            // ������� ����� ��� ���� ������
            Form searchMenu = new Form();
            searchMenu.Text = "�������� ��� ������";
            searchMenu.Size = new Size(300, 200);

            // ������ ��� ������ �� ������
            Button buttonSortAutor = new Button();
            buttonSortAutor.Text = "����� �� ������";
            buttonSortAutor.Dock = DockStyle.Top;
            buttonSortAutor.Size = new Size(250, 40); // ������������� ������ ������
            buttonSortAutor.Click += buttonSortAutor_NDV_Click;
            searchMenu.Controls.Add(buttonSortAutor);

            // ������ ��� ������ �� ���� �������
            Button buttonSortYear = new Button();
            buttonSortYear.Text = "����� �� ���� �������";
            buttonSortYear.Dock = DockStyle.Top;
            buttonSortYear.Size = new Size(250, 40); // ������������� ������ ������
            buttonSortYear.Click += buttonSortYear_NDV_Click;
            searchMenu.Controls.Add(buttonSortYear);

            // ���������� ����� ���� ������
            searchMenu.ShowDialog();
        }



        private DataTable dataTableReaders; // ��������� DataTable ��� �������� ������ � ���������

        private void buttonOpenReaders_NDV_Click(object sender, EventArgs e)
        {
            // ���� � ����� � ������� � ���������
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

            // ��������� ������������� �����
            if (!File.Exists(filePath))
            {
                MessageBox.Show("���� � ������� � ��������� �� ������.");
                return;
            }

            // ������� ����� ����� ��� ����������� ������ � ���������
            Form readersForm = new Form();
            readersForm.Text = "������ � ���������";
            readersForm.Size = new System.Drawing.Size(600, 400);

            // ������� DataGridView ��� ����������� ������
            DataGridView dataGridViewReaders = new DataGridView();
            dataGridViewReaders.Dock = DockStyle.Fill;
            readersForm.Controls.Add(dataGridViewReaders);

            // ������� DataTable ��� �������� ������ � ���������
            dataTableReaders = new DataTable();
            dataTableReaders.Columns.Add("���"); // ���� ���� ��� ���
            dataTableReaders.Columns.Add("�������");
            dataTableReaders.Columns.Add("���");

            // ������ ������ �� ����� � ��������� �� � DataTable
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 3)
                        {
                            dataTableReaders.Rows.Add(parts[0], parts[1], parts[2]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������ ����� � ������� � ���������: " + ex.Message);
                return;
            }

            // ���������� ������ � ��������� � DataGridView
            dataGridViewReaders.DataSource = dataTableReaders;

            // ������� ������ ��� ���������� ������ � ����� ��������
            Button addButton = new Button();
            addButton.Text = "�������� ��������";
            addButton.Dock = DockStyle.Bottom;
            addButton.Size = new Size(200, 40);
            addButton.Click += (s, ev) =>
            {
                // ��������� ����� ��� ����� ������ � ����� ��������
                Form addReaderForm = new Form();
                addReaderForm.Text = "���������� ������ ��������";
                addReaderForm.Size = new Size(400, 400); // ����������� ������ �����
                addReaderForm.FormBorderStyle = FormBorderStyle.FixedSingle; // ������������� ������ �����

                // ������� ������� � ������ ����� ������ � ��������
                Label labelFullName = new Label();
                labelFullName.Text = "���:";
                labelFullName.Top = 40;
                labelFullName.Left = 20;
                addReaderForm.Controls.Add(labelFullName);

                TextBox textBoxFullName = new TextBox(); // ���� ��� ���
                textBoxFullName.Top = 70;
                textBoxFullName.Left = 20;
                textBoxFullName.Width = 340; // ������������� ������ ���� ����� �� ������ �����
                addReaderForm.Controls.Add(textBoxFullName);

                Label labelAge = new Label();
                labelAge.Text = "�������:";
                labelAge.Top = 120;
                labelAge.Left = 20;
                addReaderForm.Controls.Add(labelAge);

                TextBox textBoxAge = new TextBox();
                textBoxAge.Top = 150;
                textBoxAge.Left = 20;
                textBoxAge.Width = 340;
                addReaderForm.Controls.Add(textBoxAge);

                Label labelGender = new Label();
                labelGender.Text = "���:";
                labelGender.Top = 200;
                labelGender.Left = 20;
                addReaderForm.Controls.Add(labelGender);

                TextBox textBoxGender = new TextBox();
                textBoxGender.Top = 230;
                textBoxGender.Left = 20;
                textBoxGender.Width = 340;
                addReaderForm.Controls.Add(textBoxGender);

                // ������� ������ "��" ��� ������������� �����
                Button buttonOK = new Button();
                buttonOK.Text = "��������";
                buttonOK.Height = 50;
                buttonOK.Width = 360; // ������������� ������ ������ �� ������ �����
                buttonOK.Top = 300;
                buttonOK.Left = 20; // ����������� ������ �� ������ ����
                buttonOK.Click += (s, ev) =>
                {
                    // ��������� ����� ������ � �������� � DataTable
                    dataTableReaders.Rows.Add(textBoxFullName.Text, textBoxAge.Text, textBoxGender.Text);
                    addReaderForm.Close();
                };
                addReaderForm.Controls.Add(buttonOK);

                // ��������� ������� ��������� ������� �����
                addReaderForm.Resize += (sender, e) =>
                {
                    labelFullName.Left = (addReaderForm.ClientSize.Width - labelFullName.Width) / 2;
                    textBoxFullName.Left = (addReaderForm.ClientSize.Width - textBoxFullName.Width) / 2;
                    labelAge.Left = (addReaderForm.ClientSize.Width - labelAge.Width) / 2;
                    textBoxAge.Left = (addReaderForm.ClientSize.Width - textBoxAge.Width) / 2;
                    labelGender.Left = (addReaderForm.ClientSize.Width - labelGender.Width) / 2;
                    textBoxGender.Left = (addReaderForm.ClientSize.Width - textBoxGender.Width) / 2;
                    buttonOK.Left = (addReaderForm.ClientSize.Width - buttonOK.Width) / 2;
                };

                // ���������� ����� ��� ����� ������ � ����� ��������
                addReaderForm.ShowDialog();
            };

            readersForm.Controls.Add(addButton);

            // ������� ������ ��� �������� ��������� ������ � ��������
            Button deleteButton = new Button();
            deleteButton.Text = "������� ��������";
            deleteButton.Dock = DockStyle.Bottom;
            deleteButton.Size = new Size(200, 40);
            deleteButton.Click += (s, ev) =>
            {
                // ���������, ������� �� �����-���� ������
                if (dataGridViewReaders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("�������� �������� ��� ��������.");
                    return;
                }

                // ����������� ������������� � ������������
                DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ���������� ��������?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // ������� ��������� ������ �� DataTable
                    foreach (DataGridViewRow row in dataGridViewReaders.SelectedRows)
                    {
                        dataTableReaders.Rows.RemoveAt(row.Index);
                    }
                }
            };
            readersForm.Controls.Add(deleteButton);

            // ������� ������ ��� ���������� ������ � ��������� � ����
            Button saveButton = new Button();
            saveButton.Text = "��������� ������";
            saveButton.Dock = DockStyle.Bottom;
            saveButton.Size = new Size(200, 40);
            saveButton.Click += (s, ev) =>
            {
                // ���� ��� ���������� ����� � ������� � ���������
                string saveFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

                // ����� ������ �� DataTable � ����
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFilePath))
                    {
                        foreach (DataRow row in dataTableReaders.Rows)
                        {
                            string line = string.Join(";", row.ItemArray);
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("������ ������� ���������.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ���������� ������: " + ex.Message);
                }
            };
            readersForm.Controls.Add(saveButton);

            readersForm.FormClosed += (sender, e) =>
            {
                LoadReadersToFIOComboBox(); // �������� ������� ��� �������� ��������� � �����-����
            };

            // ���������� ����� � ������� � ���������
            readersForm.ShowDialog();
        }



        private void comboBoxReader_NDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ���������, ������� �� �����-���� �������� � comboBoxReader_NDV
            if (comboBoxReader_NDV.SelectedItem != null)
            {
                // ����������� ��������� �������� ���� comboBoxReader_NDV
                string selectedReader = comboBoxReader_NDV.SelectedItem.ToString();
                // ����� ����������� ��������� �������� � ����� ����
            }
        }


        private void LoadReadersToFIOComboBox()
        {
            // ������� comboBoxReader_NDV ����� ����������� ����� ��������
            comboBoxReader_NDV.Items.Clear();

            // ���� � ����� � ������� � ���������
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

            // ��������� ������������� �����
            if (!File.Exists(filePath))
            {
                MessageBox.Show("���� � ������� � ��������� �� ������.");
                return;
            }

            // ������ ������ �� ����� � ��������� ��� � comboBoxReader_NDV
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 1)
                        {
                            comboBoxReader_NDV.Items.Add(parts[0]); // ��������� ���
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������ ����� � ������� � ���������: " + ex.Message);
                return;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxReader_NDV.DropDownStyle = ComboBoxStyle.DropDownList;

            // ������������� ����� ������ ��� ������, ����� ������������� ��������� �������
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // ������������� Anchor ��� ������� �������� ����������
            buttonAddBook_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonDeleteBook_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            textBoxBookName_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            textBoxBookAutor_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            textBoxYearRelease_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonCountAllBooks_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            labelAutor_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            labelNameBook_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            labelYearRelease_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonBuildGraphs_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            checkBoxInStock_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonSortBooks_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            labelProgramName_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonCancelSearch_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            buttonSearch_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            comboBoxReader_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            labelReader_NDV.Anchor = AnchorStyles.Right | AnchorStyles.Top;


            // ������������� ����� ������� ������
            buttonOpenDB_NDV.Anchor = AnchorStyles.Bottom;
            buttonWriteDB_NDV.Anchor = AnchorStyles.Bottom;
            buttonOpenReaders_NDV.Anchor = AnchorStyles.Bottom;

        }

        private bool firstResize = true; // ����, ����� ����������� ������ ��������� �������

        private void Form1_Resize(object sender, EventArgs e)
        {
            // ���������, ���� �� ��� ������ ��������� �������
            if (firstResize)
            {
                // ���� ��� ������ ��������� �������, ������������� ������ �� ���������
                SetDataGridViewSize();
                firstResize = false; // ������������� ���� � false, ����� ������ �� ��������� ��� ��������
            }
            else
            {
                dataGridViewBooks_NDV.Size = new System.Drawing.Size(762, 467);
            }

        }

        private void SetDataGridViewSize()
        {
            // ������������� ����� ������� ��� dataGridViewBooks_NDV
            dataGridViewBooks_NDV.Size = new System.Drawing.Size(1320, 840);
        }


    }
}
