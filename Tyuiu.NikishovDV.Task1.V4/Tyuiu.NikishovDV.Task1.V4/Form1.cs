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
            // Получаем DataTable из источника данных dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Ошибка: DataTable не инициализирован.");
                return;
            }

            // Получаем данные о новой книге из текстовых полей
            string bookName = textBoxBookName_NDV.Text;
            string bookAuthor = textBoxBookAutor_NDV.Text;
            string yearRelease = textBoxYearRelease_NDV.Text;
            bool inStock = checkBoxInStock_NDV.Checked; // Используем свойство Checked чекбокса

            // Получаем выбранное значение из comboBoxReader_NDV
            string selectedReader = comboBoxReader_NDV.SelectedItem?.ToString();

            // Добавляем новую строку в DataTable
            dataTable.Rows.Add(bookName, bookAuthor, yearRelease, inStock, selectedReader);

            // Очищаем текстовые поля после добавления книги
            textBoxBookName_NDV.Clear();
            textBoxBookAutor_NDV.Clear();
            textBoxYearRelease_NDV.Clear();
            checkBoxInStock_NDV.Checked = false; // Сбрасываем значение чекбокса
        }



        private void buttonDeleteBook_NDV_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли какая-либо строка
            if (dataGridViewBooks_NDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите книгу для удаления.");
                return;
            }

            // Запрашиваем подтверждение у пользователя
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную книгу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Удаляем выбранную строку из DataTable
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

            // Путь к файлу с данными о книгах
            string bookFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.txt");

            // Проверка существования файла
            if (!File.Exists(bookFilePath))
            {
                MessageBox.Show("Файл с данными о книгах не найден.");
                return;
            }

            // Создаем DataTable для книг
            DataTable bookDataTable = new DataTable();
            bookDataTable.Columns.Add("Название Книги");
            bookDataTable.Columns.Add("Автор");
            bookDataTable.Columns.Add("Год издания");
            bookDataTable.Columns.Add("В наличии", typeof(bool));
            bookDataTable.Columns.Add("Читатель");

            // Чтение данных о книгах из файла и загрузка их в DataTable
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
                MessageBox.Show("Ошибка чтения файла с данными о книгах: " + ex.Message);
                return;
            }

            // Обновление DataGridView
            dataGridViewBooks_NDV.DataSource = bookDataTable;
        }




        private void buttonWriteDB_NDV_Click(object sender, EventArgs e)
        {
            // Путь к файлу с данными
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.txt");

            // Получаем DataTable из источника данных dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Нет данных для записи.");
                return;
            }

            // Пишем данные из DataTable в файл
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
                MessageBox.Show("Данные успешно записаны в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи файла: " + ex.Message);
            }
        }

        private void buttonCountAllBooks_NDV_Click(object sender, EventArgs e)
        {
            // Получаем DataTable из источника данных dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Ошибка: DataTable не инициализирован.");
                return;
            }

            // Переменные для подсчета количества книг
            int totalCount = 0;
            int inStockCount = 0;
            int notInStockCount = 0;

            // Проходим по каждой строке в DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Увеличиваем общее количество книг
                totalCount++;

                // Проверяем значение столбца "В наличии"
                bool inStock = (bool)row["В наличии"];
                if (inStock)
                {
                    // Если книга в наличии, увеличиваем счетчик книг в наличии
                    inStockCount++;
                }
                else
                {
                    // Если книги нет в наличии, увеличиваем счетчик книг, которых нет в наличии
                    notInStockCount++;
                }
            }

            // Выводим сообщение с подсчитанными значениями
            MessageBox.Show($"Общее количество книг в базе данных: {totalCount}\nКоличество книг в наличии: {inStockCount}\nКоличество книг, которых нет в наличии: {notInStockCount}");
        }

        private void buttonBuildGraphs_NDV_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр графика для столбчатой диаграммы
            Chart columnChart = new Chart();
            columnChart.Dock = DockStyle.Fill;
            columnChart.ChartAreas.Add(new ChartArea("MainArea"));
            columnChart.Series.Add(new Series("BooksByYear"));

            // Устанавливаем тип графика (столбчатая диаграмма)
            columnChart.Series["BooksByYear"].ChartType = SeriesChartType.Column;

            // Получаем DataTable из источника данных dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Ошибка: DataTable не инициализирован.");
                return;
            }

            // Группируем книги по годам издания и считаем количество книг в каждой группе для столбчатой диаграммы
            var booksByYear = from row in dataTable.AsEnumerable()
                              group row by row.Field<string>("Год издания") into g
                              select new
                              {
                                  Year = g.Key,
                                  Count = g.Count()
                              };

            // Добавляем точки на столбчатую диаграмму
            foreach (var book in booksByYear)
            {
                columnChart.Series["BooksByYear"].Points.AddXY(book.Year, book.Count);
            }

            // Создаем форму для отображения графика
            Form chartForm = new Form();
            chartForm.Text = "График количества книг по году издания";
            chartForm.Controls.Add(columnChart);
            chartForm.Size = new System.Drawing.Size(520, 380);
            chartForm.Resize += (s, ev) =>
            {
                // Обновляем размер и позицию графика при изменении размера формы
                columnChart.Size = new Size(chartForm.ClientSize.Width - 20, chartForm.ClientSize.Height - 20);
                columnChart.Location = new Point(10, 10);
            };

            // Показываем график в новом окне
            chartForm.ShowDialog();
        }



        private void buttonSortBooks_NDV_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для выбора столбца сортировки
            Form sortDialog = new Form();
            sortDialog.Text = "Выберите столбец сортировки";
            sortDialog.Size = new System.Drawing.Size(400, 250);

            // Добавляем кнопки для выбора столбца сортировки
            Button buttonSortByName = new Button();
            buttonSortByName.Text = "По названию";
            buttonSortByName.Size = new System.Drawing.Size(70, 50);
            buttonSortByName.Dock = DockStyle.Top;
            buttonSortByName.Click += (s, ev) =>
            {
                SortBooks("Название Книги");
                sortDialog.Close();
            };

            Button buttonSortByAuthor = new Button();
            buttonSortByAuthor.Text = "По автору";
            buttonSortByAuthor.Size = new System.Drawing.Size(70, 50);
            buttonSortByAuthor.Dock = DockStyle.Top;
            buttonSortByAuthor.Click += (s, ev) =>
            {
                SortBooks("Автор");
                sortDialog.Close();
            };

            Button buttonSortByYear = new Button();
            buttonSortByYear.Text = "По году издания";
            buttonSortByYear.Size = new System.Drawing.Size(70, 50);
            buttonSortByYear.Dock = DockStyle.Top;
            buttonSortByYear.Click += (s, ev) =>
            {
                SortBooks("Год издания");
                sortDialog.Close();
            };

            Button buttonSortByStock = new Button();
            buttonSortByStock.Text = "По наличию";
            buttonSortByStock.Size = new System.Drawing.Size(70, 50);
            buttonSortByStock.Dock = DockStyle.Top;
            buttonSortByStock.Click += (s, ev) =>
            {
                SortBooks("В наличии");
                sortDialog.Close();
            };

            // Добавляем кнопки на форму
            sortDialog.Controls.Add(buttonSortByStock);
            sortDialog.Controls.Add(buttonSortByYear);
            sortDialog.Controls.Add(buttonSortByAuthor);
            sortDialog.Controls.Add(buttonSortByName);

            // Отображаем диалоговое окно
            sortDialog.ShowDialog();
        }

        // Метод для сортировки книг по выбранному столбцу
        private void SortBooks(string columnName)
        {
            // Получаем DataTable из источника данных dataGridViewBooks_NDV
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Ошибка: DataTable не инициализирован.");
                return;
            }

            // Проверяем, если сортировка по названию или по автору, то используем кастомный компаратор
            if (columnName == "Название Книги" || columnName == "Автор")
            {
                dataTable.DefaultView.Sort = columnName;
            }
            else
            {
                // Сортируем книги по выбранному столбцу
                DataView dv = dataTable.DefaultView;
                dv.Sort = columnName;
                dataTable = dv.ToTable();
            }

            // Обновляем источник данных в DataGridView
            dataGridViewBooks_NDV.DataSource = dataTable;
        }

        private void buttonSortAutor_NDV_Click(object sender, EventArgs e)
        {
            // Создаем форму для ввода текста
            Form inputForm = new Form();
            inputForm.Text = "Введите автора";
            inputForm.Size = new System.Drawing.Size(400, 220);

            // Добавляем текстовое поле для ввода автора с отступом сверху
            TextBox textBoxAuthor = new TextBox();
            textBoxAuthor.Dock = DockStyle.Top;
            textBoxAuthor.Multiline = false;
            textBoxAuthor.Width = 280;
            textBoxAuthor.Height = 90;
            textBoxAuthor.Top = 10;
            inputForm.Controls.Add(textBoxAuthor);

            // Добавляем кнопку "ОК" для подтверждения ввода
            Button buttonOK = new Button();
            buttonOK.Text = "Найти";
            buttonOK.Width = 100;
            buttonOK.Height = 40;
            buttonOK.Top = textBoxAuthor.Bottom + 10;
            buttonOK.Left = (inputForm.ClientSize.Width - buttonOK.Width) / 2;
            inputForm.Controls.Add(buttonOK);

            // Добавляем обработчик события нажатия на кнопку "ОК"
            buttonOK.Click += (s, ev) =>
            {
                // Получаем введенный текст
                string author = textBoxAuthor.Text.Trim();

                // Проверяем, не пустое ли поле ввода
                if (string.IsNullOrWhiteSpace(author))
                {
                    MessageBox.Show("Введите автора!");
                    return;
                }

                // Фильтруем строки в DataGridView по автору
                DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
                if (dataTable != null)
                {
                    // Создаем выражение фильтрации для точного совпадения
                    string filterExpression = $"Автор = '{author}'";

                    // Применяем фильтр
                    dataTable.DefaultView.RowFilter = filterExpression;

                    // Проверяем, есть ли записи после фильтрации
                    if (dataTable.DefaultView.Count == 0)
                    {
                        MessageBox.Show("Не найдено!");
                    }
                }

                // Закрываем форму для ввода
                inputForm.Close();
            };

            // Отображаем форму для ввода
            inputForm.ShowDialog();
        }

        private void buttonSortYear_NDV_Click(object sender, EventArgs e)
        {
            // Создаем форму для ввода текста
            Form inputForm = new Form();
            inputForm.Text = "Введите год издания";
            inputForm.Size = new System.Drawing.Size(400, 220);

            // Добавляем текстовое поле для ввода года издания с отступом сверху
            TextBox textBoxYear = new TextBox();
            textBoxYear.Dock = DockStyle.Top;
            textBoxYear.Multiline = false;
            textBoxYear.Width = 280;
            textBoxYear.Height = 90;
            textBoxYear.Margin = new Padding(10, 30, 10, 10); // Устанавливаем отступы сверху, справа, снизу и слева
            inputForm.Controls.Add(textBoxYear);

            // Добавляем кнопку "ОК" для подтверждения ввода
            Button buttonOK = new Button();
            buttonOK.Text = "Найти";
            buttonOK.Width = 100;
            buttonOK.Height = 40;
            buttonOK.Margin = new Padding(10);
            buttonOK.Top = textBoxYear.Bottom + 10;
            buttonOK.Left = (inputForm.ClientSize.Width - buttonOK.Width) / 2;
            inputForm.Controls.Add(buttonOK);

            // Добавляем обработчик события нажатия на кнопку "ОК"
            buttonOK.Click += (s, ev) =>
            {
                // Получаем введенный год издания
                string year = textBoxYear.Text.Trim();

                // Проверяем, не пустое ли поле ввода
                if (string.IsNullOrWhiteSpace(year))
                {
                    MessageBox.Show("Введите год издания!");
                    return;
                }

                // Фильтруем строки в DataGridView по году издания
                DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
                if (dataTable != null)
                {
                    // Создаем выражение фильтрации для точного совпадения
                    string filterExpression = $"[Год издания] = '{year}'";

                    // Применяем фильтр
                    dataTable.DefaultView.RowFilter = filterExpression;

                    // Проверяем, есть ли записи после фильтрации
                    if (dataTable.DefaultView.Count == 0)
                    {
                        MessageBox.Show("Не найдено!");
                    }
                }

                // Закрываем форму для ввода
                inputForm.Close();
            };

            // Отображаем форму для ввода
            inputForm.ShowDialog();
        }

        private void buttonCancelSearch_NDV_Click(object sender, EventArgs e)
        {
            // Очищаем фильтр
            DataTable dataTable = dataGridViewBooks_NDV.DataSource as DataTable;
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Форма загружена!");
            // Другие операции, которые вы хотите выполнить при загрузке формы
        }




        private void buttonSearch_NDV_Click(object sender, EventArgs e)
        {
            // Создаем форму для меню поиска
            Form searchMenu = new Form();
            searchMenu.Text = "Выберите тип поиска";
            searchMenu.Size = new Size(300, 200);

            // Кнопка для поиска по автору
            Button buttonSortAutor = new Button();
            buttonSortAutor.Text = "Поиск по автору";
            buttonSortAutor.Dock = DockStyle.Top;
            buttonSortAutor.Size = new Size(250, 40); // Устанавливаем размер кнопки
            buttonSortAutor.Click += buttonSortAutor_NDV_Click;
            searchMenu.Controls.Add(buttonSortAutor);

            // Кнопка для поиска по году издания
            Button buttonSortYear = new Button();
            buttonSortYear.Text = "Поиск по году издания";
            buttonSortYear.Dock = DockStyle.Top;
            buttonSortYear.Size = new Size(250, 40); // Устанавливаем размер кнопки
            buttonSortYear.Click += buttonSortYear_NDV_Click;
            searchMenu.Controls.Add(buttonSortYear);

            // Отображаем форму меню поиска
            searchMenu.ShowDialog();
        }



        private DataTable dataTableReaders; // Объявляем DataTable для хранения данных о читателях

        private void buttonOpenReaders_NDV_Click(object sender, EventArgs e)
        {
            // Путь к файлу с данными о читателях
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с данными о читателях не найден.");
                return;
            }

            // Создаем новую форму для отображения данных о читателях
            Form readersForm = new Form();
            readersForm.Text = "Данные о читателях";
            readersForm.Size = new System.Drawing.Size(600, 400);

            // Создаем DataGridView для отображения данных
            DataGridView dataGridViewReaders = new DataGridView();
            dataGridViewReaders.Dock = DockStyle.Fill;
            readersForm.Controls.Add(dataGridViewReaders);

            // Создаем DataTable для хранения данных о читателях
            dataTableReaders = new DataTable();
            dataTableReaders.Columns.Add("ФИО"); // Одно поле для ФИО
            dataTableReaders.Columns.Add("Возраст");
            dataTableReaders.Columns.Add("Пол");

            // Читаем данные из файла и загружаем их в DataTable
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
                MessageBox.Show("Ошибка чтения файла с данными о читателях: " + ex.Message);
                return;
            }

            // Отображаем данные о читателях в DataGridView
            dataGridViewReaders.DataSource = dataTableReaders;

            // Создаем кнопку для добавления записи о новом читателе
            Button addButton = new Button();
            addButton.Text = "Добавить читателя";
            addButton.Dock = DockStyle.Bottom;
            addButton.Size = new Size(200, 40);
            addButton.Click += (s, ev) =>
            {
                // Открываем форму для ввода данных о новом читателе
                Form addReaderForm = new Form();
                addReaderForm.Text = "Добавление нового читателя";
                addReaderForm.Size = new Size(400, 400); // Увеличиваем размер формы
                addReaderForm.FormBorderStyle = FormBorderStyle.FixedSingle; // Зафиксировать размер формы

                // Создаем надписи с полями ввода данных о читателе
                Label labelFullName = new Label();
                labelFullName.Text = "ФИО:";
                labelFullName.Top = 40;
                labelFullName.Left = 20;
                addReaderForm.Controls.Add(labelFullName);

                TextBox textBoxFullName = new TextBox(); // Поле для ФИО
                textBoxFullName.Top = 70;
                textBoxFullName.Left = 20;
                textBoxFullName.Width = 340; // Устанавливаем ширину поля ввода по ширине формы
                addReaderForm.Controls.Add(textBoxFullName);

                Label labelAge = new Label();
                labelAge.Text = "Возраст:";
                labelAge.Top = 120;
                labelAge.Left = 20;
                addReaderForm.Controls.Add(labelAge);

                TextBox textBoxAge = new TextBox();
                textBoxAge.Top = 150;
                textBoxAge.Left = 20;
                textBoxAge.Width = 340;
                addReaderForm.Controls.Add(textBoxAge);

                Label labelGender = new Label();
                labelGender.Text = "Пол:";
                labelGender.Top = 200;
                labelGender.Left = 20;
                addReaderForm.Controls.Add(labelGender);

                TextBox textBoxGender = new TextBox();
                textBoxGender.Top = 230;
                textBoxGender.Left = 20;
                textBoxGender.Width = 340;
                addReaderForm.Controls.Add(textBoxGender);

                // Создаем кнопку "ОК" для подтверждения ввода
                Button buttonOK = new Button();
                buttonOK.Text = "Добавить";
                buttonOK.Height = 50;
                buttonOK.Width = 360; // Устанавливаем ширину кнопки по ширине формы
                buttonOK.Top = 300;
                buttonOK.Left = 20; // Выравниваем кнопку по левому краю
                buttonOK.Click += (s, ev) =>
                {
                    // Добавляем новую запись о читателе в DataTable
                    dataTableReaders.Rows.Add(textBoxFullName.Text, textBoxAge.Text, textBoxGender.Text);
                    addReaderForm.Close();
                };
                addReaderForm.Controls.Add(buttonOK);

                // Обработка события изменения размера формы
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

                // Отображаем форму для ввода данных о новом читателе
                addReaderForm.ShowDialog();
            };

            readersForm.Controls.Add(addButton);

            // Создаем кнопку для удаления выбранной записи о читателе
            Button deleteButton = new Button();
            deleteButton.Text = "Удалить читателя";
            deleteButton.Dock = DockStyle.Bottom;
            deleteButton.Size = new Size(200, 40);
            deleteButton.Click += (s, ev) =>
            {
                // Проверяем, выбрана ли какая-либо строка
                if (dataGridViewReaders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите читателя для удаления.");
                    return;
                }

                // Запрашиваем подтверждение у пользователя
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранного читателя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Удаляем выбранную строку из DataTable
                    foreach (DataGridViewRow row in dataGridViewReaders.SelectedRows)
                    {
                        dataTableReaders.Rows.RemoveAt(row.Index);
                    }
                }
            };
            readersForm.Controls.Add(deleteButton);

            // Создаем кнопку для сохранения данных о читателях в файл
            Button saveButton = new Button();
            saveButton.Text = "Сохранить данные";
            saveButton.Dock = DockStyle.Bottom;
            saveButton.Size = new Size(200, 40);
            saveButton.Click += (s, ev) =>
            {
                // Путь для сохранения файла с данными о читателях
                string saveFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

                // Пишем данные из DataTable в файл
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
                    MessageBox.Show("Данные успешно сохранены.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
                }
            };
            readersForm.Controls.Add(saveButton);

            readersForm.FormClosed += (sender, e) =>
            {
                LoadReadersToFIOComboBox(); // Вызываем функцию для загрузки читателей в комбо-бокс
            };

            // Отображаем форму с данными о читателях
            readersForm.ShowDialog();
        }



        private void comboBoxReader_NDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбрано ли какое-либо значение в comboBoxReader_NDV
            if (comboBoxReader_NDV.SelectedItem != null)
            {
                // Присваиваем выбранное значение полю comboBoxReader_NDV
                string selectedReader = comboBoxReader_NDV.SelectedItem.ToString();
                // Далее используйте выбранное значение в вашем коде
            }
        }


        private void LoadReadersToFIOComboBox()
        {
            // Очищаем comboBoxReader_NDV перед добавлением новых значений
            comboBoxReader_NDV.Items.Clear();

            // Путь к файлу с данными о читателях
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Readers.txt");

            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с данными о читателях не найден.");
                return;
            }

            // Читаем данные из файла и добавляем ФИО в comboBoxReader_NDV
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
                            comboBoxReader_NDV.Items.Add(parts[0]); // Добавляем ФИО
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла с данными о читателях: " + ex.Message);
                return;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxReader_NDV.DropDownStyle = ComboBoxStyle.DropDownList;

            // Устанавливаем форму только для чтения, чтобы предотвратить изменение размера
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Устанавливаем Anchor для каждого элемента управления
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


            // Устанавливаем новую позицию кнопок
            buttonOpenDB_NDV.Anchor = AnchorStyles.Bottom;
            buttonWriteDB_NDV.Anchor = AnchorStyles.Bottom;
            buttonOpenReaders_NDV.Anchor = AnchorStyles.Bottom;

        }

        private bool firstResize = true; // Флаг, чтобы отслеживать первое изменение размера

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Проверяем, было ли это первое изменение размера
            if (firstResize)
            {
                // Если это первое изменение размера, устанавливаем размер по умолчанию
                SetDataGridViewSize();
                firstResize = false; // Устанавливаем флаг в false, чтобы больше не выполнять это действие
            }
            else
            {
                dataGridViewBooks_NDV.Size = new System.Drawing.Size(762, 467);
            }

        }

        private void SetDataGridViewSize()
        {
            // Устанавливаем новые размеры для dataGridViewBooks_NDV
            dataGridViewBooks_NDV.Size = new System.Drawing.Size(1320, 840);
        }


    }
}
