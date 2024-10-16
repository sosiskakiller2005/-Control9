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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        private Kozlov_StudlagerEntities _context = App.GetContext();
        private List<TypeCompetition> typeCompetitions = App.GetContext().TypeCompetition.ToList();
        private List<Group> groups = App.GetContext().Group.ToList();
        public AccountingPage()
        {
            InitializeComponent();

            AccountingLv.ItemsSource = _context.Accounting.ToList();

            SpecializationCmb.ItemsSource = _context.Specialization.ToList();
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.SelectedIndex = 0;
            CompetitionStatusCmb.ItemsSource = _context.Direction.ToList();
            CompetitionStatusCmb.DisplayMemberPath = "Name";
            CompetitionStatusCmb.SelectedIndex = 0;
            GroupCmb.ItemsSource = groups;
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.SelectedIndex = 0;
            CompetitionCmb.ItemsSource = typeCompetitions;
            CompetitionCmb.DisplayMemberPath = "Name";
            CompetitionCmb.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (GroupCmb.SelectedIndex == -1 || CompetitionStatusCmb.SelectedIndex == -1 || AccountingDP.SelectedDate == null || string.IsNullOrEmpty(EvaluationTb.Text))
            {
                MessageBox.Show("Заполните все поля для ввода.");
            }
            else
            {
                Accounting newAccounting = new Accounting()
                {
                    DateGame = (DateTime)AccountingDP.SelectedDate,
                    Group = GroupCmb.SelectedItem as Group,
                    TypeCompetition = CompetitionCmb.SelectedItem as TypeCompetition,
                    Evaluation = Convert.ToDecimal(EvaluationTb.Text)
                };
                _context.Accounting.Add(newAccounting);
                _context.SaveChanges();
                MessageBox.Show("Запись добавлена.");
                FrameHelper.selectedFrame.Navigate(new PicturePage());
            }
        }

        private void SpecializationCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GroupCmb.ItemsSource = groups.Where(g => g.Specialization == SpecializationCmb.SelectedItem as Specialization);
        }

        private void CompetitionStatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CompetitionCmb.ItemsSource = typeCompetitions.Where(tp => tp.Direction == CompetitionStatusCmb.SelectedItem as Direction);
        }
    }
}
