using System;
using System.Collections.Generic;

namespace Job.Models
{
    public class Posting
    {
        public string Company  { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string Contact { get; set; }

        private static List<Posting> _posting = new List<Posting> {};

        public Posting (string company, string position, string description, int salary, string contact)
        {
            Company = company;
            Position = position;
            Description = description;
            Salary = salary;
            Contact = contact;
            _posting.Add(this);
        }

        public static List<Posting> GetAll()
        {
            return _posting;
        }

        public static void CLearAll()
        {
            _posting.Clear();
        }

    }
}