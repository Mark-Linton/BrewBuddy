// <copyright file="SQLiteRecipeRepository.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using BrewBuddy.Data.Recipes;

    /// <summary>
    /// CRUD methods that are specific to Recipes.
    /// </summary>
    public partial class SQLiteRepository
    {
        /// <inheritdoc/>
        public void AddRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                return;
            }

            var commandString =
                $@"
                INSERT INTO {RecipesTable} (
                    id,
                    name,
                    brewer,
                    type
                )
                VALUES (
                    @id,
                    @name,
                    @brewer,
                    @type
                )";

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand(commandString, connection))
            {
                connection.Open();
                command.Parameters.Add(new SQLiteParameter("@id", null));
                command.Parameters.Add(new SQLiteParameter("@name", null));
                command.Parameters.Add(new SQLiteParameter("@brewer", null));
                command.Parameters.Add(new SQLiteParameter("@type", null));
                command.ExecuteNonQuery();
            }
        }

        /// <inheritdoc/>
        public IEnumerable<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand($"SELECT * FROM {RecipesTable}", connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var recipe = new Recipe
                        {
                            Id = (Guid)reader["id"],
                            Name = (string)reader["name"],
                            Brewer = (string)reader["brewer"],
                            Type = (RecipeType)reader["type"],
                        };

                        recipes.Add(recipe);
                    }
                }
            }

            return recipes;
        }

        /// <inheritdoc/>
        public Recipe GetRecipe(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("id must have a value");
            }

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand($"SELECT * FROM {RecipesTable} WHERE id=@id", connection))
            {
                connection.Open();
                command.Parameters.Add(new SQLiteParameter("@id", id));

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var recipe = new Recipe
                        {
                            Id = (Guid)reader["id"],
                        };

                        return recipe;
                    }
                }

                return null;
            }
        }

        /// <inheritdoc/>
        public void UpdateRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                return;
            }

            if (recipe.Id == null || recipe.Id == Guid.Empty)
            {
                return;
            }

            var commandString =
                $@"
                UPDATE
                    {RecipesTable}
                SET
                    name=@name,
                    brewer=@brewer,
                    type=@type
                WHERE
                    id=@id
                ";

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand(commandString, connection))
            {
                connection.Open();
                command.Parameters.Add(new SQLiteParameter("@id", recipe.Id));
                command.Parameters.Add(new SQLiteParameter("@name", recipe.Name));
                command.Parameters.Add(new SQLiteParameter("@brewer", recipe.Brewer));
                command.Parameters.Add(new SQLiteParameter("@type", recipe.Type));
                command.ExecuteNonQuery();
            }
        }

        /// <inheritdoc/>
        public void DeleteRecipe(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return;
            }

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand($"DELETE FROM {RecipesTable} WHERE id=@id", connection))
            {
                connection.Open();
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.ExecuteNonQuery();
            }
        }

        /// <inheritdoc/>
        public void DeleteRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                return;
            }

            this.DeleteRecipe(recipe.Id);
        }
    }
}
