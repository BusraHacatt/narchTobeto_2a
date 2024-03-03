using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1ce427a0-3aea-43ce-8588-238eae030904"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b82692df-fe33-4a92-982a-092b9c47274b"));

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilometer = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransmissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModelYear = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 253, 251, 173, 81, 106, 183, 110, 52, 93, 141, 232, 44, 4, 38, 80, 184, 34, 138, 85, 20, 184, 43, 2, 23, 170, 165, 113, 139, 241, 181, 250, 45, 142, 97, 201, 147, 202, 121, 49, 112, 195, 0, 86, 118, 42, 29, 84, 208, 25, 169, 180, 160, 50, 210, 186, 157, 204, 253, 185, 156, 36, 43, 126, 52 }, new byte[] { 179, 98, 56, 172, 42, 98, 210, 122, 95, 197, 208, 60, 235, 152, 239, 198, 93, 54, 23, 92, 89, 236, 135, 104, 250, 243, 84, 248, 22, 198, 180, 215, 185, 111, 95, 170, 76, 137, 27, 228, 99, 21, 143, 96, 66, 235, 127, 76, 21, 172, 156, 107, 1, 151, 100, 238, 118, 246, 239, 129, 55, 104, 240, 197, 151, 173, 212, 179, 173, 114, 171, 211, 24, 245, 55, 91, 72, 204, 17, 169, 90, 93, 206, 110, 167, 162, 74, 206, 52, 156, 172, 47, 9, 108, 177, 38, 57, 187, 202, 127, 28, 175, 109, 138, 64, 86, 241, 133, 183, 138, 92, 119, 187, 102, 109, 166, 214, 189, 175, 249, 108, 164, 28, 36, 244, 48, 163, 159 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("fffa8937-3919-49ac-873c-aba682d9c1b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId",
                table: "Models",
                column: "FuelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Models_TransmissionId",
                table: "Models",
                column: "TransmissionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fffa8937-3919-49ac-873c-aba682d9c1b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("b82692df-fe33-4a92-982a-092b9c47274b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 95, 220, 142, 168, 100, 145, 173, 52, 45, 107, 1, 234, 106, 42, 75, 248, 230, 233, 202, 242, 235, 68, 244, 252, 126, 246, 24, 78, 241, 24, 12, 250, 225, 128, 119, 165, 41, 33, 69, 217, 203, 17, 153, 63, 173, 218, 165, 129, 17, 165, 140, 133, 26, 231, 71, 8, 245, 123, 38, 0, 163, 45, 215, 254 }, new byte[] { 37, 190, 236, 50, 133, 245, 202, 156, 2, 43, 0, 47, 182, 182, 149, 244, 98, 117, 115, 62, 175, 129, 228, 243, 211, 53, 107, 175, 56, 224, 6, 61, 57, 70, 51, 105, 112, 87, 79, 106, 117, 78, 129, 232, 25, 179, 233, 164, 237, 80, 234, 165, 6, 206, 229, 124, 78, 76, 102, 70, 122, 71, 50, 56, 137, 73, 71, 52, 148, 247, 166, 47, 174, 214, 188, 136, 186, 209, 68, 241, 22, 24, 144, 212, 74, 189, 212, 11, 100, 169, 77, 91, 56, 205, 34, 193, 52, 106, 10, 155, 73, 203, 70, 50, 109, 15, 35, 96, 155, 252, 42, 211, 211, 111, 52, 213, 125, 226, 28, 130, 70, 63, 41, 220, 231, 153, 217, 82 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1ce427a0-3aea-43ce-8588-238eae030904"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("b82692df-fe33-4a92-982a-092b9c47274b") });
        }
    }
}
