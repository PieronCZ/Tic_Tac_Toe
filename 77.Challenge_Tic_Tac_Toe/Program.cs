using System;

namespace _77.Challenge_Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "y";
            while (x != "n")
            {
                char[,] nums =
                {
                    {'1','2','3'},
                    {'4','5','6'},
                    {'7','8','9'}
                };

                Console.Clear();
                for (int i = 0; i < 3; ++i)
                {
                    Console.WriteLine("     |     |");
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", nums[i, 0], nums[i, 1], nums[i, 2]);
                    if (i != 2)
                        Console.WriteLine("_____|_____|_____");
                    else
                        Console.WriteLine("     |     |     ");
                }


                int[] Flags = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                char IsEnd = '0';
                int player = 1;
                int choice;
                char character;
                while (IsEnd != '1')
                {                        
                    if (player == 1)
                    {
                        choice = ChoosingField(player);
                        character = 'X';

                    }
                    else
                    {
                        choice = ChoosingField(player);
                        character = 'O';
                    }

                    

                    switch (choice)
                    {
                        case 1:
                            {
                                if (Flags[0] != 1)
                                {
                                    nums[0, 0] = character;
                                    Flags[0] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 2:
                            {
                                if (Flags[1] != 1)
                                {
                                    nums[0, 1] = character;
                                    Flags[1] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 3:
                            {
                                if (Flags[2] != 1)
                                {
                                    nums[0, 2] = character;
                                    Flags[2] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 4:
                            {
                                if (Flags[3] != 1)
                                {
                                    nums[1, 0] = character;
                                    Flags[3] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 5:
                            {
                                if (Flags[4] != 1)
                                {
                                    nums[1, 1] = character;
                                    Flags[4] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 6:
                            {
                                if (Flags[5] != 1)
                                {
                                    nums[1, 2] = character;
                                    Flags[5] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 7:
                            {
                                if (Flags[6] != 1)
                                {
                                    nums[2, 0] = character;
                                    Flags[6] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 8:
                            {
                                if (Flags[7] != 1)
                                {
                                    nums[2, 1] = character;
                                    Flags[7] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }

                        case 9:
                            {
                                if (Flags[8] != 1)
                                {
                                    nums[2, 2] = character;
                                    Flags[8] = 1;
                                    if (player == 1) player = 2;
                                    else player = 1;
                                }
                                break;
                            }
                    }

                    Console.Clear();
                    for (int i = 0; i < 3; ++i)
                    {
                        Console.WriteLine("     |     |");
                        Console.WriteLine("  {0}  |  {1}  |  {2}  ", nums[i, 0], nums[i, 1], nums[i, 2]);
                        if (i != 2)
                            Console.WriteLine("_____|_____|_____");
                        else
                            Console.WriteLine("     |     |     ");
                    }

                    IsEnd = Checking(nums, Flags);

                }
                Console.WriteLine("Do you want to play once again (y/n)?");
                x = Console.ReadLine();
            }
        }

        static int ChoosingField(int player)
        {
            Console.Write("Player {0}: Choose field: ", player);
            string choose = Console.ReadLine();
            while (true)
            {
                try
                {
                    int ChoiceInt = int.Parse(choose);
                    if (ChoiceInt == 0) throw new Exception();
                    return ChoiceInt;
                }
                catch (Exception)
                {
                    Console.Write("Incorrect Input! Try again: ");
                    choose = Console.ReadLine();
                }
            }
        }

        static char Checking(char[,] nums, int[] table)
        {
            int count = 0, flags = 0;

            for(int j = 0; j<2; j++)
            {
                if (nums[j, 0] == nums[j, 1] && nums[j, 1] == nums[j, 2]) count = 1;
                if (nums[0, j] == nums[1, j] && nums[1, j] == nums[2, j]) count = 1;
                if (nums[0, 0] == nums[1, 1] && nums[1, 1] == nums[2, 2]) count = 1;
                if (nums[0, 2] == nums[1, 1] && nums[1, 1] == nums[2, 0]) count = 1;
            }

            // checking for draft
            for(int i = 0; i<table.Length; i++)
            {
                if (table[i] == 1) flags++; 
            }

            if (count == 1) return '1';
            if (flags == 9) return '1';
            else return '0';
        }

    }
}
