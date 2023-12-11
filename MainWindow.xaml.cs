using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MyTube_Music
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] paths, files;
        string[] ss = new string[10];
        TimeSpan position;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            player.LoadedBehavior = MediaState.Manual;
            //AutoAdd();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            if (player.Source != null)
            {
                startBlock.Text = player.Position.ToString(@"mm\:ss");
                endBlock.Text = player.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                slider.Value = player.Position.TotalSeconds;
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();

        }

        private void trackList_Selected(object sender, RoutedEventArgs e)
        {
            player.Source = new Uri(paths[trackList.SelectedIndex]);
            player.Play();
        }

        private void player_MediaOpened(object sender, RoutedEventArgs e)
        {
            position = player.NaturalDuration.TimeSpan;
            slider.Minimum = 0;
            slider.Maximum = position.TotalSeconds;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            borderSideMenuBar.BorderThickness = new Thickness(0, 0, 0.2, 0);
            headBar.BorderThickness = new Thickness(0, 0, 0, 0.2);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "mp3 file (*.mp3)|*.mp3";

            if (ofd.ShowDialog() == true)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    trackList.Items.Add(files[i]);
                }
            }
        }


    }
}