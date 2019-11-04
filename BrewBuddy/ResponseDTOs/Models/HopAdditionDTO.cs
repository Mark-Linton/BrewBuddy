// <copyright file="HopAdditionDTO.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.ResponseDTOs.Models
{
    /// <summary>
    /// Additions that contribute to the bittering.
    /// </summary>
    public class HopAdditionDTO : AdditionDTO
    {
        /// <summary>
        /// Gets or sets the Alpha Acids percent.
        /// </summary>
        public float AlphaAcidPercent { get; set; }

        /// <summary>
        /// Gets or sets the IBU value. The bitterness of the addition.
        /// </summary>
        public float IBU { get; set; }
    }
}
