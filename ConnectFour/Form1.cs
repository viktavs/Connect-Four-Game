using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 gameform = new Form2();
            gameform.Visible = true;
            this.Visible = false;
        }

        private void background_Load(object sender, EventArgs e)
        {
            try
            {
                startBg.Image = Image.FromFile("../../Images/startBg.png");
                startBtn.Image = Image.FromFile("../../Images/startBtn.png");
            }
            catch (Exception er)
            {
                Console.WriteLine("Error with loading background image: " + er);
            }
        }

        private void startBg_Click(object sender, EventArgs e)
        {

        }

    }
}
