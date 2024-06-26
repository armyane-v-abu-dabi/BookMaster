﻿using BookMaster.Models;
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
    /// Логика взаимодействия для BookAuthorsDetails.xaml
    /// </summary>
    public partial class BookAuthorsDetails : Window
    {
        public BookAuthorsDetails(BookAuthor selectedBookAuthor)
        {
            InitializeComponent();
            AuthorsGrid.DataContext = selectedBookAuthor;
            AuthorCmb.ItemsSource = App._context.Author.ToList();
            AuthorCmb.SelectedItem = selectedBookAuthor.Author;
            AuthorCmb.DisplayMemberPath = "FullName";
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void AuthorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookAuthor selectedBookAuthor = AuthorCmb.SelectedItem as BookAuthor;
            AuthorsGrid.DataContext = selectedBookAuthor;
        }
    }
}
