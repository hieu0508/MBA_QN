using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class KHO
    {
        [Key]
        public int id  { get; set; }
        [StringLength(50)] public string MaTaiSan { get; set; }
        [ForeignKey("DonViQuanLy")]
        [StringLength(50)] public string DonViQuanLy { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)] public string ThuKho {  get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)] public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
