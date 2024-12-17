using System;
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

namespace Master_floor
{
    /// <summary>
    /// Логика взаимодействия для PartnersPage.xaml
    /// </summary>
    public partial class PartnersPage : Page
    {
        Entities Context;
        ObservableCollection <object> Partners;
        public PartnersPage()
        {
            InitializeComponent();
            Context = new Entities();
            Partners = new ObservableCollection <object>( Context.Partners.Join(
                Context.PartTypes,
                p => p.typeId,
                t => t.id,
                (p, t) => new {
                    typeName = t.typeName,
                    id = p.id,
                    name = p.partName,
                    director = p.director,
                    phone = p.phoneNum,
                    adress = p.partAddress,
                    rating = p.rating,
                    inn = p.INN,
                    email = p.email} ) );
            PartnerList.ItemsSource = Partners;
        }
    }
}
