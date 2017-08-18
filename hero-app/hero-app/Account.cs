using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    public abstract class Account
    {
        #region Username
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        #endregion Username
        #region Password
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        #endregion Password
        #region StartDate
        private DateTime _StartDate;
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        #endregion

    }
    public class Teacher : Account
    {
        public byte Rating()
        {
            byte rating = new Byte();
            return rating;
        }
    }
    public class Student : Account
    {

    }
}
