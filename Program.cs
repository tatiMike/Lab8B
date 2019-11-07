using System;



namespace Lab8Validate

{

    class Program

    {

        static void Main(string[] args)

        {
            string[] students = {

                "",

                "Mike",

                "Brittany",

                "Mark",

                "Katie",

                "Molly",

                "Jon",

                "Dave",

                "Julie",

                "Andrea",

                "Joe",

                "Jordan",

                "Sean",

                "Evan",

                "Luke",

                "Frie",

                "Jeremy",

                "Nick",

                "Rachel",

                "Will",

                "Hunter"
            };

            string[] food = {

                "",

                "Pizza",

                "Pasta",

                "Burgers",

                "Brats",

                "Nachos",

                "Chicken",

                "Steak",

                "Pulled Pork",

                "BLT",

                "PB&J",

                "Ice Cream",

                "Fish",

                "Kilbasa",

                "Candy",

                "Cookies",

                "Salad",

                "Yogurt",

                "Cereal",

                "Chips",

                "Fondu"
            };

            string[] hometown = {

                "Toledo",

                "Bowling Green",

                "Toledo",

                "Sylvania",

                "Temperance",

                "Point Place",

                "Maumee",

                "Orlando",

                "St. Louis",

                "Columbus",

                "Milwaukee",

                "Chicago",

                "Detroit",

                "Monroe",

                "Cleveland",

                "Cincinatti",

                "Traverse City",

                "Boston",

                "Dallas",

                "San Antonio",
            };

            Console.WriteLine($"Welcome to our C# class.");
        Start1:
            Console.WriteLine("Which student would you like to learn more about?\n" +
            $"(enter a number 1 - 20):");

            string studentNumber = GetInput();
            numValidate(studentNumber);

            Console.WriteLine($"Student {studentNumber} is {students[int.Parse(studentNumber)]}. What would you like to know about {students[int.Parse(studentNumber)]}? (enter or \"hometown\" or \"favorite food\")");

            ConsoleKey response;
            string homeTown = "hometown";
            string favoriteFood = "favorite food";
            string yes = "yes";
            string no = "no";
            string choice = Console.ReadLine();

            if (choice == homeTown)
            {
                Console.WriteLine($"{students[int.Parse(studentNumber)]} is from {hometown[int.Parse(studentNumber)]}. Would you like to know more? (enter \"yes\" or \"no\")");
                choice = Console.ReadLine();

                if (choice == yes)
                {
                    Console.WriteLine($"{students[int.Parse(studentNumber)]} favorite food is {food[int.Parse(studentNumber)]}. Would you like to learn about another student? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                        goto Start1;
                    }
                    else if (choice == no)
                    {
                        return;
                    }
                }
                if (choice == no)
                {
                    Console.WriteLine("Thanks!");
                    return;
                }
                else if (choice != yes || choice != no)
                {
                    try
                    {
                        Console.WriteLine("Sorry, did you want to close the app? (enter, or \"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        response = Console.ReadKey().Key;
                        Console.ReadLine();
                        if (choice == yes || response == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }

                    }
                    catch (FormatException ex)

                    {

                        Console.WriteLine("Incorrect format. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }
                    }

                    catch (IndexOutOfRangeException ex)

                    {

                        Console.WriteLine("Number was too large. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }
                    }

                    catch (Exception ex)

                    {

                        Console.WriteLine("An error occured. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }
                    }
                }

            }

            if (choice == favoriteFood)
            {
                Console.WriteLine($"{students[int.Parse(studentNumber)]} enjoys {food[int.Parse(studentNumber)]} as their favorite food. Would you like to know more? (enter, or \"yes\" or \"no\")");
                choice = Console.ReadLine();

                while (choice == yes)
                {
                    Console.WriteLine($"{students[int.Parse(studentNumber)]} is from {hometown[int.Parse(studentNumber)]}. Would you like to learn about another student? (enter, or \"yes\" or \"no\")");
                    choice = Console.ReadLine();
                    

                    while (choice == yes)
                    {
                        goto Start1;
                    }
                    if (choice == no)
                    {
                        return;
                    }
                }
                if (choice == no)
                {
                    Console.WriteLine("Thanks!");
                    return;
                }
                else if (choice != yes || choice != no)
                {
                    try
                    {
                        Console.WriteLine("Sorry, did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }
                    }
                    catch (FormatException ex)

                    {

                        Console.WriteLine("Incorrect format. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }

                    }

                    catch (IndexOutOfRangeException ex)

                    {

                        Console.WriteLine("Number was too large. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }

                    }

                    catch (Exception ex)

                    {

                        Console.WriteLine("An error has occured. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();
                        Console.ReadLine();
                        if (choice == yes)
                        {
                            Console.WriteLine("Good bye!");
                            return;
                        }
                        else if (choice == no)
                        {
                            goto Start1;
                        }

                    }
                }

            }

        }


        public static int numValidate(string input)

        {
        Start2:
            int validatedNumber = 0;

            //validated
            try

            {

                validatedNumber = int.Parse(input);

                while (int.Parse(input) < 1 || int.Parse(input) > 20)
                {
                    Console.WriteLine("Student does not exist. Please try again. (enter a number 1-20)");
                    input = Console.ReadLine();
                    validatedNumber = int.Parse(input);
                }

            }

            catch (FormatException ex)

            {

                Console.WriteLine("Input was in incorrect format");
                goto Start2;

            }

            catch (IndexOutOfRangeException ex)

            {

                Console.WriteLine("Input was out of reach of index");
                goto Start2;
            }

            catch (Exception ex)

            {

                Console.WriteLine("An error has occured.");
                goto Start2;
            }



            return validatedNumber;

        }

        public static string GetInput()

        {

            return Console.ReadLine();

        }



    }

}