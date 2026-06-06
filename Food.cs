using System;

namespace CafeSystem

{

    public class Food : MenuItem

    {

        public int Calories { get; set; }

        public Food(int id, string name, int price, int calories)

            : base(id, name, price)

        {

            Calories = calories;

        }

        public override void ShowInfo()

        {

            base.ShowInfo();

            Console.WriteLine("Calories : " + Calories);
     }
 }
}
