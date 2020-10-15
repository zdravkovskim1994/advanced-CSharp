using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_2_test
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<string> questions = new List<string>()
            {
                "1.Sort the Invoice objects by Part Description.",
                "2.Sort the Invoice objects by Price descending.",
                "3.Select the Part Description and Quantity and sort the results by Quantity.",
                "4.Select from each Invoice the Part Description and the value of the Invoice. Name the calculated column invoice Total. Order the results by Invoice value.",
                "5.Select the invoice Totals in the range $200 to $500."
            };

                foreach (var item in questions)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nEnter: ");

                Invoice[] invoices =
                {
                new Invoice(83, "Electric Sander", 7, 57.98),
                new Invoice(24, "Power saw", 18, 99.99),
                new Invoice(7, "Sledge hammer", 11, 21.50),
                new Invoice(77, "Hammer", 76, 11.99),
                new Invoice(39, "Lawn mower", 3, 79.50),
                new Invoice(68, "Screwdriver", 106, 6.99),
                new Invoice(56, "Jig saw", 21, 11.00),
                new Invoice(3, "Wrench", 34, 7.50)
        };

                int menu = Convert.ToInt32(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        var descriptionSorted =
                            from i in invoices
                            orderby i.PartDescription
                            select i;
                        PrintElements(descriptionSorted);
                        break;
                    case 2:
                        var priceDescending =
                            from i in invoices
                            orderby i.Price descending
                            select i;
                        PrintElements(priceDescending);
                        break;
                    case 3:
                        var sort =
                            from i in invoices
                            orderby i.Quantity
                            select new { i.PartDescription, i.Quantity };
                        foreach (var item in sort)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        var invoiceTotal =
                            from i in invoices
                            let total = i.Price * i.Quantity
                            orderby total descending
                            select new { i.PartDescription, total };
                        foreach (var item in invoiceTotal)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        var invoiceTotalsRange =
                    from i in invoices
                    let total = i.Price * i.Quantity
                    where (Convert.ToInt32(total) >= 200) && (Convert.ToInt32(total) <= 500)
                    orderby total descending
                    select new { i.PartDescription, total };
                        foreach (var item in invoiceTotalsRange)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                }
                Console.WriteLine("Exit y/n");
            } while (Console.ReadLine() != "y");
        }
     

        public static void PrintElements(IEnumerable<Invoice> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.PartNumber} {item.PartDescription} {item.Quantity} {item.Price}");
            }
        }

    }
}
