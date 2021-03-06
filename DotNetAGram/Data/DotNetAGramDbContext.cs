﻿using DotNetAGram.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAGram.Data
{
    public class DotNetAGramDbContext : DbContext
    {
        /// <summary>
        /// This constructor method brings in the DbContext options
        /// </summary>
        /// <param name="options"></param>
        public DotNetAGramDbContext(DbContextOptions<DotNetAGramDbContext> options) : base(options) { }

        /// <summary>
        /// This method allows the DbContext to build model objects to seed the db
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasData(
                    new Post
                    {
                        ID = 1,
                        Author = "ChattleBrand65",
                        Description = "Gunner and Yuna playing in snow at the dog park for the first time.",
                        ImageURL = "https://placeimg.com/640/480/animals",
                        PostDate = DateTime.Now
                    },

                    new Post
                    {
                        ID = 2,
                        Author = "ChattleBrand65",
                        Description = "Gunner and Yuna playing at the beach for the first time.",
                        ImageURL = "https://placeimg.com/640/480/animals",
                        PostDate = DateTime.Now
                    },

                    new Post
                    {
                        ID = 3,
                        Author = "ChattleBrand65",
                        Description = "Gunner and Yuna playing in a volcano for the first time.",
                        ImageURL = "https://placeimg.com/640/480/animals",
                        PostDate = DateTime.Now
                    },

                    new Post
                    {
                        ID = 4,
                        Author = "ChattleBrand65",
                        Description = "Gunner and Yuna playing in the jungle for the first time.",
                        ImageURL = "https://placeimg.com/640/480/animals",
                        PostDate = DateTime.Now
                    },

                    new Post
                    {
                        ID = 5,
                        Author = "ChattleBrand65",
                        Description = "Gunner and Yuna playing in the White House for the first time.",
                        ImageURL = "https://placeimg.com/640/480/animals",
                        PostDate = DateTime.Now
                    });

        }

        public DbSet<Post> Posts { get; set; }
    }
}
