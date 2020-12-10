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
            
            dataBase.RemovePlayer(1);
            dataBase.ShowPLayers();
            dataBase.BanPlayer(2);
            dataBase.ShowPLayers();
            dataBase.UnbanPlayer(3);
            dataBase.ShowPLayers();
        }
    }

    class DataBase
    {
        private List<Player> players { get; set;}

        public DataBase()
        {
            players = new List<Player>();
        }
        public void AddPlayer(int number, string name, int level)
        {
            Player player = players.FirstOrDefault(x => x.Number == x.Number);

            if (player == null)
            {
                Player creatPlayers = new Player(number, name, level);
                players.Add(player);
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
         
        }
        public void UnbanPlayer(int number)
        {
            Player player = players.FirstOrDefault(x => x.Number == number);

            if (player != null)
            {
                player.Unban();
            }
            else
            {
                Console.WriteLine("Нельзя выполнить данное действие. Попробуйте еще раз.");
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
        public void ShowInformation()
        {
            Console.WriteLine(Name + IsBanned + Number);
        }
    }
}