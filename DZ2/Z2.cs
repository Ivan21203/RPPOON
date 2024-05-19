using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Z2
    {
        class Product
        {
            public string Name { get; private set; } 
            public string Price { get; private set; } 
            public bool InStock { get; set; } 

            public Product(string name, string price)
            {
                this.Name = name;
                this.Price = price;
                this.InStock = false;
            }
        }

        class ProductHandler
        {
            List<Product> products; 

            public ProductHandler(List<Product> products) 
            {
                products = products;
            }

            public void revive(Product product)
            {
                foreach (Product p in products)
                { 
                    if (product == p)
                        p.InStock = true;
                }
            }
            public void Remove()
            { 
                products.RemoveAll(product => product.InStock == false);
            }
        }
    }
}
