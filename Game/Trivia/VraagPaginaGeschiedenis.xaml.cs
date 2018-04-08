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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Trivia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VraagPaginaGeschiedenis : Page
    {
        private string result;
        private Random random = new Random();

        public VraagPaginaGeschiedenis()
        {
            this.InitializeComponent();
            VraagBox.Text = "Inhoud van je vraag";

        }
              static void main()
        {
            next:
            Random question = new Random();
            int x = question.Next(5);
            string[] array = new string[5];
            array[0] = "-Waar was Anne Frank ondergedoken?";
            array[1] = "-Hoe heet het houten paard uit de Griekse mythologie?";
            array[2] = "-Hoe Heette Willem van Oranje ook wel?";
            array[3] = "-Welk dier vereerden de oude Egyptenaren?";
            array[4] = "-Wie was een ondekkingsreiziger?";

            Console.WriteLine(array[x]);

            string[] answer = new string[5];
            answer[0] = "In het achterhuis";
            answer[1] = "het Paard van Troje";
            answer[2] = "Willem de Zwijger";
            answer[3] = "De kat";
            answer[4] = "Christoffel Columbus";

            string a = Console.ReadLine();

            if (a == answer[x])
            {
                Console.WriteLine("It's True \n*Next Question is:");
                goto next;
            }
            else
                Console.WriteLine("It's False \n*Please Try Again.");

            Console.ReadLine();
        }
        
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int a = 1;
        }

       
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Spinner));
        }
        // Deze knop dient als returnbutton om terug te gaan naar de spinner
        
    } 
      
}
