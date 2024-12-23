using System;
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
    /// <summary>
    /// Логика взаимодействия для PartnersPage.xaml
    /// </summary>
    public partial class PartnersPage : Page
    {
        Entities Context;
        ObservableCollection <Partners> Partners;
        public PartnersPage()
        {
            InitializeComponent();
            Context = new Entities();

            Partners = new ObservableCollection<Partners>(Context.Partners
                .Include(p => p.PartTypes)
                .Include(p => p.Sales)
                .ToList());
            foreach (Partners partner in Partners) 
            {
                partner.Discount();
            }
            PartnerList.ItemsSource = Partners;
            MessageBox.Show( $"{Partners.First().discount}");
        }

        private void PartnerInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PartnerInfoPage());
        }

        private void PartnerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(PartnerList.SelectedItem != null)
            {
                PartnerInfoPage partner = new PartnerInfoPage(PartnerList.SelectedItem as Partners);
                NavigationService.Navigate(partner);
                PartnerList.SelectedItem = null;
            }
            //после selectionchanged нужно обновлять выделение
        }
    }
}
