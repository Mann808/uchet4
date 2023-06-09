﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace uchetrachodov4
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<funcional> classes;
        public MainWindow()
        {
            InitializeComponent();
            classes = new ObservableCollection<funcional>(funcional.ConstructTestData());
            this.DataContext = classes;
        }
        private void AddNewItem(object sender, RoutedEventArgs e)
        {
            funcional asset = new funcional { Category = "Источник расходов" };
            classes.Add(asset);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удалить", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                change.Items.RemoveAt(0);
            }
        }
    }


}
