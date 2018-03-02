using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.IO;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GameSelector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string choice = RandomGame();
            GameToPlay.Text = choice;
        }

        private string RandomGame()
        {
            Random rnd = new Random();
            var lines = File.ReadAllLines("games.csv").Select(a => a.Split(';'));
            int game = rnd.Next(0, lines.Count());
            string choice = lines.ElementAt(game)[0].ToString();
            return choice;
        }

        private void GameToPlay_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }

}
