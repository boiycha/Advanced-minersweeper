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
            this.lFlags = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.lBest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bInfo = new System.Windows.Forms.Button();
            this.lSize = new System.Windows.Forms.Label();
            this.lBomb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bPause = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
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
            this.lTimer1.Location = new System.Drawing.Point(20, 161);
            this.lTimer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTimer1.Name = "lTimer1";
            this.lTimer1.Size = new System.Drawing.Size(21, 16);
            this.lTimer1.TabIndex = 0;
            this.lTimer1.Text = "00";
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
            this.lTimer2.Location = new System.Drawing.Point(52, 161);
            this.lTimer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTimer2.Name = "lTimer2";
            this.lTimer2.Size = new System.Drawing.Size(21, 16);
            this.lTimer2.TabIndex = 1;
            this.lTimer2.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Затрачено";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(20, 101);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(110, 16);
            this.lName.TabIndex = 4;
            this.lName.Text = "Текущий игрок :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lFlags);
            this.panel1.Controls.Add(this.lValue);
            this.panel1.Controls.Add(this.lBest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bInfo);
            this.panel1.Controls.Add(this.lTimer2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lSize);
            this.panel1.Controls.Add(this.lTimer1);
            this.panel1.Controls.Add(this.lBomb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 362);
            this.panel1.TabIndex = 5;
            // 
            // lFlags
            // 
            this.lFlags.AutoSize = true;
            this.lFlags.Location = new System.Drawing.Point(20, 249);
            this.lFlags.Name = "lFlags";
            this.lFlags.Size = new System.Drawing.Size(129, 15);
            this.lFlags.TabIndex = 11;
            this.lFlags.Text = "Количество флагов :";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lValue.Location = new System.Drawing.Point(20, 315);
            this.lValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(54, 16);
            this.lValue.TabIndex = 13;
            this.lValue.Text = "Время :";
            // 
            // lBest
            // 
            this.lBest.AutoSize = true;
            this.lBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBest.Location = new System.Drawing.Point(20, 297);
            this.lBest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBest.Name = "lBest";
            this.lBest.Size = new System.Drawing.Size(52, 16);
            this.lBest.TabIndex = 12;
            this.lBest.Text = "Игрок :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Последняя победа :";
            // 
            // bInfo
            // 
            this.bInfo.Location = new System.Drawing.Point(22, 203);
            this.bInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(94, 32);
            this.bInfo.TabIndex = 10;
            this.bInfo.Text = "Справка";
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSize.Location = new System.Drawing.Point(20, 53);
            this.lSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(139, 16);
            this.lSize.TabIndex = 7;
            this.lSize.Text = "Размер поля : 10 * 10";
            // 
            // lBomb
            // 
            this.lBomb.AutoSize = true;
            this.lBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBomb.Location = new System.Drawing.Point(20, 75);
            this.lBomb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBomb.Name = "lBomb";
            this.lBomb.Size = new System.Drawing.Size(106, 16);
            this.lBomb.TabIndex = 6;
            this.lBomb.Text = "Процент бомб :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Уровень :  новичок";
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(9, 306);
            this.bPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(94, 32);
            this.bPause.TabIndex = 8;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(148, 306);
            this.bExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(95, 31);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // PauseMenu
            // 
            this.PauseMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PauseMenu.Controls.Add(this.bReturn);
            this.PauseMenu.Controls.Add(this.bRestart);
            this.PauseMenu.Controls.Add(this.bContinue);
            this.PauseMenu.Controls.Add(this.lPause);
            this.PauseMenu.Location = new System.Drawing.Point(9, 44);
            this.PauseMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PauseMenu.Name = "PauseMenu";
            this.PauseMenu.Size = new System.Drawing.Size(233, 168);
            this.PauseMenu.TabIndex = 10;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(83, 115);
            this.bReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(118, 37);
            this.bReturn.TabIndex = 3;
            this.bReturn.Text = "Выход";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(83, 66);
            this.bRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(118, 37);
            this.bRestart.TabIndex = 2;
            this.bRestart.Text = "Главное меню";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(83, 18);
            this.bContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(118, 37);
            this.bContinue.TabIndex = 1;
            this.bContinue.Text = "Продолжить";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // lPause
            // 
            this.lPause.AutoSize = true;
            this.lPause.Location = new System.Drawing.Point(2, 7);
            this.lPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPause.Name = "lPause";
            this.lPause.Size = new System.Drawing.Size(41, 15);
            this.lPause.TabIndex = 0;
            this.lPause.Text = "Пауза";
            // 
            // Game10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 362);
            this.Controls.Add(this.PauseMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новичок";
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
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Panel PauseMenu;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label lPause;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Label lBest;
        private System.Windows.Forms.Label lFlags;
    }
}