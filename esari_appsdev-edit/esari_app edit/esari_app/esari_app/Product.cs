using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace esari_app
{
    public class partialProduct
    {
        public string Description { get; set; }
        public double Cost { get; set; }
        public int numberOrdered { get; set; }

        public partialProduct(string description, double cost)
        {
            Description = description;
            Cost = cost;
        }
        
    }
}
