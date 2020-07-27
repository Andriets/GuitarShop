using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Features_FeaturesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LowerDecks_LowerDeckId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_NumberOfFrets_NumberOfFretsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_NumberOfStrings_NumberOfStringsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OverlayFingerboards_OverlayFingerboardId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pegs_PegsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProducingCountries_ProducingCountryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SidePanels_SidePanelId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeOfCorps_TypeOfCorpsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UpperDecks_UpperDeckId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_NumberOfFretsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NumberOfFretsId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "UpperDeckId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfCorpsId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SidePanelId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProducingCountryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PegsId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OverlayFingerboardId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStringsId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LowerDeckId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeaturesId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumbetOfFretsId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_NumbetOfFretsId",
                table: "Products",
                column: "NumbetOfFretsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Features_FeaturesId",
                table: "Products",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LowerDecks_LowerDeckId",
                table: "Products",
                column: "LowerDeckId",
                principalTable: "LowerDecks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_NumberOfStrings_NumberOfStringsId",
                table: "Products",
                column: "NumberOfStringsId",
                principalTable: "NumberOfStrings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_NumberOfFrets_NumbetOfFretsId",
                table: "Products",
                column: "NumbetOfFretsId",
                principalTable: "NumberOfFrets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OverlayFingerboards_OverlayFingerboardId",
                table: "Products",
                column: "OverlayFingerboardId",
                principalTable: "OverlayFingerboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Pegs_PegsId",
                table: "Products",
                column: "PegsId",
                principalTable: "Pegs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProducingCountries_ProducingCountryId",
                table: "Products",
                column: "ProducingCountryId",
                principalTable: "ProducingCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SidePanels_SidePanelId",
                table: "Products",
                column: "SidePanelId",
                principalTable: "SidePanels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeOfCorps_TypeOfCorpsId",
                table: "Products",
                column: "TypeOfCorpsId",
                principalTable: "TypeOfCorps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UpperDecks_UpperDeckId",
                table: "Products",
                column: "UpperDeckId",
                principalTable: "UpperDecks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Features_FeaturesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LowerDecks_LowerDeckId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_NumberOfStrings_NumberOfStringsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_NumberOfFrets_NumbetOfFretsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OverlayFingerboards_OverlayFingerboardId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pegs_PegsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProducingCountries_ProducingCountryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SidePanels_SidePanelId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeOfCorps_TypeOfCorpsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UpperDecks_UpperDeckId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_NumbetOfFretsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NumbetOfFretsId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "UpperDeckId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfCorpsId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SidePanelId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProducingCountryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PegsId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OverlayFingerboardId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStringsId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LowerDeckId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FeaturesId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFretsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_NumberOfFretsId",
                table: "Products",
                column: "NumberOfFretsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Features_FeaturesId",
                table: "Products",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LowerDecks_LowerDeckId",
                table: "Products",
                column: "LowerDeckId",
                principalTable: "LowerDecks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_NumberOfFrets_NumberOfFretsId",
                table: "Products",
                column: "NumberOfFretsId",
                principalTable: "NumberOfFrets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_NumberOfStrings_NumberOfStringsId",
                table: "Products",
                column: "NumberOfStringsId",
                principalTable: "NumberOfStrings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OverlayFingerboards_OverlayFingerboardId",
                table: "Products",
                column: "OverlayFingerboardId",
                principalTable: "OverlayFingerboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Pegs_PegsId",
                table: "Products",
                column: "PegsId",
                principalTable: "Pegs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProducingCountries_ProducingCountryId",
                table: "Products",
                column: "ProducingCountryId",
                principalTable: "ProducingCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SidePanels_SidePanelId",
                table: "Products",
                column: "SidePanelId",
                principalTable: "SidePanels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeOfCorps_TypeOfCorpsId",
                table: "Products",
                column: "TypeOfCorpsId",
                principalTable: "TypeOfCorps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UpperDecks_UpperDeckId",
                table: "Products",
                column: "UpperDeckId",
                principalTable: "UpperDecks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
