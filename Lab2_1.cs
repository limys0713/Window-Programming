using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosenumber = 0, index1 = 0, index2 = 0, index3 = 0, index4 = 0, index5 = 0, index6 = 0, index7 = 0, index8 = 0, index9 = 0, credit = 0, count = 0, blankLine = 0;
            string temp = null, temp1 = null;
            string[,] courseInfo = new string[8, 7];   //declare 2d array format
            string[] courseID = new string[20];
            bool check = false;

            for(int n=0; n < 8; n++)               //initialize 2d string
            {
                for(int m = 0; m < 7; m++)
                {
                    courseInfo[n, m] = null;
                }
            }

            for(int n = 0; n < 20; n++)     //initialize 1d string
            {
                courseID[n] = null;
            }

            while (chosenumber != 5)
            {
                if (blankLine == 1)
                {
                    Console.WriteLine();
                }
                blankLine = 1;
                Console.WriteLine("(1)Add course (2)Delete course (3)Print class schedule (4)Calculate credits (5)Leave program");
                Console.Write("Insert a number to select a function: ");
                chosenumber = int.Parse(Console.ReadLine());
                switch (chosenumber)
                {
                    case 1:
                        count = 0;
                        check = false;
                        Console.WriteLine("Please enter the course to add, the format is <course ID Day of the week Start End> ");
                        temp = Console.ReadLine();
                        temp1 = temp.Substring(0, 5);       //Substring(from the specific index, how many)
                        index1 = temp[6]-49;               //day of the week                    //from asc11 char '0' = 48 , and it is an array too, so minus 49
                        index2 = temp[8]-49;               //start of the class period
                        index3 = temp[10]-49;                  //end of the class period
                        for (int n = 0; n < 20; n++)               //check whether has repeated course
                        {
                           if(courseID[n] == temp1)
                            {
                                Console.WriteLine("repeated course!");
                                check = true;
                                break;  //break the for loop
                            }
                        }
                        if(check == true)       //if repeated course was printed, then break the switch function
                        {
                            break;
                        }
                        if ((index3 - index2) == 2)     //3 class period
                        {
                            index4 = index2 + 1;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else if ((index3 - index2) == 3)        //4 class period
                        {
                            index4 = index2 + 1;
                            index5 = index2 + 2;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null || courseInfo[index5, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else if ((index3 - index2) == 4)        //5 class period
                        {
                            index4 = index2 + 1;
                            index5 = index2 + 2;
                            index6 = index2 + 3;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null || courseInfo[index5, index1] != null || courseInfo[index6, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else if ((index3 - index2) == 5)        //6 class period
                        {
                            index4 = index2 + 1;
                            index5 = index2 + 2;
                            index6 = index2 + 3;
                            index7 = index2 + 4;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null || courseInfo[index5, index1] != null || courseInfo[index6, index1] != null || courseInfo[index7, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else if ((index3 - index2) == 6)        //7 class period
                        {
                            index4 = index2 + 1;
                            index5 = index2 + 2;
                            index6 = index2 + 3;
                            index7 = index2 + 4;
                            index8 = index2 + 5;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null || courseInfo[index5, index1] != null || courseInfo[index6, index1] != null || courseInfo[index7, index1] != null || courseInfo[index8, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else if ((index3 - index2) == 7)        //8 class period
                        {
                            index4 = index2 + 1;
                            index5 = index2 + 2;
                            index6 = index2 + 3;
                            index7 = index2 + 4;
                            index8 = index2 + 5;
                            index9 = index2 + 6;
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null || courseInfo[index4, index1] != null || courseInfo[index5, index1] != null || courseInfo[index6, index1] != null || courseInfo[index7, index1] != null || courseInfo[index8, index1] != null || courseInfo[index9, index1] != null)
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        else
                        {
                            if (courseInfo[index2, index1] != null || courseInfo[index3, index1] != null)           //1 and 2 class period
                            {
                                Console.WriteLine("course conflict!");
                                break;
                            }
                        }
                        for (int n = 0; n < 20; n++)
                        {
                            if (courseID[n] == null && count == 0)                   //save the course name 
                            {
                                courseID[n] = temp1;
                                count = 1;
                            }
                        }
                        courseInfo[index2, index1] = temp1;             //insert in the class schedule
                        courseInfo[index3, index1] = temp1;                //insert in the class schedule
                        if (index2 == index3)
                        {
                            credit = credit + 1;
                        }
                        else
                        {
                            credit = credit + 2;
                        }
                        if ((index3 - index2) == 2)         //if the duration of the class period is 3
                        {
                            courseInfo[index4, index1] = temp1;
                            credit++;
                        }
                        if ((index3 - index2) == 3)         //if the duration of the class period is 4
                        {
                            courseInfo[index4, index1] = temp1;
                            courseInfo[index5, index1] = temp1;
                            credit = credit + 2;
                        }
                        if ((index3 - index2) == 4)         //if the duration of the class period is 5
                        {
                            courseInfo[index4, index1] = temp1;
                            courseInfo[index5, index1] = temp1;
                            courseInfo[index6, index1] = temp1;
                            credit = credit + 3;
                        }
                        if ((index3 - index2) == 5)         //if the duration of the class period is 6
                        {
                            courseInfo[index4, index1] = temp1;
                            courseInfo[index5, index1] = temp1;
                            courseInfo[index6, index1] = temp1;
                            courseInfo[index7, index1] = temp1;
                            credit = credit + 4;
                        }
                        if ((index3 - index2) == 6)         //if the duration of the class period is 7
                        {
                            courseInfo[index4, index1] = temp1;
                            courseInfo[index5, index1] = temp1;
                            courseInfo[index6, index1] = temp1;
                            courseInfo[index7, index1] = temp1;
                            courseInfo[index8, index1] = temp1;
                            credit = credit + 5;
                        }
                        if ((index3 - index2) == 7)         //if the duration of the class period is 8
                        {
                            courseInfo[index4, index1] = temp1;
                            courseInfo[index5, index1] = temp1;
                            courseInfo[index6, index1] = temp1;
                            courseInfo[index7, index1] = temp1;
                            courseInfo[index8, index1] = temp1;
                            courseInfo[index9, index1] = temp1;
                            credit = credit + 6;
                        }
                        Console.WriteLine("add the course successfully!");
                        break;

                    case 2:
                        count = 0;
                        check = false;
                        Console.Write("Please enter the course ID to delete: ");
                        temp = Console.ReadLine();
                        for (int n = 0; n < 20; n++)               //find the specific course to delete
                        {
                            if (courseID[n] == temp)
                            {
                                check = true;
                                if(count == 0)
                                {
                                    Console.WriteLine("Course deleted successfully: "+ courseID[n]);
                                    count = 1;                      //in order to let line 107 be printed one time
                                }
                                courseID[n] = null;         //delete the courseID
                            }
                            if (check == true && n != 19)
                            {
                                courseID[n] = courseID[n + 1];          
                            }
                        }
                        if (check == true)
                        {
                            for (int n = 0; n < 8; n++)              
                            {
                                for (int m = 0; m < 7; m++)
                                {
                                    if (courseInfo[n, m] == temp)
                                    {
                                        courseInfo[n, m] = null;            //delete the course in class schedule
                                        credit--;
                                    }
                                }
                            }
                        }
                        else                   //if check = false 
                        {
                            Console.WriteLine("Course " + temp + " is not in the class schedule");
                        }
                        break;

                    case 3:
                        temp=String.Format("{0,-6} {1,-6} {2,-6} {3,-6} {4,-6} {5,-6} {6,-6} {7,-6}", "", "Sun", "Mon", "Tue", "Wed", "Thu" , "Fri", "Sat", "Sun");     //string format //"{no. , (-)left+how many blank space}",string
                        Console.WriteLine(temp);
                        for (int n = 0; n < 8; n++)               //initialize 2d string
                        {
                            temp = String.Format("{0,-6} {1,-6} {2,-6} {3,-6} {4,-6} {5,-6} {6,-6} {7,-6}", n+1, courseInfo[n, 6] , courseInfo[n, 0], courseInfo[n, 1], courseInfo[n, 2], courseInfo[n, 3], courseInfo[n, 4], courseInfo[n, 5]);
                            Console.WriteLine(temp);
                        }

                        break;

                    case 4:
                        Console.WriteLine(credit);
                        break;

                    case 5:
                        chosenumber = 5;        //in order to leave the program
                        break;

                    default:
                        break;
                }
            }

            if (chosenumber != 5)
            {
                Console.Read();
            }
        }
    }
}
