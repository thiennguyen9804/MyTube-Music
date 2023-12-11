using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyTube_Music
{
    internal class Song
    {
        public BitmapImage image { get; set; }
        public string title { get; set; }
        public string artist { get; set; }

        public string path { get; set; }


        public Song(BitmapImage image, string title, string artist , string path)
        {
            this.image = image;
            this.title = title;
            this.artist = artist;
            this.path = path;
        }
    }
}
