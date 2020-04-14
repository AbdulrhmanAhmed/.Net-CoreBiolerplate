using Microsoft.EntityFrameworkCore.Migrations;

namespace Abdelrahman_task.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Fucalties (Name) VALUES ('Medicine')");
            migrationBuilder.Sql("INSERT INTO Fucalties (Name) VALUES ('Dentistry')");
            migrationBuilder.Sql("INSERT INTO Fucalties (Name) VALUES ('Law')");
            migrationBuilder.Sql("INSERT INTO Fucalties (Name) VALUES ('Sciences')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Fucalties");


        }
    }
}
