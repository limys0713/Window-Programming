using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3_2
{
    public partial class Form1 : Form
    {
        //Game stack1, stack2, stack3, stack4;
        public List<int> stacks1 = new List<int>();
        public List<int> stacks2 = new List<int>();
        public List<int> stacks3 = new List<int>();
        public List<int> stacks4 = new List<int>();
        public string temp1, temp2, temp3, temp4;
        public int length1, length2, length3, length4, tempstack;
        int win = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Select")
            {
                labelStatus.Text = "You chose stack 2";
                button1.Text = "place";
                button2.Text = "place";
                button3.Text = "place";
                button4.Text = "place";
                if (length1 != 4)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                if (length2 != 4)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                if (length3 != 4)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (length4 != 4)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
                tempstack = stacks2[length2 - 1];
                stacks2.RemoveAt(length2 - 1);            //remove the specific item using index
                length2 = stacks2.Count;
            }
            else if (button2.Text == "place")
            {
                stacks2.Add(tempstack);         //add the number that are placed
                length2 = stacks2.Count;            //place at stack2, so the length shall be counted to have the right output
                labelStatus.Text = "...";
                button1.Text = "Select";
                button2.Text = "Select";
                button3.Text = "Select";
                button4.Text = "Select";
                labelShow1.Text = "";
                labelShow2.Text = "";
                labelShow3.Text = "";
                labelShow4.Text = "";
                if (length1 != 0)
                {
                    for (int n = length1 - 1; n >= 0; n--)        //output on label from bottom to top
                    {
                        labelShow1.Text += Convert.ToString(stacks1[n]);
                        labelShow1.Text += "\n";
                    }
                }
                else
                {
                    labelShow1.Text += "";
                }
                if (length2 != 0)
                {
                    for (int n = length2 - 1; n >= 0; n--)
                    {
                        labelShow2.Text += Convert.ToString(stacks2[n]);
                        labelShow2.Text += "\n";
                    }
                }
                else
                {
                    labelShow2.Text += "";
                }
                if (length3 != 0)
                {
                    for (int n = length3 - 1; n >= 0; n--)
                    {

                        labelShow3.Text += Convert.ToString(stacks3[n]);
                        labelShow3.Text += "\n";
                    }
                }
                else
                {
                    labelShow3.Text += "";
                }
                if (length4 != 0)
                {
                    for (int n = length4 - 1; n >= 0; n--)
                    {
                        labelShow4.Text += Convert.ToString(stacks4[n]);
                        labelShow4.Text += "\n";
                    }
                }
                else
                {
                    labelShow4.Text += "";
                }

                if (length1 == 0)           //check whether the length is zero, if is, enabled = false
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (length2 == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (length3 == 0)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (length4 == 0)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }

                if((length1 == 3 && length2 == 3 && length3 == 3) || (length1 == 3 && length2 == 3 && length4 == 3) || (length1 == 3 && length3 == 3 && length4 == 3) || (length2 == 3 && length3 == 3 && length4 == 3)) //win judgement
                {
                    win = 0;
                    //for(int n = 2; n >= 0; n--)
                    //{
                        if(length1 != 0)
                        {
                            if(stacks1[0] == stacks1[1] && stacks1[1] == stacks1[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }        
                        }
                    if (length2 != 0)
                    {
                        if (stacks2[0] == stacks2[1] && stacks2[1] == stacks2[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length3 != 0)
                    {
                        if (stacks3[0] == stacks3[1] && stacks3[1] == stacks3[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length4 != 0)
                    {
                        if (stacks4[0] == stacks4[1] && stacks4[1] == stacks4[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    //}
                }

                if (win == 3)           //if win
                {
                    labelStatus.Text = "You won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Select")
            {
                labelStatus.Text = "You chose stack 3";
                button1.Text = "place";
                button2.Text = "place";
                button3.Text = "place";
                button4.Text = "place";
                if (length1 != 4)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                if (length2 != 4)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                if (length3 != 4)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (length4 != 4)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
                tempstack = stacks3[length3 - 1];
                stacks3.RemoveAt(length3 - 1);            //remove the specific item using index
                length3 = stacks3.Count;
            }
            else if(button3.Text == "place")
            {
                stacks3.Add(tempstack);         //add the number that are placed
                length3 = stacks3.Count;
                labelStatus.Text = "...";
                button1.Text = "Select";
                button2.Text = "Select";
                button3.Text = "Select";
                button4.Text = "Select";
                labelShow1.Text = "";
                labelShow2.Text = "";
                labelShow3.Text = "";
                labelShow4.Text = "";
                if (length1 != 0)
                {
                    for (int n = length1 - 1; n >= 0; n--)        //output on label from bottom to top
                    {
                        labelShow1.Text += Convert.ToString(stacks1[n]);
                        labelShow1.Text += "\n";
                    }
                }
                else
                {
                    labelShow1.Text += "";
                }
                if (length2 != 0)
                {
                    for (int n = length2 - 1; n >= 0; n--)
                    {
                        labelShow2.Text += Convert.ToString(stacks2[n]);
                        labelShow2.Text += "\n";
                    }
                }
                else
                {
                    labelShow2.Text += "";
                }
                if (length3 != 0)
                {
                    for (int n = length3 - 1; n >= 0; n--)
                    {

                        labelShow3.Text += Convert.ToString(stacks3[n]);
                        labelShow3.Text += "\n";
                    }
                }
                else
                {
                    labelShow3.Text += "";
                }
                if (length4 != 0)
                {
                    for (int n = length4 - 1; n >= 0; n--)
                    {
                        labelShow4.Text += Convert.ToString(stacks4[n]);
                        labelShow4.Text += "\n";
                    }
                }
                else
                {
                    labelShow4.Text += "";
                }

                if (length1 == 0)           //check whether the length is zero, if is, enabled = false
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (length2 == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (length3 == 0)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (length4 == 0)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }

                if ((length1 == 3 && length2 == 3 && length3 == 3) || (length1 == 3 && length2 == 3 && length4 == 3) || (length1 == 3 && length3 == 3 && length4 == 3) || (length2 == 3 && length3 == 3 && length4 == 3)) //win judgement
                {
                    win = 0;
                    //for(int n = 2; n >= 0; n--)
                    //{
                    if (length1 != 0)
                    {
                        if (stacks1[0] == stacks1[1] && stacks1[1] == stacks1[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length2 != 0)
                    {
                        if (stacks2[0] == stacks2[1] && stacks2[1] == stacks2[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length3 != 0)
                    {
                        if (stacks3[0] == stacks3[1] && stacks3[1] == stacks3[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length4 != 0)
                    {
                        if (stacks4[0] == stacks4[1] && stacks4[1] == stacks4[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    //}
                }

                if (win == 3)           //if win
                {
                    labelStatus.Text = "You won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Select")
            {
                labelStatus.Text = "You chose stack 4";
                button1.Text = "place";
                button2.Text = "place";
                button3.Text = "place";
                button4.Text = "place";
                if (length1 != 4)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                if (length2 != 4)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                if (length3 != 4)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (length4 != 4)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
                tempstack = stacks4[length4 - 1];
                stacks4.RemoveAt(length4 - 1);            //remove the specific item using index
                length4 = stacks4.Count;
            }
            else if (button4.Text == "place")
            {
                stacks4.Add(tempstack);         //add the number that are placed
                length4 = stacks4.Count;
                labelStatus.Text = "...";
                button1.Text = "Select";
                button2.Text = "Select";
                button3.Text = "Select";
                button4.Text = "Select";
                labelShow1.Text = "";
                labelShow2.Text = "";
                labelShow3.Text = "";
                labelShow4.Text = "";
                if (length1 != 0)
                {
                    for (int n = length1 - 1; n >= 0; n--)        //output on label from bottom to top
                    {
                        labelShow1.Text += Convert.ToString(stacks1[n]);
                        labelShow1.Text += "\n";
                    }
                }
                else
                {
                    labelShow1.Text += "";
                }
                if (length2 != 0)
                {
                    for (int n = length2 - 1; n >= 0; n--)
                    {
                        labelShow2.Text += Convert.ToString(stacks2[n]);
                        labelShow2.Text += "\n";
                    }
                }
                else
                {
                    labelShow2.Text += "";
                }
                if (length3 != 0)
                {
                    for (int n = length3 - 1; n >= 0; n--)
                    {

                        labelShow3.Text += Convert.ToString(stacks3[n]);
                        labelShow3.Text += "\n";
                    }
                }
                else
                {
                    labelShow3.Text += "";
                }
                if (length4 != 0)
                {
                    for (int n = length4 - 1; n >= 0; n--)
                    {
                        labelShow4.Text += Convert.ToString(stacks4[n]);
                        labelShow4.Text += "\n";
                    }
                }
                else
                {
                    labelShow4.Text += "";
                }

                if (length1 == 0)           //check whether the length is zero, if is, enabled = false
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (length2 == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (length3 == 0)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (length4 == 0)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }

                if ((length1 == 3 && length2 == 3 && length3 == 3) || (length1 == 3 && length2 == 3 && length4 == 3) || (length1 == 3 && length3 == 3 && length4 == 3) || (length2 == 3 && length3 == 3 && length4 == 3)) //win judgement
                {
                    win = 0;
                    //for(int n = 2; n >= 0; n--)
                    //{
                    if (length1 != 0)
                    {
                        if (stacks1[0] == stacks1[1] && stacks1[1] == stacks1[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length2 != 0)
                    {
                        if (stacks2[0] == stacks2[1] && stacks2[1] == stacks2[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length3 != 0)
                    {
                        if (stacks3[0] == stacks3[1] && stacks3[1] == stacks3[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length4 != 0)
                    {
                        if (stacks4[0] == stacks4[1] && stacks4[1] == stacks4[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    //}
                }

                if (win == 3)           //if win
                {
                    labelStatus.Text = "You won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Select")
            {
                labelStatus.Text = "You chose stack 1";
                button1.Text = "place";
                button2.Text = "place";
                button3.Text = "place";
                button4.Text = "place";
                if (length1 != 4)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                if (length2 != 4)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                if (length3 != 4)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (length4 != 4)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
                tempstack = stacks1[length1 - 1];
                stacks1.RemoveAt(length1-1);            //remove the specific item using index
                length1 = stacks1.Count;
            }
            else if (button1.Text == "place")
            {
                stacks1.Add(tempstack);         //add the number that are placed
                length1 = stacks1.Count;
                labelStatus.Text = "...";
                button1.Text = "Select";
                button2.Text = "Select";
                button3.Text = "Select";
                button4.Text = "Select";
                labelShow1.Text = "";
                labelShow2.Text = "";
                labelShow3.Text = "";
                labelShow4.Text = "";
                if (length1 != 0)
                {
                    for (int n = length1 - 1; n >= 0; n--)        //output on label from bottom to top
                    {
                        labelShow1.Text += Convert.ToString(stacks1[n]);
                        labelShow1.Text += "\n";
                    }
                }
                else
                {
                    labelShow1.Text += "";
                }
                if (length2 != 0)
                {
                    for (int n = length2 - 1; n >= 0; n--)
                    {
                        labelShow2.Text += Convert.ToString(stacks2[n]);
                        labelShow2.Text += "\n";
                    }
                }
                else
                {
                    labelShow2.Text += "";
                }
                if (length3 != 0)
                {
                    for (int n = length3 - 1; n >= 0; n--)
                    {

                        labelShow3.Text += Convert.ToString(stacks3[n]);
                        labelShow3.Text += "\n";
                    }
                }
                else
                {
                    labelShow3.Text += "";
                }
                if (length4 != 0)
                {
                    for (int n = length4 - 1; n >= 0; n--)
                    {
                        labelShow4.Text += Convert.ToString(stacks4[n]);
                        labelShow4.Text += "\n";
                    }
                }
                else
                {
                    labelShow4.Text += "";
                }

                if (length1 == 0)           //check whether the length is zero, if is, enabled = false
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (length2 == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (length3 == 0)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (length4 == 0)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }

                if ((length1 == 3 && length2 == 3 && length3 == 3) || (length1 == 3 && length2 == 3 && length4 == 3) || (length1 == 3 && length3 == 3 && length4 == 3) || (length2 == 3 && length3 == 3 && length4 == 3)) //win judgement
                {
                    win = 0;
                    //for(int n = 2; n >= 0; n--)
                    //{
                    if (length1 != 0)
                    {
                        if (stacks1[0] == stacks1[1] && stacks1[1] == stacks1[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length2 != 0)
                    {
                        if (stacks2[0] == stacks2[1] && stacks2[1] == stacks2[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length3 != 0)
                    {
                        if (stacks3[0] == stacks3[1] && stacks3[1] == stacks3[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    if (length4 != 0)
                    {
                        if (stacks4[0] == stacks4[1] && stacks4[1] == stacks4[2])        //check whether the three int is same
                        {
                            win = win + 1;
                        }
                    }
                    //}
                }

                if (win == 3)           //if win
                {
                    labelStatus.Text = "You won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        public string[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //tempstack = 0;
            button1.Text = "Select";
            button2.Text = "Select";
            button3.Text = "Select";
            button4.Text = "Select";
            labelStatusMenu.Text = "Status";
            labelStatusMenu.Enabled = true;
            labelStatusMenu.Visible = true;
            label1Menu.Enabled = true;
            label1Menu.Visible = true;
            label2Menu.Enabled = true;
            label2Menu.Visible = true;
            label3Menu.Enabled = true;
            label3Menu.Visible = true;
            label4Menu.Enabled = true;
            label4Menu.Visible = true;
            txtMenu1.Enabled = true;
            txtMenu1.Visible = true;
            txtMenu2.Enabled = true;
            txtMenu2.Visible = true;
            txtMenu3.Enabled = true;
            txtMenu3.Visible = true;
            txtMenu4.Enabled = true;
            txtMenu4.Visible = true;
            buttonStart.Enabled = true;
            buttonStart.Visible = true;

            label1.Enabled = false;
            label1.Visible = false;
            label2.Enabled = false;
            label2.Visible = false;
            label3.Enabled = false;
            label3.Visible = false;
            label4.Enabled = false;
            label4.Visible = false;
            labelShow1.Enabled = false;
            labelShow1.Visible = false;
            labelShow2.Enabled = false;
            labelShow2.Visible = false;
            labelShow3.Enabled = false;
            labelShow3.Visible = false;
            labelShow4.Enabled = false;
            labelShow4.Visible = false;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            labelStatus.Enabled = false;
            labelStatus.Visible = false;
            buttonMenu.Enabled = false;
            buttonMenu.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            win = 0;
            labelStatus.Text = "...";
            labelStatusMenu.Text = "Status";
            labelShow1.Text = "";   //clear the label
            labelShow2.Text = "";
            labelShow3.Text = "";
            labelShow4.Text = "";
            stacks1.Clear();        //clear the list
            stacks2.Clear();
            stacks3.Clear();
            stacks4.Clear();
            
            try
            {
                temp1 = txtMenu1.Text;
                temp2 = txtMenu2.Text;
                temp3 = txtMenu3.Text;
                temp4 = txtMenu4.Text;

                if (temp1 != "")
                {
                    numbers = temp1.Split(' ');

                    foreach (string num in numbers)      //save the number insert into the list
                    {
                        stacks1.Add(int.Parse(num));
                    }
                    length1 = stacks1.Count;
                }
                else
                {
                    length1 = 0;
                    labelShow1.Text += "";
                }

                if (temp2 != "")
                {
                    numbers = temp2.Split(' ');
                    foreach (string num in numbers)
                    {
                        stacks2.Add(int.Parse(num));
                    }
                    length2 = stacks2.Count;
                }
                else
                {
                    length2 = 0;
                    labelShow2.Text += "";
                }

                if (temp3 != "")
                {
                    numbers = temp3.Split(' ');
                    foreach (string num in numbers)
                    {
                        stacks3.Add(int.Parse(num));
                    }
                    length3 = stacks3.Count;
                }
                else
                {
                    length3 = 0;
                    labelShow3.Text += "";
                }

                if (temp4 != "")
                {
                    numbers = temp4.Split(' ');
                    foreach (string num in numbers)
                    {
                        stacks4.Add(int.Parse(num));
                    }
                    length4 = stacks4.Count;
                }
                else
                {
                    length4 = 0;
                    labelShow4.Text += "";
                }
            }
            catch
            {
                labelStatusMenu.Text = "Incorrect online judge";
            }

                if ((length1 + length2 + length3 + length4) == 9 && length1 <= 4 && length2 <= 4 && length3 <= 4 && length4 <= 4 && labelStatusMenu.Text != "Incorrect online judge")       //menu insert judgement
                {
                    if (length1 != 0)
                    {
                        for (int n = length1 - 1; n >= 0; n--)        //output on label from bottom to top
                        {
                            labelShow1.Text += Convert.ToString(stacks1[n]);
                            labelShow1.Text += "\n";
                        }
                    }
                    if (length2 != 0)
                    {
                        for (int n = length2 - 1; n >= 0; n--)
                        {
                            labelShow2.Text += Convert.ToString(stacks2[n]);
                            labelShow2.Text += "\n";
                        }
                    }
                    if (length3 != 0)
                    {
                        for (int n = length3 - 1; n >= 0; n--)
                        {

                            labelShow3.Text += Convert.ToString(stacks3[n]);
                            labelShow3.Text += "\n";
                        }
                    }
                    if (length4 != 0)
                    {
                        for (int n = length4 - 1; n >= 0; n--)
                        {
                            labelShow4.Text += Convert.ToString(stacks4[n]);
                            labelShow4.Text += "\n";
                        }
                    }

                    labelStatusMenu.Enabled = false;
                    labelStatusMenu.Visible = false;
                    label1Menu.Enabled = false;
                    label1Menu.Visible = false;
                    label2Menu.Enabled = false;
                    label2Menu.Visible = false;
                    label3Menu.Enabled = false;
                    label3Menu.Visible = false;
                    label4Menu.Enabled = false;
                    label4Menu.Visible = false;
                    txtMenu1.Enabled = false;
                    txtMenu1.Visible = false;
                    txtMenu2.Enabled = false;
                    txtMenu2.Visible = false;
                    txtMenu3.Enabled = false;
                    txtMenu3.Visible = false;
                    txtMenu4.Enabled = false;
                    txtMenu4.Visible = false;
                    buttonStart.Enabled = false;
                    buttonStart.Visible = false;

                    label1.Enabled = true;
                    label1.Visible = true;
                    label2.Enabled = true;
                    label2.Visible = true;
                    label3.Enabled = true;
                    label3.Visible = true;
                    label4.Enabled = true;
                    label4.Visible = true;
                    labelShow1.Enabled = true;
                    labelShow1.Visible = true;
                    labelShow2.Enabled = true;
                    labelShow2.Visible = true;
                    labelShow3.Enabled = true;
                    labelShow3.Visible = true;
                    labelShow4.Enabled = true;
                    labelShow4.Visible = true;
                    button1.Enabled = true;
                    button1.Visible = true;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = true;
                    button3.Visible = true;
                    button4.Enabled = true;
                    button4.Visible = true;
                    labelStatus.Enabled = true;
                    labelStatus.Visible = true;
                    buttonMenu.Enabled = true;
                    buttonMenu.Visible = true;
                if(length1 == 0)
                {
                    button1.Enabled = false;
                }
                if (length2 == 0)
                {
                    button2.Enabled = false;
                }
                if (length3 == 0)
                {
                    button3.Enabled = false;
                }
                if(length4 == 0)
                {
                    button4.Enabled = false;
                }
            }
                else if (length1 > 4 || length2 > 4 || length3 > 4 || length4 > 4 && labelStatusMenu.Text != "Incorrect online judge")
                {
                    labelStatusMenu.Text = "Incorrect online judge";
                }
            else
            {
                labelStatusMenu.Text = "Incorrect online judge";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
