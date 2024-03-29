﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebPage.Models
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base (options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }

    }
}
