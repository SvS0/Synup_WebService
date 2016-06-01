using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TaskHistoryRepository
    {
        public static byte FINISHED = 1;
        private static byte NOT_FINISHED = 0;

        /// <summary>
        /// Return Inserted TaskHistory List for a employee from first to last requested register id
        /// </summary>
        /// <param name="employeeId"> Employee Id => Nif</param>
        /// <param name="first"> First TaskHistory in request</param>
        /// <param name="last"> Last TaskHistory in request</param>
        /// <returns>TaskHistory List</returns>
        public static List<TaskHistory> GetInsertedTaskHistory(string employeeId, int first, int last)
        {
            List<TaskHistory> _taskHistories;

            using (var _dataContext = new synupEntities())
            {
                _taskHistories = new List<TaskHistory>();
                _taskHistories = _dataContext.spTHisLogI(employeeId, first, last).ToList();
            }

            return _taskHistories;
        }

        /// <summary>
        /// Return Updated TaskHistory List for a employee from first to last requested register id
        /// </summary>
        /// <param name="employeeId"> Employee Id => Nif</param>
        /// <param name="first"> First TaskHistory in request</param>
        /// <param name="last"> Last TaskHistory in request</param>
        /// <returns>TaskHistory List</returns>
        public static List<TaskHistory> GetUpdatedTaskHistory(string employeeId, int first, int last)
        {
            List<TaskHistory> _taskHistories;

            using (var _dataContext = new synupEntities())
            {
                _taskHistories = new List<TaskHistory>();
                _taskHistories = _dataContext.spTHisLogU(employeeId, first, last).ToList();
            }

            return _taskHistories;
        }

        /// <summary>
        /// Return Deleted TaskHistory List for a employee from first to last requested register id
        /// </summary>
        /// <param name="employeeId"> Employee Id => Nif</param>
        /// <param name="first"> First TaskHistory in request</param>
        /// <param name="last"> Last TaskHistory in request</param>
        /// <returns>TaskHistory List</returns>
        public static List<TaskHistory> GetDeletedTaskHistory(string employeeId, int first, int last)
        {
            List<TaskHistory> _taskHistories;

            using (var _dataContext = new synupEntities())
            {
                _taskHistories = new List<TaskHistory>();
                _taskHistories = _dataContext.spTHisLogD(employeeId, first, last).ToList();
            }

            return _taskHistories;
        }

        /// <summary>
        /// Given a EmployeeId and a TaskId this method generation a relation between this two entities.
        /// </summary>
        /// <param name="employeeId"> employeeId that request a task</param>
        /// <param name="taskId"> taskId to be done</param>
        /// <returns>TaskHistory Register with the assignation done in List data format</returns>
        public static List<TaskHistory> InsertTeamHistory(string employeeId, string taskId)
        {
            //Return value
            List<TaskHistory> _taskHistories = null;

            using (var _dataContext = new synupEntities())
            {
                _taskHistories = new List<TaskHistory>();

                //First, we look that the given employee and tasks exists
                //and if is possible take this task. 
                Task _task = _dataContext.Tasks.Where(x => x.code.Equals(taskId)).SingleOrDefault();
                Employee _employee = _dataContext.Employees.Where(x => x.nif.Equals(employeeId)).SingleOrDefault();

                if (_task != null && _employee != null &&
                    (_task.state == (int)TaskStateEnum.UNSELECTED ||
                    _task.state == (int)TaskStateEnum.ABANDONED))
                {
                    //Update task with new state into DB
                    var q = _dataContext.Tasks.Where(x => x.code == _task.code).SingleOrDefault();
                    q.state = (int)TaskStateEnum.ONGOING;

                    //create and Insert a new Task History into DB
                    TaskHistory _taskHistory = new TaskHistory();
                    _taskHistory.id_employee = employeeId;
                    _taskHistory.id_task = taskId;
                    _taskHistory.isFinished = NOT_FINISHED;
                    _taskHistory.startDate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

                    _taskHistory = _dataContext.TaskHistories.Add(_taskHistory);

                    _dataContext.SaveChanges();

                    //We call inserted register in order to return
                    _taskHistories.Add(_taskHistory);

                }
            }
            return _taskHistories;
        }

        /// <summary>
        /// Update TaskHistory finishing the register with a finishDate.
        /// Update state's Task also.
        /// </summary>
        /// <param name="th"> given TaskHistory in otder to update</param>
        /// <returns></returns>
        public static List<TaskHistory> UpdateTaskHistory(List<TaskHistory> th)
        {

            List<TaskHistory> _taskHistories = null;    //Return values
            int _taskHistoryId;     //Task History id


            using (var _dataContext = new synupEntities())
            {

                foreach (TaskHistory taskh in th)
                {
                    //First, we look that TaskHistory.
                    TaskHistory _taskHistory = _dataContext.TaskHistories.Where(x => x.id == taskh.id).SingleOrDefault();

                    if (_taskHistory != null)
                    {
                        //Update TaskHistory with finish date and FINISHED 'state'.
                        var q = _dataContext.TaskHistories.Where(x => x.id == taskh.id).SingleOrDefault();
                        q = taskh;

                        //keeping taskHistoryId
                        _taskHistoryId = q.id;

                        //Update Task with state. First we check that exists in DB
                        Task task = _dataContext.Tasks.Where(x => x.code == taskh.id_task).SingleOrDefault();

                        if (task != null)
                        {
                            //Update Task depending on taskHistory isfinished state.
                            var q2 = _dataContext.Tasks.Where(x => x.code == taskh.id_task).SingleOrDefault();
                            if (taskh.isFinished == FINISHED)
                            {
                                q2.state = (int)TaskStateEnum.FINISHED;
                            }
                            else if (taskh.isFinished == NOT_FINISHED)
                            {
                                q2.state = (int)TaskStateEnum.ABANDONED;
                            }
                        }

                        _dataContext.SaveChanges();

                        //Getting inserted data from DB
                        _taskHistories = new List<TaskHistory>();
                        _taskHistories.Add(q);
                    }
                }
            }
               
            return _taskHistories;
        }
    }
}