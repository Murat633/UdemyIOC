using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.Console
{
    public class DAL:IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {
                    Id = 1,
                    Name = "Test",
                    Price = 75,
                    Stock = 250,
                },
                new Product() {
                    Id = 2,
                    Name = "Test2",
                    Price = 110,
                    Stock = 110,
                },
                new Product() {
                    Id = 3,
                    Name = "Test3",
                    Price = 150,
                    Stock = 775,
                }
            };
        }

        public int Hesapla()
        {
            return 0;
        }
    }
}
