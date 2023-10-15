namespace New_menu_for_minersweeper
{
    partial class Game10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game10));
            this.lTimer1 = new System.Windows.Forms.Label();
            this.tGame = new System.Windows.Forms.Timer(this.components);
            this.lTimer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lSize = new System.Windows.Forms.Label();
            this.lBomb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PauseMenu = new System.Windows.Forms.Panel();
            this.bReturn = new System.Windows.Forms.Button();
            this.bRestart = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.lPause = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PauseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTimer1
            // 
            this.lTimer1.AutoSize = true;
            this.lTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimer1.Location = new System.Drawing.Point(26, 198);
            this.lTimer1.Name = "lTimer1";
            this.lTimer1.Size = new System.Drawing.Size(21, 16);
            this.lTimer1.TabIndex = 0;
            this.lTimer1.Text = "00";
            this.lTimer1.Click += new System.EventHandler(this.lTimer_Click);
            // 
            // tGame
            // 
            this.tGame.Interval = 1000;
            this.tGame.Tick += new System.EventHandler(this.tGame_Tick);
            // 
            // lTimer2
            // 
            this.lTimer2.AutoSize = true;
            this.lTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimer2.Location = new System.Drawing.Point(69, 198);
            this.lTimer2.Name = "lTimer2";
            this.lTimer2.Size = new System.Drawing.Size(21, 16);
            this.lTimer2.TabIndex = 1;
            this.lTimer2.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Затрачено";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(26, 124);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(110, 16);
            this.lName.TabIndex = 4;
            this.lName.Text = "Текущий игрок :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lTimer2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lSize);
            this.panel1.Controls.Add(this.lTimer1);
            this.panel1.Controls.Add(this.lBomb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(341, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 446);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSize.Location = new System.Drawing.Point(26, 65);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(139, 16);
            this.lSize.TabIndex = 7;
            this.lSize.Text = "Размер поля : 10 * 10";
            // 
            // lBomb
            // 
            this.lBomb.AutoSize = true;
            this.lBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBomb.Location = new System.Drawing.Point(26, 92);
            this.lBomb.Name = "lBomb";
            this.lBomb.Size = new System.Drawing.Size(106, 16);
            this.lBomb.TabIndex = 6;
            this.lBomb.Text = "Процент бомб :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Уровень :  новичок";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Пауза";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PauseMenu
            // 
            this.PauseMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PauseMenu.Controls.Add(this.bReturn);
            this.PauseMenu.Controls.Add(this.bRestart);
            this.PauseMenu.Controls.Add(this.bContinue);
            this.PauseMenu.Controls.Add(this.lPause);
            this.PauseMenu.Location = new System.Drawing.Point(12, 54);
            this.PauseMenu.Name = "PauseMenu";
            this.PauseMenu.Size = new System.Drawing.Size(311, 207);
            this.PauseMenu.TabIndex = 10;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(111, 141);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(157, 46);
            this.bReturn.TabIndex = 3;
            this.bReturn.Text = "Выход";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(111, 81);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(157, 46);
            this.bRestart.TabIndex = 2;
            this.bRestart.Text = "Главное меню";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(111, 22);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(157, 46);
            this.bContinue.TabIndex = 1;
            this.bContinue.Text = "Продолжить";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // lPause
            // 
            this.lPause.AutoSize = true;
            this.lPause.Location = new System.Drawing.Point(3, 9);
            this.lPause.Name = "lPause";
            this.lPause.Size = new System.Drawing.Size(49, 16);
            this.lPause.TabIndex = 0;
            this.lPause.Text = "Пауза";
            // 
            // Game10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 446);
            this.Controls.Add(this.PauseMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.Load += new System.EventHandler(this.Game10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PauseMenu.ResumeLayout(false);
            this.PauseMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTimer1;
        private System.Windows.Forms.Timer tGame;
        private System.Windows.Forms.Label lTimer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lBomb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PauseMenu;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label lPause;
    }
}