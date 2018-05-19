using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.DataBaseContextAndEntitiesDb;

namespace Domain.Basket
{
    public class ListOfProducts
    {
        List<Product> products = new List<Product>();

        public void CreateUpdate(Product product)
        {
            Product temp = products.Where(x => x.Id == product.Id).FirstOrDefault();

            if (temp == null)
            {
                products.Add(product);
            }
            else
            {
                temp.Quantity += product.Quantity;
            }
        }

        public List<Product> Read()
        {
            return products;
        }

        public void Delete(Product product)
        {
            products.RemoveAll(x => x.Id == product.Id);
        }
    }
}
