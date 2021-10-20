using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class FrmMain : Form
    {
        int counter;
        public FrmMain()
        {
            InitializeComponent();
        }

        public void EmptySpotChecker(ButtonX butt1, ButtonX butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
            }
        }

        public void SolutionChecker()
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "4" && btn5.Text == "5" && btn6.Text == "6" &&
                btn7.Text == "7" && btn8.Text == "8" && btn9.Text == "9" &&
                    btn10.Text == "10" && btn11.Text == "11" && btn12.Text == "12" &&
                    btn13.Text == "13" && btn14.Text == "14" && btn15.Text == "15")
            {
                MessageBox.Show("Well done you are a winner", "Shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            counter = counter + 1;
            label1.Text = "Number of Clicks :" + counter;
            label2.Text = counter.ToString();
        }

        public void Shuffle()
        {
            int[] bnum = new int[16];
            int i, j, rowchecker;
            Boolean flag = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32((rnd.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == true)
                {
                    flag = false ;
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = i + 1;
                }
            } while (i<=15);
            btn1.Text = Convert.ToString(bnum[1]);
            btn2.Text = Convert.ToString(bnum[2]);
            btn3.Text = Convert.ToString(bnum[3]);
            btn4.Text = Convert.ToString(bnum[4]);

            btn5.Text = Convert.ToString(bnum[5]);
            btn6.Text = Convert.ToString(bnum[6]);
            btn7.Text = Convert.ToString(bnum[7]);
            btn8.Text = Convert.ToString(bnum[8]);

            btn9.Text = Convert.ToString(bnum[9]);
            btn10.Text = Convert.ToString(bnum[10]);
            btn11.Text = Convert.ToString(bnum[11]);
            btn12.Text = Convert.ToString(bnum[12]);

            btn13.Text = Convert.ToString(bnum[13]);
            btn14.Text = Convert.ToString(bnum[14]);
            btn15.Text = Convert.ToString(bnum[15]);
            btn.Text = "";
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Confirm if you want to exit", "Shuffle Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Confirm if you want to exit",
                "Shuffle Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(1);
            btn2.Text = Convert.ToString(2);
            btn3.Text = Convert.ToString(3);
            btn4.Text = Convert.ToString(4);
            btn5.Text = Convert.ToString(5);
            btn6.Text = Convert.ToString(6);
            btn7.Text = Convert.ToString(7);
            btn8.Text = Convert.ToString(8);
            btn9.Text = Convert.ToString(9);
            btn10.Text = Convert.ToString(10);
            btn11.Text = Convert.ToString(11);
            btn12.Text = Convert.ToString(12);
            btn13.Text = Convert.ToString(13);
            btn14.Text = Convert.ToString(14);
            btn15.Text = Convert.ToString(15);
            btn.Text = "";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn1, btn2);
            EmptySpotChecker(btn1, btn5);
            SolutionChecker();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn2, btn1);
            EmptySpotChecker(btn2, btn3);
            EmptySpotChecker(btn2, btn6);
            SolutionChecker();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn3, btn2);
            EmptySpotChecker(btn3, btn4);
            EmptySpotChecker(btn3, btn7);
            SolutionChecker();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn4, btn3);
            EmptySpotChecker(btn4, btn8);
            SolutionChecker();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn5, btn1);
            EmptySpotChecker(btn5, btn6);
            EmptySpotChecker(btn5, btn9);
            SolutionChecker();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn6, btn5);
            EmptySpotChecker(btn6, btn2);
            EmptySpotChecker(btn6, btn10);
            EmptySpotChecker(btn6, btn7);
            SolutionChecker();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn7, btn3);
            EmptySpotChecker(btn7, btn8);
            EmptySpotChecker(btn7, btn11);
            EmptySpotChecker(btn7, btn6);
            SolutionChecker();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn8, btn4);
            EmptySpotChecker(btn8, btn7);
            EmptySpotChecker(btn8, btn12);
            SolutionChecker();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn9, btn5);
            EmptySpotChecker(btn9, btn10);
            EmptySpotChecker(btn9, btn13);
            SolutionChecker();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn10, btn9);
            EmptySpotChecker(btn10, btn6);
            EmptySpotChecker(btn10, btn11);
            EmptySpotChecker(btn10, btn14);
            SolutionChecker();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn11, btn10);
            EmptySpotChecker(btn11, btn7);
            EmptySpotChecker(btn11, btn12);
            EmptySpotChecker(btn11, btn15);
            SolutionChecker();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn12, btn8);
            EmptySpotChecker(btn12, btn11);
            EmptySpotChecker(btn12, btn);
            SolutionChecker();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn13, btn9);
            EmptySpotChecker(btn13, btn14);
            SolutionChecker();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn14, btn13);
            EmptySpotChecker(btn14, btn10);
            EmptySpotChecker(btn14, btn15);
            SolutionChecker();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn15, btn14);
            EmptySpotChecker(btn15, btn11);
            EmptySpotChecker(btn15, btn);
            SolutionChecker();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn, btn12);
            EmptySpotChecker(btn, btn15);
            SolutionChecker();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Shuffle();
            label1.Text = label2.Text = "";
            

            this.Refresh();
            this.Hide();

            FrmMain newGame = new FrmMain();
            newGame.Show();
        }
    }
}
