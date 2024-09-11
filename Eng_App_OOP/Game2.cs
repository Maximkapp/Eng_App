using Newtonsoft.Json; // Подключаем пространство имен для работы с JSON
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Eng_App_OOP
{
    // Класс формы игры
    public partial class Game2 : Form
    {
        private List<WordData> _words; // Список слов
        private Random _random = new Random(); // Генератор случайных чисел
        private int _currentIndex = -1; // Индекс текущего слова

        // Конструктор класса
        public Game2()
        {
            InitializeComponent(); // Инициализация компонентов формы
            LoadWordsFromJson("words.json"); // Загрузка слов из JSON файла
            DisplayNextWord(); // Отображение первого слова
        }

        // Метод для загрузки слов из JSON файла
        private void LoadWordsFromJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath); // Чтение содержимого файла
                _words = JsonConvert.DeserializeObject<List<WordData>>(json); // Десериализация JSON в список слов
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading words: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Вывод сообщения об ошибке при загрузке слов
            }
        }

        // Метод для отображения следующего слова
        private void DisplayNextWord()
        {
            // Проверка наличия слов в списке
            if (_words != null && _words.Any())
            {
                // Выбор случайного слова из списка
                var selectedWord = _words.OrderBy(w => _random.Next()).FirstOrDefault();
                if (selectedWord != null)
                {
                    // Отображение перевода выбранного слова и слова с пропущенной буквой
                    txtRussianWord.Text = selectedWord.Translation;
                    txtMissingLetter.Text = RemoveRandomLetter(selectedWord.EnglishWord);
                    _currentIndex = _words.IndexOf(selectedWord); // Сохранение индекса текущего слова
                }
            }
            else
            {
                MessageBox.Show("No words available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Вывод сообщения о том, что слова отсутствуют
            }
        }

        // Метод для удаления случайной буквы из слова
        private string RemoveRandomLetter(string word)
        {
            int indexToRemove = _random.Next(0, word.Length); // Генерация случайного индекса для удаления буквы
            return word.Remove(indexToRemove, 1).Insert(indexToRemove, "_"); // Удаление буквы и вставка символа подчеркивания на ее место
        }

        // Обработчик нажатия кнопки "Check"
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_currentIndex != -1)
            {
                var currentWord = _words[_currentIndex]; // Получение текущего слова из списка
                string userAnswer = txtMissingLetter.Text.Trim(); // Получение ответа пользователя
                // Проверка правильности ответа
                if (userAnswer.Equals(currentWord.EnglishWord, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Correct!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // Вывод сообщения о правильном ответе
                    DisplayNextWord(); // Отображение следующего слова
                }
                else
                {
                    MessageBox.Show("Incorrect. Try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error); // Вывод сообщения о неправильном ответе
                }
            }
        }

        // Обработчик события загрузки формы
        private void Game2_Load(object sender, EventArgs e)
        {
            // Дополнительные действия при загрузке формы (если не требуются, можно оставить пустым)
        }

        // Обработчик события рисования панели (если используется панель)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Дополнительные действия при рисовании панели (если не требуются, можно оставить пустым)
        }

        // Обработчик изменения текста в поле с русским словом
        private void txtRussianWord_TextChanged(object sender, EventArgs e)
        {
            txtRussianWord.ReadOnly = true; // Установка свойства только для чтения, чтобы пользователь не мог изменять текст
        }

        // Обработчик изменения текста в поле с пропущенной буквой
        private void txtMissingLetter_TextChanged(object sender, EventArgs e)
        {
            // Дополнительные действия при изменении текста в поле (если не требуются, можно оставить пустым)
        }
    }

    // Класс для хранения данных слова
    public class WordData
    {
        public string EnglishWord { get; set; } // Английское слово
        public string Translation { get; set; } // Перевод на русский язык
    }
}
