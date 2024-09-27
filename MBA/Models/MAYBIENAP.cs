using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class MAYBIENAP
    {
        [StringLength(50)] public string SoHieu { get; set; }
        [StringLength(50)] public string MaTaiSan { get; set; }
        [StringLength(50)] public string? Seria { get; set; }
        [ForeignKey("CapDienAp")]
        [Column(Order = 1)]
        public int CapDienAp { get; set; }

        public double CongSuat { get; set; }

        [StringLength(200)] public string TenTaiSan { get; set; }
        [StringLength(500)] public string? NguonGoc { get; set; }

        public DateTime? NgayPhatSinhTaiSan { get; set; }
        [ForeignKey("DONVICUNGCAPSUACHUA")]
        [Column(Order =1)]
        public int NhaSanXuat { get; set; }
        public int? NoiSanXuat { get; set; }

        [ForeignKey("MaNhanVien")] [StringLength(50)] public string? NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        [ForeignKey("TrangThaiTaiSan")] public int TrangThaiTaiSan { get; set; }
        [ForeignKey("TrangThaiKho")] public int TrangThaiKho { get; set; }
        [ForeignKey("DonViBanGiao")] public string DonViBanGiao { get; set; }
        [ForeignKey("DonViDangQuanLy")] public string DonViDangQuanLy { get; set; }

        public DONVICUNGCAPSUACHUA DONVICUNGCAPSUACHUA { get; set; }

    }
}
