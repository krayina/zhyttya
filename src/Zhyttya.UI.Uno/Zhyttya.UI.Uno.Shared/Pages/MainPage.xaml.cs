using Microsoft.UI.Xaml.Controls;

namespace Zhyttya.UI.Uno.Pages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnAcceptButtonClicked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            acceptButton.Content = "Отправить заявку";
            prisonerInfoStackPanel.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
            ownerInfoStackPanel.Visibility = Microsoft.UI.Xaml.Visibility.Visible;
            headerTextBlock.Text = "Данные для связи";
        }
    }
}
