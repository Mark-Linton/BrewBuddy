// <copyright file="ProfilesController.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Controllers
{
    using BrewBuddy.Data.Profiles.Equipment;
    using BrewBuddy.Data.Profiles.Fermentation;
    using BrewBuddy.Data.Profiles.Water;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains all endpoints for configuring water, brewing & fermentation equipment profiles.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IEquipmentProfilesService equipmentProfilesService;
        private readonly IFermentationProfilesService fermentationProfilesService;
        private readonly IWaterProfilesService waterProfilesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesController"/> class.
        /// </summary>
        /// <param name="equipmentProfilesService">Provides access to equipment profiles persistence.</param>
        /// <param name="fermentationProfilesService">Provides access to fermentation profiles persistence.</param>
        /// <param name="waterProfilesService">Provides access to water profiles persistence.</param>
        public ProfilesController(
            IEquipmentProfilesService equipmentProfilesService,
            IFermentationProfilesService fermentationProfilesService,
            IWaterProfilesService waterProfilesService)
        {
            this.equipmentProfilesService = equipmentProfilesService;
            this.fermentationProfilesService = fermentationProfilesService;
            this.waterProfilesService = waterProfilesService;
        }
    }
}