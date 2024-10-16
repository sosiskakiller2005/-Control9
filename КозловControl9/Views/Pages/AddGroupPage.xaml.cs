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
using System.Windows.Navigation;
using System.Windows.Shapes;
using КозловControl9.AppData;
using КозловControl9.Model;

namespace КозловControl9.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        private Kozlov_StudlagerEntities _context = App.GetContext();
        public AddGroupPage()
        {
            InitializeComponent();
            SpecializationCmb.ItemsSource = _context.Specialization.ToList();
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GroupNameTb.Text))
            {
                MessageBox.Show("Введите название группы");
            }
            else
            {
                Group newGroup = new Group()
                {
                    Name = GroupNameTb.Text,
                    Specialization = SpecializationCmb.SelectedItem as Specialization
                };
                MessageBox.Show("Группа добавлена");
                FrameHelper.selectedFrame.Navigate(new PicturePage());
            }
        }
    }
}
