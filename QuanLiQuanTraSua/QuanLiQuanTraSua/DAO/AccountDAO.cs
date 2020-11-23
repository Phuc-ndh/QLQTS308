using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool login(string username, string password)
        {
            string query = "USP_login @userName , @passWord";
            DataTable result = Dataprovider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = Dataprovider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, tenhienthi, Type )VALUES  ( N'{0}', N'{1}', {2})", name, displayName, type);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET tenhienthi = N'{1}', Type = {2} WHERE UserName = N'{0}'", name, displayName, type);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return Dataprovider.Instance.ExecuteQuery("SELECT UserName, tenhienthi, password, Type FROM dbo.Account");
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set password = N'0' where UserName = N'{0}'", name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
