using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChum
{
    public class EmployeeList
    {
        private static Dictionary<int, Employee> employeeList = new Dictionary<int, Employee>();

        public static Dictionary<int, Employee>  Employees { get { return employeeList; }}

        public static void addEmployee(Employee employee)
        {
            employeeList.Add(employee.Id, employee);
        }

        public static Boolean checkEmployeeRegistration(int id)
        {
            Employee emp;
            return employeeList.TryGetValue(id, out emp);
        }

        public static Boolean isEmployeeAttendanceRecorded(int id) => employeeList[id].isRecorded;

        public static void recordEmployeeAttendance(int id)
        {
            employeeList[id].isRecorded = true;
        }
    }
}
