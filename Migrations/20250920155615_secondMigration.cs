using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace demo.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BirthDate", "FirstName", "HireDate", "HomeAddress", "LastName", "Notes", "Position", "State", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1964, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234 Executive Way, Los Angeles, CA 90210", "Heart", "Company founder and visionary leader with over 25 years of experience", "CEO", "California", "Mr." },
                    { 2, new DateTime(1981, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia", new DateTime(2012, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "567 Sunset Boulevard, San Francisco, CA 94102", "Peyton", "Dedicated sales professional with excellent customer service skills", "Sales Assistant", "California", "Mrs." },
                    { 3, new DateTime(1974, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", new DateTime(2002, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "890 Marketing Drive, Little Rock, AR 72201", "Reagan", "Strategic marketing leader specializing in digital transformation", "CMO", "Arkansas", "Mr." },
                    { 4, new DateTime(1977, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greta", new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "123 Peachtree Street, Atlanta, GA 30309", "Sims", "Experienced HR professional focused on employee development and retention", "HR Manager", "Georgia", "Ms." },
                    { 5, new DateTime(1968, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brett", new DateTime(2009, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "456 Technology Lane, Boise, ID 83702", "Wade", "Technology infrastructure specialist with expertise in cloud solutions", "IT Manager", "Idaho", "Mr." },
                    { 6, new DateTime(1974, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandra", new DateTime(2005, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "789 Financial Way, Salt Lake City, UT 84101", "Johnson", "Financial control expert with CPA certification and audit experience", "Controller", "Utah", "Mrs." },
                    { 7, new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", new DateTime(2009, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "321 Shipping Street, San Diego, CA 92101", "Carter", "Logistics coordination specialist with supply chain optimization skills", "Shipping Manager", "California", "Mr." },
                    { 8, new DateTime(1985, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2008, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "654 Human Resources Blvd, Fayetteville, AR 72703", "Stanwick", "Detail-oriented HR support specialist with recruitment expertise", "HR Assistant", "Arkansas", "Ms." },
                    { 9, new DateTime(1972, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kent", new DateTime(2009, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "987 Mediation Avenue, Kansas City, MO 64108", "Samuelson", "PhD in Organizational Psychology, employee relations specialist", "Ombudsman", "Missouri", "Dr." },
                    { 10, new DateTime(1982, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", new DateTime(2012, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "147 Network Drive, Sacramento, CA 95814", "Riley", "Network infrastructure specialist with cybersecurity certifications", "Network Admin", "California", "Mr." },
                    { 11, new DateTime(1984, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam", new DateTime(2012, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "258 Sales Circle, Savannah, GA 31401", "Hill", "Customer relationship specialist with strong communication skills", "Sales Assistant", "Georgia", "Mr." },
                    { 12, new DateTime(1988, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2012, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "369 Support Street, Fresno, CA 93701", "Rodriguez", "Technical support specialist with multilingual customer service skills", "Support Assistant", "California", "Ms." },
                    { 13, new DateTime(1977, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "741 Training Boulevard, Las Vegas, NV 89101", "Maguire", "Corporate training specialist with adult education certification", "Trainer", "Nevada", "Mrs." },
                    { 14, new DateTime(1984, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter", new DateTime(2011, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "852 Developer Lane, Meridian, ID 83642", "Hobbs", "Full-stack developer with expertise in modern web technologies", "Programmer", "Idaho", "Mr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
