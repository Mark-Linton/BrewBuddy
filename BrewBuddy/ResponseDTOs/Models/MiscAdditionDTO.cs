// <copyright file="MiscAdditionDTO.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.ResponseDTOs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Additions that don't fall into either the Hop or Fermentable classifications, fining agents
    /// and flavor extracts for example.
    /// </summary>
    public class MiscAdditionDTO : AdditionDTO
    {
    }
}
