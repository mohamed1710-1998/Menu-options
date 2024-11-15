using System.ComponentModel.Design;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // creat list
            List<int> list = new List<int>() { 2,4,6,20,30,50,1 };
            Char option = '\0';


            do {

                // print menu
                Console.WriteLine("--------------------- Menu options ---------------------\n\n");
                Console.WriteLine(" P - Print numbers");
                Console.WriteLine(" A - Add numbers");
                Console.WriteLine(" M - Display mean of the numbers");
                Console.WriteLine(" S - Display the smallest number");
                Console.WriteLine(" L - Display the largest number");
                Console.WriteLine(" F - Find number in the list");
                Console.WriteLine(" C - Clear all numbers in the list");
                Console.WriteLine(" I - Sum any two numbers in the list");
                Console.WriteLine(" Q - Quit \n\n");
                option = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.WriteLine("\n");

                if (option == 'P' || option == 'A' || option == 'M' || option == 'S' || option == 'L' || option == 'F' || option == 'C' || option == 'I' || option == 'Q'  )
                {
                    // print numbers
                    if (option == 'P')
                    {
                        if (list.Count > 0)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine($"[{list[i]}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[] - the list is empty");
                        }

                    }
                    // add number
                    if (option == 'A')
                    {
                        int numberToAdd = 0, gitIt = 0;
                        Console.WriteLine("Enter the number to add");
                        numberToAdd = int.Parse(Console.ReadLine());

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (numberToAdd == list[i])
                            {
                                Console.WriteLine("number already have in our list " +
                                    "please enter different number");
                                gitIt++;
                                break;

                            }

                        }
                        if (gitIt == 0)
                        {
                            list.Add(numberToAdd);
                            Console.WriteLine($"{numberToAdd} added");
                        }
                    }
                    // calculate mean
                    if (option == 'M')
                    {
                        if (list.Count > 0)
                        {
                            int sum = 0;
                            double mean = 0;
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                            }
                            mean = sum / list.Count;
                            Console.WriteLine($"mean of the numbers in the list is: {mean}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                    }
                    // smallest number
                    if (option == 'S')
                    {
                        if (list.Count > 0)
                        {
                            int? smallest = null;
                            for (int i = 0 ; i < list.Count - 1; i++)
                            {
                                if (list[i] < list[i + 1])
                                {
                                    if (smallest <= list[i])
                                    {
                                       continue;
                                    }else
                                        smallest = list[i];
                                }
                                else
                                    smallest = list[i + 1];
                            }

                            Console.WriteLine($"the smallest number in the list is: {smallest}");
                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - no data");

                    }
                    // largest number 
                    if (option == 'L')
                    {
                        if (list.Count > 0)
                        {
                            int largest = 0;
                            for (int i = 0; i < list.Count - 1; i++)
                            {
                                if (list[i] > list[i + 1])
                                {
                                    largest = list[i];
                                }
                                else
                                    largest = list[i + 1];
                            }
                            Console.WriteLine($"the largest number in list {largest}");
                        }
                        else
                            Console.WriteLine("Unable to determine the largest number in list - no data");
                    }
                    // search in the list
                    if (option == 'F')
                    {
                        if (list.Count > 0)
                        {
                            int numberToSearch = 0, getIt = 0;

                            Console.WriteLine("enter the number you want to find");
                            numberToSearch = int.Parse(Console.ReadLine());

                            for (int i = 0; i < list.Count; i++)
                            {
                                if (numberToSearch == list[i])
                                {
                                    Console.WriteLine($"your number found in index {i}");
                                    getIt++;
                                    break;
                                }
                            }

                            if (getIt == 0)
                            {
                                Console.WriteLine("Sorry we didnt find your number");
                            }
                        }
                        else
                            Console.WriteLine("Unable to searh in the list - no data");
                    }
                    // clear the list
                    if (option == 'C')
                    {
                        if (list.Count > 0)
                        {
                            list.Clear();
                            Console.WriteLine("List in now clear");
                        }
                        else
                            Console.WriteLine("the list is already cleard");
                    }
                    //add two numbers with their index (bouns)
                    if (option == 'I')
                    {
                        if (list.Count > 0)
                        {

                            int sum = 0;
                            Console.WriteLine($"please enter the first index between 0 to {list.Count - 1}");
                            int index1 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"please enter the second index between 0 to {list.Count - 1}");
                            int index2 = int.Parse(Console.ReadLine());

                            if ((index1 >= 0 && index1 < list.Count) && (index2 >= 0 && index2 < list.Count))
                            {
                                sum = list[index1] + list[index2];
                                Console.WriteLine($"the sum of index1 ({list[index1]}) + index2 ({list[index2]}) = {sum} ");
                            }
                            else
                                Console.WriteLine("you enter wrong index try again!!");
                        }
                        else
                            Console.WriteLine("Sorry this Summation cant be happen - no data");
                    }
                    // Exite the programe
                    if (option == 'Q')
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(" Wrong input please enter one of the menu options again \n ");
                }

            } while (true);



            
            


        }
    }
}
