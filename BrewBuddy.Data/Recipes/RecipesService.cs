// <copyright file="RecipesService.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IRecipesService.
    /// </summary>
    public class RecipesService : IRecipesService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipesService"/> class.
        /// </summary>
        /// <param name="repository">Provides data persistence.</param>
        public RecipesService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IEnumerable<Recipe> Get()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Recipe Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
