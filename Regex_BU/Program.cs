using System;

namespace Regex_BU
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int end = 0;

            do
            {
                Console.WriteLine("Enter text:");
                text = Console.ReadLine();

                int state = 1;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a')
                    {
                        if (state == 2)
                        {
                            state = 3;
                        }
                        else if (state == 3)
                        {
                            state = 4;
                        }
                        else if (state == 4)
                        {
                            state = 5;
                        }
                        else if (state == 5)
                        {
                            state = 4;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (text[i] == 'b')
                    {

                        if (state == 1)
                        {
                            state = 2;
                        }
                        else if (state == 2)
                        {
                            state = 4;
                        }
                        else if (state == 3)
                        {
                            state = 4;
                        }
                        else if (state == 4)
                        {
                            state = 4;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (state == 2 || state == 4)
                {
                    Console.WriteLine("Akceptacja");
                }
                else
                {
                    Console.WriteLine("Brak akceptacji");
                }

                Console.WriteLine("Powtorzyc test (Y/N)?");
                string temp;
                temp = Console.ReadLine();
                if(temp=="N" || temp=="n")
                {
                    end = 0;
                }
                else
                {
                    end = 1;
                }
            }
            while (end == 1);
        }
    }
}
