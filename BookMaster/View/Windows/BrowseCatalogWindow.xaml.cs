using BookMaster.Models;
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

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        static Kozlov_BookmasterEntities _context = App._context;
        public BrowseCatalogWindow()
        {
            InitializeComponent();
            bookAuthorsLv.ItemsSource = _context.BookAuthor.ToList();
            countOfBooksTbl.DataContext = _context.Book.ToList();
            bookGrid.DataContext = _context.Book.ToList();
            LibraryMi.Visibility = Visibility.Collapsed;
            LoginMi.Visibility=Visibility.Visible;
            LogoutMi.Visibility=Visibility.Collapsed;
        }

        private void bookAuthorsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bookGrid.DataContext = bookAuthorsLv.SelectedItem as BookAuthor;
            desTbl.Visibility = Visibility.Visible;
        }


        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            BookAuthor selectedBookAuthor = bookAuthorsLv.SelectedItem as BookAuthor;
            BookAuthorsDetails bookAuthorsDetails = new BookAuthorsDetails(selectedBookAuthor);
            bookAuthorsDetails.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            LogoutMi.Visibility = Visibility.Visible;
            LoginMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Visible;
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {
            LogoutMi.Visibility = Visibility.Collapsed;
            LoginMi.Visibility = Visibility.Visible;
            LibraryMi.Visibility = Visibility.Collapsed;
        }
        private void ExitMe_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomresWindow manageCustomersWindow = new ManageCustomresWindow();
            manageCustomersWindow.Show();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            CirculationWindow circulationWindow = new CirculationWindow();
            circulationWindow.Show();
        }

        private void ReoprtsMi_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTb.Text;
            string author = AuthorTb.Text;
            bookAuthorsLv.ItemsSource = App._context.BookAuthor.Where(ba => ba.Book.Title.Contains(title) && ba.Author.Lastname.Contains(author)).ToList();
        }
    }
}
