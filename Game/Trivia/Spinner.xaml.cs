using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.Toolkit.Uwp;
using Microsoft.Toolkit.Uwp.UI.Animations;
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
    public sealed partial class Spinner : Page
    {
        Random random = new Random();
        int randomrotation;

        public Spinner()
        {
            this.InitializeComponent();
            randomrotation = random.Next(360);
            var animation = SpinnerButton.Rotate(value: 3600f + randomrotation, centerX: 92, centerY: 92, duration: 10000, delay: 200, easingType: EasingType.Circle);
            animation.Start();
            animation.Completed += Animation_Completed;
        }

        private void Animation_Completed(object sender, AnimationSetCompletedEventArgs e)
        {
            if (randomrotation >= 0 && randomrotation < 120)
            {
                this.Frame.Navigate(typeof(VraagPaginaAardrijkskunde));
            }
            else if (randomrotation >= 120 && randomrotation < 240)
            {
                this.Frame.Navigate(typeof(VraagPaginaNatuur));
            }
            else
            {
                this.Frame.Navigate(typeof(VraagPaginaGeschiedenis));
            }
        }
    }
}
  

        //0 <= x < 120 -> aardrijkskunde
        //120 <= x < 240 -> natuur
        //240 <= x < 360 -> geschiedenis
        