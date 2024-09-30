using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 0, loop = 0, startClear = 0, recordM = 0, recordN = 0, checkTop = 0, checkBottom = 0, checkLeft = 0, checkRight = 0, countO = 0, countX = 0, countGame= 0;
            string temp = null;
            char[,] sign = new char[9, 9];      //declare char array

            sign[0, 0] = Convert.ToChar(0);             //declare null
            for (int n = 1; n < 9; n++)               //initialize '1-8'
            {
                sign[n, 0] = Convert.ToChar(n+48);              //49 = 1(asc11 table)
            }
            for (int m = 1; m < 9; m++)               //initialize 'A-H'
            {
                sign[0, m] = Convert.ToChar(m + 64);              //65 = A(asc11 table)
            }
            for (int n= 1; n < 9; n++)               //initialize '-'
            {
                for (int m = 1;m < 9; m++)
                {
                    sign[n, m] = '-';
                }
            }
            while (loop != 1)          //loop
            {
                if (startClear == 1)
                {
                    Console.Clear();
                }
                for (int n = 0; n < 9; n++)               //print out
                {
                    for (int m = 0; m < 9; m++)
                    {
                        Console.Write(sign[n,m] + " ");
                    }
                    Console.WriteLine();
                }
                if (turn == 0)              //check whether which player's turn it is
                {
                    Console.WriteLine("It's Player O's turn Please enter the spot to place the piece:");
                    turn = 1;
                }
                else if (turn == 1)
                {
                    Console.WriteLine("It's Player X's turn Please enter the spot to place the piece:");
                    turn = 0;
                }
                temp = Console.ReadLine();
                for (int m = 1; m < 9; m++)         //check the input alphabet
                {
                    if (sign[0, m] == temp[0])
                    {
                        recordM = m;
                        break;
                    }
                }
                for (int n = 1; n < 9; n++)                 //check the input number
                {
                    if (sign[n, 0] == temp[1])
                    {
                        recordN = n;
                        break;
                    }
                }
                if (turn == 1 && sign[recordN, recordM] == '-')              //when the turn is player O just now  //check whether the place is been placed or not
                {
                    sign[recordN, recordM] = 'O';
                    countGame = countGame + 1;
                }
                else if (turn == 0 && sign[recordN, recordM] == '-')     //when the turn is player X just now //check whether the place is been placed or not
                {
                    sign[recordN, recordM] = 'X';
                    countGame = countGame + 1;
                }
                else if (sign[recordN, recordM] != '-')         //if that place has piece already
                {
                    if(turn == 0){
                        turn = 1;
                    }
                    else if(turn == 1)
                    {
                        turn = 0;
                    }
                    Console.WriteLine("This spot already exists a piece! Press any button to continue");
                    Console.ReadLine();                     //to stop the code until any key was pressed
                }

                for (int n = 1; n < recordN; n++)         //Rules: check vertical(from top)
                {
                    checkTop = 0;
                    if (sign[n, recordM] == sign[recordN,recordM] && checkTop == 0 && sign[n, recordM] != '-')      //check whether the last sign at vertical(from top) equal to the input sign this round
                    {
                        checkTop = 1;
                        break;      //break the for loop
                    }
                    else if (sign[n, recordM] != sign[recordN, recordM] && checkTop == 0 && sign[n, recordM] != '-')
                    {
                        checkTop = 2;
                        break;        //break the for loop
                    }
                }
                for (int n = 8; n > recordN; n--)         //Rules: check vertical(from bottom) 
                {
                    checkBottom = 0;
                    if (sign[n, recordM] == sign[recordN, recordM] && checkBottom == 0 && sign[n, recordM] != '-')      //check whether the last sign at vertical(from bottom) equal to the input sign this round
                    {
                        checkBottom = 1;
                        break;      //break the for loop
                    }
                    else if (sign[n, recordM] != sign[recordN, recordM] && checkBottom == 0 && sign[n, recordM] != '-')
                    {
                        checkBottom = 2;
                        break;        //break the for loop
                    }
                }
                for (int m = 1; m < recordM; m++)         //Rules: check horizontal(from left)
                {
                    checkLeft = 0;
                    if (sign[recordN, m] == sign[recordN, recordM] && checkLeft == 0 && sign[recordN, m] != '-')      //check whether the last sign at horizontal(from left) equal to the input sign this round
                    {
                        checkLeft = 1;
                        break;      //break the for loop
                    }
                    else if (sign[recordN, m] != sign[recordN, recordM] && checkLeft == 0 && sign[recordN, m] != '-')
                    {
                        checkLeft = 2;
                        break;        //break the for loop
                    }
                }
                for (int m = 8; m > recordM; m--)         //Rules: check horizontal(from right) 
                {
                    checkRight = 0;
                    if (sign[recordN, m] == sign[recordN, recordM] && checkRight == 0 && sign[recordN, m] != '-')      //check whether the last sign at horizontal(from right) equal to the input sign this round
                    {
                        checkRight = 1;
                        break;      //break the for loop
                    }
                    else if (sign[recordN, m] != sign[recordN, recordM] && checkRight == 0 && sign[recordN, m] != '-')
                    {
                        checkRight = 2;
                        break;        //break the for loop
                    }
                }
                if(checkTop == 1)
                {
                    for (int n = 1; n < recordN; n++)
                    {
                        if (sign[n, recordM] != sign[recordN, recordM] && sign[n, recordM] != '-')
                        {
                            sign[n, recordM] = sign[recordN, recordM];          //change the pieces that were already "eaten" by the opponent(vertical from top)
                        }
                    }
                }
                if (checkBottom == 1)
                {
                    for (int n = 8; n > recordN; n--)
                    {
                        if (sign[n, recordM] != sign[recordN, recordM] && sign[n, recordM] != '-')
                        {
                            sign[n, recordM] = sign[recordN, recordM];          //change the pieces that were already "eaten" by the opponent(vertical from bottom)
                        }
                    }
                }
                if (checkLeft == 1)
                {
                    for (int m = 1; m < recordM; m++)
                    {
                        if (sign[recordN, m] != sign[recordN, recordM] && sign[recordN, m] != '-')
                        {
                            sign[recordN, m] = sign[recordN, recordM];          //change the pieces that were already "eaten" by the opponent(horizontal from left)
                        }
                    }
                }
                if (checkRight == 1)
                {
                    for (int m = 8; m > recordM; m--)
                    {
                        if (sign[recordN, m] != sign[recordN, recordM] && sign[recordN, m] != '-')
                        {
                            sign[recordN, m] = sign[recordN, recordM];          //change the pieces that were already "eaten" by the opponent(horizontal from right)
                        }
                    }
                }

                if(countGame == 64)             //when the game ends
                {
                    for (int n = 1; n < 9; n++)               //check whether which player wins the game
                    {
                        for (int m = 1; m < 9; m++)
                        {
                            if (sign[n, m] == 'O')
                            {
                                countO = countO + 1;
                            }
                            else if (sign[n, m] == 'X')
                            {
                                countX = countX + 1;
                            }
                        }
                    }
                    Console.Clear();
                    for (int n = 0; n < 9; n++)               //print the finla result
                    {
                        for (int m = 0; m < 9; m++)
                        {
                            Console.Write(sign[n,m] + " ");
                        }
                        Console.WriteLine();
                    }
                    if (countO > countX)
                    {
                        Console.WriteLine("Game over Player O won!");
                    }
                    else if (countO < countX)
                    {
                        Console.WriteLine("Game over Player X won!");
                    }
                    loop = 1;      //stop the while loop
                }
                startClear = 1;
            }
            Console.Read();
        }
    }
}
