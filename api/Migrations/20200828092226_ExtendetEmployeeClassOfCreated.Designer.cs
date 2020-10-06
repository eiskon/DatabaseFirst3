﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Model;

namespace api.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20200828092226_ExtendetEmployeeClassOfCreated")]
    partial class ExtendetEmployeeClassOfCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Model.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryName")
                        .HasName("CategoryName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("api.Model.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5);

                    b.Property<string>("CustomerTypeId")
                        .HasColumnName("CustomerTypeID")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.HasKey("CustomerId", "CustomerTypeId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("CustomerCustomerDemo");
                });

            modelBuilder.Entity("api.Model.CustomerDemographics", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .HasColumnName("CustomerTypeID")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("ntext");

                    b.HasKey("CustomerTypeId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("api.Model.Customers", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.HasIndex("City")
                        .HasName("City");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("Region")
                        .HasName("Region");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("api.Model.EmployeeTerritories", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeId", "TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("api.Model.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("image");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("EmployeeId");

                    b.HasIndex("LastName")
                        .HasName("LastName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("api.Model.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductID")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK_Order_Details");

                    b.HasIndex("OrderId")
                        .HasName("OrdersOrder_Details");

                    b.HasIndex("ProductId")
                        .HasName("ProductsOrder_Details");

                    b.ToTable("Order Details");
                });

            modelBuilder.Entity("api.Model.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5);

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("EmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int?>("ShipVia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId")
                        .HasName("CustomersOrders");

                    b.HasIndex("EmployeeId")
                        .HasName("EmployeesOrders");

                    b.HasIndex("OrderDate")
                        .HasName("OrderDate");

                    b.HasIndex("ShipPostalCode")
                        .HasName("ShipPostalCode");

                    b.HasIndex("ShipVia")
                        .HasName("ShippersOrders");

                    b.HasIndex("ShippedDate")
                        .HasName("ShippedDate");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("api.Model.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SupplierId")
                        .HasColumnName("SupplierID")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId")
                        .HasName("CategoryID");

                    b.HasIndex("ProductName")
                        .HasName("ProductName");

                    b.HasIndex("SupplierId")
                        .HasName("SuppliersProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("api.Model.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("RegionId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Region");
                });

            modelBuilder.Entity("api.Model.Shippers", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShipperID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("api.Model.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupplierID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage")
                        .HasColumnType("ntext");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("SupplierId");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("api.Model.Territories", b =>
                {
                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("api.Model.CustomerCustomerDemo", b =>
                {
                    b.HasOne("api.Model.Customers", "Customer")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerCustomerDemo_Customers")
                        .IsRequired();

                    b.HasOne("api.Model.CustomerDemographics", "CustomerType")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerTypeId")
                        .HasConstraintName("FK_CustomerCustomerDemo")
                        .IsRequired();
                });

            modelBuilder.Entity("api.Model.EmployeeTerritories", b =>
                {
                    b.HasOne("api.Model.Employees", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeTerritories_Employees")
                        .IsRequired();

                    b.HasOne("api.Model.Territories", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId")
                        .HasConstraintName("FK_EmployeeTerritories_Territories")
                        .IsRequired();
                });

            modelBuilder.Entity("api.Model.Employees", b =>
                {
                    b.HasOne("api.Model.Employees", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");
                });

            modelBuilder.Entity("api.Model.OrderDetails", b =>
                {
                    b.HasOne("api.Model.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Order_Details_Orders")
                        .IsRequired();

                    b.HasOne("api.Model.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Order_Details_Products")
                        .IsRequired();
                });

            modelBuilder.Entity("api.Model.Orders", b =>
                {
                    b.HasOne("api.Model.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("api.Model.Employees", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("api.Model.Shippers", "ShipViaNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Orders_Shippers");
                });

            modelBuilder.Entity("api.Model.Products", b =>
                {
                    b.HasOne("api.Model.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("api.Model.Suppliers", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Products_Suppliers");
                });

            modelBuilder.Entity("api.Model.Territories", b =>
                {
                    b.HasOne("api.Model.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_Territories_Region")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
