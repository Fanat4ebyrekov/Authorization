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
using System.Windows.Threading;
using System.Windows.Forms;

namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для MediaPlayer.xaml
    /// </summary>
    public partial class MediaPlayer : Window
    {
       
        public MediaPlayer()
        {
            InitializeComponent();

            
            
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MediaState ms = MediaState.Play;
            mpMyl.LoadedBehavior = ms;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MediaState ss = MediaState.Stop;
            mpMyl.LoadedBehavior = ss;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            MediaState ps = MediaState.Pause;
            mpMyl.LoadedBehavior = ps;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MP3 Files (*.mp3|*.mp3|MP4 File (*.mp4)|*.mp4|3GP File (*.3gp)|*.3gp|Audio File (*.wma)|*.wma|MOV File (*.mov)|*.mov|AVI File (*.avi)|*.avi|Flash Video(*.wmv)|*.wmv|MPEG-2 File(*.mpeg)|*.mpeg|WebM Video (*.webm)|*.webm|All files (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.ShowDialog();
                string filename = ofd.FileName;
                if (filename !="")
                {
                    tbPyt.Text = filename;
                    Uri uri = new Uri(filename); 
                    mpMyl.Source = uri;
                    mpMyl.Volume = 100.5;
                    MediaState opt = MediaState.Play;
                    mpMyl.LoadedBehavior = opt;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Selection","Empty");
                }
            }
            catch (Exception e1)
            {
                System.Console.WriteLine("Error message: " + e1.Message);
                throw;
            }
        }

        string videoURL = @"C:\Users\Chebyrek\source\repos\Authorization\Authorization\Videos\100_0001.mov";
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri obj = new Uri(videoURL);
                mpMyl.Source = obj;
                MediaState opt = MediaState.Play;
                mpMyl.LoadedBehavior = opt;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error Message: " + ex.Message);
                throw;
            }
        }
    }
}
