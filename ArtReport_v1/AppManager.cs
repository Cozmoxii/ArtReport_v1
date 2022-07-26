using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArtReport_v1
{
    class AppManager
    {

        

        private List<Category> categories = new List<Category>();
        private List<string> Categories = new List<string>();


        public AppManager()
        {
            LoadCategories();

            foreach (string category in Categories)
            {
                categories.Add(new Category(category));
            }
        }

        
        //methods

        //Artwork
        public void AddArtwork(string categorySearch, Artwork newArtwork)
        {
            categories[FindIndexOfCat(categorySearch)].AddArtwork(newArtwork);
        }

        

        //course
        public void AddCourse(string categorySearch, Course newCourse)
        {
            categories[FindIndexOfCat(categorySearch)].AddCourse(newCourse);
        }

        //

        public int FindIndexOfCat(string categorySearch)
        {
            int index = 0;

            foreach (Category category in categories)
            {
                if (category.GetCategory().Equals(categorySearch))
                {
                    return index;
                }

                index++;
            }

            return -1;

        }



        //search for specified category and return it's overall percentage
        public float CatOverallPercent(string categorySearch)
        {
            foreach (Category category in categories)
            {
                if (category.GetCategory().Equals(categorySearch))
                {
                    return category.CalculateOverallPercent();
                }
            }
            
            return -1f;
        }

        public int CatOverallHours(int categorySearch)
        {
            
            foreach (Category category in categories)
            {
                if (category.GetCategory().Equals(categorySearch))
                {
                    return category.CalculateOverallHours();
                }
            }
             
            
            return -1;
        }


        public void LoadCategories()
        {
            string line;

            StreamReader sr = new StreamReader("Categories.txt");

            line = sr.ReadLine();
            
            Console.WriteLine(line);

            string[] category = line.Split(',');

            for (int i = 0; i < category.Length; i++)
            {
                Categories.Add(category[i]);
            }

        }

    }
}
