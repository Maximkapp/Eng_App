using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eng_App_OOP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Переключение на 1 игру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Game_Click(object sender, EventArgs e)
        {
            Form Game1 = new Game1();

            Game1.Show();
        }
        
        
        /// <summary>
        /// Переключение на 2 игру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2Game_Click(object sender, EventArgs e)
        {
            Form Game2 = new Game2();

            Game2.Show();
        }
        /// <summary>
        /// Переключение на 3 игру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3Game_Click(object sender, EventArgs e)
        {
            Form Game3 = new Game3();

            Game3.Show();
        }
        /// <summary>
        /// Переключение на добавление слов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1AddWords_Click(object sender, EventArgs e)
        {
            Form Add_new_word = new Add_new_word();
            
            Add_new_word.Show();
        }
        /// <summary>
        /// Переключение на график.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void diagramma_Click(object sender, EventArgs e)
        {
            Form Diagramma = new Diagramma();
            Diagramma.Show();
        }
        /// <summary>
        /// Переход на инструкцию.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instruction_Click(object sender, EventArgs e)
        {
            Form Instruction = new Instruction();
            Instruction.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}