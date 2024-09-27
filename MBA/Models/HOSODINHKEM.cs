using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBA.Models
{
    public class HOSODINHKEM
    {
        [Key]
        [Column(Order =1)]
        [MaxLength(50)]
        public int ID { get; set; }
        [MaxLength(50)]
        public int Type {  get; set; }
        public bool LaChiTiet {  get; set; }

        public bool BatBuocPhaiCo {  get; set; }
        public bool BaoThieuHoSo {  get; set; }
        [StringLength(500)]
        public string TenHoSo   {  get; set; }
        public int ThuTuHienThi { get; set; }
        [ForeignKey("MaNhanVien")]
        [StringLength(50)]
        public string NguoiTao {  get; set; }
        public DateTime NgayTao { get; set; }

    }
}
