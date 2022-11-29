

namespace ConsoleApp3
{
    class Learning_Homework_1
    {
        static void Main(string[] args)
        {
            string line;
            int z;

            char s1 = ' ';
            char s2 = ' ';
            char s3 = ' ';
            char s4 = ' ';
            char s5 = ' ';
            char s6 = ' ';
            char s7 = ' ';
            char s8 = ' ';
            char s9 = ' ';

            char who;

            int moves_made = 1;

            bool success = false;

            while (moves_made <= 9)
            {
                Console.WriteLine(" {0} | {1} | {2} \n"
                                    + "...+...+...\n"
                                    + " {3} | {4} | {5} \n"
                                    + "...+...+...\n"
                                    + " {6} | {7} | {8} ",
                                    s1, s2, s3, s4, s5, s6, s7, s8, s9);

                if (moves_made % 2 == 1)
                {
                    who = 'X';
                }
                else
                {
                    who = 'O';
                }

                while (true)
                {
                    success = false;

                    Console.Write("\n{0} -> ", who);

                    line = Console.ReadLine();
                    Console.WriteLine();

                    if (int.TryParse(line, out z))
                    {
                        if ((z >= 1) && (z <= 9))
                        {
                            switch (z)
                            {
                                case 1:
                                    if (s1 == ' ')
                                    {
                                        success = true;
                                        s1 = who;
                                    }
                                    break;
                                case 2:
                                    if (s2 == ' ')
                                    {
                                        success = true;
                                        s2 = who;
                                    }
                                    break;
                                case 3:
                                    if (s3 == ' ')
                                    {
                                        success = true;
                                        s3 = who;
                                    }
                                    break;
                                case 4:
                                    if (s4 == ' ')
                                    {
                                        success = true;
                                        s4 = who;
                                    }
                                    break;
                                case 5:
                                    if (s5 == ' ')
                                    {
                                        success = true;
                                        s5 = who;
                                    }
                                    break;
                                case 6:
                                    if (s6 == ' ')
                                    {
                                        success = true;
                                        s6 = who;
                                    }
                                    break;
                                case 7:
                                    if (s7 == ' ')
                                    {
                                        success = true;
                                        s7 = who;
                                    }
                                    break;
                                case 8:
                                    if (s8 == ' ')
                                    {
                                        success = true;
                                        s8 = who;
                                    }
                                    break;
                                case 9:
                                    if (s9 == ' ')
                                    {
                                        success = true;
                                        s9 = who;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (success)
                        {
                            break;
                        }
                        Console.WriteLine("Illegal Move! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Illegal Move! Try again.");
                    }
                }
                moves_made++;
            }
            Console.WriteLine("Game Over\n");
            Console.WriteLine(" {0} | {1} | {2} \n"
                                + "...+...+...\n"
                                + " {3} | {4} | {5} \n"
                                + "...+...+...\n"
                                + " {6} | {7} | {8} ",
                                s1, s2, s3, s4, s5, s6, s7, s8, s9);
        }
    }
}