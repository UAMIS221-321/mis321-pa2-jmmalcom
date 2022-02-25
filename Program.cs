using System;
using mis321_pa2_jmmalcom.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace mis321_pa2_jmmalcom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> userNames = new List<Character>();

             Character myCharacter1 = new Character();
             Character myCharacter2 = new Character();
             do{
                 myCharacter1 = ChooseCharacter.ChooseCharacters(1);
                } while(myCharacter1.Name == "Restart");
            do{
                 myCharacter2 = ChooseCharacter.ChooseCharacters(2);
                } while(myCharacter2.Name == "Restart");
           
            //Adding Characters to the list. 
           userNames.Add(myCharacter1);
           userNames.Add(myCharacter2);

            try
            {
                StreamReader inFile = null;
                inFile = new StreamReader("player.txt");
                inFile.Close();
                AddUsers.GetStats(ref userNames, myCharacter1, myCharacter2);

            }
            catch
            {
                Console.WriteLine("HI");
            }           

           //Entering into the battle arena and battling.
           Character winner =  BattleArena.Arena(myCharacter1, myCharacter2);
           Console.WriteLine($"{winner.Name} you won!");

            // Determining if they want to enter their saved information into a file. 
            try
            {
                StreamReader inFile = null;
                inFile = new StreamReader("player.txt");
                inFile.Close();
                Console.WriteLine("Would you like to save your progress?\nPress 1:yes\nPress 2: No");
                int userSelect = int.Parse(Console.ReadLine());

                if(userSelect == 1)
                {
                    AddUsers.AddOn(userNames);
                    foreach(Character x in userNames)
                    {
                        if(x.Name == myCharacter1.Name || x.Name == myCharacter2.Name)
                        {
                            Console.WriteLine($"{x.Name}, here are your stats:\nWins: {x.WonGame}\nLosses: {x.LostGame}");

                        }
                        Console.WriteLine("Bye for Now!");                       
                    }
                }
                if( userSelect == 2)
                {
                    Console.WriteLine("Hope you enjoyed the game! Bye Now");
                }

                
                
            }
            catch
            {
                Console.WriteLine("No file was found. Would you like to save your progress?\nPress 1: Yes\nPress 2: No");
                int userSelect = int.Parse(Console.ReadLine());
                if(userSelect == 1)
                {
                    Console.Clear();

                    AddUsers.Add(myCharacter1, myCharacter2);
                    foreach(Character x in userNames)
                    {
                        if(x.Name == myCharacter1.Name || x.Name == myCharacter2.Name)
                        {
                            Console.WriteLine($"{x.Name}, here are your stats:\nWins: {x.WonGame}\nLosses: {x.LostGame}");
                        }
                        Console.WriteLine("Bye For Now");
                    }
                }
                if( userSelect == 2)
                {
                    Console.WriteLine("Hope you enjoyed the game! Bye Now");
                }
                
            }

        }

       
    }
}
