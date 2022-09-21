using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float health;
            float shield;
            float multiplier;
            int lives;
            string title;
            float score;
            float combo;
            float healthpack;
            float enemy; 
            float shieldpack;
            float damage;

            // Values
            title = "Fantasia Adavantura";
            health = 100.0f;
            shield = 0.0f;
            lives = 3;
            score = 0.0f;
            multiplier = 1.0f;
            healthpack = 25;
            shieldpack = 20;
            enemy = 100;
            damage = 20;

            // rules 

            score = score * multiplier;

            // HUD
            Console.WriteLine("      " + title);
            Console.WriteLine("/==============================\\");
            Console.WriteLine("|  Health: " + health + "HP" + " ||" + "Shield: " + shield + "{}");
            Console.WriteLine("|  Lives: " + lives + " <3   ");
            Console.WriteLine("|  Multiplier: *" + multiplier + " Combo: " +  "X");
            Console.WriteLine("|  Score: " + score);
            Console.WriteLine("\\==============================/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Game Starts");
            Console.WriteLine("Player kills an enemy");
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemy;

            // HUD
            Console.WriteLine("      " + title);
            Console.WriteLine("/==============================\\");
            Console.WriteLine("|  Health: " + health + "HP" + " ||" + "Shield: " + shield + "{}");
            Console.WriteLine("|  Lives: " + lives + " <3   ");
            Console.WriteLine("|  Multiplier: *" + multiplier + " Combo: " + "X");
            Console.WriteLine("|  Score: " + score);
            Console.WriteLine("\\==============================/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player picks up healthkit");
            Console.WriteLine("Player picks up shield");
            Console.WriteLine();
            Console.WriteLine();

            health = healthpack + health;
            shield = shieldpack + shield;

            // HUD
            Console.WriteLine("      " + title);
            Console.WriteLine("/==============================\\");
            Console.WriteLine("|  Health: " + health + "HP" + " ||" + "Shield: " + shield + "{}");
            Console.WriteLine("|  Lives: " + lives + " <3   ");
            Console.WriteLine("|  Multiplier: *" + multiplier + " Combo: " + "X");
            Console.WriteLine("|  Score: " + score);
            Console.WriteLine("\\==============================/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player attacks enemy");
            Console.WriteLine("Player takes damage");
            Console.WriteLine("Player kills the enemy");
            Console.WriteLine();
            Console.WriteLine();

            shield = shield - damage;
            score = score + enemy;

            // HUD
            Console.WriteLine("      " + title);
            Console.WriteLine("/==============================\\");
            Console.WriteLine("|  Health: " + health + "HP" + " ||" + "Shield: " + shield + "{}");
            Console.WriteLine("|  Lives: " + lives + " <3   ");
            Console.WriteLine("|  Multiplier: *" + multiplier + " Combo: " + "X");
            Console.WriteLine("|  Score: " + score);
            Console.WriteLine("\\==============================/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player falls into trap");
            Console.WriteLine("Player takes damage");
            Console.WriteLine();
            Console.WriteLine();

            health = health - damage;
            // HUD
            Console.WriteLine("      " + title);
            Console.WriteLine("/==============================\\");
            Console.WriteLine("|  Health: " + health + "HP" + " ||" + "Shield: " + shield + "{}");
            Console.WriteLine("|  Lives: " + lives + " <3   ");
            Console.WriteLine("|  Multiplier: *" + multiplier + " Combo: " + "X");
            Console.WriteLine("|  Score: " + score);
            Console.WriteLine("\\==============================/");

            Console.ReadKey(true);




        }
    }
}
