using MBA.Models;
using Microsoft.EntityFrameworkCore;

namespace MBA.Data
{
    public class QLMBA:DbContext
    {
        public DbSet<TrangThaiTaiSan> trangThaiTaiSans { get; set; }
        public DbSet<TrangThaiKho> trangThaiKhos { get; set; }
        public DbSet<CAPDIENAP> cAPDIENAPs { get; set; }
        public DbSet<DONVICUNGCAPSUACHUA> dONVICUNGCAPSUACHUAs { get; set; }
        public DbSet<QUOCGIASANXUAT> qUOCGIASANXUATs { get; set; }
        public DbSet<KHO> kHOs { get; set; }
        public DbSet<MAYBIENAP> mAYBIENAPs { get; set; }
        public DbSet<HOSODINHKEM> hOSODINHKEMs { get; set; }
        public DbSet<QUANLYHANHDONGVOIMAYBIENAP> qUANLYHANHDONGVOIMAYBIENAPs { get; set; }
        public DbSet<QUANLYDANHSACHBIENAPTHEOHANHDONG> qUANLYDANHSACHBIENAPTHEOHANHDONGs { get; set; }
        public DbSet<FileDinhKemHanhDong> fileDinhKemHanhDongs { get; set; }

    }
}
