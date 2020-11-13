using Common.Tools;
using Models.Insightly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Insightly
{
    public class ProjectService : CrudService<Project>
    {
        public ProjectService(string apiKey) : base(apiKey, "Projects")
        {
        }

        public IEnumerable<Project> GetAllProjects()
        {
            try
            {
                Utils.LogMessage($"Getting all projects...");

                var projects = GetAll().Result;
                var s = projects != null && projects.Count() > 1 ? "s" : string.Empty;
                if (projects != null && projects.Count() > 0) Utils.LogMessage($"Successfully found {projects.Count()} project{s}!");
                return projects;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all projects: {ex.Message}");
                throw;
            }
        }

        public Project GetProject(long? projectId)
        {
            try
            {
                if (projectId == null) return null;
                Utils.LogMessage($"Getting project #{projectId}...");

                var project = Get((long)projectId).Result;
                if (project != null) Utils.LogMessage($"Successfully retrieved project, {project.PROJECT_NAME}!");
                return project;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting project #{projectId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Project> SearchProjectsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for projects with {fieldValue} in {fieldName}...");

                var projects = Search(fieldName, fieldValue).Result;
                var s = projects != null && projects.Count() > 1 ? "s" : string.Empty;
                if (projects != null && projects.Count() > 0) Utils.LogMessage($"Successfully found {projects.Count()} project{s} with {fieldValue} in {fieldName}!");
                return projects;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for projects with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Project CreateProject(Project project)
        {
            try
            {
                if (project == null) return null;
                Utils.LogMessage($"Creating project {project.PROJECT_NAME}...");

                project = Create(project)?.Result;
                if (project != null) Utils.LogMessage($"Successfully created project #{project.PROJECT_ID}!");
                return project;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error creating project {project.PROJECT_NAME}: {ex.Message}");
                throw;
            }
        }

        public Project UpdateProject(Project project)
        {
            try
            {
                if (project == null) return null;
                Utils.LogMessage($"Updating the project #{project.PROJECT_ID}...");

                project = Update(project).Result;
                if (project != null) Utils.LogMessage($"Successfully updated project #{project.PROJECT_ID}!");
                return project;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating the project #{project.PROJECT_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteProject(long? projectId)
        {
            try
            {
                if (projectId == null) return false;
                Utils.LogMessage($"Deleting project #{projectId}...");

                var deleted = Delete((long)projectId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted project #{projectId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting project #{projectId}: {ex.Message}");
                throw;
            }
        }

        public async Task<Pipeline> AddPipeline(long? projectId, Pipeline pipeline)
        {
            try
            {
                if (projectId == null || pipeline == null) return null;
                Utils.LogMessage($"Adding a pipeline for project #{projectId}...");

                pipeline = await apiClient.PostAsync(pipeline, $"{objectUrl}/{projectId}/Pipeline");
                if (pipeline != null) Utils.LogMessage($"Successfully added pipeline to project #{projectId}!");
                return pipeline;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Adding a pipeline for project #{projectId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Event>> GetProjectEvents(long? projectId)
        {
            try
            {
                if (projectId == null) return null;
                Utils.LogMessage($"Getting all events for project #{projectId}...");

                var events = await apiClient.GetAsync<IEnumerable<Event>>($"/Projects/{projectId}/Events");
                var s = events != null && events.Count() > 1 ? "s" : string.Empty;
                if (events != null && events.Count() > 0) Utils.LogMessage($"Successfully retrieved {events.Count()} event{s} for project #{projectId}!");
                return events;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all events for project #{projectId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<FileAttachment>> GetProjectFileAttachments(long? projectId)
        {
            try
            {
                if (projectId == null) return null;
                Utils.LogMessage($"Getting all files for project #{projectId}...");

                var files = await apiClient.GetAsync<IEnumerable<FileAttachment>>($"/Projects/{projectId}/FileAttachments");
                var s = files != null && files.Count() > 1 ? "s" : string.Empty;
                if (files != null && files.Count() > 0) Utils.LogMessage($"Successfully retrieved {files.Count()} file{s} for project #{projectId}!");
                return files;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all files for project #{projectId}: {ex.Message}");
                throw;
            }
        }

        public static Project CopyProject(Project project)
        {
            return new Project() { PROJECT_ID = project.PROJECT_ID, CUSTOMFIELDS = new List<CustomField>() };
        }
    }
}
