using aspMVC_lab1.Models;
using aspMVC_lab1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aspMVC_lab1.Managers
{
    public class EmployeeManager
    {
        ModelContext ctx = new ModelContext();
        public DbSet<Employee> Set { get; set; }
        public EmployeeManager()
        {
            ctx = new ModelContext();
            Set = ctx.Set<Employee>();
        }
        public Employee Add(Employee e)
        {
            Employee added = Set.Add(e);
            int rowsAffected = ctx.SaveChanges();
            if (rowsAffected > 0) {
                return added;
            }
            return null;
        }
        public IQueryable<Employee> GetAll() {
            return Set;
        }
    }
}