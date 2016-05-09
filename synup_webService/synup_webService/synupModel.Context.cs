﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace synup_webService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class synupEntities : DbContext
    {
        public synupEntities()
            : base("name=synupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskHistory> TaskHistory { get; set; }
    
        public virtual ObjectResult<Employee> spEmpLogD(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogD", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Employee> spEmpLogD(Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogD", mergeOption, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Employee> spEmpLogI(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogI", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Employee> spEmpLogI(Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogI", mergeOption, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Employee> spEmpLogU(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogU", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Employee> spEmpLogU(Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spEmpLogU", mergeOption, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spLast_Result> spLast(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLast_Result>("spLast", employeeIdParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogD(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogD(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogD", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogI(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogI(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogI", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogU(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogU(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogU", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogD(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogD(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogD", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogI(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogI(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogI", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogU(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogU(Nullable<int> employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogU", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    }
}
