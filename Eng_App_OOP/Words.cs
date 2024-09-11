using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Eng_App_OOP
{
    internal class Words
    {
        // Класс для хранения слов
        public class Word
        {
            public string EnglishWord { get; set; } // Английское слово
            public string Translation { get; set; } // Перевод слова
            public DateTime DateAdded { get; set; } // Дата добавления слова

            // Конструктор для инициализации слова и его перевода
            public Word(string englishWord, string translation)
            {
                EnglishWord = englishWord;
                Translation = translation;
                DateAdded = DateTime.Now.Date; // Сохранение только даты
            }
        }

        // Метод для загрузки слов из файла
        public static List<Word> LoadWordsFromFile(string filePath)
        {
            // Проверка, существует ли файл
            if (!File.Exists(filePath))
            {
                return new List<Word>(); // Возвращаем пустой список, если файл не найден
            }

            // Чтение содержимого файла JSON
            string json = File.ReadAllText(filePath);
            // Десериализация JSON строки в список слов
            return JsonConvert.DeserializeObject<List<Word>>(json);
        }

        // Метод для сохранения слов в файл
        public static void SaveWordsToFile(List<Word> words, string filePath)
        {
            // Сериализация списка слов в JSON строку
            string json = JsonConvert.SerializeObject(words, Formatting.Indented);
            // Запись JSON строки в файл
            File.WriteAllText(filePath, json);
        }
    }
}
