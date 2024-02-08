using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LunchBox.Shared.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Locationname = table.Column<string>(name: "Location name", type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Cvr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Map = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<int>(type: "int", nullable: false),
                    ActiveOffMes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageFolder = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cvr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChainId = table.Column<int>(type: "int", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ActiveOffMes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Pickup = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryOption = table.Column<bool>(type: "bit", nullable: false),
                    PickupTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpenMan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenTue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenWed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenThu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenFre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenSun = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(name: "Full Name", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true),
                    Newsletter = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnteredTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    PrimaryStoreIds = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationsDeliverys",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    DeliveryTime = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrderClosingTime = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsDeliverys", x => new { x.LocationId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_LocationsDeliverys_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationsDeliverys_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductExtraItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    ItemName1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice1 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice2 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName3 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice3 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName4 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice4 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName5 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice5 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName6 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice6 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName7 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice7 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName8 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice8 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName9 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice9 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName10 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice10 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName11 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice11 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName12 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice12 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName13 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice13 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName14 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice14 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName15 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice15 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName16 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice16 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName17 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice17 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName18 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice18 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName19 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice19 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ItemName20 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ItemPrice20 = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExtraItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductExtraItems_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoresPaymentDetails",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    MerchantId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AgreementId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PaymentWindowApiKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AccountPrivateKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresPaymentDetails", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_StoresPaymentDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserOrderNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserOrderNumberName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequiredTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: false),
                    ActiveOffMes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductExtraitem1Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory1 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem2Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory2 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem3Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory3 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem4Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory4 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem5Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory5 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem6Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory6 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem7Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory7 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem8Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory8 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem9Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory9 = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitem10Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory10 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategorys_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem10Id",
                        column: x => x.ProductExtraitem10Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem1Id",
                        column: x => x.ProductExtraitem1Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem2Id",
                        column: x => x.ProductExtraitem2Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem3Id",
                        column: x => x.ProductExtraitem3Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem4Id",
                        column: x => x.ProductExtraitem4Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem5Id",
                        column: x => x.ProductExtraitem5Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem6Id",
                        column: x => x.ProductExtraitem6Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem7Id",
                        column: x => x.ProductExtraitem7Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem8Id",
                        column: x => x.ProductExtraitem8Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtraItems_ProductExtraitem9Id",
                        column: x => x.ProductExtraitem9Id,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderExtraItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ProductExtraitemId = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductExtraitemValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductExtraitemPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderExtraItems", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderExtraItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderExtraItems_ProductExtraItems_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderExtraItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductStoreLocations",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStoreLocations", x => new { x.StoreId, x.LocationId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductStoreLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStoreLocations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStoreLocations_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TempCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TempCarts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TempCartExtraItems",
                columns: table => new
                {
                    TempCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductExtraItemId = table.Column<int>(type: "int", nullable: false),
                    ProductExtraItemName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductExtraItemValue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CartTempId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempCartExtraItems", x => x.TempCartId);
                    table.ForeignKey(
                        name: "FK_TempCartExtraItems_ProductExtraItems_ProductExtraItemId",
                        column: x => x.ProductExtraItemId,
                        principalTable: "ProductExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TempCartExtraItems_TempCarts_CartTempId",
                        column: x => x.CartTempId,
                        principalTable: "TempCarts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "013f650c-fcb4-457a-83e4-91ad9f155d3f", null, "Customer", "CUSTOMER" },
                    { "510ad68f-794f-4b3d-abe6-fa2f0d2bb97a", null, "Company administrator", "COMPANY ADMINISTRATOR" },
                    { "8faafb10-c6b3-4915-9e06-0ac1c4dfe9d1", null, "Super Administrator", "SUPER ADMINISTRATOR" },
                    { "93bf584b-5748-487a-a5db-ff74b3ab5345", null, "Administrator", "ADMINISTRATOR" },
                    { "bc354d7a-d00c-4985-9f06-a49f888190e0", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "City", "ConcurrencyStamp", "CreatedTime", "Discriminator", "Email", "EmailConfirmed", "EnteredTime", "Full Name", "LastModifiedTime", "LocationId", "LockoutEnabled", "LockoutEnd", "Newsletter", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PrimaryStoreIds", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "26f39c07-736b-456f-a7c2-fd13c0d5d307", 0, 1, null, "253f655c-7209-412b-ac01-155fa461db82", new DateTime(2024, 2, 8, 15, 2, 47, 763, DateTimeKind.Local).AddTicks(4362), "User", "visitor@hotmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, null, 0, "VISITOR@HOTMAIL.COM", "VISITOR@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP9JlIH+eYb8tF7E+mj/G2nTXTMOpLSuSE6pftdmQh8V7Oyr+oq/TZ12eAZqMGWoHA==", null, false, null, "ef4fff78-04c8-4075-8190-944c3ec8a93a", null, false, "visitor@hotmail.com", null },
                    { "b0ad6440-65d1-4566-86a5-56cae68f501a", 0, 1, null, "9cf2f076-da41-4de7-93d7-d4b60ed24679", new DateTime(2024, 2, 8, 15, 2, 47, 657, DateTimeKind.Local).AddTicks(8702), "User", "admin@hotmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, null, 0, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPnHqsXKdGBYQBC34Ra1t4/M8Ngh3RbOuoQWOJwaQBuL2suSovtNFDp6FHfveLTFCw==", null, false, null, "9b000965-d874-4a7c-b975-d3ac7a8bd24c", null, false, "admin@hotmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Active", "ActiveOffMes", "City", "ContactPersonEmail", "ContactPersonName", "CreatedTime", "Cvr", "Description", "Email", "Location name", "Logo", "Map", "Phone", "Picture", "Street", "ZipCode" },
                values: new object[] { 1, 1, "", "Viborg", "email", "name", new DateTime(2024, 2, 8, 15, 2, 47, 605, DateTimeKind.Local).AddTicks(8000), "12133", "description", "email", "Midtbyen gymnasium", null, null, "23465656", null, "", "code" });

            migrationBuilder.InsertData(
                table: "ProductCategorys",
                columns: new[] { "Id", "CategoryName", "ImageFolder" },
                values: new object[,]
                {
                    { 1, "Sandwich", null },
                    { 2, "Salat", null },
                    { 3, "Drikkevarer", null }
                });

            migrationBuilder.InsertData(
                table: "ProductExtraItems",
                columns: new[] { "Id", "ItemName1", "ItemName10", "ItemName11", "ItemName12", "ItemName13", "ItemName14", "ItemName15", "ItemName16", "ItemName17", "ItemName18", "ItemName19", "ItemName2", "ItemName20", "ItemName3", "ItemName4", "ItemName5", "ItemName6", "ItemName7", "ItemName8", "ItemName9", "ItemPrice1", "ItemPrice10", "ItemPrice11", "ItemPrice12", "ItemPrice13", "ItemPrice14", "ItemPrice15", "ItemPrice16", "ItemPrice17", "ItemPrice18", "ItemPrice19", "ItemPrice2", "ItemPrice20", "ItemPrice3", "ItemPrice4", "ItemPrice5", "ItemPrice6", "ItemPrice7", "ItemPrice8", "ItemPrice9", "MachineName", "Name", "StoreId" },
                values: new object[,]
                {
                    { 1, "Lys", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, "bread", "Brød", null },
                    { 2, "Karry", "Ingen dressing", null, null, null, null, null, null, null, null, null, "Creme fraiche", null, "Chili", "Hvidløg", "Thousand Island", "Mexikansk", "Grøn pesto", "BBQ sauce", "Senneps dild", 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, "saurce", "Dressing", null },
                    { 3, "Ananas", "Cheddar ost", null, null, null, null, null, null, null, null, null, "Bacon", null, "Jalapenios", "Kylling", "Ost", "Rejer", "Rødløg", "Tun", "Tzatziki", 5.00m, 5.00m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 5.00m, 0m, 5.00m, 5.00m, 5.00m, 5.00m, 5.00m, 5.00m, 5.00m, "pep", "Ekstra fyld", null },
                    { 4, "Dåsesodavand", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 10.00m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, "menu_drinks", "Menutilbud", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bc354d7a-d00c-4985-9f06-a49f888190e0", "26f39c07-736b-456f-a7c2-fd13c0d5d307" },
                    { "8faafb10-c6b3-4915-9e06-0ac1c4dfe9d1", "b0ad6440-65d1-4566-86a5-56cae68f501a" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "ActiveOffMes", "Discount", "Picture", "Price", "ProductCategoryId", "ProductExtraitem10Id", "ProductExtraitem1Id", "ProductExtraitem2Id", "ProductExtraitem3Id", "ProductExtraitem4Id", "ProductExtraitem5Id", "ProductExtraitem6Id", "ProductExtraitem7Id", "ProductExtraitem8Id", "ProductExtraitem9Id", "ProductExtraitemMandatory1", "ProductExtraitemMandatory10", "ProductExtraitemMandatory2", "ProductExtraitemMandatory3", "ProductExtraitemMandatory4", "ProductExtraitemMandatory5", "ProductExtraitemMandatory6", "ProductExtraitemMandatory7", "ProductExtraitemMandatory8", "ProductExtraitemMandatory9", "ProductName", "StoreId" },
                values: new object[,]
                {
                    { 1, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "kylling & Bacon", null },
                    { 2, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "kylling & Annanas", null },
                    { 3, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Kylling & Jalepenos", null },
                    { 4, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Kylling", null },
                    { 5, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Skinke & Ost", null },
                    { 6, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Æg & Rejer", null },
                    { 7, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Tunsalat", null },
                    { 8, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Koldrøget Laks", null },
                    { 9, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Oksestrimler", null },
                    { 10, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Pulled Pork", null },
                    { 11, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Lufttørret Skinke", null },
                    { 12, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Vegatar Falafel", null },
                    { 13, 0, null, 0m, null, 32.00m, 1, null, 1, 2, 3, 4, null, null, null, null, null, 1, null, 1, null, null, null, null, null, null, null, "Mexikansk krydret oksekød", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsDeliverys_StoreId",
                table: "LocationsDeliverys",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderExtraItems_ProductId",
                table: "OrderExtraItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExtraItems_StoreId",
                table: "ProductExtraItems",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem10Id",
                table: "Products",
                column: "ProductExtraitem10Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem1Id",
                table: "Products",
                column: "ProductExtraitem1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem2Id",
                table: "Products",
                column: "ProductExtraitem2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem3Id",
                table: "Products",
                column: "ProductExtraitem3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem4Id",
                table: "Products",
                column: "ProductExtraitem4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem5Id",
                table: "Products",
                column: "ProductExtraitem5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem6Id",
                table: "Products",
                column: "ProductExtraitem6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem7Id",
                table: "Products",
                column: "ProductExtraitem7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem8Id",
                table: "Products",
                column: "ProductExtraitem8Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductExtraitem9Id",
                table: "Products",
                column: "ProductExtraitem9Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreId",
                table: "Products",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStoreLocations_LocationId",
                table: "ProductStoreLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStoreLocations_ProductId",
                table: "ProductStoreLocations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TempCartExtraItems_CartTempId",
                table: "TempCartExtraItems",
                column: "CartTempId");

            migrationBuilder.CreateIndex(
                name: "IX_TempCartExtraItems_ProductExtraItemId",
                table: "TempCartExtraItems",
                column: "ProductExtraItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TempCarts_ProductId",
                table: "TempCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TempCarts_StoreId",
                table: "TempCarts",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LocationsDeliverys");

            migrationBuilder.DropTable(
                name: "OrderExtraItems");

            migrationBuilder.DropTable(
                name: "ProductStoreLocations");

            migrationBuilder.DropTable(
                name: "StoresPaymentDetails");

            migrationBuilder.DropTable(
                name: "TempCartExtraItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TempCarts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "ProductCategorys");

            migrationBuilder.DropTable(
                name: "ProductExtraItems");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
