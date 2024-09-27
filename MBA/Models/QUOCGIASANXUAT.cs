using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class QUOCGIASANXUAT
    {
        [Key]  
        public string Id { get; set; }
        
        public string TenQuocGia { get; set; }
        [ForeignKey("ThuTuHienTHi")]
        public int ThuTuHienTHi { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
