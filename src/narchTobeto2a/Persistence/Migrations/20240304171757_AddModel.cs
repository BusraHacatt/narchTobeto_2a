using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fffa8937-3919-49ac-873c-aba682d9c1b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711"));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Models.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3dfd28b8-039c-4879-8899-6fce7e68d2de"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 252, 81, 182, 182, 114, 8, 207, 210, 228, 80, 88, 162, 89, 127, 96, 134, 109, 56, 119, 125, 210, 212, 207, 30, 107, 112, 191, 51, 215, 165, 163, 210, 178, 48, 47, 57, 14, 51, 14, 75, 173, 184, 190, 101, 231, 55, 30, 181, 171, 111, 33, 113, 185, 254, 32, 70, 227, 139, 164, 100, 194, 39, 242, 9 }, new byte[] { 28, 255, 134, 51, 37, 67, 0, 177, 233, 192, 207, 179, 36, 218, 31, 53, 70, 197, 59, 188, 255, 234, 123, 140, 159, 182, 223, 197, 146, 243, 134, 213, 228, 26, 149, 243, 152, 205, 59, 7, 142, 116, 44, 171, 149, 197, 95, 222, 199, 104, 66, 133, 51, 200, 63, 203, 55, 23, 124, 99, 101, 103, 93, 161, 187, 240, 191, 62, 83, 83, 233, 197, 0, 113, 242, 6, 106, 98, 113, 25, 130, 60, 207, 12, 9, 191, 175, 184, 85, 103, 54, 42, 253, 93, 211, 113, 76, 207, 52, 130, 87, 145, 171, 239, 70, 249, 96, 66, 220, 225, 207, 99, 240, 30, 213, 50, 195, 65, 55, 15, 235, 63, 104, 246, 81, 194, 59, 210 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("866f3266-7019-4c27-804c-77c808bb71ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3dfd28b8-039c-4879-8899-6fce7e68d2de") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("866f3266-7019-4c27-804c-77c808bb71ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dfd28b8-039c-4879-8899-6fce7e68d2de"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 253, 251, 173, 81, 106, 183, 110, 52, 93, 141, 232, 44, 4, 38, 80, 184, 34, 138, 85, 20, 184, 43, 2, 23, 170, 165, 113, 139, 241, 181, 250, 45, 142, 97, 201, 147, 202, 121, 49, 112, 195, 0, 86, 118, 42, 29, 84, 208, 25, 169, 180, 160, 50, 210, 186, 157, 204, 253, 185, 156, 36, 43, 126, 52 }, new byte[] { 179, 98, 56, 172, 42, 98, 210, 122, 95, 197, 208, 60, 235, 152, 239, 198, 93, 54, 23, 92, 89, 236, 135, 104, 250, 243, 84, 248, 22, 198, 180, 215, 185, 111, 95, 170, 76, 137, 27, 228, 99, 21, 143, 96, 66, 235, 127, 76, 21, 172, 156, 107, 1, 151, 100, 238, 118, 246, 239, 129, 55, 104, 240, 197, 151, 173, 212, 179, 173, 114, 171, 211, 24, 245, 55, 91, 72, 204, 17, 169, 90, 93, 206, 110, 167, 162, 74, 206, 52, 156, 172, 47, 9, 108, 177, 38, 57, 187, 202, 127, 28, 175, 109, 138, 64, 86, 241, 133, 183, 138, 92, 119, 187, 102, 109, 166, 214, 189, 175, 249, 108, 164, 28, 36, 244, 48, 163, 159 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("fffa8937-3919-49ac-873c-aba682d9c1b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("280f1d7c-59d7-453a-9a09-6aea48d9c711") });
        }
    }
}
