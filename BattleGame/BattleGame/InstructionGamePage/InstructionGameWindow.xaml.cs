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

namespace BattleGame
{
    /// <summary>
    /// Interaction logic for Instruction.xaml
    /// </summary>
    public partial class InstructionGameWindow : Window
    {
        public InstructionGameWindow()
        {
            InitializeComponent();
            InitTextToElements();
        }

        public void InitTextToElements()
        {
            aboutGameDesc.Text = Properties.Resources.aboutGameText;
            aboutTurn.Text = Properties.Resources.turnPhasesText;
            abilityTopText.Text = Properties.Resources.basicAbilityText;
            abilityBottomText.Text = Properties.Resources.special1Text;
            abilityCenterText.Text = Properties.Resources.special2Text;
            gameFinalText.Text = Properties.Resources.finalCasesText;
        }
    }
}
