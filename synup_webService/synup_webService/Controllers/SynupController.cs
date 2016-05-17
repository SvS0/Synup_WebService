using synup_webService.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace synup_webService.Controllers
{
    public class SynupController : ApiController
    {
        #region Task

        [Route("api/TaskInserted/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetInsertedTask(string employeeId, int first, int last)
        {
            var task = TaskRepository.GetInsertedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        [Route("api/TaskUpdated/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTask(string employeeId, int first, int last)
        {
            var task = TaskRepository.GetUpdatedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        [Route("api/TaskDeleted/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTask(string employeeId, int first, int last)
        {
            var task = TaskRepository.GetDeletedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        #endregion

        #region TaskHistory

        [Route("api/TaskHistoryInserted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetInsertedTaskHistory(string employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetInsertedTaskHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, taskHistory);
            return response;
        }

        [Route("api/TaskHistoryUpdated/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTaskHistory(string employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetUpdatedTaskHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, taskHistory);
            return response;
        }

        [Route("api/TaskHistoryDeleted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTaskHistory(string employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetDeletedTaskHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, taskHistory);
            return response;
        }

        #endregion

        #region Employee

        [Route("api/EmployeeInserted/{first}/{last}")]
        public HttpResponseMessage GetInsertedEmployee(int first, int last)
        {
            var employee = EmployeeRepository.GetInsertedEmployee(first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employee);
            return response;
        }

        [Route("api/EmployeeUpdated/{first}/{last}")]
        public HttpResponseMessage GetUpdatedEmployee(int first, int last)
        {
            var employee = EmployeeRepository.GetUpdatedEmployee(first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employee);
            return response;
        }

        [Route("api/EmployeeDeleted/{first}/{last}")]
        public HttpResponseMessage GetDeletedEmployee(int first, int last)
        {
            var employee = EmployeeRepository.GetDeletedEmployee(first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employee);
            return response;
        }

        [Route("api/Login/{username}/{password}")]
        public HttpResponseMessage GetLogin(string username, string password)
        {
            var employee = EmployeeRepository.GetLogin(username, password);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employee);
            return response;
        }

        #endregion

        #region Team
        [Route("api/TeamInserted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetInsertedTeam(string employeeId, int first, int last)
        {
            var team = TeamRepository.GetInsertedTeam(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        [Route("api/TeamUpdated/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTeam(string employeeId, int first, int last)
        {
            var team = TeamRepository.GetUpdatedTeam(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        [Route("api/TeamDeleted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTeam(string employeeId, int first, int last)
        {
            var team = TeamRepository.GetDeletedTeam(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        #endregion

        #region TeamHistory

        [Route("api/TeamHistoryInserted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetInsertedTeamHistory(string employeeId, int first, int last)
        {
            var team = TeamHistoryRepository.GetInsertedTeamHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        [Route("api/TeamHistoryUpdated/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTeamHistory(string employeeId, int first, int last)
        {
            var team = TeamHistoryRepository.GetUpdatedTeamHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        [Route("api/TeamHistoryDeleted/{employeeId:alpha}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTeamHistory(string employeeId, int first, int last)
        {
            var team = TeamHistoryRepository.GetDeletedTeamHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, team);
            return response;
        }

        #endregion

        #region Last

        [Route("api/Last")]
        public HttpResponseMessage GetLast()
        {
            var last = LastRepository.GetLast();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, last);
            return response;
        }

        #endregion

    }
}