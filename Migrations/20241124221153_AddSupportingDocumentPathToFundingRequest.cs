using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumbleBee.Migrations
{
    /// <inheritdoc />
    public partial class AddSupportingDocumentPathToFundingRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupportingDocumentPath",
                table: "FundingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupportingDocumentPath",
                table: "FundingRequests");
        }
    }
}
