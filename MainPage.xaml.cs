using FoodASM.Models;
using FoodASM.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FoodASM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame mainFrame;

        public MainPage()
        {
            this.InitializeComponent();
            mainFrame = MainFrame;
        }
        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem((char)(Convert.ToInt32("E80F", 16)), "Home", "home"));
            MN.Items.Add(new MenuItem((char)(Convert.ToInt32("EA4A", 16)), "Contact", "listContact"));
            MN.Items.Add(new MenuItem((char)(Convert.ToInt32("E715", 16)), "Email", "listMail"));
            MN.Items.Add(new MenuItem((char)(Convert.ToInt32("E77B", 16)), "Customer", "listCustomer"));
        }
        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)MN.SelectedItem;
            if (selected.Des.Equals("home"))
            {
                MainFrame.Navigate(typeof(Home));
            }
            else if (selected.Des.Equals("listContact"))
            {
                MainFrame.Navigate(typeof(ListContact));
            }
            else if (selected.Des.Equals("listMail"))
            {
                MainFrame.Navigate(typeof(ListMail));
            }
            else if(selected.Des.Equals("listCustomer"))
            {
                MainFrame.Navigate(typeof(ListCustomer));
            }
        }
        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Home));
        }
    }
}

