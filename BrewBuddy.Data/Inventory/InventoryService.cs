// <copyright file="InventoryService.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Inventory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IInventoryService.
    /// </summary>
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryService"/> class.
        /// </summary>
        /// <param name="repository">Provides access to persistent inventory data.</param>
        public InventoryService(IInventoryRepository repository)
        {
            this.repository = repository;
        }
    }
}
