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

namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {

        GameSessionViewModel _gameSessionViewModel;
        private string Messages;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;
           // ActiveEnemies.Items.Add("Testing");
            InitializeComponent();
            Messages = _gameSessionViewModel.Messages;
        }

        private void GameOptions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SkillsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
