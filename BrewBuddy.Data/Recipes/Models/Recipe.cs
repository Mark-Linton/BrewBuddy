// <copyright file="Recipe.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Internal data structure for Brew recipe.
    /// </summary>
    public class Recipe
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Brewer { get; set; }

        public RecipeType Type { get; set; }

        public IEnumerable<FermentableAddition> Fermentables { get; set; }

        public IEnumerable<HopAddition> Hops { get; set; }

        public IEnumerable<MiscAddition> Misc { get; set; }
    }
}
