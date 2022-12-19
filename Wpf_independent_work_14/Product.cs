using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum ProductCategories//перечисление категорий товаров
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }//название
        public decimal Price { get; set; }//цена
        public string Image { get; set; }//тзображение
        public ProductCategories ProductCategory { get; set; }//категория
    }
}
