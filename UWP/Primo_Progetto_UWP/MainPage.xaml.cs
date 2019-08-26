using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Primo_Progetto_UWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void BtnPremi_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void BtnVisualizza_Click(object sender, RoutedEventArgs e)
        {
            if (RdbCiao.IsChecked == true)
            {
                MessageDialog dialog = new MessageDialog("Ciao!");
                dialog.ShowAsync();
            }
            else if (RdbAddio.IsChecked == true)
            {
                MessageDialog dialog = new MessageDialog("Addio");
                dialog.ShowAsync();
            }
        }
    }
}