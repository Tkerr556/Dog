using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Doggo
    {
        class Program
        {
            class Dog
            {
                public enum Gender
                {
                    Male, Female
                }
                public string name;
                public string owner;
                public int age;
                public Gender gender;
                public static string GetGender(Gender gender)
                {
                    if (gender == Gender.Male)
                    {
                        return "His";
                    }
                    return "Her";
                }
                public Dog(string name1, string owner1, int age1, Gender gender1)
                {
                    name = name1;
                    owner = owner1;
                    age = age1;
                    gender = gender1;
                }
                public void Bark(int num)
                {
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("Woof!");
                    }
                    Console.WriteLine();
                }
                public string GetTag()
                {
                    string hisOrher = GetGender(gender).ToString();
                    string heOrShe;
                    if (hisOrher == "His")
                    {
                        heOrShe = "he";
                    }
                    else
                    {
                        heOrShe = "she";
                    }
                    return "If lost, call " + owner + " " + hisOrher + " name is " + name + " and " + heOrShe + " is " + age + " old.";
                }
                static void Main(string[] args) //main method
                {
                    Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
                    puppy.Bark(3); // output: Woof!Woof!Woof!
                    Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

                    Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
                    myDog.Bark(1); // output: Woof!
                    Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
                    Console.ReadLine();
                }
            }
        }
    }


    

