using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E24105038_Practice4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] button = new Button[16];    //declare button
        Random rnd = new Random();      //declare a random type variable for random int
        int[] savePic = new int[16];    //declare array to save pic index for specific button 
        int[] count = new int[16];          //use 8 only
        int rand;
        int check = -1;
        int countClick = 0;
        int win = 0;
        string username;       //save and output username
        int score;              //save and output score
        int tempScore = 100;
        bool checkUser = false;
        bool checkPressStartFirst = false;      //to prevent the error when the player presses the restart button before he have pressed start button once

        private void buttonStart_Click(object sender, EventArgs e)
        {
            checkPressStartFirst = true;
            int a = 1, b = 0;
            for (int n = 0; n < 16; n++)
            {
                count[n] = 0;       //initialize count
            }
            score = -1;
            username = null;

            if (txtUser.Text == "")
            {
                MessageBox.Show("Username should not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); //(mssg, title, box button, box icon)
            }
            else if(txtUser.Text.Length >=3 && txtUser.Text.Length <= 10)
            {
                checkUser = true;
            }
            else
            {
                MessageBox.Show("Incorrect username format (>=3 && <=10)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if (checkUser == true)      //if the username have been insert correctly, then can proceed to the next step
            {
                for (int n = 0; n < 16; n++)
                {
                    savePic[n] = 0;        //initialize savPic
                    int index = n;
                    button[n] = new Button();           //declare
                    if (n % 4 == 0 && n != 0)     //every four card one row
                    {
                        b = b + 90;     //starting point y
                        a = 1;
                    }

                    button[n].SetBounds(65 * a, 40 + b, 50, 80); //(starting point x, starting point y, width, height)
                    button[n].ImageList = imageList;            //link to imageList(the place that picture saved)
                    button[n].ImageIndex = 8;                   //index of image in imageList
                                                                //button[n].Click += new EventHandler(ButtonClick); //**important      //generate function button click  //link to button_click function
                    button[n].Click += (senders, args) => SomeMethod(button, index);    // ***important //generate function button click  //method1

                    tabPage1.Controls.Add(button[n]);               //**important //add in the tab control *******
                    a++;

                    for (int m = 0; m < 50; m++)        //initialize the pic 
                    {
                        rand = rnd.Next(8); //random 0-7
                        savePic[n] = rand;
                        if (count[savePic[n]] < 2)      //ensure there is no more than 2 same card 
                        {
                            count[savePic[n]]++;
                            break;
                        }
                    }
                }
                for (int n = 0; n < 16; n++)
                {
                    count[n] = 0;       //clear the count in order to use in other place
                }

                if (username == null)
                {
                    username = txtUser.Text;    //save the username, use for print in the history

                }
                
                buttonStart.Enabled = false;
                txtUser.Enabled = false;
            }

        }

        private void SomeMethod(object sender, int index)
        {
            countClick++;
            if (countClick == 2 || countClick == 1)        //only allow to click two times(two cards) for those cards
            {
                win = 0;
                button[index].ImageList = imageList;            //show the picture
                button[index].ImageIndex = savePic[index];
                count[savePic[index]]++;
                if (check == index)      //if the player clicked the same card two times, refresh the countClick to 1 click
                {
                    countClick = 1;
                    count[savePic[index]] = 1;      //refresh the count[] to 1
                }
                if (check == -1)
                {      //to check whether this time index is same as last click, use for judging with the next card
                    check = index;
                }
                if (check != index && count[savePic[index]] == 2 && countClick == 2)   //if the clicked card is not the same card and those cards are the same
                {
                    button[index].Enabled = false;          //two same card have been clicked, then disable it
                    button[check].Enabled = false;
                    tempScore += 10;        //plus 10 points
                    labelScore.Text = "Score: " + tempScore;        //output the score
                }
                else if (countClick == 2 && check != index && count[savePic[check]] == 1 && count[savePic[index]] == 1)      //if the two chosen cards were different
                {
                    buttonCont.Enabled = true;
                    count[savePic[check]] = 0;          //clear the count using check(index)
                    count[savePic[index]] = 0;          //clear the count using index  
                    tempScore -= 5;     //minus 5 points
                    labelScore.Text = "Score: " + tempScore;        //output the score
                }
                if (countClick == 2 && check != index && (count[savePic[check]] == 2 || count[savePic[index]] == 2))     //clicked two same card //refresh everything recording items
                {
                    count[savePic[check]] = 0;          //if the first card is not same as the sec, clear the count using check(index)
                    count[savePic[index]] = 0;          //clear the count using index  
                    countClick = 0;
                    check = -1;
                }
                for (int n = 0; n < 16; n++)        //win judgement
                {
                    if (button[n].Enabled == false && button[n].ImageIndex != 8)
                    {
                        win++;
                    }
                }
                if (win == 16)          //if already win, show message box
                {
                    DialogResult result = MessageBox.Show("Score: " + tempScore, "Game over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);      //DialogResult

                    if (score == -1)    //output score with username at history
                    {
                        score = tempScore;
                        labelHistory.Text += username + " scored: " + score;  //print the current score with username
                        labelHistory.Text += "\n";          //skip a line
                        labelHistory.Text += "\n";          //skip a line
                    }

                    if (result == DialogResult.Retry)        //if the player clicked retry button(function same as restart)
                    {
                        //Button buttonRes = sender as Button;  //can used in sending to the (object sender)
                        //buttonRes_Click(buttonRes,);
                        RestartFunc();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {                                                                       //**important //DialogResult
            DialogResult result = MessageBox.Show("Are you sure you want to leave the game?", "Leaving the game", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //Application.Exit();     //leave
            if (result == DialogResult.OK)              //if the OK button is pressed
            {
                Application.Exit(); //leave
            }
        }

        private void buttonCont_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 16; n++)
            {
                if(button[n].Enabled != false && button[n].ImageIndex != 8)
                {
                    button[n].ImageList = imageList;            //flip back the card
                    button[n].ImageIndex = 8;
                }
            }
            check = -1;
            countClick = 0;     //refresh countclick in order to let the player flip the next two cards
            buttonCont.Enabled = false;         //disable the cont button again
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            RestartFunc();      //restart func
        }
        private void RestartFunc()      //restart func, use func like this //prevent that the argument shall be sent to buttonRes_Click(object sender, EventArgs e)
        {
            labelScore.Text = "Score: 100";
            txtUser.Text = "";
            txtUser.Enabled = true;
            checkUser = false;      //refresh checkUser
            countClick = 0;         //refresh countClick
            tempScore = 100;            //refresh tempScore
            score = -1; //refresh score
            username = null;    //refresh username
            buttonStart.Enabled = true;
            if (checkPressStartFirst == true)       //to prevent the error when the player presses the restart button before he have pressed start button once
            {
                for (int n = 0; n < 16; n++)
                {
                    button[n].Dispose();            //remove and clean up
                    Controls.Remove(button[n]);
                }
            }
        }

        //private void ButtonClick(object sender, EventArgs e)  //button_click from button array //method 2
        //{
        //int rand = rnd.Next(8);     //random 0-7 
        //Button btn = sender as Button;    //***important  //declare a variable in order to do changes to the clicked button
        //btn.ImageList = imageList;
        //btn.ImageIndex = rand;
        //}
    }
}
