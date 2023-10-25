using System;
using System.Windows.Forms;

namespace New_menu_for_minersweeper {
  public partial class Form1 : Form {
    public string playerName;
    Game10 game10 = new Game10();
    Game20 game20 = new Game20();
    Game30 game30 = new Game30();
    Records records_10 = new Records();

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите имя игрока", "Настройка игрока", "Новый игрок");
      playerName = playerName == "" ? "Новый игрок" : playerName;
      playerName = playerName.ToString().Trim();

      if (playerName.Length > 20) {
        MessageBox.Show("Слишком длинное имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Restart();
      }
      Data.UserName = playerName;
      game10.ShowDialog();

    }

    private void button1_Click_1(object sender, EventArgs e) {
      Application.Exit();
    }

    private void button2_Click(object sender, EventArgs e) {
      playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите имя игрока", "Настройка игрока", "Новый игрок");
      playerName = playerName == "" ? "Новый игрок" : playerName;
      playerName = playerName.ToString().Trim();

      if (playerName.Length > 20) {
        MessageBox.Show("Слишком длинное имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Restart();
      }
      Data.UserName = playerName;
      game20.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e) {
      playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите имя игрока", "Настройка игрока", "Новый игрок");
      playerName = playerName == "" ? "Новый игрок" : playerName;
      playerName = playerName.ToString().Trim();

      if (playerName.Length > 20) {
        MessageBox.Show("Слишком длинное имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Restart();
      }
      Data.UserName = playerName;
      game30.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e) {
      records_10.ShowDialog();
    }
  }
}
