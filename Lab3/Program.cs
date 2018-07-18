using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabNumber3
    {
        class Program
        {
            static void Main(string[] args)
            {
                ////////input user name and request number

                Console.WriteLine("Please enter your name");
                string userName = Console.ReadLine();

                Console.WriteLine("Hello " + userName + "!");

                //declare userNumber

                int userNumber;

                {

                    bool play = true;
                    while (play)
                    {

                        while (true)
                        {
                            try
                            {

                                Console.WriteLine(userName + ", please enter a number between 1 and 100.");

                                userNumber = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("please give me a number");
                            }

                        }

                        //////validation of number scope



                        if (userNumber > 100 || userNumber < 1)
                        {
                            Console.WriteLine("That number isn't within our range.");

                        }

                        //////  Recipe for Lab implemented


                        else if (userNumber % 2 == 1)

                        {
                            Console.WriteLine(userName + ", " + userNumber + " is Odd");
                        }


                        else if (userNumber <= 24)

                        {
                            Console.WriteLine(userName + ", " + userNumber + " is Even and Under 25");
                        }


                        else if (userNumber < 61 && userNumber > 25)
                        {
                            Console.WriteLine(userName + ", " + "that number is Even");
                        }


                        else if (userNumber > 60)

                        {
                            Console.WriteLine(userName + ", " + userNumber + " is Even");
                        }



                        ///////// Option to play again 
                        //// 
                        //
                        //

                        {
                            Console.WriteLine("Would you like to play again? (Y/N): ");
                            string playAgain = Console.ReadLine();


                            if (playAgain == "y" || playAgain == "Y")

                            {
                                play = true;
                            }

                            else if (playAgain == "n" || playAgain == "N")

                            {
                                play = false;
                                Console.WriteLine("Thanks for playing.");
                            }
                        }
                    }
                }
            }


        }
    }


   

