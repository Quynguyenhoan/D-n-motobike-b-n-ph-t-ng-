using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_62131673.Models.EF_62131673
{
    [Table("ThongKe_62131673")]
    public class ThongKe_62131673
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ThoiGian { get; set; }
        public long SoTruyCap { get; set; }
    }
}