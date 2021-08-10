﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._4_Loops
{
    public class Movie
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string[] Countries { get; set; }
        public Movie(string name, int releaseYear, string[] countries)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Countries = countries;
        }
    }
}
