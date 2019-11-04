// <copyright file="AdditionDTO.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.ResponseDTOs.Models
{
    /// <summary>
    /// Base addition class that all, more specialized, AdditionDTOs derive from.
    /// </summary>
    public abstract class AdditionDTO
    {
        /// <summary>
        /// Gets or sets the Name of the addition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Amount of the addition.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Gets or sets the IngredientId. The ID used to look up the specifics of the ingredient.
        /// </summary>
        public string IngredientId { get; set; }
    }
}
