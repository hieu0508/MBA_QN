using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class QUANLYHANHDONGVOIMAYBIENAP
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
        [StringLength(500)]
        public string TieuDe {  get; set; }
        [MaxLength(50)]
        public int Type { get; set; }
        [ForeignKey("DONVICUNGCAPSUACHUA")]
        [Column(Order =1)]
        public string DonViTao { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
        [ForeignKey("DONVICUNGCAPSUACHUA")]
        [Column(Order = 1)]
        public string DonViXuLy {  get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public string? NguoiXuLy { get; set; }
        public DateTime? NgayXuLy { get; set; }
        public int TrangThaiXuLy { get; set; }
        public int? KhoXuLy { get; set; }
        public int? NoiSuaChuaThiNgiem {  get; set; }
        [StringLength(50)]
        public string? SoQDXuLy { get; set; }
        public DateTime? NgayQDXuLy { get; set; }
        [StringLength(1000)]
        public string? GhiChu {  get; set; }

        public DONVICUNGCAPSUACHUA DONVICUNGCAPSUACHUA { get; set; }

    }
}
