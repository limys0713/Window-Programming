using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosenumber=0, amount=0, chosenumber2=0, totalExpense=0, temporaryReceiveInput = 0, skipOneLine = 0;
            double[] expenseItem = new double[5];

            for (int j = 0; j <= 4; j++)            //initialize double
            {
                expenseItem[j] = 0;
            }

            while (chosenumber != 5)
            {
                if (skipOneLine == 1)            //skip one line
                {
                    Console.WriteLine();
                }
                Console.WriteLine("(1)Enter income (2)Enter expense (3)Calculate the ratio (4)Balance (5)Leave the program");

                Console.Write("Enter the number to select a function: ");
                chosenumber = Convert.ToInt32(Console.ReadLine());          //Console.ReadLine reads string only
                skipOneLine = 1;
                switch (chosenumber)
                {
                    case 1:
                        Console.Write("Enter income: ");
                        temporaryReceiveInput = Convert.ToInt32(Console.ReadLine());
                        if (temporaryReceiveInput >= 0)             //to ensure the income input is positive integers, negative integers will not affect the balance
                        {
                            amount = amount + temporaryReceiveInput;
                        }
                            break;
                    case 2:
                        Console.WriteLine("(1)Food (2)Clothing (3)Accommodation (4)Transportation (5)Education with entertainment");
                        Console.Write("Enter the number to select a function: ");
                        chosenumber2 = Convert.ToInt32(Console.ReadLine());
                        if (chosenumber2 <= 5 && chosenumber2 >= 1)         //ensure the chosenumber2 go thru is within 1-5
                        {
                            Console.Write("Enter expense amount: ");
                            temporaryReceiveInput = Convert.ToInt32(Console.ReadLine());
                            if (temporaryReceiveInput >= 0)             //to ensure the expense input is positive integers
                            {
                                amount = amount - temporaryReceiveInput;
                                switch (chosenumber2)
                                {
                                    case 1:
                                        expenseItem[0] = expenseItem[0] + temporaryReceiveInput;
                                        break;
                                    case 2:
                                        expenseItem[1] = expenseItem[1] + temporaryReceiveInput;
                                        break;
                                    case 3:
                                        expenseItem[2] = expenseItem[2] + temporaryReceiveInput;
                                        break;
                                    case 4:
                                        expenseItem[3] = expenseItem[3] + temporaryReceiveInput;
                                        break;
                                    case 5:
                                        expenseItem[4] = expenseItem[4] + temporaryReceiveInput;
                                        break;
                                }
                                totalExpense = Convert.ToInt32(expenseItem[0] + expenseItem[1] + expenseItem[2] + expenseItem[3] + expenseItem[4]);
                            }
                        }
                        break;
                    case 3:
                        if (totalExpense == 0)
                        {
                            Console.WriteLine("Food: 0%");
                            Console.WriteLine("Clothing: 0%");
                            Console.WriteLine("Accommodation: 0%");
                            Console.WriteLine("Transportation: 0%");
                            Console.WriteLine("Education with entertainment: 0%");
                        }
                        else
                        {
                            Console.WriteLine("Food: " + (expenseItem[0] * 100 / totalExpense) + "%");
                            Console.WriteLine("Clothing: " + (expenseItem[1] * 100 / totalExpense) + "%");
                            Console.WriteLine("Accommodation: " + (expenseItem[2] * 100 / totalExpense) + "%");
                            Console.WriteLine("Transportation: " + (expenseItem[3] * 100 / totalExpense) + "%");
                            Console.WriteLine("Education with entertainment: " + (expenseItem[4] * 100 / totalExpense) + "%");
                        }
                        break;
                    case 4:
                        Console.WriteLine("The current balance is: " + amount);
                        break;
                    case 5:
                        chosenumber = 5;
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
