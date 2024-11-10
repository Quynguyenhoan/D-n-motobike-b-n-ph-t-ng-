using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Project_62131673.Models.Common_62131673
{
    public class ThongKeTruyCap_62131673
    {
        public static string strConnect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static ThongKeViewModel_62131673 ThongKe()
        {
            using (var connect = new SqlConnection(strConnect))
            {
                var item = connect.QueryFirstOrDefault<ThongKeViewModel_62131673>("sp_ThongKe", commandType: CommandType.StoredProcedure);
                return item;
            }
        }
    }
}