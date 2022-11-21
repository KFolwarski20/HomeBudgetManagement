using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Konrad_App
{
    [Serializable]
    public class LoginData
    {
        string login;
        string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public LoginData() { }
        public LoginData(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public override string ToString()
        {
            return $"{login} {password}";
        }
    }
    [Serializable]
    public class UserList
    {
        public List<LoginData> list_of_users;
        public UserList()
        {
            list_of_users = new List<LoginData>();
        }
        public void AddUser(LoginData ld)
        {
            list_of_users.Add(ld);
        }
        public List<LoginData> DeleteUser(LoginData ld)
        {
            foreach (LoginData user in list_of_users)
            {
                if (user.Login == ld.Login && user.Password == ld.Password)
                {
                    list_of_users.Remove(user);
                }
            }
            return list_of_users;
        }
        public bool CheckStatus(LoginData ld)
        {
            bool check = false;
            foreach (LoginData user in list_of_users)
            {
                if (user.Login == ld.Login && user.Password == ld.Password)
                {
                    check = true;
                }
            }
            if (!(check is true))
            { return false; }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static void SaveXML(string filename, UserList z)
        {
            XmlSerializer xs = new XmlSerializer(typeof(UserList));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xs.Serialize(fs, z);
            }
        }
        public static UserList ReadXML(string filename)
        {
            if (!File.Exists(filename)) { return null; }
            XmlSerializer xs = new XmlSerializer(typeof(UserList));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                return xs.Deserialize(fs) as UserList;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}