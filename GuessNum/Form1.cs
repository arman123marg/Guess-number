using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNum
{
    public partial class Form1 : Form
    {
        int GuessNumber;
        int PlayerVariant;
        int MaxBound;
        int MinBound;
        GameMode gameMode;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        enum GameMode
        {
            Easy,
            Medium,
            Hard,

        }
        enum Action
        {
            Player,
            Computer
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GuessNumber = rnd.Next(1, 101);
            lstHistory.Items.Add(GuessNumber);
            MinBound = 1;
            MaxBound = 100;
            gameMode = GameMode.Hard;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            bool IsNumber = int.TryParse(txtPlayerVariant.Text, out PlayerVariant);
            if (PlayerVariant == GuessNumber)
            {
                MessageBox.Show("Duq gwushakel eq tivy", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (PlayerVariant < GuessNumber)
            {
                MessageBox.Show("dzer tivy poqr e pntrvox tvic", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstHistory.Items.Add($"{PlayerVariant}<x");
            }
            else if (PlayerVariant > GuessNumber)
            {
                MessageBox.Show("dzer tivy mets e pntrvox tvic", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstHistory.Items.Add($"{PlayerVariant}>x");
            }
            switchTurn(Action.Computer);
            performComputerStep();
        }
        private void performComputerStep()
        {
            int consideredNumber;
            if (gameMode == GameMode.Hard)
            {
                consideredNumber = (MinBound + MaxBound) / 2;
            }
            else if (gameMode == GameMode.Medium)
            {
                consideredNumber = rnd.Next(MinBound,MaxBound);
            }
            else
            {
                consideredNumber = rnd.Next(1, 101);
            }
            txtCompGuessNum.Text = consideredNumber.ToString();
        }
        private void switchTurn(Action turn)
        {
            switch (turn)
            {
                case Action.Player:
                    gbPlayer.Enabled = true;
                    gbComputer.Enabled = false;
                    txtPlayerVariant.Focus();
                    this.AcceptButton = button1;
                    break;
                case Action.Computer:
                    gbPlayer.Enabled = false;
                    gbComputer.Enabled = true;
                   txtCompGuessNum.Focus();
                    this.AcceptButton = button2;
                    break;
            }
        }
        private void btnAcceptAnswer_Click(object sender, EventArgs e)
        {
            if (rbEqual.Checked)
            {
                MessageBox.Show("Դուք պարտվեցիք", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gameMode == GameMode.Hard)
            {
                if (rbGreate.Checked)
                {
                    int guessNumberMaxBound = int.Parse(txtCompGuessNum.Text);
                }
                else
                {
                    int guessNumberMinBound = int.Parse(txtCompGuessNum.Text);
                }
                this.Text = MinBound + " " + MaxBound;
                if (MinBound >= MaxBound)
                {
                    MessageBox.Show("Դուք պարտվեցիք, հարցերին պատասխանել եք սխալ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            switchTurn(Action.Player);
        }

    }
}
