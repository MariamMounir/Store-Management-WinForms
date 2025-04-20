using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Layer1_connection;
using layer2_business.Entities;
using layer2_business.EntityList;


namespace layer2_business.EntityManger
{
    public class UsersManger
    {
        static DBManger storeDB = new DBManger();
        //hash pass
        private static string HashPassword(string password)
        { 
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();

            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
           
        //user creation (admin or user)==>user sign up
        public static int SignUp(string username, string password,string email,bool isAdmin)
        {
            try
            {
                //check that email in uniqe
                #region email check
                Dictionary<string, object> checkDic = new Dictionary<string, object> { { "p1", email } };
                DataTable dt = storeDB.ExecuteDataTable("SELECT * FROM Users WHERE Email=@p1", checkDic);
                if (dt.Rows.Count > 0)
                {
                    return -2;
                }
                #endregion

                string hashedPass = HashPassword(password);
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("p1", username);
                dic.Add("p2", hashedPass);
                dic.Add("p3", email);
                dic.Add("p4", isAdmin);
                dic.Add("p5", false);

                return storeDB.ExecuteNonQuery("insert into Users (Username, PasswordHash, Email, IsAdmin, IsActive) VALUES (@p1, @p2, @p3, @p4, @p5) ", dic);
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }
        //user activation 
        public static int ActivateUser(int userId ,bool isActive)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("p1", userId);
                dic.Add("p2",isActive);
                return storeDB.ExecuteNonQuery("update Users set IsActive=@p2 where UserId = @p1", dic);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }
        //get user in login case 
        public static Users Login(string email,string password)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("p1", email);

                DataTable dt = storeDB.ExecuteDataTable("select * from Users where Email=@p1", dic);
                if (dt.Rows.Count == 0) return null;
                Users user = FromDataRowToUser(dt.Rows[0]);

                //verfiy pass
                string hashedInputPass =HashPassword(password);
                if (hashedInputPass != dt.Rows[0]["PasswordHash"].ToString()) return null;
                //verify is active
                if (!user.IsActive) return null;

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        //get all user
        public static UsersList GetAllUsers()
        {
            try
            {
                DataTable dt = storeDB.ExecuteDataTable("select * from Users");
                var res =FromDataTableToUserList(dt);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new UsersList();
            }
        }
        internal static UsersList FromDataTableToUserList(DataTable dt)
        {
            UsersList userList = new UsersList();
            foreach (DataRow dr in dt.Rows)
            {
                Users user = FromDataRowToUser(dr);
                userList.Add(user);
            }
            return userList;
        }
        internal static Users FromDataRowToUser(DataRow dr)
        {
            Users user = new Users();

            if (int.TryParse(dr["UserId"]?.ToString() ?? "-1", out int userId))
                user.UserId = userId;

            user.Username = dr["Username"]?.ToString() ?? "Unknown";
            user.Email = dr["Email"]?.ToString() ?? "No Email";

            if (bool.TryParse(dr["IsAdmin"]?.ToString(), out bool isAdmin))
                user.IsAdmin = isAdmin;

            if (bool.TryParse(dr["IsActive"]?.ToString(), out bool isActive))
                user.IsActive = isActive;

            return user;
        }

    }
}
