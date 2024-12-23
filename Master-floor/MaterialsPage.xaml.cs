using System;
using System.Collections.Generic;
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
    public partial class MaterialsPage : Page
    {
        Entities Context;
        public MaterialsPage()
        {
            InitializeComponent();
            Context = new Entities();
            var materials = Context.Materials.ToList();
            var production = Context.ProdTypes.ToList();

            MaterialTypeBox.DisplayMemberPath = "matName";
            MaterialTypeBox.SelectedValuePath = "defectPercent";

            ProdTypeBox.DisplayMemberPath = "typeName";
            ProdTypeBox.SelectedValuePath = "coeff";

            MaterialTypeBox.ItemsSource = materials;
            ProdTypeBox.ItemsSource = production;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(ProdAmountBox.Text, out var amount) 
                && amount >= 0
                && MaterialTypeBox.SelectedItem != null 
                && ProdTypeBox.SelectedItem != null
                && float.TryParse(Val1.Text, out float inputValue)
                && inputValue >= 0
                && float.TryParse(Val2.Text, out float inputValue1)
                && inputValue >= 0)
            {
                double ProdFinalAmount = amount * (float)1 / ((float)1 - Convert.ToSingle((MaterialTypeBox.SelectedItem as Materials).defectPercent) / (float) 100); 

                int result = Convert.ToInt32(Math.Ceiling(inputValue * inputValue1 * Convert.ToSingle((ProdTypeBox.SelectedItem as ProdTypes).coeff) * ProdFinalAmount));
                MaterialAmountBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Проверьте данные и повторите попытку.", "Некорректные данные", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
