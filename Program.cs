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
             Character myCharacter1 = new Character();
             Character myCharacter2 = new Character();
             do{
                 myCharacter1 = ChooseCharacter.ChooseCharacters(1);
                } while(myCharacter1.Name == "Restart");
            do{
                 myCharacter2 = ChooseCharacter.ChooseCharacters(2);
                } while(myCharacter2.Name == "Restart");
           
           Character winner =  BattleArena.Arena(myCharacter1, myCharacter2);
           Console.WriteLine($"{winner.Name} you won!");

        }

       
    }
}
