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
    /// Логика взаимодействия для AddCompetitionPage.xaml
    /// </summary>
    public partial class AddCompetitionPage : Page
    {
        private Kozlov_StudlagerEntities _context = App.GetContext();
        public AddCompetitionPage()
        {
            InitializeComponent();

            CompetitionTypeCmb.ItemsSource = _context.Direction.ToList();
            CompetitionTypeCmb.DisplayMemberPath = "Name";
            CompetitionTypeCmb.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CompetitionNameTb.Text))
            {
                TypeCompetition newTypeCompetition = new TypeCompetition()
                {
                    Name = CompetitionNameTb.Text,
                    Direction = CompetitionTypeCmb.SelectedItem as Direction
                };
                _context.TypeCompetition.Add(newTypeCompetition);
                _context.SaveChanges();
                MessageBox.Show("Соревнование добавлено.");
                FrameHelper.selectedFrame.Navigate(new PicturePage());
            }
        }
    }
}
