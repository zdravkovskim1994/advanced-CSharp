using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_2_test
{
    class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }


        public Invoice(int partNumber, string partDescription, int quantity, double pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = pricePerItem;
        }


    }
}
