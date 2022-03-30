using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer jumpscareplayer = new SoundPlayer(Properties.Resources.Jumpscare_Sound_Effect);
        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "You are walking down an alley way when you notice a man following you. What will you do?";
            choice1.Text = "Run";
            choice2.Text = "Confront him";
            pictureBox1.Image = Properties.Resources.alley;
        }

        private void choice1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 1;            
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            { 
                page = 1; 
            }
            else if  (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 10;
            }

            

            switch (page)
            {
                case 1:
                    label1.Text = "You are walking down an alley way when you notice a man following you. What will you do?";
                    choice1.Text = "Run";
                    choice2.Text = "Confront him";
                    pictureBox1.Image = Properties.Resources.alley;
                    break;

                case 2:
                    label1.Text = "He is right behind you. You can go through the door or go left. What will you choose?";
                    choice1.Text = "Door";
                    choice2.Text = "Left";
                    pictureBox1.Image = Properties.Resources.door;
                    break;
                    case 4:
                    label1.Text = "You enter. You can go upstairs or the basement.";
                    choice1.Text = "Upstairs";
                    choice2.Text = "Basement";
                    pictureBox1.Image = Properties.Resources.inside;
                    break;

                case 6:
                    label1.Text = "As you're running up the stairs you slip. You die from your injuries. Play Again?";
                    choice1.Text = "Yes";
                    choice2.Text = "No";
                    pictureBox1.Image = Properties.Resources.stair_ending;
                    break;

                case 8:
                    label1.Text = "You run for the exit and slam the door on him. You get away. Play Again?";
                    choice1.Text = "Yes";
                    choice2.Text = "No";
                    pictureBox1.Image = Properties.Resources.good_ending;
                        break;
                case 10:
                    label1.Text = "";
                    choice1.Text = "";
                    choice2.Text = "";
                    pictureBox1.Image = Properties.Resources.jumpscare;
                    jumpscareplayer.Play();
                    break;



                   
                      
                    

            }
        }

        private void choice2_Click (object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page ==3)
            {
                Application.Exit();
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                Application.Exit();
            }
            else if (page == 6)
            {
                Application.Exit();
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 8)
            {
                Application.Exit();
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }


            switch (page)

            {
                case 3:
                    label1.Text = "You are kidnapped and never seen again. Play again?";
                    choice1.Text = "Yes";
                    choice2.Text = "No";
                    pictureBox1.Image = Properties.Resources.kidnapped_ending;
                    break;

                case 5:
                    label1.Text = "You run as you fast as you can but it's not enough. You are caught and taken away. Play Again?";
                        choice1.Text = "Yes";
                    choice2.Text = "No";
                    pictureBox1.Image = Properties.Resources.kidnapped_ending;
                    break;

                case 7:
                    label1.Text = "It is very dark, the only light you see is from the exit.";
                    choice1.Text = "Run for exit";
                    choice2.Text = "Stay put";
                    pictureBox1.Image = Properties.Resources.basement;
                    break;

                case 9:
                    label1.Text = "...";
                    choice1.Text = ":)";
                    choice2.Text = ":)";
                    pictureBox1.Image = null;                   
                    break;

                case 10:
                    label1.Text = "";
                    choice1.Text = "";
                    choice2.Text = "";
                    pictureBox1.Image = Properties.Resources.jumpscare;
                    jumpscareplayer.Play();                   
                    break;





            }


        }

       
        }


        }

        
    

