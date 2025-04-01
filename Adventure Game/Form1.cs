using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Decisions();
            pictureOutput.BackgroundImage = Properties.Resources.page1;
        }
        //creates variables
        int page = 1;
        Random randGen = new Random();
        int endingNum = 0;
        //keeps track of which endings you have found
        bool ending1 = false;
        bool ending2 = false;
        bool ending3 = false;
        bool ending4 = false;
        bool ending5 = false;
        bool ending6 = false;
        bool ending7 = false;
        bool ending8 = false;
        bool ending9 = false;
        bool ending10 = false;
        bool ending11 = false;
        bool ending12 = false;
        bool ending13 = false;


        private void option1Button_Click(object sender, EventArgs e)
        {
            //if button 1 is clicked go to the specific page #                
            //page 3 instead of page 2 because in the flow chart I put 3 instead of 2.
            //when it asks you to play again, I made button 1 always say yes
            //although it might say different on my flow chart 
            //I thought it would be better for consistency 
            if (page == 1)
            {
                int Chance = randGen.Next(1, 71);
                if (Chance >= 60)
                {
                    page = 6;
                }
                else { page = 3; }

            }
            else if (page == 3)
            {
                page = 5;
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
                page = 9;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 18;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 13;
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
                page = 19;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            //find page information
            Decisions();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //if button 2 is clicked go to the specific page #
            //when it asks you to play again, I made button 2 always say no
            //although it might say different on my flow chart 
            //I thought it would be better for consistency 
            //page 3 instead of page 2 because in the flow chart I put 3 instead of 2.

            if (page == 1)
            {
                page = 7;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 99;
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
                page = 8;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            //find page information
            Decisions();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {//if button 3 is pressed go to certain page#
            if (page == 10)
            {
                page = 12;
            }
            else if (page == 12)
            {
                int Chance = randGen.Next(1, 71);
                if (Chance >= 60)
                {
                    page = 16;
                }
                else { page = 15; }
            }
            //find page information
            Decisions();
        }

        private void Decisions()
        {//tells each page what to do 
            switch (page)
            {
                case 1:
                    //prints page information ie question, options, story, image.
                    outputLabel.Text = "You live in a nice peaceful town and you work at the local police station as a hostage negotiator... you are sleeping peacefully until you are suddenly awaken, there is a knock at the door... ";
                    questionLabel.Text = "What do you do?";
                    option1Label.Text = "Open the door";
                    option2Label.Text = "Tell them to leave";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page1;
                    break;
                case 3:
                    outputLabel.Text = "3 men are standing there, one hits you on the head... you are thrown in the back of a car... you wake up some time later. ";
                    questionLabel.Text = "Do you try to escape? or Do nothing?";
                    option1Label.Text = "Do Nothing";
                    option2Label.Text = "Escape";
                    pictureOutput.BackgroundImage = Properties.Resources.page3;
                    break;
                case 4://ending #13
                    outputLabel.Text = "You manage to get the trunk open... you roll out... although... you head hits a big rock and you bleed out... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page4;
                    //checks to see if the player has entered this ending before and adds one to the ending counter "endingNum"
                    if (ending13 == false)
                    {
                        ending13 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 5://ending #12
                    outputLabel.Text = "You were never heard of again...";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page5;
                    if (ending12 == false)
                    {
                        ending12 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 6://ending #4
                    outputLabel.Text = "3 men are standing one of them hits you one the head... the hit kills you... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page6;
                    if (ending4 == false)
                    {
                        ending4 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 7:
                    outputLabel.Text = "The knocking stops... ";
                    questionLabel.Text = "Do you go to work for the day?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page7;
                    break;
                case 8: //ending #1
                    outputLabel.Text = "Your boss calls you... he says you fired...";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page8;
                    if (ending1 == false)
                    {
                        ending1 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 9:
                    outputLabel.Text = "You go to work... after some time you get a call... there is a situation at the city hall... you head out right away... you find out that the mayor was taken hostage by a group of rioters...  ";
                    questionLabel.Text = "Call in the FBI? or Evaluate your options?";
                    option1Label.Text = "Call in the FBI";
                    option2Label.Text = "Evaluate your options";
                    pictureOutput.BackgroundImage = Properties.Resources.page9;
                    break;
                case 10:
                    outputLabel.Text = "You evaluate your options.";
                    questionLabel.Text = "How do you stop the riot and save the mayor?";
                    option1Label.Text = "Use your own skills";
                    option2Label.Text = "The riot squad";
                    option3Label.Text = "Sniper ";
                    pictureOutput.BackgroundImage = Properties.Resources.page10;
                    break;
                case 11://ending #2
                    outputLabel.Text = "You called the FBI... they are taking over the case... everyone is disappointed in you... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page11;
                    if (ending2 == false)
                    {
                        ending2 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 12:
                    outputLabel.Text = "The sniper has multiple weapon too choose from...";
                    questionLabel.Text = "What should the sniper use";
                    option1Label.Text = "The machine gun";
                    option2Label.Text = "The rocket launcher";
                    option3Label.Text = "The rifle";
                    pictureOutput.BackgroundImage = Properties.Resources.page12;
                    break;
                case 13://ending #7
                    outputLabel.Text = "The sniper uses the machine gun on the rioters somehow not hitting anyone else... the mayor is very grateful, he gives you the key to the city.. the town is very grateful... congratulations you saved everyone";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page13;
                    if (ending7 == false)
                    {
                        ending7 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 14://ending #8
                    outputLabel.Text = "The sniper uses the rocket launcher... the rocket screams by... it hits the city hall destroying it and everyone inside... the town will never forgive you... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page14;
                    if (ending8 == false)
                    {
                        ending8 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 15://ending #5
                    outputLabel.Text = "The sniper takes care of the rioter holding the mayor with precision... it spoked the other rioters, they all scattered and got away... where is the justice, do your job...";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page15;
                    if (ending5 == false)
                    {
                        ending5 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 16://ending #6
                    outputLabel.Text = "The sniper misses and hits the mayor... the town and the mayors family will never forgive you...";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page16;
                    if (ending6 == false)
                    {
                        ending6 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 17://ending #3
                    outputLabel.Text = "The riot squad kicks down the door of the city hall... they get the initial rioters under control... when they go up to the mayors office the rioters hear them coming and kill the mayor...  the town and the mayors family won't ever forgive you... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page16;//same image as page 16
                    if (ending3 == false)
                    {
                        ending3 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 18:
                    outputLabel.Text = "You get on the phone with the leader... they are really upset with the mayor...";
                    questionLabel.Text = "What do you do?";
                    option1Label.Text = "Ask them why";
                    option2Label.Text = "Hang up";
                    option3Label.Text = "";
                    pictureOutput.BackgroundImage = Properties.Resources.page18;
                    break;
                case 19:
                    outputLabel.Text = "They explain to you that the mayor is very corrupt... he has been taking tax payer money and going on expensive vacations... ";
                    questionLabel.Text = "Do you arrest the mayor?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page19;
                    break;
                case 20://ending #9
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                  pictureOutput.BackgroundImage = Properties.Resources.page6;
                    if (ending9 == false)
                    {
                        ending9 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    } 
                    outputLabel.Text = "What are you doing!? ";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "This was your chance to mediate the situation... ";
                    break;
                case 21://ending #11
                    outputLabel.Text = "You angered the rioters... they kill the mayor... the violence spreads... everyone thinks you helped them and you get arrested... ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page16;
                    if (ending11 == false)
                    {
                        ending11 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 22://ending #10
                    outputLabel.Text = "The rioters let you in the city hall... you arrested the mayor... the riot ends... the townspeople find out about the corruption... they are forever thankful... congratulations you stopped the riot and saved the town!  ";
                    questionLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureOutput.BackgroundImage = Properties.Resources.page22;
                    if (ending10 == false)
                    {
                        ending10 = true;
                        endingNum = endingNum + 1;
                        endingLabel.Text = $"Ending's {endingNum}/13";
                    }
                    break;
                case 99:
                    outputLabel.Text = "THANK YOU FOR PLAYING!! :)";
                    questionLabel.Text = "Created by Cole Otten ";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    
                    break;
            }
        }

        
    }
}