using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18650721-2eb7-43e1-95ee-0d6d5fe9c4d6", "8e6853af-fc97-4626-b7b1-92296c3a6e6b", "Usuário", "USUÁRIO" },
                    { "8f04ab87-ed5f-4ecd-b825-7018e6fdc985", "554ee9d4-fded-4657-89ae-34fee1bc58e3", "Administrador", "ADMINISTRADOR" },
                    { "d77b5697-d757-413e-b9a0-036687455f6b", "bd63493e-3ca0-4211-bd09-f7fc87486b3f", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9e1e8916-11df-404b-aee7-ab69c161d9ce", 0, "387739e6-64c9-4f24-bdc1-590bfd2ec6b2", "jose.santos1242@etec.sp.gov.br", true, false, null, "JOSE.SANTOS1242@ETEC.SP.GOV.BR", "JOSEMAKSUD", "AQAAAAEAACcQAAAAEIIVs3fQ6S5djadnPUl3msNAsAREIKYDUUVmjP0fkr+/qJ+1IJaD/IR+ScHD1i25vQ==", "14912345678", true, "19b95350-0d33-42db-b404-03195925963b", false, "JoseMaksud" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "FullStack" },
                    { (byte)2, "FrontEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f04ab87-ed5f-4ecd-b825-7018e6fdc985", "9e1e8916-11df-404b-aee7-ab69c161d9ce" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "9e1e8916-11df-404b-aee7-ab69c161d9ce", new DateTime(2006, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.png", "José Francisco Dos Santos Neto", (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18650721-2eb7-43e1-95ee-0d6d5fe9c4d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d77b5697-d757-413e-b9a0-036687455f6b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f04ab87-ed5f-4ecd-b825-7018e6fdc985", "9e1e8916-11df-404b-aee7-ab69c161d9ce" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "9e1e8916-11df-404b-aee7-ab69c161d9ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f04ab87-ed5f-4ecd-b825-7018e6fdc985");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e1e8916-11df-404b-aee7-ab69c161d9ce");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)1);
        }
    }
}
