using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carmodels.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTaxonomies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Insert some taxonomies
            migrationBuilder.Sql(
                "INSERT INTO Taxonomies(Name)" +
                "VALUES" +
                "('Type')," +
                "('Size')," +
                "('Brand')"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //Remove taxonomies
            migrationBuilder.Sql(
                "DELETE FROM Taxonomies " +
                "WHERE Name IN ('Type', 'Size', 'Brand')"
            );
        }
    }
}