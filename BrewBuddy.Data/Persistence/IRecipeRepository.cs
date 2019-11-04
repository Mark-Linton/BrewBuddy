// <copyright file="IRecipeRepository.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Persistence
{
    using System;
    using System.Collections.Generic;
    using BrewBuddy.Data.Recipes;

    public interface IRecipeRepository
    {
        /// <summary>
        /// Creates a new recipe entry in the repository.
        /// </summary>
        /// <param name="recipe">The recipe to add.</param>
        void AddRecipe(Recipe recipe);

        /// <summary>
        /// Gets a single recipe from the repository.
        /// </summary>
        /// <param name="id">The id of the recipe to return.</param>
        /// <returns>A recipe if it exists, null otherwise.</returns>
        Recipe GetRecipe(Guid id);

        /// <summary>
        /// Gets all recipes from the repository.
        /// </summary>
        /// <returns>An IEnumerable that either contains all recipes, or is empty if there are no recipes.</returns>
        IEnumerable<Recipe> GetRecipes();

        /// <summary>
        /// Updates an already existing recipe.
        /// </summary>
        /// <param name="recipe">The updated recipe.</param>
        void UpdateRecipe(Recipe recipe);

        /// <summary>
        /// Deletes an existing recipe.
        /// </summary>
        /// <param name="id">The id of the recipe to delete.</param>
        void DeleteRecipe(Guid id);

        /// <summary>
        /// Deletes an existing recipe.
        /// </summary>
        /// <param name="recipe">The recipe to delete.</param>
        void DeleteRecipe(Recipe recipe);
    }
}
