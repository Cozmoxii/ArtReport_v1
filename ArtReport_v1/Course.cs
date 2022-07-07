using System;
using System.Collections.Generic;
using System.Text;

namespace ArtReport_v1
{
    class Course
    {
        //object properties

        //access modifiers - public / private / protected

        private string platform;
        private string courseName;
        private int timeSpent;
        private int percentDone;
        private string notes;
        
        //Constructor - Constructs an onject by assigning values to the properties
        
        public Course(string p, string cn, int ts, int pd, string nts)
        {
            platform = p;
            courseName = cn;
            timeSpent = ts;
            percentDone = pd;
            notes = nts;
        }


        //Getter and Setter method

        public string GetPlatform()
        {
            return platform;
        }

        public void SetPlatform(string p)
        {
            platform = p;
        }


        public string GetCourseName()
        {
            return courseName;
        }

        public void SetCourseName(string n)
        {
            courseName = n;
        }

        public int GetTimeSpent()
        {
            return timeSpent;
        }

        public void SetTimeSpent(int ts)
        {
            timeSpent = ts;
        }

        public int GetPercentDone()
        {
            return percentDone;
        }

        public void SetPercentDone(int pd)
        {
            percentDone = pd;
        }

        public string GetNotes()
        {
            return notes;
        }

        public void SetNotes(string nts)
        {
            notes = nts;
        }


    }

}
