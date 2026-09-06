using System.Windows;

namespace WPFTutorial_KampaPlays
{
    public partial class MainWindow : Window
    {
        private bool running = false;
        public MainWindow()
        {
            InitializeComponent();
            
            //Must subscribe to an efvent. Properties are wrenches in xaml. Lightning bolts are events.

        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if (!ReferenceEquals(sender, btnRun))
                return;
            
            if (running)
            {
                btnRun.Content = "Run";
                tbHelloWorld.Text = "Stopped";
            }
            else
            {
                btnRun.Content = "Stop";
                tbHelloWorld.Text = "Running";
            }
            running = !running;
        }
    }
}