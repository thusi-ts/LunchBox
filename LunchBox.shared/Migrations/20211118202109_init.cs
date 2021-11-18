using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LunchBox.Shared.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(name: "Full Name", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Newsletter = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnteredTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    PrimaryStoreIds = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Locations_LocationId",
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
                    ItemMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserOrderNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserOrderNumberName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequiredTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: false),
                    ActiveOffMes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductExtraitem1Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory1 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem2Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory2 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem3Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory3 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem4Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory4 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem5Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory5 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem6Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory6 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem7Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory7 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem8Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory8 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem9Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory9 = table.Column<int>(type: "int", nullable: false),
                    ProductExtraitem10Id = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemMandatory10 = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductExtraitemId = table.Column<int>(type: "int", nullable: true),
                    ProductExtraitemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductExtraitemValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductExtraitemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_LocationId",
                table: "Users",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TempCarts");

            migrationBuilder.DropTable(
                name: "Users");

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
