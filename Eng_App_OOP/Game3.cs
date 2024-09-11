using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Eng_App_OOP
{
    public partial class Game3 : Form
    {
        private List<WordPair> wordPairs; // Список всех пар слов (английское слово и его перевод)
        private List<WordPair> currentWordPairs; // Список текущих пар слов, отображаемых в таблице
        private TableLayoutPanel tableLayoutPanel; // Таблица для отображения английских слов и пустых ячеек для переводов
        private FlowLayoutPanel russianWordsPanel; // Панель для отображения слов на русском языке для перетаскивания
        private Random random; // Объект для генерации случайных чисел

        public Game3()
        {
            InitializeComponent();
            random = new Random();
            LoadWords(); // Загрузка слов из JSON файла
            InitializeGame(); // Инициализация элементов управления
            LoadRandomWords(); // Загрузка случайных слов для игры
        }

        private void LoadWords()
        {
            string jsonFilePath = "words.json";
            if (File.Exists(jsonFilePath))
            {
                // Чтение JSON файла и десериализация в список пар слов
                string json = File.ReadAllText(jsonFilePath);
                wordPairs = JsonConvert.DeserializeObject<List<WordPair>>(json);
            }
            else
            {
                MessageBox.Show("Файл с словами не найден!");
            }
        }

        private void InitializeGame()
        {
            // Создание и настройка TableLayoutPanel для отображения слов
            tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 2,
                Dock = DockStyle.Top,
                AutoSize = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            this.Controls.Add(tableLayoutPanel);

            // Создание панели для отображения слов на русском языке, которые можно перетаскивать
            russianWordsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                AutoSize = true
            };
            this.Controls.Add(russianWordsPanel);

            // Создание и добавление кнопки проверки
            checkButton = new Button
            {
                Text = "Проверить",
                Dock = DockStyle.Bottom
            };
            checkButton.Click += new EventHandler(CheckButton_Click);
            this.Controls.Add(checkButton);
        }

        private void LoadRandomWords()
        {
            // Очистка предыдущего содержимого таблицы и панели
            tableLayoutPanel.Controls.Clear();
            russianWordsPanel.Controls.Clear();

            if (wordPairs.Count < 3)
            {
                MessageBox.Show("Недостаточно слов для игры!");
                return;
            }

            // Выбор случайных трех слов для текущей игры
            currentWordPairs = wordPairs.OrderBy(x => random.Next()).Take(3).ToList();

            // Добавление английских слов в первый столбец таблицы
            for (int i = 0; i < currentWordPairs.Count; i++)
            {
                var englishLabel = new Label
                {
                    Text = currentWordPairs[i].EnglishWord,
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                };
                tableLayoutPanel.Controls.Add(englishLabel, 0, i);

                var emptyPanel = new Panel
                {
                    AllowDrop = true,
                    BorderStyle = BorderStyle.FixedSingle
                };
                emptyPanel.DragEnter += new DragEventHandler(Panel_DragEnter);
                emptyPanel.DragDrop += new DragEventHandler(Panel_DragDrop);
                tableLayoutPanel.Controls.Add(emptyPanel, 1, i);
            }

            // Добавление слов на русском языке в панель для перетаскивания
            foreach (var wordPair in currentWordPairs)
            {
                var russianLabel = new Label
                {
                    Text = wordPair.Translation,
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5)
                };
                russianLabel.MouseDown += new MouseEventHandler(Label_MouseDown);
                russianWordsPanel.Controls.Add(russianLabel);
            }
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            // Начало перетаскивания слова на русском языке
            Label label = sender as Label;
            if (label != null)
            {
                DoDragDrop(label, DragDropEffects.Move);
            }
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            // Проверка типа данных при перетаскивании
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            // Обработка события перетаскивания и размещения слова
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                Label label = (Label)e.Data.GetData(typeof(Label));
                Panel panel = sender as Panel;
                if (panel != null && label != null)
                {
                    panel.Controls.Clear();
                    label.Parent = panel;
                    label.Location = new System.Drawing.Point(0, 0);
                }
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            List<string> incorrectWords = new List<string>();

            // Проверка правильности размещения слов
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                var panel = tableLayoutPanel.GetControlFromPosition(1, i) as Panel;
                if (panel != null && panel.Controls.Count > 0)
                {
                    var label = panel.Controls[0] as Label;
                    if (label != null)
                    {
                        var englishWord = tableLayoutPanel.GetControlFromPosition(0, i) as Label;
                        if (englishWord != null)
                        {
                            var wordPair = currentWordPairs.FirstOrDefault(wp => wp.EnglishWord == englishWord.Text);
                            if (wordPair != null && wordPair.Translation != label.Text)
                            {
                                incorrectWords.Add($"{englishWord.Text} - {label.Text}");
                            }
                        }
                    }
                }
                else
                {
                    var englishWord = tableLayoutPanel.GetControlFromPosition(0, i) as Label;
                    if (englishWord != null)
                    {
                        incorrectWords.Add($"{englishWord.Text} - (пусто)");
                    }
                }
            }

            // Показ результатов проверки
            if (incorrectWords.Count > 0)
            {
                string message = "Неправильно расставлены слова:\n" + string.Join("\n", incorrectWords);
                MessageBox.Show(message, "Результат проверки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Все слова расставлены правильно!", "Результат проверки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadRandomWords(); // Загрузка новых слов после проверки
        }

        private void Game3_Load(object sender, EventArgs e)
        {
            // Обработчик события загрузки формы (пустой в данном случае)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Обработчик события рисования панели (пустой в данном случае)
        }
    }

    public class WordPair
    {
        public string EnglishWord { get; set; } // Английское слово
        public string Translation { get; set; } // Перевод на русский
    }
}
