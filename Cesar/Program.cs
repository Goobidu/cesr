using System;
using System.Collections.Generic;

namespace Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decode or encode");
            string interaction = Console.ReadLine();
            Console.WriteLine("user input");
            string input = Console.ReadLine();
            Console.WriteLine(" changing number");
            int userInput =  Convert.ToInt32(Console.ReadLine());
            string[] output = new string[150000];
            string[] alphabet ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            if (interaction == "encode")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int p = 0; p < alphabet.Length; p++)
                    {
                        if (Convert.ToString(input[i]) == " " ^ Convert.ToString(input[i]) == "." ^ Convert.ToString(input[i]) == ",")
                        {
                            if (Convert.ToString(input[i]) == " ")
                            {
                                output[i] = " ";
                            }
                            if (Convert.ToString(input[i]) == ".")
                            {
                                output[i] = ".";
                            }
                            if (Convert.ToString(input[i]) == ",")
                            {
                                output[i] = ",";
                            }
                        }
                        else if (Convert.ToString(input[i]) == Convert.ToString(input[i]).ToUpper())
                        {
                            if (Convert.ToString(input[i]).ToLower() == alphabet[p])
                            {
                                if (p + userInput >= 26)
                                {
                                    output[i] = alphabet[(p + userInput) - 25].ToUpper();
                                }
                                else
                                {
                                    output[i] = alphabet[p + userInput].ToUpper();
                                }
                            }
                        }
                        else if (Convert.ToString(input[i]).ToLower() == alphabet[p])
                        {
                            if (p + userInput >= 26)
                            {
                                output[i] = alphabet[(p + userInput) - 25];
                            }
                            else
                            {
                                output[i] = alphabet[p + userInput];
                            }
                        }
                    }
                }
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write(output[i]);
                }
            }
            if (interaction == "decode")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int p = 0; p < alphabet.Length; p++)
                    {
                        if (Convert.ToString(input[i]) == " " ^ Convert.ToString(input[i]) == "." ^ Convert.ToString(input[i]) == ",")
                        {
                            if (Convert.ToString(input[i]) == " ")
                            {
                                output[i] = " ";
                            }
                            if (Convert.ToString(input[i]) == ".")
                            {
                                output[i] = ".";
                            }
                            if (Convert.ToString(input[i]) == ",")
                            {
                                output[i] = ",";
                            }
                        }
                        else if (Convert.ToString(input[i]) == Convert.ToString(input[i]).ToUpper())
                        {
                            if (Convert.ToString(input[i]).ToLower() == alphabet[p])
                            {
                                if (p - userInput < 0)
                                {
                                    output[i] = alphabet[(p - userInput) + 26].ToUpper();
                                }
                                else
                                {
                                    output[i] = alphabet[p - userInput].ToUpper();
                                }
                            }
                        }
                        else if (Convert.ToString(input[i]).ToLower() == alphabet[p])
                        {
                            if (p - userInput < 0)
                            {
                                output[i] = alphabet[(p - userInput) + 26];
                            }
                            else
                            {
                                output[i] = alphabet[p - userInput];
                            }
                        }
                    }
                }
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write(output[i]);
                }
            }


        }
    }
}
