using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class DONVICUNGCAPSUACHUA
    {
        [Key] [Column(Order =1)] public int ID { get; set; }
        [StringLength(50)]
        public string TenDonVi { get; set; }

        public bool LaSanXuat { get; set; }

        public bool LaCungCap {  get; set; }

        public bool LaSuaChua { get; set; }
        [ForeignKey("ThuTuHienTHi")]
        public int ThuTuHienTHi { get; set; }

        public int NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
