using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BLL;

namespace DAL_EntityFramework_
{
    public class EmployeeManager
    {
        public void AddEmployee(string login = "", string password = "", string email = "")
        {
            Employee employee = new Employee(1, login, password, email);
            using (DBContext dB = new DBContext())
            {
                if(login != null && password != null && email != null)
                {
                    dB.Employees.Add(employee);
                    dB.SaveChanges();

                }
            }
                
        }
    }
}
