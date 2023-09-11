using BattleGame.Core;
using BattleGame.Data.Entities;
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


namespace BattleGame.UserControls
{
    /// <summary>
    /// Interaction logic for UpdateChosenSquare.xaml
    /// </summary>
    public partial class UpdateChosenSquare : Window
    {
        public Square _currentSquare;
        public SquareUserControl _squareUserControl;

        public UpdateChosenSquare(SquareUserControl squareUserControl)
        {
            InitializeComponent();

            _squareUserControl = squareUserControl;
            Position.Text = "   Line: " + (squareUserControl._currentSquare.Line + 1).ToString() + "\n" + "Column: " +
                (squareUserControl._currentSquare.Column + 1).ToString() + "\n";
            AbilityText.Content = Properties.Resources.abilityTextTitle;
            DisplayValues();
        }

        public void DisplayValues()
        {
            if (Engine.isRedSideTurn)
            {
                HighLevelEnergy.Content = "+" + Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.High].ToString();
                HighLevelEnergy.IsEnabled = Engine.Player1.HighLevelEnergyNr > 0;
                HighLevelEnergy.BorderThickness = new Thickness(3.0);
                HighLevelEnergy.BorderBrush = Brushes.DarkRed;
                MediumLevelEnergy.Content = "+" + Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.Medium].ToString();
                MediumLevelEnergy.IsEnabled = Engine.Player1.MediumLevelEnergyNr > 0;
                MediumLevelEnergy.BorderThickness = new Thickness(3.0);
                MediumLevelEnergy.BorderBrush = Brushes.Red;
                LowLevelEnergy.Content = "+" + Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.Low].ToString();
                LowLevelEnergy.IsEnabled = Engine.Player1.LowLevelEnergyNr > 0;
                LowLevelEnergy.BorderThickness = new Thickness(3.0);
                AbilityText.Foreground = Brushes.Red;
                LowLevelEnergy.BorderBrush = Brushes.MistyRose;
                SpecialAbility1.IsEnabled = Engine.Player1.HighLevelEnergyNr > 0 && Engine.Player1.MediumLevelEnergyNr > 0;
                SpecialAbility1.Content = Properties.Resources.redSpecialAbilityText;
                SpecialAbility1.BorderThickness = new Thickness(3.0);
                SpecialAbility1.BorderBrush = Brushes.DarkGoldenrod;
                SpecialAbility2.IsEnabled = Engine.Player1.LowLevelEnergyNr > 1;
                SpecialAbility2.Content = Properties.Resources.redSpecialAbility2Text;
                SpecialAbility2.BorderThickness = new Thickness(3.0);
                SpecialAbility2.BorderBrush = Brushes.Gold;
            }
            else
            {
                HighLevelEnergy.Content = Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.High].ToString();
                HighLevelEnergy.IsEnabled = Engine.Player2.HighLevelEnergyNr > 0;
                HighLevelEnergy.BorderThickness = new Thickness(3.0);
                HighLevelEnergy.BorderBrush = Brushes.DarkBlue;
                MediumLevelEnergy.Content = Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.Medium].ToString();
                MediumLevelEnergy.IsEnabled = Engine.Player2.MediumLevelEnergyNr > 0;
                MediumLevelEnergy.BorderThickness = new Thickness(3.0);
                MediumLevelEnergy.BorderBrush = Brushes.Blue;
                LowLevelEnergy.Content = Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.Low].ToString();
                LowLevelEnergy.IsEnabled = Engine.Player2.LowLevelEnergyNr > 0;
                LowLevelEnergy.BorderThickness = new Thickness(3.0);
                LowLevelEnergy.BorderBrush = Brushes.LightBlue;
                AbilityText.Foreground = Brushes.Blue;
                SpecialAbility1.IsEnabled = Engine.Player2.HighLevelEnergyNr > 0 && Engine.Player2.MediumLevelEnergyNr > 0;
                SpecialAbility1.Content = Properties.Resources.blueSpecialAbilityText;
                SpecialAbility1.BorderThickness = new Thickness(3.0);
                SpecialAbility1.BorderBrush = Brushes.DarkGoldenrod;
                SpecialAbility2.IsEnabled = Engine.Player2.LowLevelEnergyNr > 1;
                SpecialAbility2.Content = Properties.Resources.blueSpecialAbility2Text;
                SpecialAbility2.BorderThickness = new Thickness(3.0);
                SpecialAbility2.BorderBrush = Brushes.Gold;
            }
        }

        private void HighLevelEnergy_Click(object sender, RoutedEventArgs e)
        {
            if (Engine.isRedSideTurn)
            {
                if (Engine.Player1.HighLevelEnergyNr > 0)
                {
                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.High];
                    Engine.Player1.HighLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }
            else
            {
                if (Engine.Player2.HighLevelEnergyNr > 0)
                {
                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.High];
                    Engine.Player2.HighLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }

            _squareUserControl.UpdateEnergyLabels();
            _squareUserControl.UpdateValue(true);

            this.Close();
        }

        private void MediumLevelEnergy_Click(object sender, RoutedEventArgs e)
        {
            if (Engine.isRedSideTurn)
            {
                if (Engine.Player1.MediumLevelEnergyNr > 0)
                {
                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.Medium];
                    Engine.Player1.MediumLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }
            else
            {
                if (Engine.Player2.MediumLevelEnergyNr > 0)
                {
                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.Medium];
                    Engine.Player2.MediumLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }

            _squareUserControl.UpdateEnergyLabels();
            _squareUserControl.UpdateValue(true);
            this.Close();
        }

        private void LowLevelEnergy_Click(object sender, RoutedEventArgs e)
        {
            if (Engine.isRedSideTurn)
            {
                if (Engine.Player1.LowLevelEnergyNr > 0)
                {

                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesRed[Data.Enums.EnergyLevelEnum.Low];
                    Engine.Player1.LowLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }
            else
            {
                if (Engine.Player2.LowLevelEnergyNr > 0)
                {
                    _squareUserControl._currentSquare.Value += Engine.EnergyValuesBlue[Data.Enums.EnergyLevelEnum.Low];
                    Engine.Player2.LowLevelEnergyNr--;
                    _squareUserControl.Disable();
                }
            }

            _squareUserControl.UpdateEnergyLabels();
            _squareUserControl.UpdateValue(true);
            this.Close();
        }

        private void SpecialAbility2_Click(object sender, RoutedEventArgs e)
        {
            if (Engine.isRedSideTurn && Engine.Player1.LowLevelEnergyNr > 1)
            {
                Engine.Player1.LowLevelEnergyNr -= 2;
                _squareUserControl.Disable();
            }
            else if(Engine.Player2.LowLevelEnergyNr > 1)
            {
                Engine.Player2.LowLevelEnergyNr -= 2;
                _squareUserControl.Disable();
            }

            _squareUserControl.UpdateEnergyLabels();
            _squareUserControl.UpdateValue(true, true);
            this.Close();
        }

        private void SpecialAbility1_Click(object sender, RoutedEventArgs e)
        {
            if (Engine.isRedSideTurn && Engine.Player1.HighLevelEnergyNr > 0 && Engine.Player1.MediumLevelEnergyNr > 0)
            {
                Engine.Player1.HighLevelEnergyNr--;
                Engine.Player1.MediumLevelEnergyNr--;
                _squareUserControl.Disable();
            }
            else if(Engine.Player2.HighLevelEnergyNr > 0 && Engine.Player2.MediumLevelEnergyNr > 0)
            {
                Engine.Player2.HighLevelEnergyNr--;
                Engine.Player2.MediumLevelEnergyNr--;
                _squareUserControl.Disable();
            }

            _squareUserControl.UpdateEnergyLabels();
            _squareUserControl.UpdateValue(true, false, true);
            this.Close();
        }
    }
}
