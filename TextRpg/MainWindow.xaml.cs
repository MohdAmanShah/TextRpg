using Engine.ViewModel;
using System.Windows;

namespace TextRpg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _session;
        public MainWindow()
        {
            InitializeComponent();
            _session = new GameSession();
            DataContext = _session;
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _session.CurrentPlayer.ExperiencePoints += 10;
        }
    }
}