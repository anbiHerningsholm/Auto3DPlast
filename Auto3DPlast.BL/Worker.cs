using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3DPlast.BL
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }
        public void Work()
        {
            PotentialCustomer potCustomer = new PotentialCustomer();
            potCustomer.Reason = "Kunden har ikke råd";

            Product product = new Product();
            List<Product> productList = Product.productList();
            foreach(Product prod in productList)
            {
                Console.WriteLine("{0} {1} {2} {3}", prod.ProductId, product.ProductName, prod.ProductDescription, prod.CurrentPrice);
            }
            Console.ReadLine();
            Console.WriteLine("Nu vil vi gemme produkterne i en fil...");
            product.Log();
        }
    }
}

