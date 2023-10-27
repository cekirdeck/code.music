using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AdressBookData.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "character varying", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "character varying", maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "character varying", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "character varying", maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "character varying", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", maxLength: 250, nullable: true),
                    surname = table.Column<string>(type: "character varying", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phoneNumber = table.Column<string>(type: "character varying", maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "character varying", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Person_N_Company",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idPerson = table.Column<int>(type: "int", nullable: false),
                    idCompany = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_N_Company", x => x.id);
                    table.ForeignKey(
                        name: "FK_PERSON_N_COMPANY_COMPANY",
                        column: x => x.idCompany,
                        principalTable: "Company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_N_COMPANY_PERSON",
                        column: x => x.idPerson,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person_N_Email",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idPerson = table.Column<int>(type: "int", nullable: false),
                    idEmail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_N_Email", x => x.id);
                    table.ForeignKey(
                        name: "FKPERSON_N_EMAIL_EMAIL",
                        column: x => x.idEmail,
                        principalTable: "Email",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_N_EMAIL_PERSON",
                        column: x => x.idPerson,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person_N_Location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idPerson = table.Column<int>(type: "int", nullable: false),
                    idLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_N_Location", x => x.id);
                    table.ForeignKey(
                        name: "FKPERSON_N_LOCATION_LOCATION",
                        column: x => x.idLocation,
                        principalTable: "Location",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_N_LOCATION_PERSON",
                        column: x => x.idPerson,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person_N_Phone",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idPerson = table.Column<int>(type: "int", nullable: false),
                    idPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_N_Phone", x => x.id);
                    table.ForeignKey(
                        name: "FKPERSON_N_PHONE_PHONE",
                        column: x => x.idPhone,
                        principalTable: "Phone",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_N_PHONE_PERSON",
                        column: x => x.idPerson,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Company_idCompany",
                table: "Person_N_Company",
                column: "idCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Company_idPerson",
                table: "Person_N_Company",
                column: "idPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Email_idEmail",
                table: "Person_N_Email",
                column: "idEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Email_idPerson",
                table: "Person_N_Email",
                column: "idPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Location_idLocation",
                table: "Person_N_Location",
                column: "idLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Location_idPerson",
                table: "Person_N_Location",
                column: "idPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Phone_idPerson",
                table: "Person_N_Phone",
                column: "idPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Person_N_Phone_idPhone",
                table: "Person_N_Phone",
                column: "idPhone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person_N_Company");

            migrationBuilder.DropTable(
                name: "Person_N_Email");

            migrationBuilder.DropTable(
                name: "Person_N_Location");

            migrationBuilder.DropTable(
                name: "Person_N_Phone");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
