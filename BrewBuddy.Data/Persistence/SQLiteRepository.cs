namespace BrewBuddy.Data.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SQLiteRepository : IRepository
    {
        private const string RecipeTable = "Recipe";
        private const string RecipeIngredientsTable = "Recipe_Ingredients";
        private const string IngredientsTable = "Ingredients";
        private const string InventoryTable = "Inventory";
        private const string ProfilesWater = "Profiles_Water";
        private const string ProfilesEquipment = "Profiles_Equipment";
        private const string ProfilesFermentation = "Profiles_Fermentation";

        private readonly string[] createTableCommands =
            {
                "PRAGMA locking_mode=EXCLUSIVE",

                @$"CREATE TABLE IF NOT EXISTS {RecipeTable} (
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
                    id              INTEGER PRIMARY KEY AUTOINCREMENT,
                )",

                $@"CREATE TABLE IF NOT EXISTS {ProfilesEquipment} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT,
                )",

                $@"CREATE TABLE IF NOT EXISTS {ProfilesFermentation} (
                    id              INTEGER PRIMARY KEY AUTOINCREMENT,
                )",
            };

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteRepository"/> class.
        /// </summary>
        public SQLiteRepository()
        {

        }
    }
}
