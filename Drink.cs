 using System;

namespace CafeSystem

{

    public class Drink : MenuItem

    {

        public string Size { get; set; }

        public Drink(int id, string name, int price, string size)

            : base(id, name, price)

        {

            Size = size;

        }

        public override void ShowInfo()

        {

            base.ShowInfo();

            Console.WriteLine("Size : " + Size);

        }

    }

}
