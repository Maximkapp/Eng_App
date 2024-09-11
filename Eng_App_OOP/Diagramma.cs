using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Eng_App_OOP.Words;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Eng_App_OOP
{
    public partial class Diagramma : Form
    {
        public Diagramma()
        {
            InitializeComponent();
        }

        // Событие, которое вызывается при загрузке формы
        private void Diagramma_Load(object sender, EventArgs e)
        {
            // Укажите путь к вашему JSON файлу
            string filePath = "words.json";

            // Загрузите слова из файла
            List<Word> words = LoadWordsFromFile(filePath);

            // Группировка слов по дате добавления и подсчет количества слов на каждую дату
            var wordsByDate = words
                .GroupBy(word => word.DateAdded)
                .Select(group => new
                {
                    Date = group.Key,  // Дата добавления слов
                    Count = group.Count()  // Количество слов, добавленных в эту дату
                })
                .OrderBy(x => x.Date)  // Сортировка по дате
                .ToList();

            // Настройка диаграммы
            chart1.Series.Clear(); // Очистка существующих серий
            Series series = new Series
            {
                Name = "Количество слов",  // Название серии данных
                Color = Color.Blue,  // Цвет столбцов
                ChartType = SeriesChartType.Column  // Тип диаграммы - столбчатая
            };

            // Добавление серии данных в диаграмму
            chart1.Series.Add(series);

            // Добавление данных в серию
            foreach (var item in wordsByDate)
            {
                // Добавление точки данных (дата и количество слов) в серию
                series.Points.AddXY(item.Date, item.Count);
            }

            // Настройка осей диаграммы
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";  // Формат меток на оси X (месяц-день)
            chart1.ChartAreas[0].AxisX.Interval = 1;  // Интервал между метками на оси X
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;  // Интервал в днях
            chart1.ChartAreas[0].AxisX.Title = "Дата добавления";  // Название оси X
            chart1.ChartAreas[0].AxisY.Title = "Количество слов";  // Название оси Y
        }

        // Событие, которое вызывается при клике на диаграмму
        private void chart1_Click(object sender, EventArgs e)
        {
            // Обработка событий при нажатии на диаграмму (если необходимо)
        }
    }
}
