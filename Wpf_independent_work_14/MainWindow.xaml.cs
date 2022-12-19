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

namespace Wpf_independent_work_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Яблоки",
                Price = 100,
                Image = "Data/яблоки.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Мандарины",
                Price = 190,
                Image = "Data/мандарины.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Киви",
                Price = 130,
                Image = "Data/киви.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Смартфон",
                Price = 55000,
                Image = "Data/смартфон.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                Name = "Наушники",
                Price = 20000,
                Image = "Data/наушники.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                Name = "Виниловый проигрыватель",
                Price = 250000,
                Image = "Data/виниловый проигрыватель.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
