using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.GameAdditions;
using ConsoleApplication1.Game;
using ConsoleApplication1.SetupDetails;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicGame fightclub = new FightClub();
            BasicGame fishing = new Fishing();

            MenuGame(fightclub);
            MenuGame(fishing);

            Console.WriteLine("\n-----------------------------\n");

            var installator = new Installator();
            installator.Next();
            installator.Next();
            installator.Next();
            installator.Finish();

            Console.WriteLine("\n-----------------------------\n");

            //var fightSetup = new FightSetup();
            var fishSetup = new FishSetup();

            //Console.WriteLine("Fight:");
            //fightSetup.Prepare();
            Console.WriteLine("Fish:");
            fishSetup.Prepare();
            Console.WriteLine("\n-----------------------------\n");

            BasicGame FishingWithSoundAndRussifier = new BackgroundMusic(new Russifier(new Fishing()));
            PrintGame(FishingWithSoundAndRussifier);
            //BasicGame FightingWithRussifier = new Russifier(new Fishing());
            //PrintGame(FightingWithRussifier);


        }

        static void MenuGame(BasicGame game)
        {
            Console.WriteLine("Game: {0}; Size: {1}",
                game.GetDescription(), game.GetSize());
        }

        static void PrintGame(BasicGame game)
        {
            Console.WriteLine("You installed: {0}; Size: {1}",
                game.GetDescription(), game.GetSize());
        }



    }
}
