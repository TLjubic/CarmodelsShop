using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carmodels.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Add some categories
            migrationBuilder.Sql(
                "INSERT INTO Categories(Name, TaxonomyId)" +
                "VALUES" +
                "('Cars', (SELECT Id FROM Taxonomies WHERE Name = 'Type'))," +
                "('Buses', (SELECT Id FROM Taxonomies WHERE Name = 'Type'))," +
                "('Motorcycles', (SELECT Id FROM Taxonomies WHERE Name = 'Type'))," +
                "('1/18', (SELECT Id FROM Taxonomies WHERE Name = 'Size'))," +
                "('1/24', (SELECT Id FROM Taxonomies WHERE Name = 'Size'))," +
                "('1/32', (SELECT Id FROM Taxonomies WHERE Name = 'Size'))," +
                "('1/64', (SELECT Id FROM Taxonomies WHERE Name = 'Size'))," +
                "('Alfa Romeo', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Audi', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Buggati', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Ferrari', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Lamborghini', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Mercedes', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))," +
                "('Porsche', (SELECT Id FROM Taxonomies WHERE Name = 'Brand'))"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //Remove categories
            migrationBuilder.Sql(
                "DELETE FROM Categories " +
                "WHERE Name IN ('Cars', 'Buses', 'Motorcycles', '1/18', '1/24', '1/32', '1/64', 'Alfa Romeo', 'Audi', 'Buggati', 'Ferrari', 'Lamborghini', 'Mercedes', 'Porsche')"
            );
        }
    }
}