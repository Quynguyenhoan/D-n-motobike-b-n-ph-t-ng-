using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_62131673.Models
{
    public abstract class CommonAbstract_62131673
    {
        public static object Filter { get; internal set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
    }
}