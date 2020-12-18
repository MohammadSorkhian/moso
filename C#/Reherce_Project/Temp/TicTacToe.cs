using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class TicTacToe
    {
        private int[,] table =
          {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

        private void DrawTable()
        {
            Console.WriteLine(
                $"   |   |   \n" +
                $" {table[0,0]} | {table[0,1]} | {table[0,2]}\n"+
                $"   |   |   \n" +
                $"-----------\n" +
                $"   |   |   \n" +
                $" {table[1,0]} | {table[1,1]} | {table[1,2]}\n"+
                $"   |   |   \n" +
                $"-----------\n" +
                $"   |   |   \n" +
                $" {table[2,0]} | {table[2,1]} | {table[2,2]}\n"+
                $"   |   |   \n"
                );
        }

        private bool IsUserInputValidNumber_1_6(string UserInput)
        {
            bool result = false;

            if (UserInput.ToLower().Equals("q"))
                System.Environment.Exit(1);

            if ((int.TryParse(UserInput, out int extractedNumber)) &&
                    (extractedNumber > 0 &&
                    extractedNumber < 7)
                    ) 
                    result = true;

            return result;
            }
        

        private bool IsValidnumberSelectableForTable(int UserNumber)
        {
            bool result = false;

            switch (UserNumber)
            {
                case 1:
                    {
                        if (table[0, 0] == 1) result = true;
                    } break;

                case 2:
                    {
                        if (table[0, 1] == 2) result = true;
                    }
                    break;

                case 3:
                    {
                        if (table[0, 2] == 3) result = true;
                    }
                    break;

                case 4:
                    {
                        if (table[1, 0] == 4) result = true;
                    }
                    break;

                case 5:
                    {
                        if (table[1, 1] == 5) result = true;
                    }
                    break;

                case 6:
                    {
                        if (table[1, 2] == 6) result = true;
                    }
                    break;

                case 7:
                    {
                        if (table[2, 0] == 7) result = true;
                    }
                    break;

                case 8:
                    {
                        if (table[2, 1] == 8) result = true;
                    }
                    break;

                case 9:
                    {
                        if (table[2, 2] == 9) result = true;
                    }
                    break;
            }

                    return result;
        }


        private int GetValidInput()
        {
            string input = null;
            bool validation = false;
            while (!validation)
            {
                Console.Clear();
                DrawTable();
                Console.WriteLine("Enter a number (q:quite) : ");
                input = Console.ReadLine();

                if (IsUserInputValidNumber_1_6(input))
                    if (IsValidnumberSelectableForTable(int.Parse(input)))
                    {
                        validation = true;
                    }
            }

            return (int.Parse(input));
        }


        public void runTicTacToe()
        {
            int userInputNumber = GetValidInput();


        }
    }
}
