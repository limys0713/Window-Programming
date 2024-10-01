using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosenumber = 0, amount = 0, chosenumber2 = 0, totalExpense = 0, temporaryReceiveInput = 0, skipOneLine = 0, amountItem = 0;
            string checkItemName;
            string[] expenseItemName = new string[5];       //declare string array
            double[] expenseItem = new double[5];
            bool check = false;

            for (int j = 0; j <= 4; j++)            //initialize string and double
            {
                expenseItemName[j] = null;
                expenseItem[j] = 0;
            }

            while (chosenumber != 8)
            {
                if(skipOneLine == 1)            //skip one line
                {
                    Console.WriteLine();
                }
                Console.WriteLine("(1)Enter income (2)Enter expense (3)Add item (4)Delete item (5)Calculate the ratio (6)Search expense (7)Balance (8)Leave the program");

                Console.Write("Enter the number to select a function: ");
                chosenumber = Convert.ToInt32(Console.ReadLine());          //Console.ReadLine reads string only
                skipOneLine = 1;    //ensure next loop will skip one line when print out the statement of line 31,33

                switch (chosenumber)
                {
                    case 1:
                        try
                        {                                                                               //try catch block*****
                            Console.Write("Enter income: ");
                            temporaryReceiveInput = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a valid number");
                            break;
                        }
                        if (temporaryReceiveInput < 0)
                        {
                            Console.WriteLine("The income must not be negative");
                        }
                        else if (temporaryReceiveInput >= 0)
                        {
                            amount = amount + temporaryReceiveInput;
                        }
                        break;

                    case 2:
                        if (expenseItemName[0] == null && expenseItemName[1] == null && expenseItemName[2] == null && expenseItemName[3] == null && expenseItemName[4] == null)
                        {
                            Console.WriteLine("Please add an expense item");        //if don't have any expense item
                            break;
                        }
                        amountItem = 0;
                        for (int j = 0; j <= 4; j++)            //show the expense item that already exists
                        {
                            if (expenseItemName[j] != null)
                            {
                                Console.Write("(" + (j + 1) + ")" + expenseItemName[j] + " ");
                                amountItem = amountItem + 1;
                            }
                        }

                        Console.WriteLine("");      //skip a line
                        Console.Write("Enter the number to select a function: ");
                        chosenumber2 = Convert.ToInt32(Console.ReadLine());
                        if (chosenumber2 <= amountItem && chosenumber2 >= 1)             //ensure the chosenumber2 go thru is within 1---amount item 
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
                                if (amount < 0)
                                {
                                    Console.WriteLine("Insufficient deposit");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("This number is not within the range");
                        }
                        break;

                    case 3:
                        if (expenseItemName[0] != null && expenseItemName[1] != null && expenseItemName[2] != null && expenseItemName[3] != null && expenseItemName[4] != null)     //if the item is full, print the statement
                        {
                            Console.WriteLine("You can no longer add more expense items");
                            break;
                        }
                        Console.Write("Enter item name: ");
                        checkItemName = Console.ReadLine();
                        if (checkItemName == expenseItemName[0] || checkItemName == expenseItemName[1] || checkItemName == expenseItemName[2] || checkItemName == expenseItemName[3] || checkItemName == expenseItemName[4])
                        {
                            Console.WriteLine("The expense item already exists");
                            break;
                        }
                        else
                        {
                            if (expenseItemName[0] == null)
                            {
                                expenseItemName[0] = checkItemName;
                                break;
                            }
                            else if (expenseItemName[1] == null)
                            {
                                expenseItemName[1] = checkItemName;
                                break;
                            }
                            else if (expenseItemName[2] == null)
                            {
                                expenseItemName[2] = checkItemName;
                                break;
                            }
                            else if (expenseItemName[3] == null)
                            {
                                expenseItemName[3] = checkItemName;
                                break;
                            }
                            else if (expenseItemName[4] == null)
                            {
                                expenseItemName[4] = checkItemName;
                                break;
                            }
                        }
                        break;
                    case 4:
                        if (expenseItemName[0] == null && expenseItemName[1] == null && expenseItemName[2] == null && expenseItemName[3] == null && expenseItemName[4] == null)
                        {
                            Console.WriteLine("Expenses can no longer be deleted");             //if there is no expenses item that can be deleted
                            break;
                        }
                        else
                        {
                            int n = 0;
                            check = false;
                            Console.Write("Enter the item name: ");
                            checkItemName = Console.ReadLine();
                            for (int j = 0; j <= 4; j++)            //delete an item according to the same name of the item
                            {
                                if (checkItemName == expenseItemName[j])
                                {
                                    check = true;
                                    if (check == true)
                                    {
                                        expenseItemName[j] = null;
                                    }
                                }
                                if (check == true && j != 4)
                                {
                                    expenseItemName[j] = expenseItemName[j + 1];          //To fill up the front string that is null, let the last array of the string be null
                                    if(n == 0)
                                    {
                                        amount = amount + Convert.ToInt32(expenseItem[j]);          //eliminate the expense that was deleted 
                                        n = 1;
                                    }
                                    expenseItem[j] = expenseItem[j + 1];                    //The corresponding expenses are also needed to be move forward
                                }
                            }
                            if(check == true)
                            {
                                expenseItemName[4] = null;          //delete the last name
                                expenseItem[4] = 0;             //delete the last expense
                                totalExpense = Convert.ToInt32(expenseItem[0] + expenseItem[1] + expenseItem[2] + expenseItem[3] + expenseItem[4]);  //renew the total expenses
                            }
                            if (check == false)               //if there is no suitable item name to be deleted
                            {
                                Console.WriteLine("This item does not exist");
                            }
                        }
                        break;

                    case 5:
                        if (totalExpense == 0)      //when total expense = 0, print 0%
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (expenseItemName[j] != null)     //if item name does't exist, don't print that out
                                {
                                    Console.WriteLine("(" + (j + 1) + ")" + expenseItemName[j] + ": 0%");
                                }
                            }
                            break;
                        }
                        else
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (expenseItemName[j] != null)     //if item name does't exist, don't print that out
                                {
                                    Console.WriteLine("(" + (j + 1) + ")" + expenseItemName[j] + ": " + (expenseItem[j] * 100 / totalExpense) + "%");
                                }
                            }
                        }
                        break;

                    case 6:
                        check = false;
                        Console.WriteLine("The current total expense is: " + totalExpense);
                        Console.Write("Enter the item name to check the expense: ");
                        checkItemName = Console.ReadLine();
                        for (int j = 0; j <= 4; j++)
                        {
                            if (checkItemName == expenseItemName[j])     //if item name exists, print the expense of that item
                            {
                                check = true;
                                Console.WriteLine(expenseItemName[j] + ": " + expenseItem[j]);
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("This item does not exist");
                        }
                        break;

                    case 7:
                        Console.WriteLine("The current balance is: " +  amount);
                        break;

                    case 8:
                        chosenumber = 8;
                        break;
                    default:
                        break;
                }
            }
            if(chosenumber != 8)
            {
                Console.Read();         //leave the program when the number 8 was pressed
            }
        }
    }
}
