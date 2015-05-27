using System;
using System.Windows;
using Microsoft.Phone.Controls;
using System.Windows.Input;

namespace Kostrad
{
    public partial class MainPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        #region Private methods

        private static void NavigateToUrl(string url)
        {
            var uri = new Uri(url, UriKind.Relative);
            ((PhoneApplicationFrame)Application.Current.RootVisual).Navigate(uri);
        }

        #endregion

        #region Events

        private void OnApplicationBarAboutIconButtonClick(object sender, EventArgs e)
        {
            NavigateToUrl("/Views/AboutView.xaml");
        }

        private void OnTextBlockFishTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/FishGuide.xaml");
        }

        private void OnTextBlockCheeseTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/CheeseGuide.xaml");
        }

        private void OnTextBlockMeatTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/MeatGuide.xaml");
        }

        private void OnTextBlockNutritionTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/NutritionGuide.xaml");
        }

        private void OnTextBlockBacteriaTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/BacteriaGuide.xaml");
        }

        private void OnTextBlockInfoTap(object sender, GestureEventArgs e)
        {
            NavigateToUrl("/Views/InfoGuide.xaml");
        }

        #endregion

    }
}