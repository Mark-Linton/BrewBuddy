namespace BrewBuddy.Data.Profiles.Equipment
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IEquipmentProfilesService.
    /// </summary>
    public class EquipmentProfilesService : IEquipmentProfilesService
    {
        private readonly IProfilesRepository profilesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentProfilesService"/> class.
        /// </summary>
        /// <param name="profilesRepository">Provides data persistence.</param>
        public EquipmentProfilesService(IProfilesRepository profilesRepository)
        {
            this.profilesRepository = profilesRepository;
        }
    }
}
