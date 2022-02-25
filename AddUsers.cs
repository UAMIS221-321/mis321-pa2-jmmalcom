using System;
using System.IO;
using System.Collections.Generic;
namespace mis321_pa2_jmmalcom
{
    public class AddUsers
    {
        public static void Add(Character player1, Character player2)
        {
            Console.WriteLine($"Okay {player1.Name} I am going to add your username and wins/losses to the file.");

            StreamWriter writer = new StreamWriter("player.txt");
            writer.WriteLine($"{player1.Name}#{player1.WonGame}#{player1.LostGame}");
            writer.Close();
            
            

            Console.WriteLine($"Okay {player2.Name} I am going to add your username and wins/losses to the file.");

            writer = new StreamWriter("player.txt",true);
            writer.WriteLine($"{player2.Name}#{player2.WonGame}#{player2.LostGame}");
            writer.Close();

            Console.WriteLine("They have been added and will be avaiable for the next time you play.");
        }

        public static void AddOn(List<Character> players)
        {
            StreamWriter writer = new StreamWriter("player.txt");
            foreach(Character x in players)
            {
                writer.WriteLine($"{x.Name}#{x.WonGame}#{x.LostGame}");
            }
            writer.Close();

            Console.WriteLine("Your file has been updated.");
        }

        public static void GetStats(ref List<Character> players, Character player1, Character player2)
        {
            StreamReader reader = new StreamReader("player.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                Character tempCharacter = new Character(){Name = temp[0].ToLower(), WonGame = int.Parse(temp[1]), LostGame = int.Parse(temp[2])};
                if(player1.Name.ToLower() == tempCharacter.Name)
                {
                    player1.WonGame = tempCharacter.WonGame;
                    player1.LostGame = tempCharacter.LostGame;
                }

                if(player2.Name.ToLower() == tempCharacter.Name)
                {
                    player2.WonGame = tempCharacter.WonGame;
                    player2.LostGame = tempCharacter.LostGame;
                }
                if(player2.Name.ToLower() != tempCharacter.Name && player1.Name.ToLower() != tempCharacter.Name)
                {
                    players.Add(tempCharacter);
                }
                line = reader.ReadLine();
            }
            reader.Close();
 
        }
    }
}