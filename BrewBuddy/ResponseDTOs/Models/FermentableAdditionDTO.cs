// <copyright file="FermentableAdditionDTO.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.ResponseDTOs.Models
{
    /// <summary>
    /// Additions that contribute to the ABV of the finished beverage.
    /// Typically grains and sugars.
    /// </summary>
    public class FermentableAdditionDTO : AdditionDTO
    {
        /// <summary>
        /// Gets or sets the Category.
        ///
        /// The 6 supported values are:
        /// Grain, Liquid Extract, Dry Extract, Sugar, Adjunct, Other.
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// Gets or sets the Color contribution of the Addition.
        /// Measured using ither EBC or SRM/Lovibond depending on the app settings.
        /// </summary>
        public float Color { get; set; }
    }
}
