using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class titleLabel : Form
    {
        Random randGen = new Random();
        int eightBallAnswer;
        public titleLabel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            eightBallAnswer = randGen.Next(1, 7);        

            switch (eightBallAnswer)
            {
                case 1:
                    magicBallOutput.Text = " Don't count on it.";
                    break;
                case 2:
                    magicBallOutput.Text = " Reply hazy, try again.";
                    break;
                case 3:
                    magicBallOutput.Text = "As I see it, yes.";
                    break;
                case 4:
                    magicBallOutput.Text = " My reply is no.";
                    break;
                case 5:
                    magicBallOutput.Text = "Yes.";
                    break;
                case 6:
                    magicBallOutput.Text = "Without a doubt.";
                    break;
            }
        }
    }
}
