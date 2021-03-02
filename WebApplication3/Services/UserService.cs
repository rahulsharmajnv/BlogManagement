using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Services
{
    public class UserService
    {
        internal User GetData(Login login)
        {
            DataTable dt;
            string query = $"Select * from dbo.[User] where username='{login.UserName}' and password='{login.Password}'";
            User user = new User();
            dt = DataReader.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                   user.Email= row.Field<string>("Email");
                   user.UserName=row.Field<string>("Password");

                }
            }
            return user;
        }
    }
}
