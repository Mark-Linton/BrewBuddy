// <copyright file="SQLiteRepository.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy.Data.Persistence
{
    using System.Data;
    using System.Data.SQLite;
    using System.IO;

    /// <summary>
    /// Provides data persistence using SQLite.
    /// </summary>
    public partial class SQLiteRepository
        : IRecipeRepository, IBatchesRepository, IIngredientsRepository, IInventoryRepository, IProfilesRepository
    {
        private const string DbName = "data.db3";
        private const string RecipesTable = "Recipe";
        private const string RecipeIngredientsTable = "Recipe_Ingredients";
        private const string IngredientsTable = "Ingredients";
        private const string InventoryTable = "Inventory";
        private const string ProfilesWater = "Profiles_Water";
        private const string ProfilesEquipment = "Profiles_Equipment";
        private const string ProfilesFermentation = "Profiles_Fermentation";

        private readonly string[] createTableCommands =
            {
                "PRAGMA locking_mode=EXCLUSIVE",

                @$"CREATE TABLE IF NOT EXISTS {RecipesTable} (
                    id              GUID    NOT NULL,
                    name            TEXT,
                    brewer          TEXT,
                    type            TEXT
                )",

                @$"CREATE TABLE IF NOT EXISTS {RecipeIngredientsTable} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT,
                    recipe_id       GUID    NOT NULL,
                    ingredient_id   GUID    NOT NULL,
                    units           TEXT,
                    amount          FLOAT,
                    add_during      INT,
                    time            INT,
                    type            INT
                )",

                @$"CREATE TABLE IF NOT EXISTS {IngredientsTable} (
                    id              GUID    NOT NULL,
                    name            TEXT,
                    supplier        TEXT,
                    origin          TEXT,
                    category        INT,
                    type            INT
                )",

                @$"CREATE TABLE IF NOT EXISTS {InventoryTable} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT,
                    ingredient_id   GUID    NOT NULL,
                    units           INT,
                    amount          FLOAT,
                    unit_cost       FLOAT
                )",

                $@"CREATE TABLE IF NOT EXISTS {ProfilesWater} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT
                )",

                $@"CREATE TABLE IF NOT EXISTS {ProfilesEquipment} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT
                )",

                $@"CREATE TABLE IF NOT EXISTS {ProfilesFermentation} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT
                )",
            };

        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteRepository"/> class.
        /// </summary>
        public SQLiteRepository()
        {
            this.connectionString = $"Data Source={DbName};Version=3;";
            this.CreateDB();
        }

        private void CreateDB()
        {
            if (!File.Exists(DbName))
            {
                SQLiteConnection.CreateFile(DbName);
            }

            using (var connection = new SQLiteConnection(this.connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                foreach (var cmdString in this.createTableCommands)
                {
                    command.CommandText = cmdString;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
