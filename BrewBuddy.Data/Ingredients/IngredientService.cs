namespace BrewBuddy.Data.Ingredients
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrewBuddy.Data.Persistence;

    /// <summary>
    /// Concrete implementation of IIngredientService.
    /// </summary>
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientsRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientService"/> class.
        /// </summary>
        /// <param name="repository">Provides access to persistent ingredient data.</param>
        public IngredientService(IIngredientsRepository repository)
        {
            this.repository = repository;
        }
    }
}
