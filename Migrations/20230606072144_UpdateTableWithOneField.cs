using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelViewController.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableWithOneField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Booknows",
                table: "Booknows");

            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "Booknows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "Booknows",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booknows",
                table: "Booknows",
                column: "hotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Booknows",
                table: "Booknows");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "Booknows");

            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "Booknows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booknows",
                table: "Booknows",
                column: "amount");
        }
    }
}
