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
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeLog> EmployeeLogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskHistory> TaskHistories { get; set; }
        public virtual DbSet<TaskHistoryLog> TaskHistoryLogs { get; set; }
        public virtual DbSet<TaskLog> TaskLogs { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamHistory> TeamHistories { get; set; }
        public virtual DbSet<TeamLog> TeamLogs { get; set; }
        public virtual DbSet<TeamHistoryLog> TeamHistoryLogs { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
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
    
        public virtual ObjectResult<spGetByDate_Result> spGetByDate(Nullable<System.DateTime> begin, Nullable<System.DateTime> end)
        {
            var beginParameter = begin.HasValue ?
                new ObjectParameter("begin", begin) :
                new ObjectParameter("begin", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetByDate_Result>("spGetByDate", beginParameter, endParameter);
        }
    
        public virtual ObjectResult<spGetRankingEmployee_Result> spGetRankingEmployee(Nullable<System.DateTime> begin, Nullable<System.DateTime> end)
        {
            var beginParameter = begin.HasValue ?
                new ObjectParameter("begin", begin) :
                new ObjectParameter("begin", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRankingEmployee_Result>("spGetRankingEmployee", beginParameter, endParameter);
        }
    
        public virtual ObjectResult<spGetRankingTeam_Result> spGetRankingTeam(Nullable<System.DateTime> begin, Nullable<System.DateTime> end)
        {
            var beginParameter = begin.HasValue ?
                new ObjectParameter("begin", begin) :
                new ObjectParameter("begin", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRankingTeam_Result>("spGetRankingTeam", beginParameter, endParameter);
        }
    
        public virtual ObjectResult<spLast_Result> spLast()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLast_Result>("spLast");
        }
    
        public virtual ObjectResult<Employee> spLogin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spLogin", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Employee> spLogin(string username, string password, MergeOption mergeOption)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("spLogin", mergeOption, usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogD(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogD", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogI(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogI", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Task> spTasklogU(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Task>("spTasklogU", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogD(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogD", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogI(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogI", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<Team> spTeamLogU(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Team>("spTeamLogU", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTeHisLogD_Result> spTeHisLogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTeHisLogD_Result>("spTeHisLogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTeHisLogI_Result> spTeHisLogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTeHisLogI_Result>("spTeHisLogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTeHisLogU_Result> spTeHisLogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTeHisLogU_Result>("spTeHisLogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogD(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogD", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogI(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogI", mergeOption, employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaskHistory>("spTHisLogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<TaskHistory> spTHisLogU(string employeeId, Nullable<int> first, Nullable<int> last, MergeOption mergeOption)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
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
