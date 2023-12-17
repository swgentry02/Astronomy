using System;
using Xamarin.Forms;

namespace Astronomy.Pages
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage ()
        {
            InitializeComponent ();

        }
        private void OnLabelClicked(object sender, EventArgs e)
        {
            // Open a website link (replace with your desired link)
            Device.OpenUri(new Uri("https://www.muscleandfitness.com/workout-routines/"));
        }

    }
}