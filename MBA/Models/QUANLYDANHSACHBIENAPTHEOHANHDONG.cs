using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class QUANLYDANHSACHBIENAPTHEOHANHDONG
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [ForeignKey("QUANLYDANHSACHBIENAPTHEOHANHDONG")]
        [Column(Order =2)]
        public int ActionId { get; set; }
        [ForeignKey("SoHieu")][StringLength(20)] public string SoHieu { get; set; }
        [ForeignKey("MaNhanVien")][StringLength(50)] public string NguoiTao { get; set; }
         public DateTime NgayTao { get; set; }
        [ForeignKey("DONVICUNGCAPSUACHUA")][Column(Order =1)][StringLength(50)] public string DonViXuLy { get; set; }
        [ForeignKey("MaNhanVien")][StringLength(50)] public string? NguoiXuLy { get; set; }
        public DateTime NgayXuLy { get; set; }
        public int TrangThaiXuLy { get; set; }
        public int TrangThaiTaiSan { get; set; }
        public int TrangThaiKho {  get; set; }
        [StringLength(50)] public string? SoQDXuLy { get; set; }
        public DateTime? NgayQDXuLy { get; set; }
        [StringLength(1000)] public string? GhiChu { get; set; }
        public DONVICUNGCAPSUACHUA DONVICUNGCAPSUACHUA { get; set; }
    }

}
