using System;
using System.ComponentModel.Design;
using System.Linq;

namespace TameOfThrones
{
    class TameOfThrones
    {
        private static string inputFileName;
        static void Main(string[] args)
        {
            Initialize();
            //inputFileName = args[0];
            inputFileName = @"D:\PersonalGitProjects\input.txt";
            GoldenCrown goldenCrown = new GoldenCrown();
            goldenCrown.ParseFile(inputFileName);
            goldenCrown.MsgDecryptionStrategy();
            if(goldenCrown.ConquerStrategy()==null)
            {
                Console.WriteLine("NONE");
            }
            else
            {
                Console.Write(goldenCrown.CurrentRulingKingdom.Name + " ");
                foreach (string kingdom in goldenCrown.ConquerStrategy())
                {
                    Console.Write(kingdom + " ");
                }
            }

        }

        private static void Initialize()
        {
            UniverseSoutheros.GetInstance().AddKingdom("SPACE", "GORILLA");
            UniverseSoutheros.GetInstance().AddKingdom("LAND", "PANDA");
            UniverseSoutheros.GetInstance().AddKingdom("WATER", "OCTOPUS");
            UniverseSoutheros.GetInstance().AddKingdom("ICE", "MAMMOTH");
            UniverseSoutheros.GetInstance().AddKingdom("AIR", "OWL");
            UniverseSoutheros.GetInstance().AddKingdom("FIRE", "DRAGON");
        }
    }
}
