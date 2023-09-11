using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BattleGame.UserControls;
using BattleGame.Data.Entities;
using BattleGame.Core;
using BattleGame.Data.Enums;

namespace BattleGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        public SquareUserControl[,] squaresTable;
        public Square[,] squares;
        public System.Windows.Threading.DispatcherTimer turnTimer;
        public int turnCounter;
        public int[,] initialBoardValues;

        public MainGameWindow()
        {
            InitializeComponent();
            StartBattle();
        }

        public void InitTextToControls()
        {
            redSideNameLbl.Content = Engine.Player1.Name;
            blueSideNameLbl.Content = Engine.Player2.Name;
            btnLobby.Content = Properties.Resources.lobbyBtnText;
            btnReset.Content = Properties.Resources.resetBtnText;
            instrWindowButton.Content = Properties.Resources.instrBtnText;
            redSideSurrender.Content = Properties.Resources.surrenderBtnText;
            blueSideSurrender.Content = Properties.Resources.surrenderBtnText;
            redSidePassTurn.Content = Properties.Resources.passTurnBtnText;
            blueSidePassTurn.Content = Properties.Resources.passTurnBtnText;
            scoreLbl.Content = Properties.Resources.scoreLbl;
            turnSideLblStr.Content = Properties.Resources.turnLblStr;
            string player1Name = Engine.Player1.Name;
            turnSideLbl.Content = player1Name;
            turnSideLbl.Foreground = Brushes.Red;
            celsiusSign.Content = Properties.Resources.celsiusSign;
            redSideEnergyLbl.Content = Properties.Resources.energyTypeLbl;
            blueSideEnergyLbl.Content = Properties.Resources.energyTypeLbl;
            darkRedEnergyEffectLbl.Content = Properties.Resources.highRedEffect;
            redEnergyEffectLbl.Content = Properties.Resources.medRedEffect;
            lightRedEnergyEffectLbl.Content = Properties.Resources.lowRedEffect;
            darkBlueEnergyEffectLbl.Content = Properties.Resources.highBlueEffect;
            blueEnergyEffectLbl.Content = Properties.Resources.medBlueEffect;
            lightBlueEnergyEffectLbl.Content = Properties.Resources.lowBlueEffect;
            blueSidePassTurn.IsEnabled = false;
            blueSideSurrender.IsEnabled = false;
        }

        public void InitSquares()
        {
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int j = 0; j < squares.GetLength(1); j++)
                {
                    squares[i, j] = new Square
                    {
                        Line = i,
                        Column = j,
                        Value = initialBoardValues[i, j]
                    };
                }
            }
        }

        public void InitBoard()
        {
            for (int i = 0; i < squaresTable.GetLength(0); i++)
            {
                for (int j = 0; j < squaresTable.GetLength(1); j++)
                {
                    squaresTable[i, j] = new SquareUserControl(squares[i, j]);                
                }
            }
        }

        public void RefreshGameBoard()
        {
            Board.Children.Clear();
            for (int i = 0; i < Engine._boardSize; i++)
            {
                for (int j = 0; j < Engine._boardSize; j++)
                {
                    squaresTable[i, j].UpdateValue();
                    Board.Children.Add(squaresTable[i, j]);
                }
            }
        }

        public void StartTurnTimer()
        {
            turnTimer = new System.Windows.Threading.DispatcherTimer();
            turnTimer.Interval = new TimeSpan(0, 0, 1);
            turnTimer.Tick += new EventHandler(TurnTimer_Tick);
            turnCounter = Engine.Counter;
            turnTimer.Start();
        }

        private void TurnTimer_Tick(object sender, EventArgs e)
        {
            string minutes = Math.Floor((double)turnCounter / 60).ToString("00");
            string seconds = (turnCounter % 60).ToString("00");
            TimerTb.Text = minutes + ":" + seconds;
            turnCounter--;
            if (turnCounter == -1)
            {                    
                ChangeGameTurn();
                turnCounter = Engine.Counter;
                turnTimer.Start();
            }
        }

        private void StartBattle()
        {
            squaresTable = new SquareUserControl[Engine._boardSize, Engine._boardSize];
            squares = new Square[Engine._boardSize, Engine._boardSize];
            initialBoardValues = GenerateInitialValues();
            InitTextToControls();
            InitSquares();
            InitBoard();
            RefreshGameBoard();
            StartTurnTimer();
            UpdateScore();
            Engine.isRedSideTurn = true;
            UpdateEnergies();
        }

        public int[,] GenerateInitialValues()
        {
            int[,] values = new int[Engine._boardSize, Engine._boardSize];

            for (int i = 0; i < Engine._boardSize; i++)
            {
                for (int j = 0; j < Engine._boardSize / 2 ; j++)
                {
                    values[i, j] = Engine.rnd.Next(1, 31);
                }
            }

            for (int h = 0; h < Engine._boardSize; h++)
            {
                for (int t = Engine._boardSize / 2; t < Engine._boardSize; t++)
                {
                    values[h, t] = Engine.rnd.Next(-30, 0);
                }
            }

            int sum = Engine.CalculateSumForInitialValues(values);

            while (sum != 0)
            {
                int randomLine;
                int randomColumn;

                if (sum < 0)
                {
                    randomLine = Engine.rnd.Next(0, Engine._boardSize);
                    randomColumn = Engine.rnd.Next(0, Engine._boardSize / 2);

                    values[randomLine, randomColumn]++;
                    sum++;
                }
                else
                {
                    randomLine = Engine.rnd.Next(0, Engine._boardSize);
                    randomColumn = Engine.rnd.Next(Engine._boardSize / 2, Engine._boardSize);

                    values[randomLine, randomColumn]--;
                    sum--;
                }
            }

            sum = Engine.CalculateSumForInitialValues(values);

            Engine.ShuffleMatrix(values);

            return values;
        }
            
        public void ChangeGameTurn()
        {
            Engine.isRedSideTurn = !Engine.isRedSideTurn;
            turnCounter = Engine.Counter;
            UpdateEnergies();
            UpdateTurnControlLabels();
        }

        public void UpdateTurnControlLabels()
        {

            if (Engine.isRedSideTurn)
            {
                redSideSurrender.IsEnabled = true;
                redSidePassTurn.IsEnabled = true;
                blueSideSurrender.IsEnabled = false;
                blueSidePassTurn.IsEnabled = false;
                string player1Name = Engine.Player1.Name;
                turnSideLbl.Content = player1Name;
                turnSideLbl.Foreground = Brushes.Red;
            }
            else
            {
                redSideSurrender.IsEnabled = false;
                redSidePassTurn.IsEnabled = false;
                blueSideSurrender.IsEnabled = true;
                blueSidePassTurn.IsEnabled = true;
                string player2Name = Engine.Player2.Name;
                turnSideLbl.Content = player2Name;
                turnSideLbl.Foreground = Brushes.Blue;
            }
        }

        public void UpdateEnergies(bool onlyLabels = false)
        {
            if (Engine.isRedSideTurn)
            {
                if (!onlyLabels)
                {
                    Engine.AddEnergyToPlayer(true);
                }
                darkRedEnergyNumberLbl.Content = Engine.Player1.HighLevelEnergyNr.ToString();
                redEnergyNumberLbl.Content = Engine.Player1.MediumLevelEnergyNr.ToString();
                lightRedEnergyNumberLbl.Content = Engine.Player1.LowLevelEnergyNr.ToString();
            }
            else
            {
                if (!onlyLabels)
                {
                    Engine.AddEnergyToPlayer(false);
                }
                darkBlueEnergyNumberLbl.Content = Engine.Player2.HighLevelEnergyNr.ToString();
                blueEnergyNumberLbl.Content = Engine.Player2.MediumLevelEnergyNr.ToString();
                lightBlueEnergyNumberLbl.Content = Engine.Player2.LowLevelEnergyNr.ToString();
            }
        }

        public void UpdateScore()
        {
            int sum = 0;

            for (int i = 0; i < squaresTable.GetLength(0); i++)
            {
                for (int j = 0; j < squaresTable.GetLength(1); j++)
                {
                    sum += squaresTable[i, j]._currentSquare.Value;
                }
            }
            ScoreTb.Text = sum.ToString();
            CheckIfWinner();
        }

        public void UpdateBoardNeighboursValue(Square currentSquare, bool isRedSideTurn)
        {
            for (int i = currentSquare.Line - 1; i <= currentSquare.Line + 1; i++)
            {
                for (int j = currentSquare.Column - 1; j <= currentSquare.Column + 1; j++)
                {
                    if (Engine.IsOnTheBoard(i, j) && (i != currentSquare.Line || j != currentSquare.Column))
                    {
                        if (isRedSideTurn && squares[i, j].Value >= 0)
                        {
                            squaresTable[i, j]._currentSquare.Value += 2; 
                        }
                        else if (!isRedSideTurn && squares[i, j].Value <= 0)
                        {
                            squaresTable[i, j]._currentSquare.Value -= 2;
                        }
                    }
                }
            }
            RefreshGameBoard();
        }


        public void UpdateBoardNeighboursValue2(Square currentSquare, bool isRedSideTurn)
        {
            for (int i = currentSquare.Line - 2; i <= currentSquare.Line + 2; i++)
            {
                if (Engine.LineIsOnTheBoard(i) && (i != currentSquare.Line))
                {
                    if (isRedSideTurn && squares[i, currentSquare.Column].Value >= 0)
                    {
                        squaresTable[i, currentSquare.Column]._currentSquare.Value += 3; 
                    }
                    else if (!isRedSideTurn && squares[i, currentSquare.Column].Value <= 0)
                    {
                        squaresTable[i, currentSquare.Column]._currentSquare.Value -= 3;
                    }
                }
            }
            for (int j = currentSquare.Column - 2; j <= currentSquare.Column + 2; j++)
            {
                if (Engine.ColumnIsOnTheBoard(j) && (j != currentSquare.Line))
                {
                    if (isRedSideTurn && squares[currentSquare.Line, j].Value >= 0)
                    {
                        squaresTable[currentSquare.Line, j]._currentSquare.Value += 3; 
                    }
                    else if (!isRedSideTurn && squares[currentSquare.Line, j].Value <= 0)
                    {
                        squaresTable[currentSquare.Line, j]._currentSquare.Value -= 3;
                    }
                }
            }           
            RefreshGameBoard();
        }

        public void CheckIfWinner()
        {
            int scoreValue = int.Parse(ScoreTb.Text);

            if (scoreValue >= 42)
            {
                GameResult(WinOutcomesEnum.Red);
            }

            if (scoreValue <= -42)
            {
                GameResult(WinOutcomesEnum.Blue);
            }

            bool isSquaresTableCovered = true;

            for (int i = 0; i < Engine._boardSize && isSquaresTableCovered; i++)
            {
                for (int j = 0; j < Engine._boardSize && isSquaresTableCovered; j++)
                {
                    if (!squaresTable[i,j].isSquareDisabled)
                    {
                        isSquaresTableCovered = false;
                    }
                }
            }

            if (isSquaresTableCovered)
            {
                GameResult(Engine.CheckTheWinner(scoreValue));
            }
        }

        public void GameResult(WinOutcomesEnum winner) 
        {
            turnTimer.Stop();

            if (winner == WinOutcomesEnum.Red)
                MessageBox.Show("Congratulations" + "  " + Engine.Player1.Name + "  " + "you've won this battle !");
            else if (winner == WinOutcomesEnum.Blue)
            {
                MessageBox.Show("Congratulations" + "  " + Engine.Player2.Name + "  " + "you've won this battle !");
            }
            else if (winner == WinOutcomesEnum.Blue)
            {
                MessageBox.Show("It's a DRAW !");
            }           
            Board.IsEnabled = false;
        }

        private void RedSideSurrender_Click(object sender, RoutedEventArgs e)
        {
            GameResult(Data.Enums.WinOutcomesEnum.Blue);
            redSideSurrender.IsEnabled = false;
            blueSideSurrender.IsEnabled = false;
            redSidePassTurn.IsEnabled = false;
            blueSidePassTurn.IsEnabled = false;
        }

        private void BlueSideSurrender_Click(object sender, RoutedEventArgs e)
        {
            GameResult(Data.Enums.WinOutcomesEnum.Red);
            blueSideSurrender.IsEnabled = false;
            redSideSurrender.IsEnabled = false;
            blueSidePassTurn.IsEnabled = false;
            redSidePassTurn.IsEnabled = false;
        }

        private void RedSidePassTurn_Click(object sender, RoutedEventArgs e)
        {
            ChangeGameTurn();
            UpdateTurnControlLabels();
        }

        private void BlueSidePassTurn_Click(object sender, RoutedEventArgs e)
        {
            ChangeGameTurn();
            UpdateTurnControlLabels();
        }

        public void ResetBattle()
        {
            turnTimer.Stop();
            Board.IsEnabled = true;
            redSideSurrender.IsEnabled = true;
            blueSideSurrender.IsEnabled = true;
            redSidePassTurn.IsEnabled = true;
            blueSidePassTurn.IsEnabled = true;
            Engine.Player1.HighLevelEnergyNr = 0;
            darkBlueEnergyNumberLbl.Content = Engine.Player1.HighLevelEnergyNr.ToString();
            Engine.Player1.MediumLevelEnergyNr = 0;
            blueEnergyNumberLbl.Content = Engine.Player1.HighLevelEnergyNr.ToString();
            Engine.Player1.LowLevelEnergyNr = 0;
            lightBlueEnergyNumberLbl.Content = Engine.Player1.HighLevelEnergyNr.ToString();
            Engine.Player2.HighLevelEnergyNr = 0;
            darkRedEnergyNumberLbl.Content = Engine.Player2.MediumLevelEnergyNr.ToString();
            Engine.Player2.MediumLevelEnergyNr = 0;
            redEnergyNumberLbl.Content = Engine.Player2.MediumLevelEnergyNr.ToString();
            Engine.Player2.LowLevelEnergyNr = 0;
            lightRedEnergyNumberLbl.Content = Engine.Player2.MediumLevelEnergyNr.ToString();
        }

        private void BtnLobby_Click(object sender, RoutedEventArgs e)
        {
            ResetBattle();
            LobbyGameWindow lobbyWindow = new LobbyGameWindow();
            lobbyWindow.Show();
            Close();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetBattle();
            StartBattle();
        }
        
        private void InstrWindowButton_Click(object sender, RoutedEventArgs e)
        {
            InstructionGameWindow instructionWindow = new InstructionGameWindow();
            instructionWindow.Show();
        }
    }
}
