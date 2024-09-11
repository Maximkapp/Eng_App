using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Eng_App_OOP
{
    public partial class Game1 : Form
    {
        private List<Words.Word> _words; // Список слов
        private int _currentWordIndex = 0; // Индекс текущего слова
        private const string WordsFilePath = "words.json"; // Путь к файлу с JSON данными

        public Game1()
        {
            InitializeComponent();
            LoadWords(); // Загрузка слов из файла
            DisplayCurrentWord(); // Отображение первого слова
        }

        // Метод для загрузки слов из файла
        private void LoadWords()
        {
            _words = Words.LoadWordsFromFile(WordsFilePath); // Загрузка слов из файла JSON
            _words = _words.OrderBy(w => w.EnglishWord).ToList(); // Сортировка слов по алфавиту
        }

        // Метод для отображения текущего слова
        private void DisplayCurrentWord()
        {
            if (_words.Count > 0 && _currentWordIndex < _words.Count)
            {
                txtEnglishWord.Text = _words[_currentWordIndex].EnglishWord; // Отображение английского слова
                txtTranslation.Clear(); // Очистка поля ввода перевода
                lblResult.Text = string.Empty; // Очистка текста результата
            }
            else
            {
                // Сообщение о том, что больше нет слов
                MessageBox.Show("No more words available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Обработчик события нажатия кнопки "Проверить"
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_words.Count > 0 && _currentWordIndex < _words.Count)
            {
                var currentWord = _words[_currentWordIndex]; // Текущее слово
                if (txtTranslation.Text.Trim().Equals(currentWord.Translation, StringComparison.OrdinalIgnoreCase))
                {
                    // Переход к следующему слову только если перевод правильный
                    MessageBox.Show("Correct! The word is spelled correctly.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _currentWordIndex++;
                    DisplayCurrentWord(); // Отображение следующего слова
                }
                else
                {
                    // Сообщение о неправильном переводе и отображение правильного перевода
                    MessageBox.Show($"Incorrect. The correct translation is '{currentWord.Translation}'.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработчик события загрузки формы
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // Обработчик события рисования панели (если необходимо)
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Обработчик события изменения текста английского слова (если необходимо)
        private void txtEnglishWord_TextChanged(object sender, EventArgs e)
        {

        }

        // Обработчик события изменения текста перевода (если необходимо)
        private void txtTranslation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
