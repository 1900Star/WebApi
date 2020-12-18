using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TodoApi.Utils
{

    class SqlHelper
    {
        // 将查询到的数据以Json格式返回
        public static string DataToJson(DataTable dt, int count)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("{");
            sbjson.Append("\"total\":" + count + ",\"rows\":[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            sbjson.Append("]}");
          //  Console.WriteLine(sbjson.ToString());
            string str = Regex.Unescape(sbjson.ToString());
            return str;
        }

    }
}
