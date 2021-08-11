using DataAccess;
using DataAccess.Repositories;
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
        public int Test { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        [Inject]
        public IEmployeeRepository _repository { get; set; }
        [Inject]
        private ApplicationDbContext _context { get; set; }
        protected override Task OnInitializedAsync()
        {
            Employees = _repository.Get().ToList();
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
            if (employee is not null)
            {
                _repository.Update(employee);
            }
           
            

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
