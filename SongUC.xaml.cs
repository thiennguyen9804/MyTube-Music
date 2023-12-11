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
using static System.Net.Mime.MediaTypeNames;

namespace MyTube_Music
{
    /// <summary>
    /// Interaction logic for SongUC.xaml
    /// </summary>
    public partial class SongUC : UserControl
    {
        public SongUC()
        {
            InitializeComponent();
            BitmapImage y = new BitmapImage();
            y.BeginInit();
            y.UriSource = new Uri(@"D:\Visual Programming\MyTube Music\Song Images\Heat Waves Image.png");
            y.EndInit();
            string p = @"D:\\1-Download\\y2mate.com - heat waves  JP ver.mp3\";

            Song x = new Song(
               y,
               "Heat Waves (Japanese Version)",
               "Lime",
               p
               );
            SongImage.Source = x.image;
            TitleBlock.Text = x.title;
            ArtistBlock.Text = x.artist;


        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
           //this.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        private void SongImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*
            SongUC x = (SongUC)sender;
            */
            
        }
    }
}
