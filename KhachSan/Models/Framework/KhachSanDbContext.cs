namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KhachSanDbContext : DbContext
    {
        public KhachSanDbContext()
            : base("name=KhachSanDbContext")
        {
        }

        public virtual DbSet<CHI_TIET_NHAN_PHONG> CHI_TIET_NHAN_PHONG { get; set; }
        public virtual DbSet<CHI_TIET_PHI_DICH_VU> CHI_TIET_PHI_DICH_VU { get; set; }
        public virtual DbSet<CHI_TIET_PHI_THUE_PHONG> CHI_TIET_PHI_THUE_PHONG { get; set; }
        public virtual DbSet<DANH_MUC_CHUC_NANG> DANH_MUC_CHUC_NANG { get; set; }
        public virtual DbSet<DANH_MUC_DIA_CHI> DANH_MUC_DIA_CHI { get; set; }
        public virtual DbSet<DANH_MUC_DICH_VU> DANH_MUC_DICH_VU { get; set; }
        public virtual DbSet<DANH_MUC_GIOI_TINH> DANH_MUC_GIOI_TINH { get; set; }
        public virtual DbSet<DANH_MUC_KIEU_PHONG> DANH_MUC_KIEU_PHONG { get; set; }
        public virtual DbSet<DANH_MUC_KHACH_HANG> DANH_MUC_KHACH_HANG { get; set; }
        public virtual DbSet<DANH_MUC_LOAI_GIAY_TO> DANH_MUC_LOAI_GIAY_TO { get; set; }
        public virtual DbSet<DANH_MUC_LOAI_PHONG> DANH_MUC_LOAI_PHONG { get; set; }
        public virtual DbSet<DANH_MUC_LOAI_TIEN> DANH_MUC_LOAI_TIEN { get; set; }
        public virtual DbSet<DANH_MUC_NGUOI_DUNG> DANH_MUC_NGUOI_DUNG { get; set; }
        public virtual DbSet<DANH_MUC_PHONG> DANH_MUC_PHONG { get; set; }
        public virtual DbSet<DANH_MUC_TIEN_NGHI> DANH_MUC_TIEN_NGHI { get; set; }
        public virtual DbSet<PHAN_QUYEN_NGUOI_DUNG> PHAN_QUYEN_NGUOI_DUNG { get; set; }
        public virtual DbSet<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }
        public virtual DbSet<PHIEU_NHAN_PHONG> PHIEU_NHAN_PHONG { get; set; }
        public virtual DbSet<PHIEU_THANH_TOAN> PHIEU_THANH_TOAN { get; set; }
        public virtual DbSet<GIOITHIEU> GIOITHIEU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANH_MUC_CHUC_NANG>()
                .HasMany(e => e.PHAN_QUYEN_NGUOI_DUNG)
                .WithRequired(e => e.DANH_MUC_CHUC_NANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_DICH_VU>()
                .HasMany(e => e.CHI_TIET_PHI_DICH_VU)
                .WithRequired(e => e.DANH_MUC_DICH_VU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_KIEU_PHONG>()
                .HasMany(e => e.DANH_MUC_PHONG)
                .WithOptional(e => e.DANH_MUC_KIEU_PHONG)
                .HasForeignKey(e => e.KIEUPHONG);

            modelBuilder.Entity<DANH_MUC_LOAI_GIAY_TO>()
                .HasMany(e => e.DANH_MUC_KHACH_HANG)
                .WithOptional(e => e.DANH_MUC_LOAI_GIAY_TO)
                .HasForeignKey(e => e.LOAIGIAYTO);

            modelBuilder.Entity<DANH_MUC_LOAI_PHONG>()
                .HasMany(e => e.DANH_MUC_PHONG)
                .WithOptional(e => e.DANH_MUC_LOAI_PHONG)
                .HasForeignKey(e => e.LOAIPHONG);

            modelBuilder.Entity<DANH_MUC_LOAI_PHONG>()
                .HasMany(e => e.PHIEU_DAT_PHONG)
                .WithOptional(e => e.DANH_MUC_LOAI_PHONG)
                .HasForeignKey(e => e.LOAIPHONG);

            modelBuilder.Entity<DANH_MUC_LOAI_TIEN>()
                .HasMany(e => e.DANH_MUC_DICH_VU)
                .WithOptional(e => e.DANH_MUC_LOAI_TIEN)
                .HasForeignKey(e => e.LOAITIEN);

            modelBuilder.Entity<DANH_MUC_LOAI_TIEN>()
                .HasMany(e => e.DANH_MUC_PHONG)
                .WithOptional(e => e.DANH_MUC_LOAI_TIEN)
                .HasForeignKey(e => e.LOAITIEN);

            modelBuilder.Entity<DANH_MUC_LOAI_TIEN>()
                .HasMany(e => e.PHIEU_THANH_TOAN)
                .WithOptional(e => e.DANH_MUC_LOAI_TIEN)
                .HasForeignKey(e => e.LOAITIEN);

            modelBuilder.Entity<DANH_MUC_NGUOI_DUNG>()
                .Property(e => e.NHOMQUYEN)
                .IsFixedLength();

            modelBuilder.Entity<DANH_MUC_NGUOI_DUNG>()
                .HasMany(e => e.PHAN_QUYEN_NGUOI_DUNG)
                .WithRequired(e => e.DANH_MUC_NGUOI_DUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_PHONG>()
                .HasMany(e => e.CHI_TIET_NHAN_PHONG)
                .WithRequired(e => e.DANH_MUC_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_PHONG>()
                .HasMany(e => e.CHI_TIET_PHI_DICH_VU)
                .WithRequired(e => e.DANH_MUC_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_PHONG>()
                .HasMany(e => e.CHI_TIET_PHI_THUE_PHONG)
                .WithRequired(e => e.DANH_MUC_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_PHONG>()
                .HasMany(e => e.DANH_MUC_TIEN_NGHI)
                .WithMany(e => e.DANH_MUC_PHONG)
                .Map(m => m.ToTable("TIEN_NGHI_PHONG").MapLeftKey("MASOPHONG").MapRightKey("MATIENNGHI"));

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .HasMany(e => e.PHIEU_NHAN_PHONG)
                .WithOptional(e => e.PHIEU_DAT_PHONG)
                .HasForeignKey(e => e.PHIEUDATPHONG);

            modelBuilder.Entity<PHIEU_NHAN_PHONG>()
                .HasMany(e => e.CHI_TIET_NHAN_PHONG)
                .WithRequired(e => e.PHIEU_NHAN_PHONG)
                .HasForeignKey(e => e.PHIEUNHANPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_NHAN_PHONG>()
                .HasMany(e => e.PHIEU_THANH_TOAN)
                .WithOptional(e => e.PHIEU_NHAN_PHONG)
                .HasForeignKey(e => e.PHIEUNHANPHONG);

            modelBuilder.Entity<PHIEU_THANH_TOAN>()
                .HasMany(e => e.CHI_TIET_PHI_DICH_VU)
                .WithRequired(e => e.PHIEU_THANH_TOAN)
                .HasForeignKey(e => e.PHIEUTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_THANH_TOAN>()
                .HasMany(e => e.CHI_TIET_PHI_THUE_PHONG)
                .WithRequired(e => e.PHIEU_THANH_TOAN)
                .HasForeignKey(e => e.PHIEUTHANHTOAN)
                .WillCascadeOnDelete(false);
        }
    }
}
