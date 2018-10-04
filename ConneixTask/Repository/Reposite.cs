using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConneixTask.IRepository;
using ConneixTask.Models;
using System.Data;

namespace ConneixTask.Repository
{
    public class Reposite : IReposite
    {
        public taskempEntities db = new taskempEntities();

        public void AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
        }
        public void UpdateEmployee(Employee emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteEmployee(Employee emp)
        {
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> ListEmp = new List<Employee>();
            ListEmp= db.Employees.ToList();
            return ListEmp;
        }
    }
}