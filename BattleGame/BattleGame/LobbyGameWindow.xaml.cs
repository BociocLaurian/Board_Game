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
using BattleGame.Core;
using BattleGame.Data.Entities;


namespace BattleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LobbyGameWindow : Window
    {
        public LobbyGameWindow()
        {
            _gameOptions = Engine.GetGameOptions();
            InitializeComponent();
            cmbBoxDifficulty.SelectedIndex = 1;
            InitControlsWithText();
        }

        private Dictionary<int, string> _gameOptions;

        public Dictionary<int, string> GameOptions
        {
            get { return _gameOptions; }
            set { _gameOptions = value; }
        }
   
        private void InstructionBtn_Click(object sender, RoutedEventArgs e)
        {
            InstructionGameWindow instructionWindow = new InstructionGameWindow();
            instructionWindow.Show();           
        }

        private void EnterGameBtn_Click(object sender, RoutedEventArgs e)
        {
            Engine.Player1 = new Player(Player1RedNametxtbox.Text);
            Engine.Player2 = new Player(Player2BlueNametxtbox.Text);
            int selectedValue = cmbBoxDifficulty.SelectedIndex;
            if (selectedValue == 0)
                Engine.Counter = 60;

            else if (selectedValue == 1)
                Engine.Counter = 40;
            else
                Engine.Counter = 20;

            if (CheckTextBox())
            {              
                MainGameWindow game = new MainGameWindow();
                game.Show();
                Close();
            }
            else if (!CheckTextBox())
            { MessageBox.Show(Properties.Resources.entryGameWindowMessage); }
           
        }

        public void InitControlsWithText()
        {
            GameName.Content = Properties.Resources.gameTitle;
            Player1RedSide.Content = Properties.Resources.redSide;
            Player2BlueSide.Content = Properties.Resources.blueSide;
            Player1RedSidelbl.Content = Properties.Resources.redSideLbl;
            Player2BlueSidelbl.Content = Properties.Resources.blueSideLbl;
            ChooseGameDifficultyText.Text = Properties.Resources.gameDifficultyText;
            InstructionBtn.Content= Properties.Resources.instrBtnText;
            StartBtn.Content = Properties.Resources.startBtnText;
            extraTextPage.Content = Properties.Resources.extraBtnTxt;
        }

        public bool CheckTextBox()
        {
            bool redCheck = false;
            bool blueCheck = false;
            bool ready = false;
            string redPlayerName = Player1RedNametxtbox.Text;
            string bluePlayerName = Player2BlueNametxtbox.Text;
            redCheck = string.IsNullOrEmpty(redPlayerName);
            blueCheck = string.IsNullOrEmpty(bluePlayerName);

            if (redCheck == false && blueCheck==false)
            {
                ready = true;
            }
            return ready;
        }

        private void extraTextPage_Click(object sender, RoutedEventArgs e)
        {
            ExtraPage extraWindow = new ExtraPage();
            extraWindow.Show();
        }
    }
}
