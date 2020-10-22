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
using System.Diagnostics;
using System.Drawing;
using Microsoft.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_Desktop.Clipboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImageSelector : Page
    {
        public static string PickedPicPath;
        public ImageSelector()
        {
            this.InitializeComponent();
            ini();
        }
        public void ini()
        {

            getDirFolder();
        }
        public void getDirFolder()
        {

            try
            {
                // Only get files that begin with the letter "jpg" or "png".
                IEnumerable<string> dirs = Directory.GetFiles(@"C:\Users\User\Pictures\", "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg")); ;
                //add item to UI
                ListView UserImages = new ListView();
                
                foreach (string dir in dirs)
                {

                    Debug.WriteLine(dir);
                    UserImages.Items.Add(dir);
                    
                    
                    UserImages.Background = new SolidColorBrush(Colors.Black); 
                }
                
                ImagePickerPanel.Children.Add(UserImages);
                UserImages.IsItemClickEnabled = true;
                UserImages.ItemClick += getImage;
            }
            catch
            {
                Debug.WriteLine("The process failed.");
            }
        }
        public void getImage(object sender, ItemClickEventArgs e)
        {
            PickedPicPath = e.ClickedItem.ToString();
        }

        public void TurnTo_ImgCopy(object sender, RoutedEventArgs e)
        {

            var parameters = new pickerParameter();
            parameters.parentPage = "ImgPicker";
            parameters.singlePicPath = PickedPicPath;
            ImgSelectorFrame.Navigate(typeof(ImgCopy), parameters);
        }
    }
}
