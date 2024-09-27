using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class CAPDIENAP
    {
        [Key]
        public int Id { get; set; }
        public string CapDienAp { get; set; }
        [ForeignKey("ThuTuHienTHi")]
        public int ThuTuHienTHi { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public int NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
