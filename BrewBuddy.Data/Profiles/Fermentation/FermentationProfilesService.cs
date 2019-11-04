// <copyright file="FermentationProfilesService.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Profiles.Fermentation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IFermentationProfilesService.
    /// </summary>
    public class FermentationProfilesService : IFermentationProfilesService
    {
        private readonly IProfilesRepository profilesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FermentationProfilesService"/> class.
        /// </summary>
        /// <param name="profilesRepository">Provides data persistence.</param>
        public FermentationProfilesService(IProfilesRepository profilesRepository)
        {
            this.profilesRepository = profilesRepository;
        }
    }
}
