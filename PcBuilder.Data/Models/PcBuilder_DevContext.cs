using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PcBuilder.Data.Models
{
    public partial class PcBuilder_DevContext : DbContext
    {
        public PcBuilder_DevContext()
        {
        }

        public PcBuilder_DevContext(DbContextOptions<PcBuilder_DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CachDetails> CachDetails { get; set; }
        public virtual DbSet<Cache> Cache { get; set; }
        public virtual DbSet<CacheType> CacheType { get; set; }
        public virtual DbSet<CapabilityType> CapabilityType { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryNode> CategoryNode { get; set; }
        public virtual DbSet<ChipsetType> ChipsetType { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<ConditionType> ConditionType { get; set; }
        public virtual DbSet<Cooler> Cooler { get; set; }
        public virtual DbSet<CoolerType> CoolerType { get; set; }
        public virtual DbSet<Cooling> Cooling { get; set; }
        public virtual DbSet<Cpu> Cpu { get; set; }
        public virtual DbSet<EfficiencyRating> EfficiencyRating { get; set; }
        public virtual DbSet<ExternalPowerType> ExternalPowerType { get; set; }
        public virtual DbSet<FormFactorType> FormFactorType { get; set; }
        public virtual DbSet<FrameSyncType> FrameSyncType { get; set; }
        public virtual DbSet<HardwareType> HardwareType { get; set; }
        public virtual DbSet<Header> Header { get; set; }
        public virtual DbSet<HeaderDetails> HeaderDetails { get; set; }
        public virtual DbSet<HeaderType> HeaderType { get; set; }
        public virtual DbSet<IntegratedGraphic> IntegratedGraphic { get; set; }
        public virtual DbSet<Interface> Interface { get; set; }
        public virtual DbSet<ManufacturerType> ManufacturerType { get; set; }
        public virtual DbSet<Memory> Memory { get; set; }
        public virtual DbSet<MemorySpeed> MemorySpeed { get; set; }
        public virtual DbSet<MemoryType> MemoryType { get; set; }
        public virtual DbSet<MicroArchitectureType> MicroArchitectureType { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<MortherBoardMemory> MortherBoardMemory { get; set; }
        public virtual DbSet<MotherBoard> MotherBoard { get; set; }
        public virtual DbSet<MotherBoardMemorySpeed> MotherBoardMemorySpeed { get; set; }
        public virtual DbSet<MotherBoardPort> MotherBoardPort { get; set; }
        public virtual DbSet<MotherBoardPortDetails> MotherBoardPortDetails { get; set; }
        public virtual DbSet<MotherBoardSlot> MotherBoardSlot { get; set; }
        public virtual DbSet<MotherBoardSlotDetails> MotherBoardSlotDetails { get; set; }
        public virtual DbSet<OnBoardEthernet> OnBoardEthernet { get; set; }
        public virtual DbSet<OpticalDrive> OpticalDrive { get; set; }
        public virtual DbSet<PortType> PortType { get; set; }
        public virtual DbSet<PowerSupply> PowerSupply { get; set; }
        public virtual DbSet<PowerSupplyType> PowerSupplyType { get; set; }
        public virtual DbSet<ProductStore> ProductStore { get; set; }
        public virtual DbSet<SeriesType> SeriesType { get; set; }
        public virtual DbSet<SlotType> SlotType { get; set; }
        public virtual DbSet<SocketType> SocketType { get; set; }
        public virtual DbSet<SoldProduct> SoldProduct { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<StorageType> StorageType { get; set; }
        public virtual DbSet<VideoCard> VideoCard { get; set; }
        public virtual DbSet<VideoCardPort> VideoCardPort { get; set; }
        public virtual DbSet<VideoCardPortDetails> VideoCardPortDetails { get; set; }
        public virtual DbSet<VolumeType> VolumeType { get; set; }
        public virtual DbSet<WirelesNetworking> WirelesNetworking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=PcBuilder_Dev;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CachDetails>(entity =>
            {
                entity.ToTable("CachDetails", "PcHardware");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Cach)
                    .WithMany(p => p.CachDetails)
                    .HasForeignKey(d => d.CachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CachDetails_Cache");
            });

            modelBuilder.Entity<Cache>(entity =>
            {
                entity.ToTable("Cache", "PcHardware");

                entity.HasOne(d => d.CashType)
                    .WithMany(p => p.Cache)
                    .HasForeignKey(d => d.CashTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cache_CacheType");

                entity.HasOne(d => d.Cpu)
                    .WithMany(p => p.Cache)
                    .HasForeignKey(d => d.CpuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cache_Cpu");
            });

            modelBuilder.Entity<CacheType>(entity =>
            {
                entity.ToTable("CacheType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CapabilityType>(entity =>
            {
                entity.ToTable("CapabilityType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CategoryNode>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryNode)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryIdNode_CategoryId");
            });

            modelBuilder.Entity<ChipsetType>(entity =>
            {
                entity.ToTable("ChipsetType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.ChipsetType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .HasConstraintName("FK_ChipsetType_HardwareType1");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConditionType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Cooler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cooler", "PcHardware");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cooler_Category");

                entity.HasOne(d => d.CoolerType)
                    .WithMany()
                    .HasForeignKey(d => d.CoolerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cooler_CoolerType");

                entity.HasOne(d => d.Socket)
                    .WithMany()
                    .HasForeignKey(d => d.SocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cooler_SocketType");
            });

            modelBuilder.Entity<CoolerType>(entity =>
            {
                entity.ToTable("CoolerType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cooling>(entity =>
            {
                entity.ToTable("Cooling", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cpu>(entity =>
            {
                entity.ToTable("Cpu", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tdp).HasColumnName("TDP");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cpu_Category");

                entity.HasOne(d => d.Manufactirer)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.ManufactirerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cpu_ManufacturerType");

                entity.HasOne(d => d.Microarchitecture)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.MicroarchitectureId)
                    .HasConstraintName("FK_Cpu_MicroArchitectureType");

                entity.HasOne(d => d.Serie)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.SerieId)
                    .HasConstraintName("FK_Cpu_SeriesType");

                entity.HasOne(d => d.Socket)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.SocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cpu_SocketType");
            });

            modelBuilder.Entity<EfficiencyRating>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExternalPowerType>(entity =>
            {
                entity.ToTable("ExternalPowerType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FormFactorType>(entity =>
            {
                entity.ToTable("FormFactorType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.FormFactorType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormFactorType_HardwareType");
            });

            modelBuilder.Entity<FrameSyncType>(entity =>
            {
                entity.ToTable("FrameSyncType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HardwareType>(entity =>
            {
                entity.ToTable("HardwareType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.ToTable("Header", "PcHardware");

                entity.HasOne(d => d.HeaderType)
                    .WithMany(p => p.Header)
                    .HasForeignKey(d => d.HeaderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Header_HeaderType");

                entity.HasOne(d => d.MotherBoard)
                    .WithMany(p => p.Header)
                    .HasForeignKey(d => d.MotherBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Header_MotherBoard");
            });

            modelBuilder.Entity<HeaderDetails>(entity =>
            {
                entity.ToTable("HeaderDetails", "PcHardware");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.HeaderDetails)
                    .HasForeignKey(d => d.HeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeaderDetails_Header");
            });

            modelBuilder.Entity<HeaderType>(entity =>
            {
                entity.ToTable("HeaderType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IntegratedGraphic>(entity =>
            {
                entity.ToTable("IntegratedGraphic", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Interface>(entity =>
            {
                entity.ToTable("Interface", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.Interface)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Interface_HardwareType");
            });

            modelBuilder.Entity<ManufacturerType>(entity =>
            {
                entity.ToTable("ManufacturerType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.ManufacturerType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .HasConstraintName("FK_ManufacturerType_HardwareType");
            });

            modelBuilder.Entity<Memory>(entity =>
            {
                entity.ToTable("Memory", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Memory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Memory_Category");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Memory)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Memory_Module");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Memory)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Memory_MemoryType1");
            });

            modelBuilder.Entity<MemorySpeed>(entity =>
            {
                entity.ToTable("MemorySpeed", "PcHardware");

                entity.HasOne(d => d.MemoryType)
                    .WithMany(p => p.MemorySpeed)
                    .HasForeignKey(d => d.MemoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemorySpeed_MemoryType");
            });

            modelBuilder.Entity<MemoryType>(entity =>
            {
                entity.ToTable("MemoryType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.MemoryType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemoryType_HardwareType");
            });

            modelBuilder.Entity<MicroArchitectureType>(entity =>
            {
                entity.ToTable("MicroArchitectureType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.MicroArchitectureType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .HasConstraintName("FK_MicroArchitectureType_HardwareType");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module", "PcHardware");

                entity.HasOne(d => d.VolumeType)
                    .WithMany(p => p.Module)
                    .HasForeignKey(d => d.VolumeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Module_VolumeType");
            });

            modelBuilder.Entity<MortherBoardMemory>(entity =>
            {
                entity.ToTable("MortherBoardMemory", "PcHardware");

                entity.HasOne(d => d.MemoryType)
                    .WithMany(p => p.MortherBoardMemory)
                    .HasForeignKey(d => d.MemoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MortherBoardMemory_MemoryType");

                entity.HasOne(d => d.MotherBoard)
                    .WithMany(p => p.MortherBoardMemory)
                    .HasForeignKey(d => d.MotherBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MortherBoardMemory_MotherBoard");
            });

            modelBuilder.Entity<MotherBoard>(entity =>
            {
                entity.ToTable("MotherBoard", "PcHardware");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoard_Category");

                entity.HasOne(d => d.Chipset)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.ChipsetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoard_ChipsetType");

                entity.HasOne(d => d.OnboardEthernetNavigation)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.OnboardEthernet)
                    .HasConstraintName("FK_MotherBoard_OnBoardEthernet");

                entity.HasOne(d => d.Socket)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.SocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoard_SocketType");

                entity.HasOne(d => d.WirelesNetworkingNavigation)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.WirelesNetworking)
                    .HasConstraintName("FK_MotherBoard_WirelesNetworking");
            });

            modelBuilder.Entity<MotherBoardMemorySpeed>(entity =>
            {
                entity.ToTable("MotherBoardMemorySpeed", "PcHardware");

                entity.HasOne(d => d.MotherBoardMemory)
                    .WithMany(p => p.MotherBoardMemorySpeed)
                    .HasForeignKey(d => d.MotherBoardMemoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoardMemorySpeed_MortherBoardMemory");
            });

            modelBuilder.Entity<MotherBoardPort>(entity =>
            {
                entity.ToTable("MotherBoardPort", "PcHardware");

                entity.HasOne(d => d.MotherBoard)
                    .WithMany(p => p.MotherBoardPort)
                    .HasForeignKey(d => d.MotherBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Port_MotherBoard");

                entity.HasOne(d => d.PortType)
                    .WithMany(p => p.MotherBoardPort)
                    .HasForeignKey(d => d.PortTypeId)
                    .HasConstraintName("FK_Port_PortType1");
            });

            modelBuilder.Entity<MotherBoardPortDetails>(entity =>
            {
                entity.ToTable("MotherBoardPortDetails", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.MotherBoardPortDetails)
                    .HasForeignKey(d => d.PortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoardPortDetails_Port");
            });

            modelBuilder.Entity<MotherBoardSlot>(entity =>
            {
                entity.ToTable("MotherBoardSlot", "PcHardware");

                entity.HasOne(d => d.MotherBoard)
                    .WithMany(p => p.MotherBoardSlot)
                    .HasForeignKey(d => d.MotherBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slot_MotherBoard");

                entity.HasOne(d => d.SlotType)
                    .WithMany(p => p.MotherBoardSlot)
                    .HasForeignKey(d => d.SlotTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slot_SlotType");
            });

            modelBuilder.Entity<MotherBoardSlotDetails>(entity =>
            {
                entity.ToTable("MotherBoardSlotDetails", "PcHardware");

                entity.HasOne(d => d.MotherBoardSlot)
                    .WithMany(p => p.MotherBoardSlotDetails)
                    .HasForeignKey(d => d.MotherBoardSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoardSlotDetails_MotherBoardSlot");
            });

            modelBuilder.Entity<OnBoardEthernet>(entity =>
            {
                entity.ToTable("OnBoardEthernet", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OpticalDrive>(entity =>
            {
                entity.ToTable("OpticalDrive", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CapabilityType)
                    .WithMany(p => p.OpticalDrive)
                    .HasForeignKey(d => d.CapabilityTypeId)
                    .HasConstraintName("FK_OpticalDrive_CapabilityType");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.OpticalDrive)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpticalDrive_Category");

                entity.HasOne(d => d.FormFactorType)
                    .WithMany(p => p.OpticalDrive)
                    .HasForeignKey(d => d.FormFactorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpticalDrive_FormFactorType");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.OpticalDrive)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .HasConstraintName("FK_OpticalDrive_Interface");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.OpticalDrive)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpticalDrive_ManufacturerType");
            });

            modelBuilder.Entity<PortType>(entity =>
            {
                entity.ToTable("PortType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.PortType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortType_HardwareType");
            });

            modelBuilder.Entity<PowerSupply>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PowerSupply)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PowerSupply_Category");

                entity.HasOne(d => d.EfficiencyRating)
                    .WithMany(p => p.PowerSupply)
                    .HasForeignKey(d => d.EfficiencyRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PowerSupply_EfficiencyRating");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.PowerSupply)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PowerSupply_ManufacturerType");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PowerSupply)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PowerSupply_PowerSupplyType");
            });

            modelBuilder.Entity<PowerSupplyType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductStore>(entity =>
            {
                entity.ToTable("ProductStore", "Shop");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.HasOne(d => d.Categoey)
                    .WithMany(p => p.ProductStore)
                    .HasForeignKey(d => d.CategoeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductStore_Category");

                entity.HasOne(d => d.ConditionType)
                    .WithMany(p => p.ProductStore)
                    .HasForeignKey(d => d.ConditionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductStore_ConditionType");
            });

            modelBuilder.Entity<SeriesType>(entity =>
            {
                entity.ToTable("SeriesType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.SeriesType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .HasConstraintName("FK_SeriesType_HardwareType");
            });

            modelBuilder.Entity<SlotType>(entity =>
            {
                entity.ToTable("SlotType", "PcHardware");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.SlotType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotType_SlotType");
            });

            modelBuilder.Entity<SocketType>(entity =>
            {
                entity.ToTable("SocketType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HardwareType)
                    .WithMany(p => p.SocketType)
                    .HasForeignKey(d => d.HardwareTypeId)
                    .HasConstraintName("FK_SocketType_HardwareType");
            });

            modelBuilder.Entity<SoldProduct>(entity =>
            {
                entity.ToTable("SoldProduct", "Shop");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SellDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.ToTable("Storage", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nvme).HasColumnName("NVME");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Storage_Category");

                entity.HasOne(d => d.FormFactor)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.FormFactorId)
                    .HasConstraintName("FK_Storage_FormFactorType");

                entity.HasOne(d => d.Interface)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.InterfaceId)
                    .HasConstraintName("FK_Storage_Interface");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Storage_ManufacturerType");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Storage_StorageType");

                entity.HasOne(d => d.VolumeType)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.VolumeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Storage_VolumeType");
            });

            modelBuilder.Entity<StorageType>(entity =>
            {
                entity.ToTable("StorageType", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VideoCard>(entity =>
            {
                entity.ToTable("VideoCard", "PcHardware");

                entity.Property(e => e.Tdp).HasColumnName("TDP");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCard_Category1");

                entity.HasOne(d => d.Chipset)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.ChipsetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCard_ChipsetType");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_VideoCard_Color");

                entity.HasOne(d => d.CoolingType)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.CoolingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCard_Cooling");

                entity.HasOne(d => d.ExternalPowerType)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.ExternalPowerTypeId)
                    .HasConstraintName("FK_VideoCard_ExternalPowerType");

                entity.HasOne(d => d.FrameSyncType)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.FrameSyncTypeId)
                    .HasConstraintName("FK_VideoCard_FrameSyncType");

                entity.HasOne(d => d.Interface)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.InterfaceId)
                    .HasConstraintName("FK_VideoCard_Interface");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCard_ManufacturerType");

                entity.HasOne(d => d.VolumeType)
                    .WithMany(p => p.VideoCard)
                    .HasForeignKey(d => d.VolumeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCard_VolumeType");
            });

            modelBuilder.Entity<VideoCardPort>(entity =>
            {
                entity.ToTable("VideoCardPort", "PcHardware");

                entity.HasOne(d => d.PortType)
                    .WithMany(p => p.VideoCardPort)
                    .HasForeignKey(d => d.PortTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCardPort_PortType");

                entity.HasOne(d => d.VideoCard)
                    .WithMany(p => p.VideoCardPort)
                    .HasForeignKey(d => d.VideoCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCardPort_VideoCard");
            });

            modelBuilder.Entity<VideoCardPortDetails>(entity =>
            {
                entity.ToTable("VideoCardPortDetails", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.VideoCardPort)
                    .WithMany(p => p.VideoCardPortDetails)
                    .HasForeignKey(d => d.VideoCardPortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCardPortDetails_VideoCardPort");
            });

            modelBuilder.Entity<VolumeType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WirelesNetworking>(entity =>
            {
                entity.ToTable("WirelesNetworking", "PcHardware");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
