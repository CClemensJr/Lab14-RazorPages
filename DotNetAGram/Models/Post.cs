﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAGram.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string PostDate { get; set; }
    }
}
