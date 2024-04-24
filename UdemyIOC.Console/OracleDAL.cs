using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.Console
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {
                    Id = 1,
                    Name = "oracle Test",
                    Price = 75,
                    Stock = 250,
                },
                new Product() {
                    Id = 2,
                    Name = "oracle Test 2",
                    Price = 110,
                    Stock = 110,
                },
                new Product() {
                    Id = 3,
                    Name = "oracle Test 3",
                    Price = 150,
                    Stock = 775,
                }
            };
        }
    }
}
