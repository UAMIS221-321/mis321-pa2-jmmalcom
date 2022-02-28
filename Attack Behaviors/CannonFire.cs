using System;
using mis321_pa2_jmmalcom.Interfaces;
namespace mis321_pa2_jmmalcom
{
    public class CannonFire: IAttack
    {
        public double Attack(Character attacker, Character defender)
        {
            double damageWBonus = ((attacker.AttackStrength - defender.DefensivePower) * 1.20);
            double damageWOBonus = (attacker.AttackStrength - defender.DefensivePower);
            if (attacker.AttackStrength > defender.DefensivePower &&  attacker.CharacterName == "Jack Sparrow" && defender.CharacterName == "Will Turner")
            {
                defender.Health -= ((attacker.AttackStrength - defender.DefensivePower) * 1.20);
                return damageWBonus;
            }

            else if (attacker.AttackStrength > defender.DefensivePower &&  attacker.CharacterName == "Will Turner" && defender.CharacterName == "Davy Jones")
            {
                defender.Health -= ((attacker.AttackStrength - defender.DefensivePower) * 1.20);
                return damageWBonus;
            }

            else if (attacker.AttackStrength > defender.DefensivePower &&  attacker.CharacterName == "Davy Jones" && defender.CharacterName == "Jack Sparrow")
            {
                defender.Health -= ((attacker.AttackStrength - defender.DefensivePower) * 1.20);
                return damageWBonus;
            }

            else if (attacker.AttackStrength > defender.DefensivePower)
            {
                defender.Health -= damageWOBonus;
                return damageWBonus;
            }
            else
               Console.WriteLine("Defender blocked your attack");
               defender.Health = defender.Health - 5.00;
               return 5.00;
        }
    }
}