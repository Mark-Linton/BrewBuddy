namespace BrewBuddy.Data.Profiles.Water
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IWaterProfilesService.
    /// </summary>
    public class WaterProfilesService : IWaterProfilesService
    {
        private readonly IProfilesRepository profilesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="WaterProfilesService"/> class.
        /// </summary>
        /// <param name="profilesRepository">Provides data persistence.</param>
        public WaterProfilesService(IProfilesRepository profilesRepository)
        {
            this.profilesRepository = profilesRepository;
        }
    }
}
