using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //you could also use float or double, but decimal is more precise for financial calculations
        public decimal Price { get; set; }

    }
}
