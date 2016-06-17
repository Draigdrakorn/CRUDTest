﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCSTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=EmployeeContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMP_QUALIFICATION> EMP_QUALIFICATION { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<QualificationList> QualificationLists { get; set; }
    
        public virtual ObjectResult<usp_SelectEmployee_Result> usp_SelectEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectEmployee_Result>("usp_SelectEmployee");
        }
    
        public virtual ObjectResult<usp_SelectEmpQualification_Result> usp_SelectEmpQualification()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectEmpQualification_Result>("usp_SelectEmpQualification");
        }
    
        public virtual ObjectResult<usp_SelectQualificationList_Result> usp_SelectQualificationList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectQualificationList_Result>("usp_SelectQualificationList");
        }
    
        public virtual ObjectResult<usp_AddEmployee_Result> usp_AddEmployee(string empName, Nullable<System.DateTime> dOB, string gender, Nullable<int> salary, string entryBy, Nullable<System.DateTime> entryDate)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(int));
    
            var entryByParameter = entryBy != null ?
                new ObjectParameter("EntryBy", entryBy) :
                new ObjectParameter("EntryBy", typeof(string));
    
            var entryDateParameter = entryDate.HasValue ?
                new ObjectParameter("EntryDate", entryDate) :
                new ObjectParameter("EntryDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_AddEmployee_Result>("usp_AddEmployee", empNameParameter, dOBParameter, genderParameter, salaryParameter, entryByParameter, entryDateParameter);
        }
    
        public virtual int usp_AddEmpQualification(Nullable<int> employeeID, Nullable<int> qID, Nullable<double> marks)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var qIDParameter = qID.HasValue ?
                new ObjectParameter("QID", qID) :
                new ObjectParameter("QID", typeof(int));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("Marks", marks) :
                new ObjectParameter("Marks", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddEmpQualification", employeeIDParameter, qIDParameter, marksParameter);
        }
    }
}
