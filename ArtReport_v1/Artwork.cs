using System;
using System.Collections.Generic;
using System.Text;

namespace ArtReport_v1
{
    class Artwork
    {
        //object properties

        //access modifiers - public / private / protected
        private string artworkName;
        private string medium; //may have to change to a list

        //private readonly List<string> READONLY 

        private int timeSpent;
        private string notes;
        private string artworkImage;

        


        //Constructor - Constructs an onject by assigning values to the properties
        public Artwork(string an, string m, int ts, string nts, string ai)
        {
            artworkName = an;
            medium = m;
            timeSpent = ts;
            notes = nts;
            artworkImage = ai;
        }

        //methods


       


        //getter and setter methods

        //artworkName
        public string GetArtworkName()
        {
            return artworkName;
        }

        public void SetArtworkName(string an)
        {
            artworkName = an;
        }

        //medium
        public string GetMedium()
        {
            return medium;
        }

        public void SetMedium(string m)
        {
            medium = m;
        }

        //timeSpent
        public int GetTimeSpent()
        {
            return timeSpent;
        }

        public void SetTimeSpent(int ts)
        {
            timeSpent = ts;
        }

        //notes
        public string GetNotes()
        {
            return notes;
        }
      
        public void SetNotes(string n)
        {
            notes = n;
        }

        //artworkimage
        public string GetArtworkImage()
        {
            return artworkImage;
        }

        public void SetArtworkImage(string ai)
        {
            artworkImage = ai;
        }






    }
    

}
