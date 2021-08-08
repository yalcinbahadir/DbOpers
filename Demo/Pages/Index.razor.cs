using DataAccess;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace Demo.Pages
{
    public partial class Index
    {
       
        public List<Employee> Employees { get; set; } = new List<Employee>();
        [Inject]
        public ApplicationDbContext _context { get; set; }
        protected override Task OnInitializedAsync()
        {
            Employees = _context.Employees.Include(e=>e.Department).ToList();
            return base.OnInitializedAsync();
        }

        private void CreateEmployee(GridCommandEventArgs args)
        {
            var employee = (Employee)args.Item;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            UpdateUI();
        }

        private void UpdateEmployee(GridCommandEventArgs args)
        {
            var employee = (Employee)args.Item;
            var empToUpdate = Employees.FirstOrDefault(e=>e.Id==employee.Id);
            empToUpdate.FirstName = employee.FirstName;
            _context.SaveChanges();
            UpdateUI();
        }
        private void DeleteEmployee(GridCommandEventArgs args)
        {
            var employee = (Employee)args.Item;
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            UpdateUI();
        }


        private void UpdateUI()
        {
            Employees = _context.Employees.Include(e => e.Department).ToList();
        }

    }
}
