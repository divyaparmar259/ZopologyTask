using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp
{
    interface Species
    {
        void African();
        void Asian();
    }
    interface BodyCharacteristics
    {
        void Trunk();
        void Tusk();
        void Teeth();
        void Skin();
        void Legs();
        void Ears();

    }
    interface Diet
    {
        void Herbivores();
    }
    interface Reproduction
    {
        void Interval();
        void Weight();
    }

    interface Domestication
    {
        void Use();
    }
    class Elephant : Species, BodyCharacteristics,Diet, Reproduction, Domestication
    {


        public void African()
        {
            ArrayList list = new ArrayList();
            list.Add("African elephants are found in 38 countries");
            list.Add("African elephants are 4 m tall");
            list.Add("There weigh around 7000kg");
            Console.WriteLine("African Elephant Information:");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("");
        }

            public void Asian()
        {
            ArrayList list = new ArrayList();
            list.Add("Asian elephants are 3.4 m tall");
            list.Add("There weigh around 5400kg");
            Console.WriteLine("Asian Elephant Information:");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("");
        }

        public void Trunk()
        {
            ArrayList list = new ArrayList();
            list.Add("Trunk Information:");
            list.Add("Is used to tear up their food");
            list.Add("And then place it in their mouth");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("");
        }
        public void Tusk()
        {
            ArrayList list = new ArrayList();
            list.Add("Tusk Information:");
            list.Add("Used to dig for water, salt, and roots");
            list.Add("to debark trees, to eat the bark; to dig into baobab trees to get at the pulp insideh");
            list.Add("and to move trees and branches when clearing a path.");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("");
        }

        public void Teeth()
        {
            Console.WriteLine("Teeth Information:");
            Console.WriteLine("They usally have 28 Teeth");
            Console.WriteLine("");
        }
        public void Skin()
        {
            Console.WriteLine("Skin Information:");
            Console.WriteLine("It is extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick. ");
            Console.WriteLine("");
        }
        public void Legs()
        {
            Console.WriteLine("They are great straight pillars, as they must be to support its bulk weight.");
            Console.WriteLine("");
        }
        public void Ears()
        {
            Console.WriteLine("Ears Information:");
            Console.WriteLine("Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels. ");
            Console.WriteLine("");
        }

        public void Herbivores()
        {
            Console.WriteLine("Herbivores Information:");
            Console.WriteLine("Elephants are herbivores, spending 16 hours a day collecting plant food. ");
            Console.WriteLine("");
        }

        public void Interval()
        {
            Console.WriteLine("Interval Information:");
            Console.WriteLine("Females give birth at intervals of about every 5 years. ");
            Console.WriteLine("");
        }

        public void Weight()
        {
            Console.WriteLine("Weight Information:");
            Console.WriteLine("At birth, calves weigh around 90–115 kg.");
            Console.WriteLine("");
        }

        public void Use()
        {
           
            Console.WriteLine("Elephants have been working animals used in various capacities by humans.");
        }
    }
}
