namespace Eng_App_OOP
{
    partial class Add_new_word
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
            this.AddAll = new System.Windows.Forms.Button();
            this.Enter_transl = new System.Windows.Forms.TextBox();
            this.Enter_new_word = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Eng_App_OOP.Properties.Resources.british;
            this.panel1.Controls.Add(this.AddAll);
            this.panel1.Controls.Add(this.Enter_transl);
            this.panel1.Controls.Add(this.Enter_new_word);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 161);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddAll
            // 
            this.AddAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAll.Location = new System.Drawing.Point(190, 126);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(105, 23);
            this.AddAll.TabIndex = 4;
            this.AddAll.Text = "Добавить слово";
            this.AddAll.UseVisualStyleBackColor = true;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Enter_transl
            // 
            this.Enter_transl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_transl.Location = new System.Drawing.Point(297, 50);
            this.Enter_transl.Multiline = true;
            this.Enter_transl.Name = "Enter_transl";
            this.Enter_transl.Size = new System.Drawing.Size(165, 50);
            this.Enter_transl.TabIndex = 3;
            this.Enter_transl.TextChanged += new System.EventHandler(this.Enter_transl_TextChanged);
            this.Enter_transl.Enter += new System.EventHandler(this.Enter_transl_Enter);
            this.Enter_transl.Leave += new System.EventHandler(this.Enter_transl_Leave);
            // 
            // Enter_new_word
            // 
            this.Enter_new_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_new_word.Location = new System.Drawing.Point(26, 50);
            this.Enter_new_word.Multiline = true;
            this.Enter_new_word.Name = "Enter_new_word";
            this.Enter_new_word.Size = new System.Drawing.Size(165, 50);
            this.Enter_new_word.TabIndex = 2;
            this.Enter_new_word.TextChanged += new System.EventHandler(this.Enter_new_word_TextChanged);
            this.Enter_new_word.Enter += new System.EventHandler(this.Enter_new_word_Enter);
            this.Enter_new_word.Leave += new System.EventHandler(this.Enter_new_word_Leave);
            // 
            // Add_new_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.panel1);
            this.Name = "Add_new_word";
            this.Text = "Add new word";
            this.Load += new System.EventHandler(this.Add_new_word_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Enter_new_word;
        private System.Windows.Forms.TextBox Enter_transl;
        private System.Windows.Forms.Button AddAll;
    }
}