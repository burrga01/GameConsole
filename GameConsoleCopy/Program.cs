﻿using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter(null);
            player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;

            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
