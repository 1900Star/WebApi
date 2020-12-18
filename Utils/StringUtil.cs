using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Utils
{
    public class StringUtil
    {
        //得到一个数据库连接字符串 
        public static string GetConnectString()
        {

            return "data source=211.162.119.217,30000;initial catalog=DB_Light_LH;user id=serverAMDZ;pwd=CSDN1shit*";
        }
    }
}
