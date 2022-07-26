using System;
using System.Collections.Generic;
using System.Text;

namespace ArtReport_v1
{
    class Category
    {
        
        private List<Artwork> artworks = new List<Artwork>();
        
        private List<Course> courses = new List<Course>();

        //a collection of catergories 

        private string category;

        public Category(string category)
        {
            this.category = category;
        }

        public Category()
        {
        }

        //methods -artwork

        //adds a new artwork to the collection
        public void AddArtwork(Artwork newArtwork)
        {
            artworks.Add(newArtwork);
        }

        public int CalculateArtHours()
        {
            int totalhrs = 0;

            foreach (Artwork artwork in artworks)
            {
                totalhrs += artwork.GetTimeSpent();
            }

            return totalhrs;
        }

        public int CalculateCourseHours()
        {
            int totalhrs = 0;

            foreach (Course course in courses)
            {
                totalhrs += course.GetTimeSpent();
            }

            return totalhrs;
        }


        //methods- Courses

        public void AddCourse(Course newCourse)
        {
            courses.Add(newCourse);
        }


        public float CalculateOverallPercent()
        {
            float overallPercent = 1;

            foreach (Course course in courses)
            {
                
                overallPercent *= course.GetPercentDone();
            }

            return overallPercent/100;
        }

        public int CalculateOverallHours()
        {
            int overallHours = CalculateArtHours() + CalculateCourseHours();

            return overallHours;
        }



        //getters and setters

        public string GetCategory()
        {
            return category;
        }



    }
}
