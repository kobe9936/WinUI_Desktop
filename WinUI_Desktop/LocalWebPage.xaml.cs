using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_Desktop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocalWebPage : Page
    {
        public LocalWebPage()
        {
            this.InitializeComponent();
            WebActiveAsync();
        }

        private async void WebActiveAsync()
        {
            var storageFile = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Web/index.html"));
            LocalWebView.Source = new Uri(storageFile.Path);
        }
        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            await LocalWebView.ExecuteScriptAsync($"alert(' is not safe, try an https link')");
        }
    }
}
