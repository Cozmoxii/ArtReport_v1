
using System;
using System.Collections.Generic;

namespace ArtReport_v1
{
    class Program
    {
        //global variables
        

        static void Main(string[] args)
        {

            AppManager am = new AppManager();

            am.AddArtwork("Fanart", new Artwork("Name", "Digital", 26, "needs more work", "document2.jpg"));

            am.AddCourse("Client", new Course("Youtube", "Painting Masterclass", 4, 88, "needs more work"));
            am.AddCourse("Client", new Course("Class101", "Lions", 6, 23, "could be better"));

            //c.AddArtwork(new Artwork("Waterfall", "Ink", 8, "needs more work", "waterfall.jpg"));

            //c.AddArtwork(new Artwork("Name", "Digital", 26, "needs more work", "document2.jpg"));

            //c.AddCourse(new Course("Schoolism", "A Frame a Day", 20, 32, "needs more work"));

            //c.AddCourse(new Course("Youtube", "Painting Masterclass", 4, 88, "needs more work"));

            //test

            Console.WriteLine(am.CatOverallPercent("Fanart")+"%");
            Console.WriteLine("Client category percentage:");
            Console.WriteLine(am.CatOverallPercent("Client") + "%");
            //Console.WriteLine(c.CalculateOverallHours() + "hrs");


        }



        }
}
