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
        public HttpResponseMessage GetInsertedTask(int employeeId, int first, int last)
        {
            var task = TaskRepository.GetInsertedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        [Route("api/TaskUpdated/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTask(int employeeId, int first, int last)
        {
            var task = TaskRepository.GetInsertedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        [Route("api/TaskDeleted/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTask(int employeeId, int first, int last)
        {
            var task = TaskRepository.GetInsertedTask(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, task);
            return response;
        }

        #endregion

        #region TaskHistory

        [Route("api/TaskHistoryInserted/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetInsertedTaskHistory(int employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetInsertedTaskHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, taskHistory);
            return response;
        }

        [Route("api/TaskHistoryUpdated/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetUpdatedTaskHistory(int employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetInsertedTaskHistory(employeeId, first, last);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, taskHistory);
            return response;
        }

        [Route("api/TaskHistoryDeleted/{employeeId}/{first}/{last}")]
        public HttpResponseMessage GetDeletedTaskHistory(int employeeId, int first, int last)
        {
            var taskHistory = TaskHistoryRepository.GetInsertedTaskHistory(employeeId, first, last);
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

        #endregion

        #region Last

        [Route("api/Last/{employeeId}")]
        public HttpResponseMessage GetLast(int employeeId)
        {
            var last = LastRepository.GetLast(employeeId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, last);
            return response;
        }

        #endregion



    }
}