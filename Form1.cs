using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace New_menu_for_minersweeper
{
    public partial class Form1 : Form
    {
        public string playerName;
        Game10 game10 = new Game10();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите имя игрока", "Настройка игрока", "Новый игрок");
            if (playerName == "")
            {
                playerName = "Новый игрок";
                
            }
            Data.UserName = playerName;
            game10.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
