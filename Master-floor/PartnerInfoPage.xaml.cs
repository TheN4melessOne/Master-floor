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
    public partial class PartnerInfoPage : Page
    {
        Partners partner;
        Entities Context;
        public PartnerInfoPage()
        {
            Context = new Entities();
            InitializeComponent();
            Save.Visibility = Visibility.Collapsed;
            Delete.Visibility = Visibility.Collapsed;
            History.Visibility = Visibility.Collapsed;
            PartType.ItemsSource = Context.PartTypes.ToList();
            PartType.DisplayMemberPath = "typeName";
            PartType.SelectedValuePath = "id";
        }

        public PartnerInfoPage(Partners importPartner)
        {
            Context = new Entities();
            //Context.PartTypes.Where(p => p.id == 1).FirstOrDefault().typeName = "ЗАО";
            //Context.SaveChanges();
            InitializeComponent();
            Create.Visibility = Visibility.Collapsed;
            partner = Context.Partners.ToList().Find(p => p.id == importPartner.id);
            this.DataContext = partner;
            PartType.ItemsSource = Context.PartTypes.ToList();
            PartType.DisplayMemberPath = "typeName";
            PartType.SelectedValuePath = "id";
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "" 
                && INN.Text != ""
                && Email.Text != ""
                && Phone.Text != ""
                && PartType.SelectedValue != null
                && Director.Text != ""
                && Adress.Text != ""
                && int.TryParse(Rating.Text, out var result))
            {
                try
                {
                    Partners newPartner = new Partners() { 
                        partName = Name.Text,
                        director = Director.Text,
                        partAddress = Adress.Text,
                        INN = INN.Text,
                        email = Email.Text,
                        phoneNum = Phone.Text,
                        rating = result,
                        typeId = (PartType.SelectedItem as PartTypes).id,

                    };
                    Context.Partners.Add(newPartner);
                    Context.SaveChanges();
                    MessageBox.Show("Новый партнер добавлен в базу.", "Создание партнера завершено", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch 
                {
                    MessageBox.Show("Произошла ошибка при добавлении даных в базу.", "Ошибка добавления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("В данных допущена ошибка. Проверьте данные и повторите попытку.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != ""
                && INN.Text != ""
                && Email.Text != ""
                && Phone.Text != ""
                && PartType.SelectedValue != null
                && Director.Text != ""
                && Adress.Text != ""
                && int.TryParse(Rating.Text, out var result))
            {
                try
                {
                    Context.SaveChanges();
                    MessageBox.Show("Изменения данных партнера внесены в базу.", "Изменение данных партнера завершено", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при сохранении даных в базу.", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("В данных допущена ошибка. Проверьте данные и повторите попытку.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Удалить партнера {partner.partName} ?", "Подтвердите удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.OK:
                    {
                        try
                        {
                            Context.Partners.Remove(partner);
                            Context.SaveChanges();
                            MessageBox.Show("Удаление завершено");
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка при удалении даных.", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    }
                case MessageBoxResult.Cancel: 
                    {
                        break;
                    }
                default: break;
            }
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
