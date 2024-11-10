using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_62131673.Models.EF_62131673
{
    [Table("tb_Subscribe")]
    public class Subscribe_62131673
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public List<Subscribe_62131673> Subs { get; set; }
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public void ClearCart()
        {
            Subs.Clear();
        }

    }
}