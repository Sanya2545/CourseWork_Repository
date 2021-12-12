
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BLL
{
    public class Employee
    {
        public Employee(int id = 0, string login = "", string password = "", string email = "")
        {

        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}