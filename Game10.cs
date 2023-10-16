using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace New_menu_for_minersweeper
{
    public partial class Game10 : Form
    {
        
        int height = 10;
        int width = 10;
        int offset = 25;
        int bombCount = 1;
        bool isFirstClick = true;
        int cellsOpened = 0;
        int bombs = 0;
        int flagsCount = 0;

        int m, s;

        FieldButton[,] field;

        public Game10()
        {
            InitializeComponent();
            PauseMenu.Hide();
            lValue.Text = Properties.Settings.Default.best_time;
            lBest.Text = Properties.Settings.Default.best_user;
            tGame.Interval = 500;
            m = 0;
            s = 0;
            lTimer1.Text = "00";
            lTimer2.Text = "00";
        }

        private void Game10_Load(object sender, EventArgs e)
        {
            width = 10;
            height = 10;
            field = new FieldButton[width, height];

            lName.Text = "Текущий игрок :\n" + Data.UserName;
            lBomb.Text = "Количество бомб : " + (bombCount).ToString();
            lSize.Text = "Размер поля : " + width.ToString() + "*" + height.ToString();
            lFlags.Text = "Количество флагов : 0";

            GenerateField();
            tGame.Start();
        }

        void GenerateField()
        {
            Random random = new Random();


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    FieldButton newButton = new FieldButton();
                    newButton.Location = new Point(x * offset, y * offset);
                    newButton.Size = new Size(offset, offset);
                    newButton.isClickable = true;
                    newButton.xCoord = x;
                    newButton.yCoord = y;
                    Controls.Add(newButton);
                    newButton.MouseUp += new MouseEventHandler(FieldButtonClick);
                    field[x, y] = newButton;
                }
            }

            while (bombs != bombCount)
            {
                int xTemp = random.Next(0, width);
                int yTemp = random.Next(0, height);

                if (!field[xTemp, yTemp].isBomb)
                {
                    field[xTemp, yTemp].isBomb = true;
                    bombs++;
                }

            }
        }

        void FieldButtonClick(object sender, MouseEventArgs e) //для каждой кнопки при нажатии
        {
            FieldButton clickedButton = (FieldButton)sender;

            if (e.Button == MouseButtons.Left && clickedButton.isClickable)
            {
                if (clickedButton.isBomb)
                {
                    if (isFirstClick)
                    {
                        clickedButton.isBomb = false;
                        isFirstClick = false;
                        bombs--;
                        OpenRegion(clickedButton.xCoord, clickedButton.yCoord, clickedButton);
                    }
                    else
                    {
                        Explode();
                    }
                }
                else
                {
                    EmptyFieldButtonClick(clickedButton);
                }
                isFirstClick = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                clickedButton.isClickable = !clickedButton.isClickable; //деактивация
                if (clickedButton.isClickable)
                {
                    clickedButton.Text = "🚩"; //флаг
                    flagsCount += 1;
                    lFlags.Text = $"Количество флагов: {flagsCount}";
                }
                else
                {
                    clickedButton.Text = ""; //не бомба
                }
            }
            CheckWin();
        }
        void Explode()
        {
            foreach (FieldButton button in field)
            {
                if (button.isBomb)
                {
                    button.Text = "💣";
                }
            }
            tGame.Stop();
            MessageBox.Show("Вы проиграли");
           
            using (StreamWriter streamWriter = new StreamWriter("newrecords.txt", true))
            {
                streamWriter.WriteLine("Проигрыш - " + Data.UserName + " " + lTimer1.Text + " : " + lTimer2.Text);
            }
           
            Application.Restart();

        }
        void EmptyFieldButtonClick(FieldButton clickedButton)
        {

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (field[x, y] == clickedButton)
                    {
                        OpenRegion(x, y, clickedButton);
                    }
                }
            }

        }

        void OpenRegion(int xCoord, int yCoord, FieldButton clickedButton)
        {
            Queue<FieldButton> queue = new Queue<FieldButton>();
            queue.Enqueue(clickedButton);
            clickedButton.wasAdded = true;

            while (queue.Count > 0)
            {
                FieldButton currentCell = queue.Dequeue();
                OpenCell(currentCell.xCoord, currentCell.yCoord, currentCell); //открытие поля
                cellsOpened++;
                if (CountBombsAround(currentCell.xCoord, currentCell.yCoord) == 0)
                {
                    for (int y = currentCell.yCoord - 1; y <= currentCell.yCoord + 1; y++) //проходим по полю 3 на 3 вокруг нажатой клетки
                    {
                        for (int x = currentCell.xCoord - 1; x <= currentCell.xCoord + 1; x++)
                        {
                            if (x == currentCell.xCoord && y == currentCell.yCoord)
                            {
                                continue;
                            }
                            if (x >= 0 && x < width && y >= 0 && y < height) //если не выходим за границы поля 3 на 3
                            {
                                if (!field[x, y].wasAdded)
                                {
                                    queue.Enqueue(field[x, y]);
                                    field[x, y].wasAdded = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        void OpenCell(int x, int y, FieldButton clickedButton)
        {
            int bombsAround = CountBombsAround(x, y);

            if (bombsAround == 0)
            {

            }
            else
            {
                clickedButton.Text = "" + bombsAround;
                clickedButton.ForeColor = Color.Black;
            }
            clickedButton.Enabled = false; //если нет бомб, то деактивация
        }
        int CountBombsAround(int xCoord, int yCoord) //позиция кнопки в массиве
        {
            int bombsAround = 0;
            for (int x = xCoord - 1; x <= xCoord + 1; x++)
            {
                for (int y = yCoord - 1; y <= yCoord + 1; y++)
                {
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        if (field[x, y].isBomb == true)
                        {
                            bombsAround++;
                        }
                    }
                }
            }
            return bombsAround;
        }

        private void tGame_Tick(object sender, EventArgs e)
        {

            if (label1.Visible)
            {
                if (s < 59)
                {
                    s++;
                    if (s < 10)
                    {
                        lTimer2.Text = "0" + s.ToString();
                    }
                    else
                    {
                        lTimer2.Text = s.ToString();
                    }
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        if (m < 10)
                        {
                            lTimer1.Text = "0" + m.ToString();
                        }
                        else
                        {
                            lTimer1.Text = m.ToString();
                        }
                        s = 0;
                        lTimer2.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        lTimer1.Text = "00";
                    }

                }
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры:\r\n\r\nИгровое поле разделено на смежные ячейки, некоторые из которых «заминированы»; количество «заминированных» ячеек известно.\r\nЦелью игры является открытие всех ячеек, не содержащих мины.\r\n\r\nИгрок открывает ячейки, стараясь не открыть ячейку с миной. Открыв ячейку с миной, он проигрывает. Мины расставляются после первого хода, поэтому проиграть на первом же ходу невозможно. Если под открытой ячейкой мины нет, то в ней появляется число, показывающее, сколько ячеек, соседствующих с только что открытой, «заминировано»; используя эти числа, игрок пытается рассчитать расположение мин, однако иногда даже в середине и в конце игры некоторые ячейки всё же приходится открывать наугад. Если под соседними ячейками тоже нет мин, то открывается некоторая «не заминированная» область до ячеек, в которых есть цифры. «Заминированные» ячейки игрок может пометить, чтобы случайно не открыть их.\r\n\r\nОткрыв все «не заминированные» ячейки, игрок выигрывает.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tGame.Stop();
            PauseMenu.Show();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            tGame.Start();
            PauseMenu.Hide();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void CheckWin()
        {
            int cells = width * height;
            int emptyCells = cells - bombs;
            if (cellsOpened >= emptyCells)
            {
                tGame.Stop();
                MessageBox.Show("Вы победили! :)");

                lValue.Text = lTimer1.Text + " : " + lTimer2.Text;
                Properties.Settings.Default.best_time = lValue.Text;
                Properties.Settings.Default.Save();

                lBest.Text = Data.UserName;
                Properties.Settings.Default.best_user = lBest.Text;
                Properties.Settings.Default.Save();
                

                using (StreamWriter streamWriter = new StreamWriter("newrecords.txt", true))
                {

                    streamWriter.WriteLine("Выигрыш - " + Data.UserName + " " + lTimer1.Text + " : " + lTimer2.Text);
                }
                Application.Restart();
            }
        } 
    }
    class FieldButton : Button
    {
        public bool isBomb;
        public bool isClickable;
        public bool wasAdded;
        public int xCoord;
        public int yCoord;

    }
}
