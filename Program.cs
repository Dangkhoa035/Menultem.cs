using System;

namespace CafeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CafeManager manager = new CafeManager();

            while (true)
            {
                Console.WriteLine("1. 메뉴 추가");
                Console.WriteLine("2. 메뉴 삭제");
                Console.WriteLine("3. 메뉴 조회");
                Console.WriteLine("4. 종료");

                Console.Write("선택 : ");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        manager.AddMenu();
                        break;

                    case 2:
                        manager.DeleteMenu();
                        break;

                    case 3:
                        manager.ShowMenu();
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}
