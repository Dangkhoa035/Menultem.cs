using System;
using System.Collections.Generic;

namespace CafeSystem
{
    public class CafeManager : IManager
    {
        private List<MenuItem> menuList = new List<MenuItem>();

        public void AddMenu()
        {
            Console.Write("ID : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("이름 : ");
            string name = Console.ReadLine();

            Console.Write("가격 : ");
            int price = int.Parse(Console.ReadLine());

            menuList.Add(new MenuItem(id, name, price));

            Console.WriteLine("메뉴 추가 완료!");
        }

        public void DeleteMenu()
        {
            Console.Write("삭제할 ID : ");
            int id = int.Parse(Console.ReadLine());

            MenuItem found = menuList.Find(x => x.Id == id);

            if (found != null)
            {
                menuList.Remove(found);
                Console.WriteLine("삭제 완료!");
            }
            else
            {
                Console.WriteLine("메뉴 없음");
            }
        }

        public void ShowMenu()
        {
            foreach (MenuItem item in menuList)
            {
                item.ShowInfo();
            }
        }
    }
}
