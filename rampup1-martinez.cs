using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Weight Conversion
            Console.Write("What is your weight in lbs: ");
            int weight_lbs = Convert.ToInt32(Console.ReadLine());
            double kg = weight_lbs / 2.205;
            kg = Math.Round(kg, 2);

            string lbs = weight_lbs.ToString();
            string kgStr = kg.ToString();

            Console.WriteLine("Weight in Pounds (lbs): " + lbs);
            Console.WriteLine("Weight in Kilograms (kg): " + kgStr);
            Console.WriteLine("=========================================");

            // Length Conversion
            Console.Write("Give me a distance in Miles (mi): ");
            double len_mi = Convert.ToDouble(Console.ReadLine());
            double km = len_mi * 1.609;
            km = Math.Round(km, 2);

            string mi = len_mi.ToString();
            string kmStr = km.ToString();

            Console.WriteLine("Length in Miles (mi): " + mi);
            Console.WriteLine("Length converted to Kilometers (km): " + kmStr);
            Console.WriteLine("=========================================");

            // Temperature Conversion
            Console.Write("What's the temperature in fahrenheit: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            celsius = Math.Round(celsius, 2);

            string frt = fahrenheit.ToString();
            string cls = celsius.ToString();

            Console.WriteLine("Temperature in Fahrenheit (°f): " + frt);
            Console.WriteLine("Temperature converted to Celsius (°C): " + cls);
            Console.WriteLine("=========================================");

            // Average Age Calculation
            List<int> studentAgeList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Age of student: ");
                int age = Convert.ToInt32(Console.ReadLine());
                studentAgeList.Add(age);
            }

            Console.WriteLine(string.Join(", ", studentAgeList));

            int studentAgeSum = 0;
            foreach (int age in studentAgeList)
            {
                studentAgeSum += age;
            }

            double average = studentAgeSum / 10.0;
            string ave = average.ToString();

            Console.WriteLine("The average age of the student is: " + ave);
            Console.WriteLine("=========================================");

            // Story
            string[] chNames = { "Lumaine", "Scara", "Raiden", "Barbatos", "Kaedehara" };
            string[] worldNames = { "Teyvat", "Earth-918" };
            string[] weaponNames = { "Skyward", "Widsith", "The Catch" };
            string[] abilities = { "elemental resonance", "vision holder", "elemental reaction" };

            Console.WriteLine("There was once a lost star who was searching for her brother who she separated with. Her name was " + chNames[0] + " traveling the world of " + worldNames[0] + ". " +
                "A world which holds elemental powers where " + abilities[1] + "s from all nations help with its peace and safety. " + chNames[0] + " somehow has the ability of " + abilities[0] +
                " where she can connect with any elements on the world of " + worldNames[0] + ". There she met a loving mother named " + chNames[2] + ". She was helping her child " + chNames[1] +
                " farm for Rukkhashava Mushroom for them to feast on for dinner. " + chNames[0] + " did not realize that she encountered the nation's archon and casually spoke with her. " + chNames[0] +
                " soon violated the rules of " + chNames[2] + "'s nation and fought with her using her " + weaponNames[0] + " sword. To " + chNames[0] + "'s little knowledge, she did not know that " + chNames[1] +
                " also has the ability to fight with his " + weaponNames[1] + " weapon. " + chNames[2] + " wielded " + weaponNames[2] + " and tried to strike on " + chNames[0] +
                " but the wind was her guardian. The archon " + chNames[3] + " has come to her rescue together with his assistant, " + chNames[chNames.Length - 1] + ". While " + chNames[chNames.Length - 1] + ", as a double " + abilities[1] + ", help buy time for " + chNames[0] +
                " to escape, " + chNames[3] + " told her that her brother was in another world called " + worldNames[1] + " where Avengers exists. And with that, " + chNames[0] +
                " has gathered her strength to leap to another world and find her brother. That's how she ended up on our world with no weapons, abilities and just a laptop to study computer science while looking for her brother. The end.");
        }
    }
}