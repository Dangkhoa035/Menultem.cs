using System;
namespace CafeSystem
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public MenuItem() { }

        public MenuItem(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Id} / {Name} / {Price}원");
        }
    }
}
