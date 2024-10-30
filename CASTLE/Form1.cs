using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASTLE
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();


            displayText.Text = "You are a robber trying to steal the dragons gold";
            Thread.Sleep(2000);
            Refresh();
            displayText.Text = "How do you plan to break into the castle";
            option1Text.Text = "though the moat";
            option2Text.Text = "you just decided to give up on the misson";
            option3Text.Text = "Storm the Gate";

        }
        SoundPlayer Bonk = new SoundPlayer(Properties.Resources.Page8Bonk);
        SoundPlayer Bow = new SoundPlayer(Properties.Resources.BowFire);
        SoundPlayer Splash = new SoundPlayer(Properties.Resources.Splash);
        SoundPlayer Angel = new SoundPlayer(Properties.Resources.Angel);
        SoundPlayer Grass = new SoundPlayer(Properties.Resources.Grass);
        SoundPlayer Dragon = new SoundPlayer(Properties.Resources.Dragon);
        SoundPlayer Cart = new SoundPlayer(Properties.Resources.Cart);
        SoundPlayer Roar = new SoundPlayer(Properties.Resources.Roar);
        private void Option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }





            DisplayPage();

        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 99;
            }

            DisplayPage();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                Random randGen = new Random();
                int random = randGen.Next(1, 101);

                if (random > 50)
                {
                    page = 4;
                }
                else
                {
                    page = 5;
                }
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            DisplayPage();
        }


        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    {
                        Angel.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.page1drawing;
                        displayText.Text = "How do you plan to break into the castle";
                        option1Text.Text = "though the moat";
                        option2Text.Text = "you just decided to give up on the misson";
                        option3Text.Text = "Storm the Gate";



                    }
                    break;
                case 2:
                    {
                        Splash.Play();
                        Refresh();
                        Thread.Sleep(500);
                        pictureBox1.Image = CASTLE.Properties.Resources.Page2Drawing;
                        option3Text.Text = "";
                        displayText.Text = "it's 1480 you can't swim";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                        option3Text.Text = "";

                    }
                    break;
                case 3:
                    {
                        Grass.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page3drawing;
                        option3Text.Text = "";
                        displayText.Text = "You Leave the castle and are captured";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";

                    }
                    break;
                case 4:
                    {
                        Bow.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page4Drawing;
                        option3Text.Text = "";
                        displayText.Text = "They sent some arrows at you but you dodged it";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "How do you sneak in now";
                        option1Text.Text = "You Hide in the food";
                        option2Text.Text = "Play Dead";
                    }
                    break;
                case 5:
                    {
                        Bow.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page5drawing;
                        option3Text.Text = "";
                        displayText.Text = "They sent some arrows at you and they hit you";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;
                case 6:
                    {
                        {
                            Bow.Play();
                            pictureBox1.Image = CASTLE.Properties.Resources.Page6drawing;
                            displayText.Text = "They Just saw you dodge the arrow";
                            Refresh();
                            Thread.Sleep(800);
                            displayText.Text = "YOU HAVE DIED!   Play Again";
                            option1Text.Text = "Yes";
                            option2Text.Text = "NO";


                        }

                    }
                    break;
                case 7:
                    {
                        Grass.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page7drawing;
                        Refresh();
                        Thread.Sleep(1500);
                        pictureBox1.Image = CASTLE.Properties.Resources.ADDED;
                        displayText.Text = "They take you to the kitchen";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "What do you do now";
                        option1Text.Text = "Leave the cart and go for a chef's outfit";
                        option2Text.Text = "Leave the kitchen";
                        option3Text.Text = "Stay in the cart";

                    }


                    break;
                case 8:
                    {

                        Bonk.Play();
                        Refresh();
                        Thread.Sleep(300);
                        pictureBox1.Image = CASTLE.Properties.Resources.Page8Drawing;
                        option3Text.Text = "";
                        displayText.Text = "The chef see you and kills you with a frying pan";
                        Refresh();

                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;
                case 9:
                    {
                        Bonk.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page9drawing;
                        option3Text.Text = "";
                        displayText.Text = "all the soldiers see you they kill you";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;
                case 10:
                    {
                        Cart.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Jail;
                        option3Text.Text = "";
                        displayText.Text = "they take you to their jail cells";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "What do you do";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Leave";
                    }
                    break;
                case 11:
                    {
                        Bonk.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page9drawing;
                        displayText.Text = "You leave the cart and the guard see you.";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;

                case 12:
                    {
                        Cart.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page14;
                        displayText.Text = "You are taken to the dragons den";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "what do you do";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Leave";
                    }
                    break;

                case 13:
                    {
                        Dragon.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page13Drawing;
                        displayText.Text = "The dragon see you and eats you";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;
                case 14:
                    {
                        Roar.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page14;
                        displayText.Text = "You consider leaving";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "Do you stay or leave";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Leave";
                    }
                    break;
                case 15:
                    {
                        Dragon.Play();
                        displayText.Text = "You fell for the dragons trap";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;
                case 16:
                    {
                        Dragon.Play();
                        pictureBox1.Image = CASTLE.Properties.Resources.Page16drawing;
                        displayText.Text = "You consider leaving";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "Do you stay or leave";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Stay";
                    }
                    break;
                case 17:
                    {
                        Dragon.Play();
                        displayText.Text = "You consider leaving but you can't";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "Do you stay or leave";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Stay";
                    }
                    break;
                case 18:
                    {
                        Dragon.Play();

                        displayText.Text = "You consider leaving but you can't";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "Do you stay or leave";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Stay";
                    }
                    break;
                case 19:
                    {
                        Dragon.Play();

                        displayText.Text = "You consider leaving but you can't";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "Do you stay or leave";
                        option1Text.Text = "Stay";
                        option2Text.Text = "Stay";
                    }
                    break;

                case 20:
                    {

                        Dragon.Play();

                        displayText.Text = "You Have been Squished";
                        Refresh();
                        Thread.Sleep(800);
                        displayText.Text = "YOU HAVE DIED!   Play Again";
                        option1Text.Text = "Yes";
                        option2Text.Text = "NO";
                    }
                    break;

                case 99:
                    {
                        displayText.Text = "Thank you for playing";
                        Thread.Sleep(2000);
                        Refresh();
                        Close();
                    }
                    break;

            }
        }
    }
}


