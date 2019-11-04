// <copyright file="RecipeResponseDTO.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.ResponseDTOs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BrewBuddy.ResponseDTOs.Models;

    /// <summary>
    /// External data representation of a brew Recipe.
    /// </summary>
    public class RecipeResponseDTO
    {
        /// <summary>
        /// Gets or sets the Id. Used to identify the recipe in various queries.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Name. The name of the beverage.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Brewer. The person who created the recipe.
        /// </summary>
        public string Brewer { get; set; }

        /// <summary>
        /// Gets or sets the Fermentables. The ingredients that will contrubute to the ABV of the
        /// finished beverage.
        /// </summary>
        public IEnumerable<FermentableAdditionDTO> Fermentables { get; set; }

        /// <summary>
        /// Gets or sets the HopAdditions. Ingredients that will control the final IBU of the
        /// finished beverage.
        /// </summary>
        public IEnumerable<HopAdditionDTO> HopAdditions { get; set; }

        /// <summary>
        /// Gets or sets the MiscAdditions. Non-Hop ingredients that are typically added during the
        /// fermentation process but do not contrubute to the final ABV of the finished beverage.
        /// </summary>
        public IEnumerable<MiscAdditionDTO> MiscAdditions { get; set; }
    }
}
