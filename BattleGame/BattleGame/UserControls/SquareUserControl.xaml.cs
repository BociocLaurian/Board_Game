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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BattleGame.Data.Entities;
using BattleGame.Core;

namespace BattleGame.UserControls
{
    /// <summary>
    /// Interaction logic for SquareUserControl.xaml
    /// </summary>
    public partial class SquareUserControl : UserControl
    {
        public Square _currentSquare;
        MainGameWindow _gameWindow;
        public bool isSquareDisabled=false;

        public SquareUserControl(Square square)
        {
            InitializeComponent();
            _currentSquare = square;
            UpdateValue();
        }

        public SquareUserControl()
        {
            InitializeComponent();
        }

        public void UpdateChosenSquare(object sender, MouseButtonEventArgs e)
        {
           
            UpdateChosenSquare updateSquare = new UpdateChosenSquare(this);
                updateSquare.Show();
                         
        }

        public void UpdateValue(bool? shouldChangeTurn = null, bool specialAbility1Used = false, 
                                bool specialAbility2Used = false)
        {
            Value.Content = _currentSquare.Value;


            if (specialAbility1Used)
            {
                _gameWindow = (MainGameWindow)Window.GetWindow(this);
                _gameWindow.UpdateBoardNeighboursValue(_currentSquare, Engine.isRedSideTurn); 
            }

            if (specialAbility2Used)
            {
                _gameWindow = (MainGameWindow)Window.GetWindow(this);
                _gameWindow.UpdateBoardNeighboursValue2(_currentSquare, Engine.isRedSideTurn);
            }

            if (shouldChangeTurn.HasValue)
            {
                _gameWindow = (MainGameWindow)Window.GetWindow(this);
                _gameWindow.ChangeGameTurn();
                _gameWindow.UpdateScore();
            }
        }

        public void Disable()
        {
            if (Engine.isRedSideTurn)
            {
                border.BorderBrush = Brushes.Red;
                border.Background = Brushes.WhiteSmoke;
            }
            else
            {
                border.BorderBrush = Brushes.Blue;
                border.Background = Brushes.WhiteSmoke;
            }

            mainGrid.IsEnabled = false;
            isSquareDisabled = true;
            mainGrid.IsHitTestVisible = false;
        }

        public void UpdateEnergyLabels()
        {
            _gameWindow = (MainGameWindow)Window.GetWindow(this);
            _gameWindow.UpdateEnergies(true);
        }
    }
}
