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
    using BrewBuddy.ResponseDTOs;
    using BrewBuddy.ResponseDTOs.Models;

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
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            return new RecipeResponseDTO
            {
                Id = recipe.Id.ToString("N"),
                Name = recipe.Name,
                Fermentables = recipe.Fermentables.ToDTOs(),
                HopAdditions = recipe.Hops.ToDTOs(),
                MiscAdditions = recipe.Misc.ToDTOs(),
            };
        }

        private static IEnumerable<FermentableAdditionDTO> ToDTOs(this IEnumerable<FermentableAddition> fermentables)
        {
            var dtoList = new List<FermentableAdditionDTO>();

            if (fermentables != null && fermentables.Any())
            {
                foreach (var fermentable in fermentables)
                {
                    dtoList.Add(new FermentableAdditionDTO
                    {

                    });
                }
            }

            return dtoList;
        }

        private static IEnumerable<HopAdditionDTO> ToDTOs(this IEnumerable<HopAddition> hops)
        {
            var dtoList = new List<HopAdditionDTO>();

            if (hops != null && hops.Any())
            {
                foreach (var hop in hops)
                {
                    dtoList.Add(new HopAdditionDTO
                    {

                    });
                }
            }

            return dtoList;
        }

        private static IEnumerable<MiscAdditionDTO> ToDTOs(this IEnumerable<MiscAddition> miscellaneous)
        {
            var dtoList = new List<MiscAdditionDTO>();

            if (miscellaneous != null && miscellaneous.Any())
            {
                foreach (var misc in miscellaneous)
                {
                    dtoList.Add(new MiscAdditionDTO
                    {

                    });
                }
            }

            return dtoList;
        }
    }
}
