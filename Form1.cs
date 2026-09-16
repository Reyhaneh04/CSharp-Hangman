using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] words = { "SARA", "BITA", "NIMA", "MANI", "AMIN", "MINA" }; // اسامی آرایه
        int timer = 20; // تایمر مقدار
        string txtInput;
        string charInput;
        int counter = 0;
        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            lblTime.Text = timer.ToString();
            if (timer <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("زمان شما تمام شد");
                pictureBox1.Image = Properties.Resources.p5;
                lblAnswer.Text = txtInput;
                lblResult.Text = "YOU LOSE";
                lblResult.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            charInput = (sender as Button).Text;
            (sender as Button).Enabled = false;
            findChar();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            initGame();
            timer1.Enabled = true;
            Random r = new Random();
            int rndRow = r.Next(words.Length);
            txtInput = words[rndRow];
            counter = 0;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;

        }
        private void initGame()
        {
            timer = 20;
            lblAnswer.Text = "";
            lblResult.Text = "";
            label5.Text = "";
            pictureBox1.Image = Properties.Resources.tree;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
            label1.Text = "____";
            label2.Text = "____";
            label3.Text = "____";
            label4.Text = "____";
        }
        public void winTest()
        {
            bool test = true;
            if (label1.Text == "____")
                test = false;
            if (label2.Text == "____")
                test = false;
            if (label3.Text == "____")
                test = false;
            if (label4.Text == "____")
                test = false;
            if (true == test)
            {
                timer1.Enabled = false;
                lblResult.Text = "YOU WIN";
                lblResult.Visible = true;
                lblAnswer.Text = txtInput;
                counter = 5;
            }
        }
            private void findChar()
 {
 int place;
 if (counter < 5)
 {
place=txtInput.IndexOf(charInput);
 if (place >= 0)
 {
 while (place >= 0)
{
 switch (place)
{
 case 0: label1.Text = charInput; break;
 case 1: label2.Text = charInput; break;
 case 2: label3.Text = charInput; break;
 case 3: label4.Text = charInput; break;
 }
place = txtInput.IndexOf(charInput, ++place);
 }
winTest();
 }
 else
 {
counter++;
 switch (counter)
 {
     case 1:
 pictureBox1.Image = Properties.Resources.p1;
break;
 case 2:
 pictureBox1.Image = Properties.Resources.p2;
break;
 case 3:
 pictureBox1.Image = Properties.Resources.p3;
break;
 case 4:
 pictureBox1.Image = Properties.Resources.p4;
break;
 case 5:
 timer1.Enabled = false;
pictureBox1.Image = Properties.Resources.p5;
lblAnswer.Text = txtInput;
lblResult.Text = "YOU LOSE";
lblResult.Visible = true;
 break
;

}

}

}
        }

            private void buttonB_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonC_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonD_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonE_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonF_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonG_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonH_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonI_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonJ_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonK_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonL_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonM_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonN_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonO_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonP_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonQ_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonR_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonS_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonT_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonU_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonV_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonW_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonX_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonY_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

            private void buttonZ_Click(object sender, EventArgs e)
            {
                charInput = (sender as Button).Text;
                (sender as Button).Enabled = false;
                findChar();
            }

    }
}