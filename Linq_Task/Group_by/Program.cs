using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_by
{
    public class Program
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public int Rq { get; set; }

    }

    public class LinqQuery
    {
        static void Main(string[] args)
        {
            List<Program> obj1 = new List<Program>()
            {
                new Program()
                {
                    Name = "abc",
                    Number = 123,
                    Quantity = 5,
                    Rq = -1
                },

                new Program() {

                    Name = "abc",
                    Number = 123,
                    Quantity = 10,
                    Rq = 0
                },

                new Program() {

                    Name = "bcd",
                    Number = 345,
                    Quantity = 5,
                    Rq = -5
                }
            };
            var obj2 = obj1.GroupBy(x => new { x.Name, x.Number })
                .Select(y => new
                {
                    y.Key.Name,
                    y.Key.Number,
                    TotalQuantity = y.Sum(x => x.Quantity) - Math.Abs(y.Sum(x => x.Rq)),

                });

            foreach (var x in obj2)
            {
                Console.WriteLine($"Name: {x.Name}, Number: {x.Number}, TotalQuantity: {x.TotalQuantity}");
            }
        }
    }


}
        
            
    


