using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _2910_Lab1
{

    /*////////////////////////////////////////////////////////////////////////////////////////////
     *  NAME: ABDULAI BAH                                                                        *
     *  DATE: 09/14/2023                                                                         *
     *  PROJECT: C# ADVANCED LAB 2                                                               *
     *  CLASS: CSCI 2910-800 SERVER SIDE WEB PROGRAMMING                                         *
     *                                                                                           *
     *                                                                                           *
     *                                                                                           *
     *                                                                                           *
     *                                                                                           *
     *                                                                                           *
     *                                                                                           *
     *////////////////////////////////////////////////////////////////////////////////////////////
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoGames videoGame;
            List<VideoGames?> listOfGames = new List<VideoGames?>();       
            Stack<VideoGames?> videoGameStack = new Stack<VideoGames?>();
            Queue<string> vdgQueue = new Queue<string>();

            //File Path that needs to be read
            string rootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
                string filePath = $"{rootFolder}{Path.DirectorySeparatorChar}videogames.csv";


                try
                {
                    //Read all text from the file
                    string fileContents = File.ReadAllText(filePath);

                    //Print the contents of the file to the console
                    Console.WriteLine("File Contents: ");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured while trying to read this file, please try again");
                    Console.WriteLine(ex.Message);
                }

                using (var rdr = new StreamReader(filePath))
                {
                    rdr.ReadLine();

                    while (!rdr.EndOfStream)
                    {
                    //reads the lines of the files
                        string nextLine = rdr.ReadLine();
                    //splits the contents of the file where the , happens
                        string[] fields = nextLine.Split(",");
                    //each field is a datatype in the VideoGames class and they all have their respective datatypes that the file needs to fit, so this saves each of the segments and spits them out in the same format
                        videoGame = new VideoGames(fields[0].Trim(), fields[1].Trim(), Int32.Parse(fields[2].Trim()), fields[3].Trim(), fields[4], Decimal.Parse(fields[5].Trim()), Decimal.Parse(fields[6]), Decimal.Parse(fields[7].Trim()), Decimal.Parse(fields[8].Trim()), Decimal.Parse(fields[9].Trim()));  
                    //compares each value for video and sorts it 
                        videoGame.CompareTo(videoGame);    
                    //adds the contents of video to the list of games
                        listOfGames.Add(videoGame);
                }
            }
            //print the list of games
            listOfGames.Sort();
            foreach (VideoGames Game in listOfGames)
            {
                Console.WriteLine(Game.ToString());
            }
            //grabs the total number of elements in the list
            int numOfGames = listOfGames.Count();

            Console.WriteLine("\n\n\n\n");
//////////////////////////VIDEGAME PUBLISHER////////////////////////////////////////////////////
            var selectPublisher = from x in listOfGames
                                  where x.Publisher == "Nintendo"
                                  select x;

            foreach (VideoGames vGame in selectPublisher)
            {
                Console.WriteLine(vGame.ToString());
            }

            int numOfVGames = selectPublisher.Count();

            double numGames = Double.Parse(numOfGames.ToString());
            double numVGames = Double.Parse(numOfVGames.ToString());


            double percentageOfPublishers = Math.Round((numVGames / numGames) * 100, 2);
            Console.WriteLine(percentageOfPublishers + "%");
            Console.WriteLine("Please Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\n\n\n");
////////////////////////////////////////VIDEGAME PUBLISHER////////////////////////////////////////////////////
            var selectGenre = from a in listOfGames
                                  where a.Genre == "Simulation"
                              select a;

            foreach (VideoGames vGameG in selectGenre)
            {
                Console.WriteLine(vGameG.ToString());
            }

            int numOfVGameG = selectGenre.Count();

            double numVGameG = Double.Parse(numOfVGameG.ToString());


            Console.WriteLine(numOfVGameG);

            double percentageOfGenres = Math.Round((numVGameG / numGames) * 100, 2);
            Console.WriteLine(percentageOfGenres + "%");
            Console.WriteLine("Please Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

////////////////////////////////////////USERINPUT VIDEGAME PUBLISHER////////////////////////////////////////////////////
            Console.WriteLine("What Publisher would you like to select?");
            string usrSelect = Console.ReadLine();

            var usrSelectPublisher = from z in listOfGames
                                  where z.Publisher == usrSelect
                                  select z;

            foreach (VideoGames usrGame in usrSelectPublisher)
            {
                Console.WriteLine(usrGame.ToString());
            }

            int usrNumOfVGames = usrSelectPublisher.Count();

            double usrNumVGames = Double.Parse(numOfVGames.ToString());


            Console.WriteLine(usrNumOfVGames);

            double usrPercentageOfPublishers = Math.Round((usrNumOfVGames / numGames) * 100, 2);
            Console.WriteLine(usrPercentageOfPublishers + "%");
            Console.WriteLine("Please Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\n\n\n");

////////////////////////////////////////VIDEGAME SELECT GENRE////////////////////////////////////////////////////
            Console.WriteLine("What Genre would you like to see?");
            string usrGenreInput = Console.ReadLine();

            var usrSelectGenre = from b in listOfGames
                              where b.Genre == usrGenreInput
                              select b;

            foreach (VideoGames usrVGame in usrSelectGenre)
            {
                Console.WriteLine(usrVGame.ToString());
            }

            int usrNumOfVGameG = usrSelectGenre.Count();

            double usrNumVGameG = Double.Parse(numOfVGameG.ToString());

            Console.WriteLine("Genre: " + usrNumOfVGameG);
            Console.WriteLine("Total Games: " + numGames);

            double usrPercentageOfGenres = Math.Round((usrNumOfVGameG / numGames) * 100, 2);
            Console.WriteLine(usrPercentageOfGenres + "%");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            ////////////////////////////DICTIONARY//////////////////////////////
            Console.Clear(); //clears up the console to be more neat

            //creates a dictionary that takes a string key and a int value
            Dictionary<int, VideoGames> askVDGDict = new Dictionary<int, VideoGames>();
            List<int> listForQueues = new List<int>();
            //adds the games from list of games to the dictionary askVDGDict
            for (int i = 0; i < listOfGames.Count(); i++)
            {
                askVDGDict[i] = listOfGames[i];
            }

            //grabs all the games in the dicitonary where their key is greater than or equal to 100000
            var iHateThis = askVDGDict.Where(keyNumber => keyNumber.Key >= 10000);

            //prints the games in iHateThis
            foreach (var v in iHateThis)
            {
                Console.WriteLine(v);
            }

            var running = true;
            int addToCart = 0;

            while(running== true)
            {
                //prompts user to enter in a dicitonary key to grab a game and then stores that number into a list to be used later
                Console.WriteLine("Which of these games would you like to add to the cart?");
                Console.Write("For the sake of time pleas enter in a random number from 1-16327: ");
                addToCart = Int32.Parse(Console.ReadLine());
                listForQueues.Add(addToCart);

                //error handling, make it so you cant enter values less than 0 or values greater than the dictionary count
                try
                {
                    while (addToCart <= 0 || addToCart > askVDGDict.Count())
                    {
                        Console.WriteLine("ERROR: Invalid Input, Please try again!");
                        Console.WriteLine("Which of these games would you like to add to the cart?");
                        addToCart = Int32.Parse(Console.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Invalid input has caused console to crash, Please start over.");
                }


                //prompts the user to enter in a number to continue or exit
                Console.WriteLine("Would you like to add more games to your cart?");
                Console.Write("Enter in 0 for no or 1 for yes: ");
                var intRunning = Int32.Parse(Console.ReadLine());
                
                //error handling, makes it so you can only enter in the numbers 0 and 1
                try
                {
                    while (intRunning < 0 || intRunning > 1)
                    {
                        Console.WriteLine("ERROR: Invalid Input, please try again!");
                        intRunning = Int32.Parse(Console.ReadLine());
                    }
                }
                catch 
                {
                    Console.WriteLine("ERROR: Invalid input has caused console to crash, please start over!");
                }

                //if user decides to stop entering in the game key it closes the interface
                if (intRunning == 0)
                {
                    running = false;
                }
            }

            /////////////////////////////STACK/////////////////////////////////
            //Grabs all the games where their platform is not Xbox
            var whyDoISuffer = listOfGames.Where(keyNumber => keyNumber.Platform != "Xbox");
            //Puts all the non Xbox games into the stack
            foreach (var kvp in whyDoISuffer)
            {
                videoGameStack.Push(kvp);
            }
            Console.WriteLine("/////////////////////////////THIS IS THE FIRST GAME IN THE STACK/////////////////////////////////");

            //stores the pop method, which removes a game from the top of the stack
            var subPrint = videoGameStack.Pop();

            //prints the removed game
            Console.WriteLine(subPrint);

            Console.WriteLine("Please Press Enter to continue: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("//////////////////////////YOUR CART//////////////////////////////////////////");
            ////////////////////////////QUEUE//////////////////////////////////
            Console.WriteLine("Games Added: ");
            
            //grabs all the games that have the same value as addToCart
            var screwYouOver = listForQueues.Where(iHateYou => iHateYou == addToCart);
            //adds everything within screwYouOver to the queue
            foreach (var kvp in screwYouOver)
            {
                vdgQueue.Enqueue($"You have just added the following game \n {askVDGDict[addToCart]}\n");
            }

            //Prints the game, that has been removed from the beginning of the queue
            Console.WriteLine("\n");
            Console.WriteLine(vdgQueue.Dequeue());
            Console.WriteLine("\n");


            Console.WriteLine("//////////////////////////YOUR CART//////////////////////////////////////////");
        }
    }
}