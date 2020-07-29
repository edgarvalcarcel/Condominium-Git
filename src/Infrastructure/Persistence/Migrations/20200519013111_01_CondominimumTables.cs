using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Condominium.Infrastructure.Persistence.Migrations
{
    public partial class _01_CondominimumTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Breed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitorParking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Zona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorParking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Relationship = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    City = table.Column<string>(maxLength: 60, nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    InsertDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "SYSDATETIME()"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "SYSDATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Comments = table.Column<int>(nullable: false),
                    PropertyTypeId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_PropertyType_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resident",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdDocument = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    PartnerId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    IsOwner = table.Column<bool>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Fingerprint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resident_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resident_Resident_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Resident_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Resident_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Leasing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false),
                    ResidentTenantId = table.Column<int>(nullable: false),
                    MoveInDate = table.Column<DateTime>(nullable: true),
                    LeaseStartDate = table.Column<DateTime>(nullable: false),
                    LeaseEndDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leasing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leasing_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leasing_Resident_ResidentTenantId",
                        column: x => x.ResidentTenantId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leasing_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetTypeId = table.Column<int>(nullable: false),
                    BreeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true),
                    VisitorId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    IsPotentiallyDangerous = table.Column<bool>(nullable: false),
                    BreedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Breed_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pet_PetType_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Resident_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pet_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyOwner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    ResidentId = table.Column<int>(nullable: false),
                    IsMainOwner = table.Column<bool>(nullable: false),
                    AcquiredDate = table.Column<DateTime>(nullable: false),
                    SellingDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyOwner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyOwner_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyOwner_Resident_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakerId = table.Column<int>(nullable: false),
                    VehicleModelId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    Plate = table.Column<string>(nullable: true),
                    ResidentId = table.Column<int>(nullable: false),
                    VisitorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Maker_MakerId",
                        column: x => x.MakerId,
                        principalTable: "Maker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Resident_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModel_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(nullable: false),
                    PropertyId = table.Column<int>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    DismissalTime = table.Column<DateTime>(nullable: true),
                    ResidentApprovingId = table.Column<int>(nullable: false),
                    IndexCard = table.Column<string>(nullable: true),
                    VisitorParkingId = table.Column<string>(nullable: true),
                    VisitorParkingId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitorLog_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorLog_Resident_ResidentApprovingId",
                        column: x => x.ResidentApprovingId,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VisitorLog_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorLog_VisitorParking_VisitorParkingId1",
                        column: x => x.VisitorParkingId1,
                        principalTable: "VisitorParking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StateId",
                table: "Contact",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StatusId",
                table: "Contact",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Leasing_PropertyId",
                table: "Leasing",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Leasing_ResidentTenantId",
                table: "Leasing",
                column: "ResidentTenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Leasing_StatusId",
                table: "Leasing",
                column: "StatusId");
         
            migrationBuilder.CreateIndex(
                name: "IX_Pet_BreedId",
                table: "Pet",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetTypeId",
                table: "Pet",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_ResidentId",
                table: "Pet",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_StatusId",
                table: "Pet",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_VisitorId",
                table: "Pet",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_LocationId",
                table: "Property",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyTypeId",
                table: "Property",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_StatusId",
                table: "Property",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyOwner_PropertyId",
                table: "PropertyOwner",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyOwner_ResidentId",
                table: "PropertyOwner",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_ContactId",
                table: "Resident",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_PartnerId",
                table: "Resident",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_StateId",
                table: "Resident",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_StatusId",
                table: "Resident",
                column: "StatusId");


            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ColorId",
                table: "Vehicle",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_MakerId",
                table: "Vehicle",
                column: "MakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ResidentId",
                table: "Vehicle",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleModelId",
                table: "Vehicle",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VisitorId",
                table: "Vehicle",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorLog_PropertyId",
                table: "VisitorLog",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorLog_ResidentApprovingId",
                table: "VisitorLog",
                column: "ResidentApprovingId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorLog_VisitorId",
                table: "VisitorLog",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorLog_VisitorParkingId1",
                table: "VisitorLog",
                column: "VisitorParkingId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "Leasing");
            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "PropertyOwner");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VisitorLog");

            migrationBuilder.DropTable(
                name: "Breed");

            migrationBuilder.DropTable(
                name: "PetType");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Maker");

            migrationBuilder.DropTable(
                name: "VehicleModel");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Resident");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "VisitorParking");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "PropertyType");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
