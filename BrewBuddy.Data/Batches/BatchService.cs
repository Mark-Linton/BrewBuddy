// <copyright file="BatchService.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Batches
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IBatchService.
    /// </summary>
    public class BatchService : IBatchService
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IBatchesRepository batchesRepository;
        private readonly IInventoryRepository inventoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchService"/> class.
        /// </summary>
        /// <param name="recipeRepository">Provides recipes data persistence.</param>
        /// <param name="batchesRepository">Provides batches data persistence.</param>
        /// <param name="inventoryRepository">Provides inventory data persistence.</param>
        public BatchService(IRecipeRepository recipeRepository, IBatchesRepository batchesRepository, IInventoryRepository inventoryRepository)
        {
            this.recipeRepository = recipeRepository;
            this.batchesRepository = batchesRepository;
            this.inventoryRepository = inventoryRepository;
        }
    }
}
