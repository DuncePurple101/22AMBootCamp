using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace _22AMBootCamp
{
    public static class DataManagement
    {

        public static void SavePlayerData(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine("Serializing {0}", jsP);
            string fileName = "e:\\vgd\\AMCasey\\PlayerData.txt";
            File.WriteAllText(fileName, jsP);
            Console.WriteLine("Player data saved.");
        }

        public static Player LoadPlayerData(Player p)
        {
            string fileName = "e:\\vgd\\AMCasey\\PlayerData.txt";
            string jsP = File.ReadAllText(fileName);
            Player x = JsonSerializer.Deserialize<Player>(jsP);
            Console.WriteLine("Player data returned");
            return x;
        }

    }
}
