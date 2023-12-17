using System;
using Xamarin.Forms;

namespace Astronomy.Pages
{
    public partial class AstronomicalBodyPage : ContentPage
    {
        public AstronomicalBodyPage(AstronomicalBody body)
        {
            InitializeComponent();

            Title = body.Name;

            lblIcon.Text = body.EmojiIcon;
            lblName.Text = body.Name;
            lblMass.Text = body.Mass;
            lblCircumference.Text = body.Circumference;
            lblAge.Text = body.Age;
            lblWorkout4.Text = body.Workout4;
            lblWorkout5.Text = body.Workout5;
            lblWorkout6.Text = body.Workout6;
        }
        private void OnLabelClick(object sender, EventArgs e)
        {
            // Open a website link (replace with your desired link)
            Device.OpenUri(new Uri("https://www.muscleandfitness.com/workout-routines/exercise-videos/"));
        }
    }
}