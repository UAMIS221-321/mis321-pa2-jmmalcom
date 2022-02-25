using System;
using mis321_pa2_jmmalcom.Interfaces;
namespace mis321_pa2_jmmalcom
{
    public class Character
    {
        public string  Name{get; set;}
        public int MaxPower {get; set;}
        public double Health{get; set;}
        public int AttackStrength{get; set;}
        public int DefensivePower{get; set;}
        public string CharacterName{get; set;}
        public IAttack attackBehavior {get; set;}


        public Character()
        {
            Health = 100;
            MaxPower = RandomNumber(100);
            AttackStrength = RandomNumber(MaxPower);
            DefensivePower = RandomNumber(MaxPower);

        }

          public int RandomNumber(int num)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,num);
            return randomNumber;
        }

    }
}