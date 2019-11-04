// <copyright file="RecipesController.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BrewBuddy.Data.Recipes;
    using BrewBuddy.Helpers;
    using BrewBuddy.ResponseDTOs;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains all endpoints relevent to viewing and manipulating brewing recipes.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService recipesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipesController"/> class.
        /// </summary>
        /// <param name="recipesService">Provides access to recipe database.</param>
        public RecipesController(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        /// <summary>
        /// GET: api/Recipes .
        /// </summary>
        /// <returns>An array containing all recipes.</returns>
        [HttpGet]
        public IEnumerable<RecipeResponseDTO> Get()
        {
            var recipes = this.recipesService.GetRecipes();

            var recipeDTOs = new List<RecipeResponseDTO>();
            foreach (var recipe in recipes)
            {
                recipeDTOs.Add(recipe.ToDTO());
            }

            return recipeDTOs;
        }

        /// <summary>
        /// GET: api/Recipes/4 .
        /// </summary>
        /// <param name="id">The id of the recipe to get.</param>
        /// <returns>The recipe if found, "NotFound" otherwise.</returns>
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<RecipeResponseDTO> Get(string id)
        {
            Guid recipeId;
            if (Guid.TryParse(id, out recipeId))
            {
                var recipe = this.recipesService.GetRecipe(recipeId);
                var dto = recipe.ToDTO();

                return dto;
            }

            return this.NotFound();
        }

        /// <summary>
        /// DELETE: api/Recipes/5 .
        /// </summary>
        /// <param name="id">The id of the recipe to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Guid recipeId;
            if (Guid.TryParse(id, out recipeId))
            {
                this.recipesService.DeleteRecipe(recipeId);
            }
        }
    }
}