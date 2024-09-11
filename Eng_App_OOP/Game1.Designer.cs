using System;

namespace Eng_App_OOP
{
    partial class Game1
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
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Eng_App_OOP.Properties.Resources.british;
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.txtTranslation);
            this.panel2.Controls.Add(this.txtEnglishWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 161);
            this.panel2.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(190, 126);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(105, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTranslation.Location = new System.Drawing.Point(272, 50);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(200, 50);
            this.txtTranslation.TabIndex = 1;
            this.txtTranslation.TextChanged += new System.EventHandler(this.txtTranslation_TextChanged);
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnglishWord.Location = new System.Drawing.Point(15, 50);
            this.txtEnglishWord.Multiline = true;
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Size = new System.Drawing.Size(200, 50);
            this.txtEnglishWord.TabIndex = 0;
            this.txtEnglishWord.TextChanged += new System.EventHandler(this.txtEnglishWord_TextChanged);
            // 
            // Game1
            // 
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblResult);
            this.Name = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Game1_Load(object sender, EventArgs e)
        {
            
        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEnglishWord;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btnCheck;
    }
}