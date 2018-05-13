using System.Collections.Generic;
using System.Linq;
using AspNet5SQLite.Model;
using AspNetCoreSQLite.Model;
using Microsoft.AspNetCore.Mvc;  
using Microsoft.Extensions.Logging;

namespace AspNet5SQLite.Repositories
{
    public class DataBaseImpl : IDataBase
    {
        private readonly KingsAwardDataBase _context;

        private readonly ILogger _logger;

        public DataBaseImpl(KingsAwardDataBase context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger(nameof(DataBaseImpl));          
        }

        public List<Child> GetAll()
        {
            throw new System.NotImplementedException();
            
        }

        public Child Get(long id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public void Post(Child child)
        {
            throw new System.NotImplementedException();
        }

        public void Put(long id, [FromBody]Child child)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteChild(long id)
        {
            var entity = _context.Children.First(t => t.id == id);
            _context.Children.Remove(entity);
            _context.SaveChanges();
        }

        public Child GetChild(long id)
        {
            return _context.Children.First(t => t.id == id);
        }

        public List<Child> GetAllChild()
        {
             
            return _context.Children.ToList();
        }

        public void PostChild(Child data)
        {
            _context.Children.Add(data);
            _context.SaveChanges();
        }

        public void PutChild(long id, [FromBody] Child data)
        {
            _context.Children.Update(data);
            _context.SaveChanges();
        }

        public void DeleteAward(long id)
        {
            var entity = _context.Awards.First(t => t.id == id);
            _context.Awards.Remove(entity);
            _context.SaveChanges();
        }

        public Award GetAward(long id)
        {
            return _context.Awards.First(t => t.id == id);
        }

        public List<Award> GetAllAward()
        {
            return _context.Awards.ToList();
        }

        public void PostAward(Award data)
        {
            _context.Awards.Add(data);
            _context.SaveChanges();
        }

        public void PutAward(long id, [FromBody] Award data)
        {
            _context.Awards.Update(data);
            _context.SaveChanges();
        }

        public void DeleteTask(long id)
        {
            var entity = _context.Tasks.First(t => t.id == id);
            _context.Tasks.Remove(entity);
            _context.SaveChanges();
        }

        public Task GetTask(long id)
        {
            return _context.Tasks.First(t => t.id == id);
        }

        public List<Task> GetAllTask()
        {
            return _context.Tasks.ToList();
        }

        public void PostTask(Task data)
        {
            _context.Tasks.Add(data);
            _context.SaveChanges();
        }

        public void PutTask(long id, [FromBody] Task data)
        {
            _context.Tasks.Update(data);
            _context.SaveChanges();
        }

        public void DeleteArchive(long id)
        {
            var entity = _context.Archives.First(t => t.id == id);
            _context.Archives.Remove(entity);
            _context.SaveChanges();
        }

        public Archive GetArchive(long id)
        {
            return _context.Archives.First(t => t.id == id);
        }

        public List<Archive> GetAllArchive()
        {
            return _context.Archives.ToList();
        }

        public void PostArchive(Archive data)
        {
            _context.Archives.Add(data);
            _context.SaveChanges();
        }

        public void PutArchive(long id, [FromBody] Archive data)
        {
            _context.Archives.Update(data);
            _context.SaveChanges();
        }

        public void DeleteActivity(long id)
        {
            var entity = _context.Activites.First(t => t.id == id);
            _context.Activites.Remove(entity);
            _context.SaveChanges();
        }

        public Activity GetActivity(long id)
        {
            return _context.Activites.First(t => t.id == id);
        }

        public List<Activity> GetAllActivity()
        {
            return _context.Activites.ToList();
        }

        public void PostActivity(Activity data)
        {
            _context.Activites.Add(data);
            _context.SaveChanges();
        }

        public void PutActivity(long id, [FromBody] Activity data)
        {
            _context.Activites.Update(data);
            _context.SaveChanges();
        }

        public void DeleteTaskDone(long id)
        {
           var entity = _context.TasksDone.First(t => t.id == id);
            _context.TasksDone.Remove(entity);
            _context.SaveChanges();
        }

        public TaskDone GetTaskDone(long id)
        {
            return _context.TasksDone.First(t => t.id == id);
        }

        public List<TaskDone> GetAllTaskDone()
        {
            return _context.TasksDone.ToList();
        }

        public void PostTaskDone(TaskDone data)
        {
            _context.TasksDone.Add(data);
            _context.SaveChanges();
        }

        public void PutTaskDone(long id, [FromBody] TaskDone data)
        {
            _context.TasksDone.Update(data);
            _context.SaveChanges();
        }

        public void Delete<T>(long id)
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetAll<T>()
        {
            throw new System.NotImplementedException();
        }

        public void Post<T>(T data)
        {
            throw new System.NotImplementedException();
        }

        public void Put<T>(long id, [FromBody] T data)
        {
            throw new System.NotImplementedException();
        }

        public List<Task> GetTaskByName(string name)
        {
            //throw new System.NotImplementedException();
            return _context.Tasks.Where(t => t.Name.Contains(name)).ToList();
        }
    }
}
