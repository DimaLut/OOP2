﻿using System;
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
            dataBase.ShowPLayers();
            

            dataBase.RemovePlayers(1);
            dataBase.ShowPLayers();
            dataBase.BanPlayers(2);
            dataBase.ShowPLayers();
            dataBase.UnbanPlayers(3);
            dataBase.ShowPLayers();
        }
    }

    class DataBase
    {
        private readonly List<Player> players = new List<Player>();
      
        public void AddPlayer(int number, string name, int level)
        {
            Player sounghtPlayer = players.FirstOrDefault(x => x.Number == x.Number);

            if (sounghtPlayer == null)
            {
                Player player1 = new Player(1, "Mike", 2);
                Player player2 = new Player(2, "Bob", 3);
                Player player3 = new Player(3, "Rob", 5, true);
            }
        }

        public void BanPlayers(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                player.Ban();
            }
        }

        public void UnbanPlayers(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                player.Unban();
            }

        }

        public void RemovePlayers(int number)
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

        public void ShowPLayers()
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

        public void Information()
        {
            Console.WriteLine(Name + IsBanned + Number);
        }
    }
}