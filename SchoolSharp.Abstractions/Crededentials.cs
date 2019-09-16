using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions
{
    public struct UserCrededentials
    {
        public UserCrededentials(string school, string username, string password, AccountType accountType) : this(school, username, password, ((int)accountType).ToString())
        {

        }

        public UserCrededentials(string school, string username, string password, string accountType)
        {
            school.GuardNotNull(nameof(school));
            username.GuardNotNull(nameof(username));
            password.GuardNotNull(nameof(password));
            accountType.GuardNotNull(nameof(accountType));

            this.School = school;
            this.Username = username;
            this.Password = password;
            this.AccountType = accountType;
        }
        public string School { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType{ get; set; }
    }

    public enum AccountType
    {
        Student = 1,
        Personel = 0,
        Guardian = 2
    }
}
