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
            return Set.Add(e);
        }
        public IQueryable<Employee> GetAll() {
            return Set;
        }
        public Employee GetById(int id) {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }
        public bool Delete(Employee entity)
        {
            Set.Remove(entity);
            return SaveChanges() > 0;
        }

        public bool Update(Employee entity)
        {
            Set.Attach(entity);
            ctx.Entry(entity).State = EntityState.Modified;
            return SaveChanges() > 0;
        }
        public int SaveChanges() {
            return ctx.SaveChanges();
        }
    }
}