using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class TaskService : CrudService<InsightlyTask>
    {
        public TaskService(string apiKey) : base(apiKey, "Tasks")
        {
        }

        public IEnumerable<InsightlyTask> GetAllTasks()
        {
            try
            {
                Utils.LogMessage($"Getting all tasks...");

                var tasks = GetAll().Result;
                var s = tasks != null && tasks.Count() > 1 ? "s" : string.Empty;
                if (tasks != null && tasks.Count() > 0) Utils.LogMessage($"Successfully found {tasks.Count()} task{s}!");
                return tasks;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all tasks: {ex.Message}");
                throw;
            }
        }

        public InsightlyTask GetTask(long? taskId)
        {
            try
            {
                if (taskId == null) return null;
                Utils.LogMessage($"Getting task #{taskId}...");

                var task = Get((long)taskId).Result;
                if (task != null) Utils.LogMessage($"Successfully found task, {task.TITLE}");
                return task;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting task #{taskId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<InsightlyTask> SearchTasksByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for tasks with {fieldValue} in {fieldName}...");

                var tasks = Search(fieldName, fieldValue).Result;
                var s = tasks != null && tasks.Count() > 1 ? "s" : string.Empty;
                if (tasks != null && tasks.Count() > 0) Utils.LogMessage($"Successfully found {tasks.Count()} task{s}!");
                return tasks;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for tasks with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public InsightlyTask CreateTask(InsightlyTask task)
        {
            try
            {
                if (task == null) return null;
                Utils.LogMessage($"Creating task, {task?.TITLE}...");

                task = Create(task).Result;
                if (task != null) Utils.LogMessage($"Successfully created task, {task.TASK_ID}!");
                return task;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating task #{task?.TITLE}: {ex.Message}");
                throw;
            }
        }

        public InsightlyTask UpdateTask(InsightlyTask task)
        {
            try
            {
                if (task == null) return null;
                Utils.LogMessage($"Updating task #{task?.TASK_ID}...");

                task = Update(task).Result;
                if (task != null) Utils.LogMessage($"Successfully updated task, {task.TITLE}!");
                return task;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating task #{task?.TASK_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteTask(long? taskId)
        {
            try
            {
                if (taskId == null) return false;
                Utils.LogMessage($"Deleting task #{taskId}...");

                var deleted = Delete((long)taskId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted task #{taskId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting task #{taskId}: {ex.Message}");
                throw;
            }
        }
    }
}
