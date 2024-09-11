namespace Eng_App_OOP
{
    partial class Game2
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtRussianWord = new System.Windows.Forms.TextBox();
            this.txtMissingLetter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Eng_App_OOP.Properties.Resources.british;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.txtRussianWord);
            this.panel1.Controls.Add(this.txtMissingLetter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 161);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // txtRussianWord
            // 
            this.txtRussianWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRussianWord.Location = new System.Drawing.Point(15, 50);
            this.txtRussianWord.Multiline = true;
            this.txtRussianWord.Name = "txtRussianWord";
            this.txtRussianWord.Size = new System.Drawing.Size(200, 50);
            this.txtRussianWord.TabIndex = 1;
            this.txtRussianWord.TextChanged += new System.EventHandler(this.txtRussianWord_TextChanged);
            // 
            // txtMissingLetter
            // 
            this.txtMissingLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMissingLetter.Location = new System.Drawing.Point(272, 50);
            this.txtMissingLetter.Multiline = true;
            this.txtMissingLetter.Name = "txtMissingLetter";
            this.txtMissingLetter.Size = new System.Drawing.Size(200, 50);
            this.txtMissingLetter.TabIndex = 0;
            this.txtMissingLetter.TextChanged += new System.EventHandler(this.txtMissingLetter_TextChanged);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.panel1);
            this.Name = "Game2";
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRussianWord;
        private System.Windows.Forms.TextBox txtMissingLetter;
        private System.Windows.Forms.Button btnCheck;
    }
}