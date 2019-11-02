// <copyright file="DTOExtensions.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BrewBuddy.Data.Recipes;
    using BrewBuddy.Models;

    /// <summary>
    /// A collection of extension methods used to convert internal data structures to the appropriate response DTO objects.
    /// </summary>
    public static class DTOExtensions
    {
        /// <summary>
        /// Creates a RecipeResponseDTO from the supplied Recipe class.
        /// </summary>
        /// <param name="recipe">The Recipe to convert to a responseDTO.</param>
        /// <returns>A RecipeResponseDTO.</returns>
        public static RecipeResponseDTO ToDTO(this Recipe recipe)
        {
            return new RecipeResponseDTO();
        }
    }
}
