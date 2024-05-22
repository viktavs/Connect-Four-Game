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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace ConnectFour
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool playerOne = true;
        bool playerTwo = false;
        /*Image yellowCircle = Image.FromFile("../../Images/yellowCircle.png");*/



        private void Form2_Load(object sender, EventArgs e)
        {
            circle1.Visible = false;

            try
            {
                gameBg.Image = Image.FromFile("../../Images/net.png");
            }
            catch (Exception er)
            {
                Console.WriteLine("Error with loading background image: " + er);
            }
        }


        private void label50_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkFull()
        {
            if(label1.BackColor != Color.White && label8.BackColor != Color.White && label21.BackColor != Color.White && label28.BackColor != Color.White && label35.BackColor != Color.White && label42.BackColor != Color.White && label49.BackColor != Color.White)
            {
                label50.Text = ("Tie Game");


            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                {
                    if (playerOne == true)
                    {

                        /* if (label7.BackColor == Color.White)
                         {
                             label7.Image = Image.FromFile("../../Images/startBtn.png");
                             playerOne = false;
                             playerTwo = true;
                         }

                         // circle1.Visible != true

                         else*/
                        if (label6.BackColor == Color.White)
                        {
                            label6.BackColor = Color.Green;
                            circle1.Visible = true;
                            circle1.Image = Image.FromFile("../../Images/yellowCircle.png");
                            playerOne = false;
                            playerTwo = true;
                        }
                        else if (label5.BackColor == Color.White)
                        {
                            label5.BackColor = Color.Green;
                            playerOne = false;
                            playerTwo = true;
                        }
                        else if (label4.BackColor == Color.White)
                        {
                            label4.BackColor = Color.Green;
                            playerOne = false;
                            playerTwo = true;
                        }
                        else if (label3.BackColor == Color.White)
                        {
                            label3.BackColor = Color.Green;
                            playerOne = false;
                            playerTwo = true;
                        }
                        else if (label2.BackColor == Color.White)
                        {
                            label2.BackColor = Color.Green;
                            playerOne = false;
                            playerTwo = true;
                        }
                        else if (label1.BackColor == Color.White)
                        {
                            label1.BackColor = Color.Green;
                            playerOne = false;
                            playerTwo = true;
                        }
                    }
                    else if (playerTwo == true)

                    {

                       /* if (label7.BackColor == Color.White)
                        {
                            label7.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else*/ if (label6.BackColor == Color.White)
                        {
                            label6.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else if (label5.BackColor == Color.White)
                        {
                            label5.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else if (label4.BackColor == Color.White)
                        {
                            label4.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else if (label3.BackColor == Color.White)
                        {
                            label3.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else if (label2.BackColor == Color.White)
                        {
                            label2.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                        else if (label1.BackColor == Color.White)
                        {
                            label1.BackColor = Color.Red;
                            playerOne = true;
                            playerTwo = false;
                        }
                    }

                }
            }

            else if (e.KeyChar == '2')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                   /* if (label14.BackColor == Color.White)
                    {
                        label14.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label13.BackColor == Color.White)
                    {
                        label13.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label12.BackColor == Color.White)
                    {
                        label12.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label11.BackColor == Color.White)
                    {
                        label11.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label10.BackColor == Color.White)
                    {
                        label10.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label9.BackColor == Color.White)
                    {
                        label9.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label8.BackColor == Color.White)
                    {
                        label8.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                   /* if (label14.BackColor == Color.White)
                    {
                        label14.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label13.BackColor == Color.White)
                    {
                        label13.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label12.BackColor == Color.White)
                    {
                        label12.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label11.BackColor == Color.White)
                    {
                        label11.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label10.BackColor == Color.White)
                    {
                        label10.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label9.BackColor == Color.White)
                    {
                        label9.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label8.BackColor == Color.White)
                    {
                        label8.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                }
            }

            else if (e.KeyChar == '3')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                    /*if (label15.BackColor == Color.White)
                    {
                        label15.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label16.BackColor == Color.White)
                    {
                        label16.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label17.BackColor == Color.White)
                    {
                        label17.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label18.BackColor == Color.White)
                    {
                        label18.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label19.BackColor == Color.White)
                    {
                        label19.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label20.BackColor == Color.White)
                    {
                        label20.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label21.BackColor == Color.White)
                    {
                        label21.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                    /*if (label15.BackColor == Color.White)
                    {
                        label15.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label16.BackColor == Color.White)
                    {
                        label16.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label17.BackColor == Color.White)
                    {
                        label17.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label18.BackColor == Color.White)
                    {
                        label18.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label19.BackColor == Color.White)
                    {
                        label19.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label20.BackColor == Color.White)
                    {
                        label20.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label21.BackColor == Color.White)
                    {
                        label21.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                }
            }

            else if (e.KeyChar == '4')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                    /*if (label22.BackColor == Color.White)
                    {
                        label22.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label23.BackColor == Color.White)
                    {
                        label23.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label24.BackColor == Color.White)
                    {
                        label24.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label25.BackColor == Color.White)
                    {
                        label25.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label26.BackColor == Color.White)
                    {
                        label26.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label27.BackColor == Color.White)
                    {
                        label27.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label28.BackColor == Color.White)
                    {
                        label28.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                    /*if (label22.BackColor == Color.White)
                    {
                        label22.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label23.BackColor == Color.White)
                    {
                        label23.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label24.BackColor == Color.White)
                    {
                        label24.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label25.BackColor == Color.White)
                    {
                        label25.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label26.BackColor == Color.White)
                    {
                        label26.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label27.BackColor == Color.White)
                    {
                        label27.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label28.BackColor == Color.White)
                    {
                        label28.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }

                }
            }

            else if (e.KeyChar == '5')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                    /*if (label29.BackColor == Color.White)
                    {
                        label29.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label30.BackColor == Color.White)
                    {
                        label30.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label31.BackColor == Color.White)
                    {
                        label31.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label32.BackColor == Color.White)
                    {
                        label32.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label33.BackColor == Color.White)
                    {
                        label33.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label34.BackColor == Color.White)
                    {
                        label34.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label35.BackColor == Color.White)
                    {
                        label35.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                    /*if (label29.BackColor == Color.White)
                    {
                        label29.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label30.BackColor == Color.White)
                    {
                        label30.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label31.BackColor == Color.White)
                    {
                        label31.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label32.BackColor == Color.White)
                    {
                        label32.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label33.BackColor == Color.White)
                    {
                        label33.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label34.BackColor == Color.White)
                    {
                        label34.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label35.BackColor == Color.White)
                    {
                        label35.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                }
            }

            else if (e.KeyChar == '6')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                    /*if (label36.BackColor == Color.White)
                    {
                        label36.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label37.BackColor == Color.White)
                    {
                        label37.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label38.BackColor == Color.White)
                    {
                        label38.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label39.BackColor == Color.White)
                    {
                        label39.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label40.BackColor == Color.White)
                    {
                        label40.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label41.BackColor == Color.White)
                    {
                        label41.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label42.BackColor == Color.White)
                    {
                        label42.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                    /*if (label36.BackColor == Color.White)
                    {
                        label36.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label37.BackColor == Color.White)
                    {
                        label37.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label38.BackColor == Color.White)
                    {
                        label38.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label39.BackColor == Color.White)
                    {
                        label39.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label40.BackColor == Color.White)
                    {
                        label40.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label41.BackColor == Color.White)
                    {
                        label41.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label42.BackColor == Color.White)
                    {
                        label42.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                }
            }

            else if (e.KeyChar == '7')
            {
                if (playerOne == true)
                {
                    label50.Text = ("Player Two Turn");
                }
                else if (playerTwo == true)
                {
                    label50.Text = ("Player One Turn");
                }
                checkFull();
                if (playerOne == true)
                {
                   /* if (label43.BackColor == Color.White)
                    {
                        label43.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else */if (label44.BackColor == Color.White)
                    {
                        label44.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label45.BackColor == Color.White)
                    {
                        label45.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label46.BackColor == Color.White)
                    {
                        label46.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label47.BackColor == Color.White)
                    {
                        label47.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label48.BackColor == Color.White)
                    {
                        label48.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                    else if (label49.BackColor == Color.White)
                    {
                        label49.BackColor = Color.Green;
                        playerOne = false;
                        playerTwo = true;
                    }
                }
                else if (playerTwo == true)
                {
                    /*if (label43.BackColor == Color.White)
                    {
                        label43.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else */if (label44.BackColor == Color.White)
                    {
                        label44.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label45.BackColor == Color.White)
                    {
                        label45.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label46.BackColor == Color.White)
                    {
                        label46.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label47.BackColor == Color.White)
                    {
                        label47.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label48.BackColor == Color.White)
                    {
                        label48.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                    else if (label49.BackColor == Color.White)
                    {
                        label49.BackColor = Color.Red;
                        playerOne = true;
                        playerTwo = false;
                    }
                }
            }





            /////
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }
    }
}
