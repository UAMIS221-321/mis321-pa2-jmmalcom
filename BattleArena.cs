using System;
namespace mis321_pa2_jmmalcom
{
    public class BattleArena
    {
        public static Character Arena(Character player1, Character player2)
        {
            int count = 0;
            int num1 = player1.RandomNumber(20);
            int num2 = player2.RandomNumber(20);
            if (num1 > num2)
            {
                Console.WriteLine($"{player1.Name} gets to go first.");
                double attackDamage = player1.attackBehavior.Attack(player1, player2);
                Console.WriteLine($"{player1.Name} your attack strength is {player1.AttackStrength}. You dealt {Math.Round(attackDamage)} damage to the opponent {player2.Name}.");
                Console.WriteLine($"{player2.Name} your current health is {Math.Round(player2.Health)}. Your defense power is {player2.DefensivePower}.\nBased off your health, it will take {Math.Round(player2.Health/attackDamage)} hits before you lose.");
                count ++;
            }

            
            while (player1.Health > 0 && player2.Health > 0)
            {
                if( count == 0)
                {
                    Console.WriteLine($"{player2.Name} gets to go first.");
                }
                // Player 2 is going to attack.
                Console.WriteLine($"it is {player2.Name}'s turn to attack. Press enter to attack.");
                Console.ReadKey();
                double attackDamage = player2.attackBehavior.Attack(player2, player1);
                Console.WriteLine($"{player2.Name} your attack strength is {player2.AttackStrength}. You dealt {Math.Round(attackDamage)} damage to the opponent {player1.Name}.");
                Console.WriteLine($"{player1.Name} your current health is {Math.Round(player1.Health)}. Your defense power is {player1.DefensivePower}.\nBased off your health, it will take {Math.Round(player1.Health/attackDamage)} hits before you lose.");

                //Player 1 is going to attack.
                if (player1.Health > 0)
                {
                    Console.WriteLine($"it is {player1.Name}'s turn to attack. Press enter to attack.");
                    Console.ReadKey();
                    attackDamage = player1.attackBehavior.Attack(player1, player2);
                    Console.WriteLine($"{player1.Name} your attack strength is {player1.AttackStrength}. You dealt {Math.Round(attackDamage)} damage to the opponent {player1.Name}.");
                    Console.WriteLine($"{player2.Name} your current health is {Math.Round(player2.Health)}. Your defense power is {player2.DefensivePower}.\nBased off your health, it will take {Math.Round(player2.Health/attackDamage)} hits before you lose.");
                }
                count ++;

            }

            if(player1.Health > 0)
            {
                player1.WonGame ++;
                player2.LostGame ++;
                return player1;
            }

            if(player2.Health > 0)
            {
                player2.WonGame ++;
                player1.LostGame++;
                return player2;
            }
            
            return null;
        }
    }
}