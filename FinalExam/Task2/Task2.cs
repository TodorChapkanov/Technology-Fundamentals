namespace Task2
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;
    using System.Collections.Generic;

    public class Task2
    {
        public static void Main()
        {
            var songsList = new List<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(":");
                var sb = new StringBuilder();
                if (input[0] == "end")
                {
                    break;
                }
                var key = input[0].Length;
                bool isTrue = true;
                for (int i = 0; i < input[0].Length; i++)
                {

                    if (char.IsUpper(input[0][0]) && i == 0)
                    {
                        var firsrtLetter = input[0][0];
                        if (firsrtLetter + key <= 90)
                        {
                            char letter = (char)(firsrtLetter + key);
                            sb.Append(letter);
                        }
                        else
                        {
                            char letter = (char)((firsrtLetter + key - 90) + 64);
                            sb.Append(letter);
                        }
                    }
                    else if (!char.IsUpper(input[0][0]))
                    {
                        isTrue = false;
                    }
                    if (input[0][i] == ' ' || input[0][i] == '\'')
                    {
                        sb.Append(input[0][i]);
                    }
                    if (i > 0 && char.IsLower(input[0][i]))
                    {
                        var curentLetter = input[0][i];
                        if (curentLetter + key <= 122)
                        {
                            char letter = (char)(curentLetter + key);
                            sb.Append(letter);
                        }
                        else
                        {
                            char letter = (char)((curentLetter + key - 122) + 96);
                            sb.Append(letter);
                        }
                    }
                    else if (i != 0 && !char.IsLower(input[0][i]) && input[0][i] != ' ' && input[0][i] != '\'')
                    {
                        isTrue = false;
                    }

                    if (isTrue == false)
                    {
                        sb.Clear();
                        Console.WriteLine("Invalid input!");
                        break;
                    }
                }
                sb.Append('@');
                if (isTrue != false)
                {
                    for (int i = 0; i < input[1].Length; i++)
                    {
                        char curentLetter = input[1][i];
                        if (char.IsUpper(input[1][i]))
                        {
                            if (curentLetter + key <= 90)
                            {
                                char letter = (char)(curentLetter + key);
                                sb.Append(letter);
                            }
                            else
                            {
                                char letter = (char)((curentLetter + key - 90) + 64);
                                sb.Append(letter);
                            }

                        }
                        else if (curentLetter == ' ' || curentLetter == '\'')
                        {
                            sb.Append(curentLetter);
                        }
                        else
                        {
                            isTrue = false;
                        }
                        if (isTrue == false)
                        {
                            sb.Clear();
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                    }
                //for (int i = 0; i < input[1].Length; i++)
                //{
                //    char curentLetter = input[1][i];
                //    if (char.IsUpper(input[1][i]))
                //    {
                //        if (curentLetter + key <= 90)
                //        {
                //            char letter = (char)(curentLetter + key);
                //            sb.Append(letter);
                //        }
                //        else
                //        {
                //            char letter = (char)((curentLetter + key - 90) + 64);
                //            sb.Append(letter);
                //        }

                //    }
                //    else if (curentLetter == ' ' || curentLetter == '\'')
                //    {
                //        sb.Append(curentLetter);
                //    }
                //    else
                //    {
                //        isTrue = false;
                //    }
                //    if (isTrue == false)
                //    {
                //        sb.Clear();
                //        Console.WriteLine("Invalid input!");
                //        break;
                //    }

                }
                var song = sb.ToString();
                var songIsCorect = false;
                for (int i = 0; i < song.Length; i++)
                {
                    if (song[i] != ' ' && song[i] != '@')
                    {
                        songIsCorect = true;
                        songsList.Add(song);
                    }
                }
                if (songIsCorect)
                {
                    Console.WriteLine($"Successful encryption: {song}");
                }
                





            }
            
            
        }
    }
}
