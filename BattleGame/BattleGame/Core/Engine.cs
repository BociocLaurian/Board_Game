using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Data.Entities;
using BattleGame.Data.Enums;
using BattleGame.UserControls;

namespace BattleGame.Core
{
    public static class Engine
    {
        public static Player Player1;
        public static Player Player2;

        public static Random rnd = new Random();
        public static int _boardSize = 8;
        public static int _shuffleSteps = 500;
        public static bool isRedSideTurn;

        public static Dictionary<EnergyLevelEnum, int> EnergyValuesRed = new Dictionary<EnergyLevelEnum, int>()
        {
            { EnergyLevelEnum.Low, 2 },
            { EnergyLevelEnum.Medium, 5 },
            { EnergyLevelEnum.High, 10 },           
        };

        public static Dictionary<EnergyLevelEnum, int> EnergyValuesBlue = new Dictionary<EnergyLevelEnum, int>()
        {
            { EnergyLevelEnum.Low, -2 },
            { EnergyLevelEnum.Medium, -5 },
            { EnergyLevelEnum.High, -10 },           
        };


        public static Dictionary<int, string> GetGameOptions()
        {
            Dictionary<int, string> options = new Dictionary<int, string>();

            options.Add(1, "Easy (60 seconds)");
            options.Add(2, "Medium (40 seconds)");
            options.Add(3, "Hard (20 seconds)");

            return options;
        }

        public static int Counter;

        public static void AddEnergyToPlayer(bool isForRedPlayer)
        {
            int randomValue = rnd.Next(1, 101);

            if (isForRedPlayer)
            {
                if (randomValue <= 60)
                {
                    Player1.LowLevelEnergyNr++;
                }
                else if (randomValue > 60 && randomValue <= 85)
                {
                    Player1.MediumLevelEnergyNr++;
                }
                else
                {
                    Player1.HighLevelEnergyNr++;
                }
            }
            else
            {
                if (randomValue <= 60)
                {
                    Player2.LowLevelEnergyNr++;
                }
                else if (randomValue > 60 && randomValue <= 85)
                {
                    Player2.MediumLevelEnergyNr++;
                }
                else
                {
                    Player2.HighLevelEnergyNr++;
                }
            }
   
        }

        public static int CalculateSumForInitialValues(int[,] values)
        {
            int sum = 0;

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    sum += values[i, j];
                }
            }

            return sum;
        }

        public static void ShuffleMatrix(int[,] matrix)
        {
            for (int i = 0; i < _shuffleSteps; i++)
            {
                int firstRandomLine = rnd.Next(0, _boardSize);
                int firstRandomColumn = rnd.Next(0, _boardSize);

                int secondRandomLine = rnd.Next(0, _boardSize);
                int secondRandomColumn = rnd.Next(0, _boardSize);

                int temp = matrix[firstRandomLine, firstRandomColumn];
                matrix[firstRandomLine, firstRandomColumn] = matrix[secondRandomLine, secondRandomColumn];
                matrix[secondRandomLine, secondRandomColumn] = temp;
            }
        }

        public static WinOutcomesEnum CheckTheWinner(int score)
        {
            if (score > 0)
            {
                return WinOutcomesEnum.Red;
            }
            else if (score < 0)
            {
                return WinOutcomesEnum.Blue;
            }

            return WinOutcomesEnum.Draw;
        }

        public static bool IsOnTheBoard(int line, int column)
        {
            return line >= 0 && line <= (_boardSize - 1) && column >= 0 && column <= (_boardSize - 1);
        }

        public static bool LineIsOnTheBoard(int line)
        {
            return line >= 0 && line <= (_boardSize - 1);
        }

        public static bool ColumnIsOnTheBoard(int column)
        {
            return column >= 0 && column <= (_boardSize - 1);
        }
    }
}
