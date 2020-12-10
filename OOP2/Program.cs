using System;
using System.Collections.Generic;
using System.Linq;

namespace ООП
{
    class Program
    {
        static void Main(string[] args)
        {
       
            

            DataBase dataBase = new DataBase();
            dataBase.AddPlayer(1, "Mike", 2);
            dataBase.AddPlayer(2, "Bob", 3);
            dataBase.AddPlayer(3, "Rob", 5);
            dataBase.ShowPLayer();
            

            dataBase.RemovePlayer(1);
            dataBase.ShowPLayer();
            dataBase.BanPlayer(2);
            dataBase.ShowPLayer();
            dataBase.UnbanPlayers(3);
            dataBase.ShowPLayer();
        }
    }

    class DataBase
    {
        public List<Player> players {private get; set;}

        public DataBase()
        {
            players = new List<Player>();
        }

        public void AddPlayer(int number, string name, int level)
        {
            Player sounghtPlayer = players.FirstOrDefault(x => x.Number == x.Number);

            if (sounghtPlayer == null)
            {
                Player player1 = new Player(number, name, level);

            }
            else
            {
                Console.WriteLine("Нельзя выполнить данное действие. Попробуйте еще раз.");
            }
        }

        public void BanPlayer(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                player.Ban();
            }
            Console.WriteLine("Нельзя выполнить данное действие. Попробуйте еще раз.");
        }

        public void UnbanPlayers(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                player.Unban();
            }

        }

        public void RemovePlayer(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                players.Remove(player);
            }
            else
            {
                Console.WriteLine("Нельзя выполнить данное действие. Попробуйте еще раз.");
            }
        }

        public void ShowPLayer()
        {
            Console.WriteLine("Start");

            players.ForEach(x =>
            {
                Console.WriteLine(x.Name + x.IsBanned + x.Number);
            });

            Console.WriteLine("End");
        }
    }

    class Player
    {
        public int Number { get; }

        public string Name { get; }
        public int Level { get; }

        public bool IsBanned { get; private set; }

        public Player(int number, string name, int level, bool isBanned)
        {
            Number = number;
            Name = name;
            Level = level;
            IsBanned = isBanned;
        }

        public Player(int number, string name, int level)
        {
            Number = number;
            Name = name;
            Level = level;
            IsBanned = false;
        }

        public void Ban()
        {
            IsBanned = true;
        }

        public void Unban()
        {
            IsBanned = false;
        }

        public void GetInformation()
        {
            Console.WriteLine(Name + IsBanned + Number);
        }
    }
}