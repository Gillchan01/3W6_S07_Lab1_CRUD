using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class SeedMonWeapon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "CreatedDate", "Description", "Force", "Image", "Name", "Price", "Qty", "QtyBought" },
                values: new object[] { 3, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The sword used by the Lich king", 300m, "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/c78f1949-5e75-4eab-9541-770f5214a2b7/dhe20pb-202b5835-44a7-4a7e-9a25-f1a06aaf0002.png/v1/fit/w_828,h_1412/frostmourne_by_gortime_dhe20pb-414w-2x.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MjE2MCIsInBhdGgiOiIvZi9jNzhmMTk0OS01ZTc1LTRlYWItOTU0MS03NzBmNTIxNGEyYjcvZGhlMjBwYi0yMDJiNTgzNS00NGE3LTRhN2UtOWEyNS1mMWEwNmFhZjAwMDIucG5nIiwid2lkdGgiOiI8PTEyNjcifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.Si10jV5IEsUOJg9AppnfQQlXN2K-1HY8PJ1pPPCbzNU", "Frostmourne", 1000m, 1, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3);
        }
    }
}
