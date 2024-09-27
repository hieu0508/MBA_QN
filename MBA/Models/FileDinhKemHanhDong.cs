using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class FileDinhKemHanhDong
    {
        [Key]
        [Column(Order =1)]
        public int ID { get; set; }
        [ForeignKey("HOSODINHKEM")]
        [MaxLength(50)]
        public int Hsld { get; set; }
        [ForeignKey("QUANLYDANHSACHBIENAPTHEOHANHDONG")]
        [Column(Order = 2)]
        public int ActionId { get; set; }
        //FK (Mã hành động đính kèm) 
        [StringLength(50)] public string? SoHieu { get; set; }
        [StringLength(255)] public string FileURL { get; set; }
        [StringLength(100)] public string FileName { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)] public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }

        public HOSODINHKEM HOSODINHKEM { get; set; }
        public QUANLYDANHSACHBIENAPTHEOHANHDONG QUANLYDANHSACHBIENAPTHEOHANHDONG { get; set; }
    }
}
