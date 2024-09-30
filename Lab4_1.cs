using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E24105038_Practice_4_1
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
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int a = 1, b = 1;
            for (int n = 0; n < 16; n++)
            {
                count[n] = 0;       //initialize count
            }
            for (int n = 0; n < 16; n++)
            {
                savePic[n] = 0;        //initialize savPic
                int index = n;
                button[n] = new Button();           //declare
                if (n % 4 == 0 && n != 0)     //every four card one row
                {
                    b = b + 2;
                    a = 1;
                }
                button[n].SetBounds(65 * a, 40 * b, 50, 80); //(starting point x, starting point y, width, height)
                button[n].ImageList = imageList;            //link to imageList(the place that picture saved)
                button[n].ImageIndex = 8;                   //index of image in imageList
                //button[n].Click += new EventHandler(ButtonClick); //**important      //generate function button click  //link to button_click function
                button[n].Click += (senders, args) => SomeMethod(button, index);    // ***important //generate function button click  //method1

                Controls.Add(button[n]);
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
            buttonStart.Enabled = false;

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
                }
                else if (countClick == 2 && check != index && count[savePic[check]] == 1 && count[savePic[index]] == 1)      //if the two chosen cards were different
                {
                    buttonCont.Enabled = true;
                    count[savePic[check]] = 0;          //clear the count using check(index)
                    count[savePic[index]] = 0;          //clear the count using index  
                }
                if (countClick == 2 && check != index && (count[savePic[check]] == 2 || count[savePic[index]] == 2))     //clicked two card 
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
                    MessageBox.Show("You won!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();     //leave
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

        //private void ButtonClick(object sender, EventArgs e)  //button_click from button array //method 2
        //{
        //int rand = rnd.Next(8);     //random 0-7 
        //Button btn = sender as Button;    //***important  //declare a variable in order to do changes to the clicked button
        //btn.ImageList = imageList;
        //btn.ImageIndex = rand;
        //}
    }
}
