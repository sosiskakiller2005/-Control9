using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using КозловControl9.AppData;
using КозловControl9.Views.Pages;

namespace КозловControl9.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();

            FrameHelper.selectedFrame = MainFrm;
            MainFrm.Navigate(new PicturePage());
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddGroupPage());
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddCompetitionPage());
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AccountingPage());
        }
    }
}
