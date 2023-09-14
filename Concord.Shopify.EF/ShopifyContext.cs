using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Concord.Shopify.EF.Models;

#nullable disable

namespace Concord.Shopify.EF
{
    public partial class ShopifyContext : DbContext
    {
        public ShopifyContext()
        {
        }

        public ShopifyContext(DbContextOptions<ShopifyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DimCurrency> DimCurrencies { get; set; }
        public virtual DbSet<DimDate> DimDates { get; set; }
        public virtual DbSet<DimFinancialStatus> DimFinancialStatuses { get; set; }
        public virtual DbSet<DimFulFillmentStatus> DimFulFillmentStatuses { get; set; }
        public virtual DbSet<DimProductVariant> DimProductVariants { get; set; }
        public virtual DbSet<DimStore> DimStores { get; set; }
        public virtual DbSet<DimTitle> DimTitles { get; set; }
        public virtual DbSet<DimVendor> DimVendors { get; set; }
        public virtual DbSet<EmailNotification> EmailNotifications { get; set; }
        public virtual DbSet<Exception> Exceptions { get; set; }
        public virtual DbSet<FactOrder> FactOrders { get; set; }
        public virtual DbSet<FactOrderItem> FactOrderItems { get; set; }
        public virtual DbSet<FactOrderItemRefund> FactOrderItemRefunds { get; set; }
        public virtual DbSet<FactOrderRefund> FactOrderRefunds { get; set; }
        public virtual DbSet<FactOrderShipping> FactOrderShippings { get; set; }
        public virtual DbSet<Global> Globals { get; set; }
        public virtual DbSet<PackageExecution> PackageExecutions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<QueueOrder> QueueOrders { get; set; }
        public virtual DbSet<SprocExecution> SprocExecutions { get; set; }
        public virtual DbSet<SprocExecutionError> SprocExecutionErrors { get; set; }
        public virtual DbSet<StoreOrder> StoreOrders { get; set; }
        public virtual DbSet<StoreOrder1> StoreOrders1 { get; set; }
        public virtual DbSet<StoreOrderBundle> StoreOrderBundles { get; set; }
        public virtual DbSet<StoreOrderItem> StoreOrderItems { get; set; }
        public virtual DbSet<StoreOrderItemFulfillment> StoreOrderItemFulfillments { get; set; }
        public virtual DbSet<StoreOrderItemRefund> StoreOrderItemRefunds { get; set; }
        public virtual DbSet<StoreOrderMetafield> StoreOrderMetafields { get; set; }
        public virtual DbSet<StoreOrderRefund> StoreOrderRefunds { get; set; }
        public virtual DbSet<StoreOrderShipping> StoreOrderShippings { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }
        public virtual DbSet<VwDimDate> VwDimDates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=bis-dev-sql;Database=Shopify;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DimCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyKey);

                entity.ToTable("DimCurrency", "dw");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimDate>(entity =>
            {
                entity.HasKey(e => e.DateKey);

                entity.ToTable("DimDate", "dw");

                entity.HasIndex(e => e.FullDate, "AK_DimDate")
                    .IsUnique();

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.DateEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfMonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeekEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullDate).HasColumnType("date");

                entity.Property(e => e.HalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HalfYearOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfMonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrimesterOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeekEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeekOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weekday)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimFinancialStatus>(entity =>
            {
                entity.HasKey(e => e.FinancialStatusKey);

                entity.ToTable("DimFinancialStatus", "dw");

                entity.Property(e => e.FinancialStatus)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimFulFillmentStatus>(entity =>
            {
                entity.HasKey(e => e.FulFillmentStatusKey);

                entity.ToTable("DimFulFillmentStatus", "dw");

                entity.Property(e => e.FulFillmentStatus)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimProductVariant>(entity =>
            {
                entity.HasKey(e => e.ProductVariantKey);

                entity.ToTable("DimProductVariant", "dw");

                entity.Property(e => e.ProductVariantKey).ValueGeneratedNever();

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FulfillmentService)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SKU");

                entity.Property(e => e.VariantTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimStore>(entity =>
            {
                entity.HasKey(e => e.StoreKey);

                entity.ToTable("DimStore", "dw");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimTitle>(entity =>
            {
                entity.HasKey(e => e.TitleKey);

                entity.ToTable("DimTitle", "dw");

                entity.Property(e => e.TitleName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DimVendor>(entity =>
            {
                entity.HasKey(e => e.VendorKey);

                entity.ToTable("DimVendor", "dw");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EmailNotification>(entity =>
            {
                entity.ToTable("EmailNotification", "Core");

                entity.HasIndex(e => e.EmailSubject, "AK_EmailNotification")
                    .IsUnique();

                entity.Property(e => e.EmailNotificationId).HasColumnName("EmailNotificationID");

                entity.Property(e => e.EmailRecipient)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpsertedDate).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Exception>(entity =>
            {
                entity.ToTable("Exception");

                entity.Property(e => e.ExceptionId).HasColumnName("ExceptionID");

                entity.Property(e => e.BusinessKey)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BusinessKeyValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FactOrder>(entity =>
            {
                entity.HasKey(e => e.OrderKey);

                entity.ToTable("FactOrder", "dw");

                entity.Property(e => e.OrderKey).ValueGeneratedNever();

                entity.Property(e => e.OrderAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderDiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrderShippingAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderTaxAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderTotalAmount).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.CurrencyKeyNavigation)
                    .WithMany(p => p.FactOrders)
                    .HasForeignKey(d => d.CurrencyKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrder_DimCurrency");

                entity.HasOne(d => d.FinancialStatusKeyNavigation)
                    .WithMany(p => p.FactOrders)
                    .HasForeignKey(d => d.FinancialStatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrder_DimFinancialStatus");

                entity.HasOne(d => d.FulFillmentStatusKeyNavigation)
                    .WithMany(p => p.FactOrders)
                    .HasForeignKey(d => d.FulFillmentStatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrder_DimFulFillmentStatus");

                entity.HasOne(d => d.OrderDateKeyNavigation)
                    .WithMany(p => p.FactOrders)
                    .HasForeignKey(d => d.OrderDateKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrder_DimDate");

                entity.HasOne(d => d.StoreKeyNavigation)
                    .WithMany(p => p.FactOrders)
                    .HasForeignKey(d => d.StoreKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrder_DimStore");
            });

            modelBuilder.Entity<FactOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemKey);

                entity.ToTable("FactOrderItem", "dw");

                entity.Property(e => e.OrderItemKey).ValueGeneratedNever();

                entity.Property(e => e.OrderItemAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderItemDiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderItemTaxAmount).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.FulFillmentStatusKeyNavigation)
                    .WithMany(p => p.FactOrderItems)
                    .HasForeignKey(d => d.FulFillmentStatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItem_DimFulFillmentStatus");

                entity.HasOne(d => d.OrderKeyNavigation)
                    .WithMany(p => p.FactOrderItems)
                    .HasForeignKey(d => d.OrderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItem_FactOrder");

                entity.HasOne(d => d.ProductVariantKeyNavigation)
                    .WithMany(p => p.FactOrderItems)
                    .HasForeignKey(d => d.ProductVariantKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItem_DimProductVariant");

                entity.HasOne(d => d.VendorKeyNavigation)
                    .WithMany(p => p.FactOrderItems)
                    .HasForeignKey(d => d.VendorKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItem_DimVendor");
            });

            modelBuilder.Entity<FactOrderItemRefund>(entity =>
            {
                entity.HasKey(e => e.OrderItemRefundKey);

                entity.ToTable("FactOrderItemRefund", "dw");

                entity.Property(e => e.OrderItemRefundKey).ValueGeneratedNever();

                entity.Property(e => e.OrderItemRefundAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderItemRefundTaxAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RefundReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RestockType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.OrderItemKeyNavigation)
                    .WithMany(p => p.FactOrderItemRefunds)
                    .HasForeignKey(d => d.OrderItemKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItemRefund_FactOrderItem");

                entity.HasOne(d => d.RefundDateKeyNavigation)
                    .WithMany(p => p.FactOrderItemRefunds)
                    .HasForeignKey(d => d.RefundDateKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderItemRefund_DimDate");
            });

            modelBuilder.Entity<FactOrderRefund>(entity =>
            {
                entity.HasKey(e => e.OrderRefundKey);

                entity.ToTable("FactOrderRefund", "dw");

                entity.Property(e => e.OrderRefundKey).ValueGeneratedNever();

                entity.Property(e => e.RefundAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RefundLineReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RefundReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RefundTaxAmount).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.OrderKeyNavigation)
                    .WithMany(p => p.FactOrderRefunds)
                    .HasForeignKey(d => d.OrderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderRefund_FactOrder");

                entity.HasOne(d => d.RefundDateKeyNavigation)
                    .WithMany(p => p.FactOrderRefunds)
                    .HasForeignKey(d => d.RefundDateKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderRefund_DimDate");
            });

            modelBuilder.Entity<FactOrderShipping>(entity =>
            {
                entity.HasKey(e => e.ShippingKey);

                entity.ToTable("FactOrderShipping", "dw");

                entity.Property(e => e.ShippingKey).ValueGeneratedNever();

                entity.Property(e => e.Carrier)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ShippingDiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ShippingTaxAmount).HasColumnType("numeric(38, 6)");

                entity.HasOne(d => d.OrderKeyNavigation)
                    .WithMany(p => p.FactOrderShippings)
                    .HasForeignKey(d => d.OrderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactOrderShipping_FactOrder");
            });

            modelBuilder.Entity<Global>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Globals", "Core");
            });

            modelBuilder.Entity<PackageExecution>(entity =>
            {
                entity.ToTable("PackageExecution", "Core");

                entity.Property(e => e.PackageExecutionId).HasColumnName("PackageExecutionID");

                entity.Property(e => e.ComponentMessage).IsRequired();

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.ProductJson)
                    .IsRequired()
                    .HasColumnName("ProductJSON");

                entity.Property(e => e.ProductType).HasMaxLength(255);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasPrecision(0);

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProductVariant>(entity =>
            {
                entity.HasKey(e => e.VariantId);

                entity.ToTable("ProductVariant");

                entity.Property(e => e.VariantId)
                    .ValueGeneratedNever()
                    .HasColumnName("VariantID");

                entity.Property(e => e.Barcode).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.FulfillmentService)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Sku)
                    .HasMaxLength(255)
                    .HasColumnName("SKU");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasPrecision(0);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariant_Product");
            });

            modelBuilder.Entity<QueueOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QueueOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderJson)
                    .IsRequired()
                    .HasColumnName("OrderJSON");

                entity.Property(e => e.QueueId).HasColumnName("QueueID");
            });

            modelBuilder.Entity<SprocExecution>(entity =>
            {
                entity.HasKey(e => e.ExecutionId);

                entity.ToTable("SprocExecution", "Core");

                entity.Property(e => e.ExecutionId).HasColumnName("ExecutionID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExecutionBatchId).HasColumnName("ExecutionBatchID");

                entity.Property(e => e.SprocName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SprocParameter)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.TimeElapsedMillisecond).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<SprocExecutionError>(entity =>
            {
                entity.HasKey(e => e.ExecutionErrorId);

                entity.ToTable("SprocExecutionError", "Core");

                entity.Property(e => e.ExecutionErrorId).HasColumnName("ExecutionErrorID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ExecutionBatchId).HasColumnName("ExecutionBatchID");

                entity.Property(e => e.SprocName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SprocParameter)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<StoreOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("StoreOrder");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.CancelledDate).HasPrecision(0);

                entity.Property(e => e.CancelledReason).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.FinancialStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FulfillmentStatus).HasMaxLength(255);

                entity.Property(e => e.LineItemAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderJson)
                    .IsRequired()
                    .HasColumnName("OrderJSON");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SaleChannel)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SubtotalAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.UpdatedDate).HasPrecision(0);
            });

            modelBuilder.Entity<StoreOrder1>(entity =>
            {
                entity.HasKey(e => e.StoreOrderId);

                entity.ToTable("StoreOrder", "Stage");

                entity.Property(e => e.StoreOrderId).HasColumnName("StoreOrderID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.OrderJson)
                    .IsRequired()
                    .HasColumnName("OrderJSON");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StoreOrderBundle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoreOrderBundle");

                entity.HasIndex(e => new { e.OrderId, e.BundleVariantId }, "IX_StoreOrderBundle__OrderID__BundleVariantID");

                entity.Property(e => e.BundleJson)
                    .IsRequired()
                    .HasColumnName("BundleJSON");

                entity.Property(e => e.BundleVariantId).HasColumnName("BundleVariantID");

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Sku)
                    .HasMaxLength(255)
                    .HasColumnName("SKU");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasPrecision(0);

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.HasOne(d => d.BundleVariant)
                    .WithMany()
                    .HasForeignKey(d => d.BundleVariantId);

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_StoreOrderBundle_StoreOrder");

                entity.HasOne(d => d.Variant)
                    .WithMany()
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StoreOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId);

                entity.ToTable("StoreOrderItem");

                entity.Property(e => e.OrderItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.FulfillmentStatus).HasMaxLength(255);

                entity.Property(e => e.LineItemAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.StoreOrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_StoreOrderItem_StoreOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StoreOrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_StoreOrderItem_Product");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.StoreOrderItems)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_StoreOrderItem_ProductVariant");
            });

            modelBuilder.Entity<StoreOrderItemFulfillment>(entity =>
            {
                entity.HasKey(e => new { e.FulfillmentId, e.OrderItemId });

                entity.ToTable("StoreOrderItemFulfillment");

                entity.Property(e => e.FulfillmentId).HasColumnName("FulfillmentID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.FulfillmentItemStatus).HasMaxLength(255);

                entity.Property(e => e.FulfillmentService)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FulfillmentStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCompany).HasMaxLength(255);

                entity.Property(e => e.ShippingSatus).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasPrecision(0);

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.StoreOrderItemFulfillments)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK_StoreOrderItemFulfillment_StoreOrderItem");
            });

            modelBuilder.Entity<StoreOrderItemRefund>(entity =>
            {
                entity.HasKey(e => e.OrderItemAdjustmentId);

                entity.ToTable("StoreOrderItemRefund");

                entity.HasIndex(e => e.OrderItemId, "IX_StoreOrderItemRefund__OrderItemID");

                entity.Property(e => e.OrderItemAdjustmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderItemAdjustmentID");

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.RefundAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RefundNote).HasMaxLength(255);

                entity.Property(e => e.RestockType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.StoreOrderItemRefunds)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK_StoreOrderItemRefund_StoreOrderItem");
            });

            modelBuilder.Entity<StoreOrderMetafield>(entity =>
            {
                entity.ToTable("StoreOrderMetafield", "Stage");

                entity.Property(e => e.StoreOrderMetafieldId).HasColumnName("StoreOrderMetafieldID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.OrderMetafieldJson)
                    .IsRequired()
                    .HasColumnName("OrderMetafieldJSON");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StoreOrderRefund>(entity =>
            {
                entity.HasKey(e => e.OrderAdjustmentId);

                entity.ToTable("StoreOrderRefund");

                entity.Property(e => e.OrderAdjustmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderAdjustmentID");

                entity.Property(e => e.CreatedDate).HasPrecision(0);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RefundAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RefundNote).HasMaxLength(255);

                entity.Property(e => e.RefundReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.StoreOrderRefunds)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Refund_StoreOrder_StoreOrder");
            });

            modelBuilder.Entity<StoreOrderShipping>(entity =>
            {
                entity.HasKey(e => e.ShippingId);

                entity.ToTable("StoreOrderShipping");

                entity.Property(e => e.ShippingId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShippingID");

                entity.Property(e => e.Carrier)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShippingAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(38, 6)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.StoreOrderShippings)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_StoreOrderShipping_StoreOrder");
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.ToTable("StoreProduct", "Stage");

                entity.Property(e => e.StoreProductId).HasColumnName("StoreProductID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ProductJson)
                    .IsRequired()
                    .HasColumnName("ProductJSON");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwDimDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DimDate", "dw");

                entity.Property(e => e.DateEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfMonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeekEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullDate).HasColumnType("date");

                entity.Property(e => e.HalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HalfYearOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuarterOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfHalfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfMonthEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfQuarterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfTrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDaysOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrimesterEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrimesterOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeekEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeekOfYearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weekday)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YearEnglishName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
