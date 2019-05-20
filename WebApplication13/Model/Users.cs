using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Users
    {

        int U_Id;
        string Email_Id;
        string Passwrd;
        string Roles;
        string Names;
        string Phoneno;
        string Addres;



        public Users()
        {

        }
        public Users(int u_Id, string email_Id, string passwrd, string roles, string names, string phoneno, string addres)
        {
            U_Id = u_Id;
            Email_Id = email_Id;
            Passwrd = passwrd;
            Roles = roles;
            Names = names;
            Phoneno = phoneno;
            Addres = addres;
        }

        public int U_Id1 { get { return U_Id; } set { U_Id = value; } }
        public string Email_Id1 { get { return Email_Id; } set { Email_Id = value; } }
        public string Passwrd1
        {
            get { return Passwrd; }
            set { Passwrd = value; }
        }
        public string Roles1
        {
            get { return Roles; }
            set { Roles = value; }
        }
        public string Names1
        {
            get { return Names; }
            set { Names = value; }
        }
        public string Phoneno1
        {
            get { return Phoneno; }
            set { Phoneno = value; }
        }
        public string Addres1 { get { return Addres; } set { Addres = value; } }
    }
}