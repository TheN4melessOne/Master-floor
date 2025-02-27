﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity;
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

namespace Master_floor
{
    public partial class HistoryPage : Page
    {
        Entities Context;
        public HistoryPage(Partners partner)
        {
            InitializeComponent();
            Context = new Entities();
            ObservableCollection<Sales> history = new ObservableCollection<Sales>(partner.Sales);
            foreach (Sales sale in history) 
            {
                sale.GetDate();
            }
            HistoryGrid.ItemsSource = history;
        }
    }
}
