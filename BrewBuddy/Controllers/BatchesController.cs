// <copyright file="BatchesController.cs" company="Mark Linton">
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
    using BrewBuddy.Data.Batches;
    using BrewBuddy.Data.Recipes;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains all Endpoints related to brewing a batch.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BatchesController : ControllerBase
    {
        private readonly IBatchService batchService;
        private readonly IRecipesService recipesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchesController"/> class.
        /// </summary>
        /// <param name="batchService">Provides access to batches persistance.</param>
        /// <param name="recipesService">provides access to existing recipes.</param>
        public BatchesController(IBatchService batchService, IRecipesService recipesService)
        {
            this.batchService = batchService;
            this.recipesService = recipesService;
        }
    }
}