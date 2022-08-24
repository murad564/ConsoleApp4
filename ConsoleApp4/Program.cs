

class Program
{
    static void Main()
    {
        string[,] Questions = new string[,]
        {
        {"Ucbucaghin neche terefi var","f2","t3","f4" },
        {"5*5= neche edir?","f10","f20","t25" },
        {"Riyaziyyata aid olani sechin","tHendese","fSheir","ftemsil" }
        };
        bool start = true;
        int check = 0;
        int score = 0;
        for (int i = 0; i < 3; i++)
        {
            while (start)
            {
                if (i < 3)
                {
                    Console.Clear();
                    Console.WriteLine(Questions[i, 0]);
                    for (int j = 1; j < 4; j++)
                    {
                        if (j == check)
                            Console.ForegroundColor = ConsoleColor.Red;
                        string checktrue = Questions[i, j].Substring(1);

                        Console.WriteLine(checktrue);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.Clear();
                            if (check != 0)
                                check--;
                            else
                                check = 3;
                            break;
                        case ConsoleKey.DownArrow:
                            Console.Clear();
                            if (check != 3)
                                check++;
                            else
                                check = 1;
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();

                            for (int j = 1; j < 4; j++)
                            {
                                if (j == check && Questions[i, j].Substring(0, 1) == "t")
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    score += 10;
                                }
                                else if (j == check)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    //score -= 10;

                                }

                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            i++;
                            break;
                    }
                }
                if (i == 3)
                {
                    //Console.Clear();
                    start = false;
                    Console.WriteLine($"{score}");
                    break;
                }
            }
        }
    }
}