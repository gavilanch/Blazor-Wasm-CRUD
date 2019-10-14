using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUDApp.Server.Migrations
{
    public partial class TonsOfPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Name" },
                values: new object[,]
                {
                    { 6, null, "Person 6" },
                    { 78, null, "Person 78" },
                    { 77, null, "Person 77" },
                    { 76, null, "Person 76" },
                    { 75, null, "Person 75" },
                    { 74, null, "Person 74" },
                    { 73, null, "Person 73" },
                    { 72, null, "Person 72" },
                    { 71, null, "Person 71" },
                    { 70, null, "Person 70" },
                    { 69, null, "Person 69" },
                    { 68, null, "Person 68" },
                    { 67, null, "Person 67" },
                    { 66, null, "Person 66" },
                    { 65, null, "Person 65" },
                    { 64, null, "Person 64" },
                    { 63, null, "Person 63" },
                    { 62, null, "Person 62" },
                    { 61, null, "Person 61" },
                    { 60, null, "Person 60" },
                    { 59, null, "Person 59" },
                    { 58, null, "Person 58" },
                    { 79, null, "Person 79" },
                    { 57, null, "Person 57" },
                    { 80, null, "Person 80" },
                    { 82, null, "Person 82" },
                    { 103, null, "Person 103" },
                    { 102, null, "Person 102" },
                    { 101, null, "Person 101" },
                    { 100, null, "Person 100" },
                    { 99, null, "Person 99" },
                    { 98, null, "Person 98" },
                    { 97, null, "Person 97" },
                    { 96, null, "Person 96" },
                    { 95, null, "Person 95" },
                    { 94, null, "Person 94" },
                    { 93, null, "Person 93" },
                    { 92, null, "Person 92" },
                    { 91, null, "Person 91" },
                    { 90, null, "Person 90" },
                    { 89, null, "Person 89" },
                    { 88, null, "Person 88" },
                    { 87, null, "Person 87" },
                    { 86, null, "Person 86" },
                    { 85, null, "Person 85" },
                    { 84, null, "Person 84" },
                    { 83, null, "Person 83" },
                    { 81, null, "Person 81" },
                    { 56, null, "Person 56" },
                    { 55, null, "Person 55" },
                    { 54, null, "Person 54" },
                    { 27, null, "Person 27" },
                    { 26, null, "Person 26" },
                    { 25, null, "Person 25" },
                    { 24, null, "Person 24" },
                    { 23, null, "Person 23" },
                    { 22, null, "Person 22" },
                    { 21, null, "Person 21" },
                    { 20, null, "Person 20" },
                    { 19, null, "Person 19" },
                    { 18, null, "Person 18" },
                    { 17, null, "Person 17" },
                    { 16, null, "Person 16" },
                    { 15, null, "Person 15" },
                    { 14, null, "Person 14" },
                    { 13, null, "Person 13" },
                    { 12, null, "Person 12" },
                    { 11, null, "Person 11" },
                    { 10, null, "Person 10" },
                    { 9, null, "Person 9" },
                    { 8, null, "Person 8" },
                    { 7, null, "Person 7" },
                    { 28, null, "Person 28" },
                    { 29, null, "Person 29" },
                    { 30, null, "Person 30" },
                    { 31, null, "Person 31" },
                    { 53, null, "Person 53" },
                    { 52, null, "Person 52" },
                    { 51, null, "Person 51" },
                    { 50, null, "Person 50" },
                    { 49, null, "Person 49" },
                    { 48, null, "Person 48" },
                    { 47, null, "Person 47" },
                    { 46, null, "Person 46" },
                    { 45, null, "Person 45" },
                    { 44, null, "Person 44" },
                    { 104, null, "Person 104" },
                    { 43, null, "Person 43" },
                    { 41, null, "Person 41" },
                    { 40, null, "Person 40" },
                    { 39, null, "Person 39" },
                    { 38, null, "Person 38" },
                    { 37, null, "Person 37" },
                    { 36, null, "Person 36" },
                    { 35, null, "Person 35" },
                    { 34, null, "Person 34" },
                    { 33, null, "Person 33" },
                    { 32, null, "Person 32" },
                    { 42, null, "Person 42" },
                    { 105, null, "Person 105" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 105);
        }
    }
}
