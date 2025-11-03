using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaiisanji
{
    public enum UserType
    {
        Admin = 0,
        Doctor = 1,
        Secretary = 2
    }
    public class Session
    {
        public static int UserID { get; set; }
        public static UserType UserType { get; set; }
    }
}
