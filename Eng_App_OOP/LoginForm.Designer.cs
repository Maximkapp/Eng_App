using System;

namespace Eng_App_OOP
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.instruction = new System.Windows.Forms.Button();
            this.diagramma = new System.Windows.Forms.Button();
            this.button1AddWords = new System.Windows.Forms.Button();
            this.button3Game = new System.Windows.Forms.Button();
            this.button2Game = new System.Windows.Forms.Button();
            this.button1Game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Eng_App_OOP.Properties.Resources.british;
            this.panel1.Controls.Add(this.instruction);
            this.panel1.Controls.Add(this.diagramma);
            this.panel1.Controls.Add(this.button1AddWords);
            this.panel1.Controls.Add(this.button3Game);
            this.panel1.Controls.Add(this.button2Game);
            this.panel1.Controls.Add(this.button1Game);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 361);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // instruction
            // 
            this.instruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instruction.Location = new System.Drawing.Point(530, 98);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(40, 50);
            this.instruction.TabIndex = 6;
            this.instruction.Text = "?";
            this.instruction.UseVisualStyleBackColor = true;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // diagramma
            // 
            this.diagramma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diagramma.Location = new System.Drawing.Point(12, 260);
            this.diagramma.Name = "diagramma";
            this.diagramma.Size = new System.Drawing.Size(108, 75);
            this.diagramma.TabIndex = 5;
            this.diagramma.Text = "График";
            this.diagramma.UseVisualStyleBackColor = true;
            this.diagramma.Click += new System.EventHandler(this.diagramma_Click);
            // 
            // button1AddWords
            // 
            this.button1AddWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1AddWords.Location = new System.Drawing.Point(462, 260);
            this.button1AddWords.Name = "button1AddWords";
            this.button1AddWords.Size = new System.Drawing.Size(108, 75);
            this.button1AddWords.TabIndex = 4;
            this.button1AddWords.Text = "Добавить слова";
            this.button1AddWords.UseVisualStyleBackColor = true;
            this.button1AddWords.Click += new System.EventHandler(this.button1AddWords_Click);
            // 
            // button3Game
            // 
            this.button3Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3Game.Location = new System.Drawing.Point(219, 242);
            this.button3Game.Name = "button3Game";
            this.button3Game.Size = new System.Drawing.Size(131, 38);
            this.button3Game.TabIndex = 3;
            this.button3Game.Text = "Сопоставь слова";
            this.button3Game.UseVisualStyleBackColor = true;
            this.button3Game.Click += new System.EventHandler(this.button3Game_Click);
            // 
            // button2Game
            // 
            this.button2Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2Game.Location = new System.Drawing.Point(219, 167);
            this.button2Game.Name = "button2Game";
            this.button2Game.Size = new System.Drawing.Size(131, 42);
            this.button2Game.TabIndex = 2;
            this.button2Game.Text = "Напиши слово";
            this.button2Game.UseVisualStyleBackColor = true;
            this.button2Game.Click += new System.EventHandler(this.button2Game_Click);
            // 
            // button1Game
            // 
            this.button1Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Game.Location = new System.Drawing.Point(219, 98);
            this.button1Game.Name = "button1Game";
            this.button1Game.Size = new System.Drawing.Size(131, 44);
            this.button1Game.TabIndex = 1;
            this.button1Game.Text = "Переведи слово";
            this.button1Game.UseVisualStyleBackColor = true;
            this.button1Game.Click += new System.EventHandler(this.button1Game_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "EngApp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngApp";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        
            

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Game;
        private System.Windows.Forms.Button button3Game;
        private System.Windows.Forms.Button button2Game;
        private System.Windows.Forms.Button button1AddWords;
        private System.Windows.Forms.Button diagramma;
        private System.Windows.Forms.Button instruction;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}