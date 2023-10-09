using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class EmployeesRepository : RepositoryBase<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Employee GetEmployeeByUserID(int EmployeeUserID)
        {
            var Employee = this.DbContext.Employees.Where(c => c.UserID == EmployeeUserID).FirstOrDefault();

            return Employee;
        }
        public Employee GetEmployeeByPositionID(int PositionID)
        {
            var Employee = this.DbContext.Employees.Where(c => c.PositionID == PositionID).FirstOrDefault();

            return Employee;
        }
        public Employee GetEmployeeByFirstName(string EmployeeFirstName)
        {
            var Employee = this.DbContext.Employees.Where(c => c.FirstName == EmployeeFirstName).FirstOrDefault();
            return Employee;
        }
        public Employee GetEmployeeByLastName(string EmployeeLastName)
        {
            var Employee = this.DbContext.Employees.Where(c => c.LastName == EmployeeLastName).FirstOrDefault();
            return Employee;
        }
        public Employee GetEmployeeByPhoneNumber(string EmployeePhoneNumber)
        {
            var Employee = this.DbContext.Employees.Where(c => c.PhoneNumber == EmployeePhoneNumber).FirstOrDefault();
            return Employee;
        }
        public Employee GetEmployeeByEmail(string EmployeeEmail)
        {
            var Employee = this.DbContext.Employees.Where(c => c.Email == EmployeeEmail).FirstOrDefault();
            return Employee;
        }

        public override void Update(Employee entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IEmployeesRepository : IRepository<Employee>
    {
        Employee GetEmployeeByUserID(int EmployeeUserID);
        Employee GetEmployeeByPositionID(int PositionID);
        Employee GetEmployeeByLastName(string EmployeeLastName);
        Employee GetEmployeeByFirstName(string EmployeeFirstName);
        Employee GetEmployeeByPhoneNumber(string EmployeePhoneNumber);
        Employee GetEmployeeByEmail(string EmployeeEmail);

    }
}
