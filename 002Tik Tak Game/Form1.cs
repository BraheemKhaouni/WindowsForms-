using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tik_Tak_Game.Properties;

namespace Tik_Tak_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enPlayer playerTurn = enPlayer.Brahim;
        stGameStauts GameStauts;
        enum enPlayer {Brahim,Ferhat };
        enum enWinner {Brahim,Ferhat,Draw,InPrograss };

        struct stGameStauts
        {
            public bool GameOver;
            public short GameCount;
            public enWinner Winner;
        }

        void DiFrezzGame()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
        void FreezGame()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }
        void EndGame()
        {
            FreezGame();
            lblPlayerTurn.Text = "Game Over";
            switch(GameStauts.Winner)
            {
                case enWinner.Brahim:
                    lblWinner.Text = "Brahim";
                    break;
                case enWinner.Ferhat:
                    lblWinner.Text = "Ahmed";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool CheckValues(PictureBox PBox1, PictureBox PBox2, PictureBox PBox3)
        {
            if (PBox1.Tag.ToString() != "?" && PBox1.Tag.ToString() == PBox2.Tag.ToString() && PBox1.Tag.ToString() == PBox3.Tag.ToString()) 
            {
                PBox1.BackColor=Color.HotPink;
                PBox2.BackColor=Color.HotPink;
                PBox3.BackColor=Color.HotPink;
                if(PBox1.Tag.ToString()=="X")
                {
                    GameStauts.Winner = enWinner.Brahim;
                    GameStauts.GameOver = true;
                    EndGame();
                    return true;
                }
               else
                {
                    GameStauts.Winner = enWinner.Ferhat;
                    GameStauts.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            else
            {
                GameStauts.GameOver = false;
                return false;
            }
        }
        void CheckWinner()
        {
            //Row
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3)) { return; }
            if (CheckValues(pictureBox4, pictureBox5, pictureBox6)) { return; }
            if (CheckValues(pictureBox7, pictureBox8, pictureBox9)) { return; }

            //Clo
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7)) { return; }
            if (CheckValues(pictureBox2, pictureBox5, pictureBox8)) { return; }
            if (CheckValues(pictureBox3, pictureBox6, pictureBox9)) { return; }
            //Daig
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9)) { return; }
            if (CheckValues(pictureBox3, pictureBox5, pictureBox7)) { return; }
        }
        void ChaneImage(PictureBox PBOX)
        {
            if(PBOX.Tag.ToString() == "?")
            {
                switch(playerTurn)
                {
                    case enPlayer.Brahim:
                        PBOX.Image = Resources.crossed;
                        lblPlayerTurn.Text = "Ahmed";
                        PBOX.Tag = "X";
                        playerTurn = enPlayer.Ferhat;
                        GameStauts.GameCount++;
                        CheckWinner();
                        break;
                    case enPlayer.Ferhat:
                        PBOX.Image = Resources.letter_o;
                        lblPlayerTurn.Text = "Brahim";
                        PBOX.Tag = "O";
                        playerTurn = enPlayer.Brahim;
                        GameStauts.GameCount++;
                        CheckWinner();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Wrong Chiose ", "Errer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(GameStauts.GameCount==9)
            {
                GameStauts.Winner = enWinner.Draw;
                GameStauts.GameOver=true;
                EndGame();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox2);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox3);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox4);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox5);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox6);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox7);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox8);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ChaneImage(pictureBox9);

        }
        void RestartPboxes(PictureBox PBOX)
        {
            PBOX.Image = Resources.search;
            PBOX.Tag = "?";
            PBOX.BackColor= Color.White;
        }
        void RestartGame()
        {
            RestartPboxes(pictureBox1);
            RestartPboxes(pictureBox2);
            RestartPboxes(pictureBox3);
            RestartPboxes(pictureBox4);
            RestartPboxes(pictureBox5);
            RestartPboxes(pictureBox6);
            RestartPboxes(pictureBox7);
            RestartPboxes(pictureBox8);
            RestartPboxes(pictureBox9);

            lblWinner.Text = "In Prograss";
            lblPlayerTurn.Text = "Brahim";
            playerTurn = enPlayer.Brahim;
            GameStauts.GameCount = 0;

        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            RestartGame();
            DiFrezzGame();
        }
    }
}
