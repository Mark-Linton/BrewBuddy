// <copyright file="IRecipesService.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Recipes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Service used to persist brew recipe data.
    /// </summary>
    public interface IRecipesService
    {
        /// <summary>
        /// Gets all recipes.
        /// </summary>
        /// <returns>A collection of Recipe objects.</returns>
        IEnumerable<Recipe> GetRecipes();

        /// <summary>
        /// Gets a recipe.
        /// </summary>
        /// <param name="id">The id of the recipe to fetch.</param>
        /// <returns>A Recipe if found, null otherwise.</returns>
        Recipe GetRecipe(Guid id);

        /// <summary>
        /// Deletes a recipe from persistent storage.
        /// </summary>
        /// <param name="id">The id of the recipe to delete.</param>
        void DeleteRecipe(Guid id);
    }
}
