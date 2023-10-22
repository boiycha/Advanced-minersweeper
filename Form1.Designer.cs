namespace New_menu_for_minersweeper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bExit = new System.Windows.Forms.Button();
            this.bMiddle = new System.Windows.Forms.Button();
            this.bPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(11, 45);
            this.bNew.Margin = new System.Windows.Forms.Padding(2);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(186, 46);
            this.bNew.TabIndex = 0;
            this.bNew.Text = "Новичок";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(235, 176);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(92, 46);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bMiddle
            // 
            this.bMiddle.Location = new System.Drawing.Point(11, 110);
            this.bMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.bMiddle.Name = "bMiddle";
            this.bMiddle.Size = new System.Drawing.Size(186, 46);
            this.bMiddle.TabIndex = 2;
            this.bMiddle.Text = "Любитель";
            this.bMiddle.UseVisualStyleBackColor = true;
            this.bMiddle.Click += new System.EventHandler(this.button2_Click);
            // 
            // bPro
            // 
            this.bPro.Location = new System.Drawing.Point(11, 176);
            this.bPro.Margin = new System.Windows.Forms.Padding(2);
            this.bPro.Name = "bPro";
            this.bPro.Size = new System.Drawing.Size(186, 46);
            this.bPro.TabIndex = 3;
            this.bPro.Text = "Профессионал";
            this.bPro.UseVisualStyleBackColor = true;
            this.bPro.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите уровень сложности :";
            // 
            // bRecords
            // 
            this.bRecords.Location = new System.Drawing.Point(235, 45);
            this.bRecords.Margin = new System.Windows.Forms.Padding(2);
            this.bRecords.Name = "bRecords";
            this.bRecords.Size = new System.Drawing.Size(92, 46);
            this.bRecords.TabIndex = 5;
            this.bRecords.Text = "Рекорды";
            this.bRecords.UseVisualStyleBackColor = true;
            this.bRecords.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 251);
            this.Controls.Add(this.bRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPro);
            this.Controls.Add(this.bMiddle);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bMiddle;
        private System.Windows.Forms.Button bPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRecords;
    }
}

