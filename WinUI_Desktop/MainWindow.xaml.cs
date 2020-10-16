using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "Main Window";
            rootFrame.Navigate(typeof(HomePage));
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {

            LoginButton.Label = "Login";
            //LoginButton.Icon = new SymbolIcon(Symbol.Contact); ;
            rootFrame.Navigate(typeof(LoginPage));

        }

        private void onShouldStartLoadWithRequest()
        {

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {         
            Type pageType = typeof(HomePage);
            var invokedItem = args.InvokedItemContainer;
            if (invokedItem == NavViewItem_Home)
                pageType = typeof(HomePage);
            else if(invokedItem == NavViewItem_Microsoft)
                pageType = typeof(MicrosoftHomePage);
            else if (invokedItem == NavViewItem_Google)
                pageType = typeof(GooglePage);

            rootFrame.Navigate(pageType);

        }
    }
}
