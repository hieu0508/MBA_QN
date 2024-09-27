using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class TrangThaiTaiSan
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]public string TenTrangThai { get; set; }
        [ForeignKey("ThuTuHienTHi")]
        public int ThuTuHienTHi { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }   
    }
}
