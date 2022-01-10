using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FasterThanTheFastest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void FromPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToPicker.SelectedIndex > 0) Button_Clicked(sender, null);
            /*From.Text = "Вы выбрали станцию отбытия: \n" + FromPicker.Items[FromPicker.SelectedIndex];*/
        }
        void ToPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromPicker.SelectedIndex > 0) Button_Clicked(sender, null);
            /*To.Text = "Вы выбрали станцию прибытия: \n" + ToPicker.Items[ToPicker.SelectedIndex];*/
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender != null) Result.IsVisible = true;
            if ((FromPicker.SelectedIndex == 0) && (ToPicker.SelectedIndex == 1)) Result.Source = "Komendantsyi_Chernyshevsaya.png";
            else if ((FromPicker.SelectedIndex == 1) && (ToPicker.SelectedIndex == 0)) Result.Source = "Chernyshevsaya_Komendantsyi.png";
            else if ((FromPicker.SelectedIndex == 4) && (ToPicker.SelectedIndex == 5)) Result.Source = "Ozerky_Krestovskiy.png";
            else if ((FromPicker.SelectedIndex == 5) && (ToPicker.SelectedIndex == 4)) Result.Source = "Krestovskiy_Ozerky.png";
            else if ((FromPicker.SelectedIndex == 6) && (ToPicker.SelectedIndex == 7)) Result.Source = "parkpobedy_nevsky.png";
            else if ((FromPicker.SelectedIndex == 7) && (ToPicker.SelectedIndex == 6)) Result.Source = "nevsky_parkpobedy.png";
            else if ((FromPicker.SelectedIndex == 2) && (ToPicker.SelectedIndex == 3)) Result.Source = "Shyshary_Sadovaya.png";
            else Result.Source = "default1.jpg";
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            int index = ToPicker.SelectedIndex;
            ToPicker.SelectedIndex = FromPicker.SelectedIndex;
            FromPicker.SelectedIndex = index;
            if ((FromPicker.SelectedIndex > 0) && (ToPicker.SelectedIndex > 0)) Button_Clicked(sender, null);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Advice.IsVisible) Advice.IsVisible = false;
            else Advice.IsVisible = true;
            Button_Clicked(null, null);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Result.Source = Result.Source;
            Advice.Source = Advice.Source;
            Button_Clicked(null,null);
        }

    }
}
