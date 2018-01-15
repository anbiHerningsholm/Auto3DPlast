using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3DPlast.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Product(int productId, string productName, string productDescription, double currentPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            CurrentPrice = currentPrice;

        }

        public double? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product
            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public static List<Product> productList()
        {
            List<Product> list = new List<Product>()
            {
                { new Product(1235, "VW kofanger", "Blå kofanger til VW Up", 465.34) },
                { new Product(1298, "Audi kofanger", "Blå kofanger til Audi TT", 567.78)},
                { new Product(3321, "Audi kofanger", "Gul kofanger til Audi TT", 567.78)},
                { new Product(4321, "VW motorventil", "Gul motorventil til VW Golf", 32.65)},
                { new Product(5987, "VW motorventil 2", "Blå motorventil til VW Passat", 34.95)},
                { new Product(6121, "Skoda stænklap", "Sort stænklap til Skoda Fabia", 134.87)},
                { new Product(1227, "Skoda stænklap 2", "Sort stænklap til Skoda Superb", 165.12)},
                { new Product(1248, "VW gearknop", "Rød gearknop, passer til Polo og Golf", 4750)},
                { new Product(2329, "Audi gearknop", "Rød gearknop, passer til Audi A3 og A4", 4750)},
                { new Product(1090, "Skoda gearknop", "Rød gearknop, passer til Fabia og Octavia", 4750)},
          };
            return list;
        }

        public void Log()
        {
            List<Product> list = productList();
            foreach (Product product in list)
            {
                string log = product.ProductId + "; " + product.ProductName + "; " + product.ProductDescription + product.CurrentPrice + "; " + "\r\n";
                System.IO.File.AppendAllText(@"C:\Users\ANBI\Documents\Visual Studio 2017\Projects\Auto3DPlast\testLog.txt", log);
            }
        }
}
}
