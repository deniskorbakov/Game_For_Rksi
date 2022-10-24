
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введите имя первого игрока: ");
        string username1 = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Введите имя второго игрока: ");
        string username2 = Console.ReadLine();

        Random rand = new Random();

        int game_number = rand.Next(12, 120);

        int motion_1;
        int motion_2;

        bool isopen = true;

        Console.WriteLine();

        while (isopen)
        {
            Console.Clear();

            Console.WriteLine($"Число: {game_number}");
            Console.Write($"Ход {username1}: ");

            motion_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            while (true)
            {
                if (motion_1 > 4)
                {
                    Console.Write("Введите число повторно: ");
                    motion_1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();


                }

                else
                {
                    game_number -= motion_1;
                    break;
                }
            }


            if (game_number <= 0)
            {
                Console.WriteLine($"Победил игрок - {username1}");
                Console.WriteLine();

                Console.Write("Если хотите продолжить нажмите: 1 если закончить игру нажмите: 2 " +
                    "\nВведите число: ");

                int choice_player1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice_player1 == 1)
                {
                    game_number = rand.Next(12, 127);
                    continue;
                }

                else
                {
                    isopen = false;
                }
            }

            Console.Clear();

            Console.WriteLine($"Число: {game_number}");
            Console.Write($"Ход {username2}: ");

            motion_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            while (true)
            {
                if (motion_2 > 4)
                {
                    Console.Write("Введите число повторно: ");
                    motion_2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();



                }

                else
                {
                    game_number -= motion_2;
                    break;
                }
            }

            if (game_number <= 0)
            {
                Console.WriteLine($"Победил игрок - {username2}");
                Console.WriteLine();

                Console.Write("Если хотите продолжить нажмите: 1 если закончить игру нажмите: 2 " +
                    "\nВведите число: ");

                int choice_player2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice_player2 == 1)
                {
                    game_number = rand.Next(12, 120);
                    continue;
                }

                else
                {
                    isopen = false;
                }
            }


        }
    }

}
//gg



