using System;
using mis321_pa2_jmmalcom.Interfaces;

namespace mis321_pa2_jmmalcom
{
    public class ChooseCharacter
    {
        public static Character ChooseCharacters(int numPlayers)
        {
            
            Console.WriteLine($" Hello player {numPlayers}! Please choose your username.");
            string name = Console.ReadLine();
            Console.WriteLine("What character would you like to play?");
            Console.WriteLine("Press 1:\nJack Sparrow\n Press 2:\nWill Turner\nPress 3:\nDavy Jones");
            int selection = int.Parse(Console.ReadLine());
            switch(selection)
            {
                case 1:
                Character jackSparrow = new JackSparrow();
                jackSparrow.Name = name;
                jackSparrow.CharacterName = "Jack Sparrow";
                return jackSparrow;
                
                
                case 2:
                Character willTurner = new WillTurner();
                willTurner.Name = name;
                willTurner.CharacterName = "Will Turner";
                return willTurner;
                

                case 3:
                Character cannonFire = new DavyJones();
                cannonFire.Name = name;
                cannonFire.CharacterName = "Davy Jones";
                return cannonFire;
                

                default:
                Console.Clear();
                Console.WriteLine("You did not choose a character.");
                Character didnotChoose = new Character();
                didnotChoose.Name = "Restart";
                return didnotChoose;
                
            }

            
        }

    }
}