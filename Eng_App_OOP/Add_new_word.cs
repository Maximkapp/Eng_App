using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eng_App_OOP.Words;
using System.IO;
using Newtonsoft.Json;

namespace Eng_App_OOP
{
    public partial class Add_new_word : Form
    {
        private List<Words.Word> wordList = new List<Words.Word>();
        public Add_new_word()
        {
            InitializeComponent();
            Enter_new_word.Text = "Анг. слово";
            Enter_new_word.ForeColor = Color.Gray;
            Enter_transl.Text = "Перевод";
            Enter_transl.ForeColor = Color.Gray;

        }

        private void Add_new_word_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Поле ввод слова
        /// <summary>
        /// Окно ввода анг. слова.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_new_word_TextChanged(object sender, EventArgs e)
        {

        }


        private void Enter_new_word_Enter(object sender, EventArgs e)
        {
            if (Enter_new_word.Text == "Анг. слово")
            {
                Enter_new_word.Text = "";
                Enter_new_word.ForeColor = Color.Black;
            }

        }

        private void Enter_new_word_Leave(object sender, EventArgs e)
        {
            if (Enter_new_word.Text == "")
            {
                Enter_new_word.Text = "Анг. слово";
                Enter_new_word.ForeColor = Color.Gray;
            }

        }
        #endregion


        #region Поле ввода перевода
        /// <summary>
        /// Поле ввода перевода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_transl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_transl_Enter(object sender, EventArgs e)
        {
            if (Enter_transl.Text == "Перевод")
            {
                Enter_transl.Text = "";
                Enter_transl.ForeColor = Color.Black;
            }
        }

        private void Enter_transl_Leave(object sender, EventArgs e)
        {
            if (Enter_transl.Text == "")
            {
                Enter_transl.Text = "Перевод";
                Enter_transl.ForeColor = Color.Gray;
            }
        }
        #endregion

        /// <summary>
        /// Создание нового слова и запись в JSON файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAll_Click(object sender, EventArgs e)
        {
            string englishWord = Enter_new_word.Text.ToLower();
            string translation = Enter_transl.Text.ToLower();

            // Получаем текущую дату без времени
            DateTime currentDate = DateTime.Now.Date;

            // Сначала пытаемся прочитать данные из файла
            List<Word> wordList = new List<Word>();
            if (File.Exists("words.json"))
            {
                string json = File.ReadAllText("words.json");
                wordList = JsonConvert.DeserializeObject<List<Word>>(json);
            }

            if (!string.IsNullOrEmpty(englishWord) && !string.IsNullOrEmpty(translation))
            {
                // Проверяем, есть ли слово уже в списке
                if (wordList != null && wordList.Any(w => w.EnglishWord == englishWord))
                {
                    MessageBox.Show("Такое слово уже есть!");
                }
                else
                {
                    // Создаем новый объект Word с указанием даты добавления
                    Word newWord = new Word(englishWord, translation);
                    wordList.Add(newWord);

                    // После добавления нового слова, сохраняем все данные в файл
                    string updatedJson = JsonConvert.SerializeObject(wordList, Formatting.Indented);
                    File.WriteAllText("words.json", updatedJson);

                    MessageBox.Show("Новое слово добавлено!");
                    Enter_transl.Text = "";
                    Enter_new_word.Text = "";
                }
            }
        }

    }
}



