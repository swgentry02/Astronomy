using Xamarin.Forms;

namespace Astronomy.Pages
{
    public partial class AstronomicalBodiesPage : ContentPage
    {
        public AstronomicalBodiesPage()
        {
            InitializeComponent();

            btnChest.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(BodySystemData.Chest));
            btnMoon.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(BodySystemData.Legs));
            btnSun.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(BodySystemData.Arms));
            btnComet.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(BodySystemData.Back));
        }
    }
}