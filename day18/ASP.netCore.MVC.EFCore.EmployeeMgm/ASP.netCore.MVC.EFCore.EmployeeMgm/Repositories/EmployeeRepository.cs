﻿using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public class EmployeeRepository : IEmployeeRepository

{
    #region constructor
 // add constructor injection for DbContext if needed
    private readonly AppDbContext _dbContext;
    public EmployeeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    

    #endregion
   

    #region Add to database
public async Task  AddAsync(EmployeeViewModel employee)
    {
        // define employee entity 
        var newEmployee = new Employee()
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateOfBirth = employee.DateOfBirth,
            PhoneNumber = employee.PhoneNumber,
            Gender = employee.Gender,
            Email = employee.Email,
            Address = employee.Address,
            IsActive = employee.IsActive,
            DepartmentId = employee.DepartmentId,
        };
        await _dbContext.Employees.AddAsync(newEmployee);
        await _dbContext.SaveChangesAsync();
    }


    #endregion

    #region delete

    public async Task DeleteAsync(int Id)
    {
        Employee employee = await _dbContext.Employees.FindAsync(Id);
        _dbContext.Employees.Remove(employee);
        await _dbContext.SaveChangesAsync();
    }


    #endregion

    #region get all employees

    
 public IQueryable<EmployeeViewModel> GetAllAsync()
    {
        //Lamda expression to select the properties from the Employee model
        var employees = _dbContext.Employees
            .Select(e => new EmployeeViewModel
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DateOfBirth = e.DateOfBirth,
                Gender = e.Gender,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                Address = e.Address,
                IsActive = e.IsActive,
                DepartmentId = e.DepartmentId
            });

        return employees;
    }
    #endregion

    #region get all departments from the  database
    // used for dropdown list in  add and edit
 public async Task<List<Department>> GetAllDepartmentsAsync()
    {
        return await _dbContext.Departments.ToListAsync();
    }


    #endregion

    #region get one record by id

     public async  Task<EmployeeViewModel> GetByIdAsync(int id)
    {
        var employee = await _dbContext.Employees.FindAsync(id);
        var employeeViewModel = new EmployeeViewModel
        {
            EmployeeId = employee.EmployeeId,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateOfBirth = employee.DateOfBirth,
            Gender = employee.Gender,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            Address = employee.Address,
            IsActive = employee.IsActive,
            DepartmentId = employee.DepartmentId
        };
        return employeeViewModel;
    }

    #endregion

    #region update record by id

     public  async Task UpdateAsync(EmployeeViewModel employeeUpdated)
    {
        // get one employee by id and update the properties
        var employee = await _dbContext.Employees.FindAsync(employeeUpdated.EmployeeId);
        employee.FirstName = employeeUpdated.FirstName;
        employee.LastName = employeeUpdated.LastName;
        employee.Email = employeeUpdated.Email;
        employee.DateOfBirth = employeeUpdated.DateOfBirth;
        employee.PhoneNumber = employeeUpdated.PhoneNumber;
        employee.Address = employeeUpdated.Address;
        employee.DepartmentId = employeeUpdated.DepartmentId;
        employee.IsActive = employeeUpdated.IsActive;

        // Update the employee in the database
        _dbContext.Employees.Update(employee);
        await _dbContext.SaveChangesAsync();
    }

    #endregion


    




} //end of class
