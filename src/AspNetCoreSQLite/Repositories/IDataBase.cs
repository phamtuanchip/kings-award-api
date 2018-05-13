using System.Collections.Generic;
using AspNet5SQLite.Model;
using AspNetCoreSQLite.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNet5SQLite.Repositories
{


    public interface IDataBase
    {

        void Delete<T>(long id);
        T Get<T>(long id);
        List<T> GetAll<T>();
        void Post<T>(T data);
        void Put<T>(long id, [FromBody] T data);

        void DeleteChild(long id);
        Child GetChild(long id);
        List<Child> GetAllChild();
        void PostChild(Child data);
        void PutChild(long id, [FromBody] Child data);


        void DeleteAward(long id);
        Award GetAward(long id);
        List<Award> GetAllAward();
        void PostAward(Award data);
        void PutAward(long id, [FromBody] Award data);


        void DeleteTask(long id);
        Task GetTask(long id);
        List<Task> GetAllTask();
        void PostTask(Task data);
        void PutTask(long id, [FromBody] Task data);


        void DeleteArchive(long id);
        Archive GetArchive(long id);
        List<Archive> GetAllArchive();
        void PostArchive(Archive data);
        void PutArchive(long id, [FromBody] Archive data);


        void DeleteActivity(long id);
        Activity GetActivity(long id);
        List<Activity> GetAllActivity();
        void PostActivity(Activity data);
        void PutActivity(long id, [FromBody] Activity data);

        void DeleteTaskDone(long id);
        TaskDone GetTaskDone(long id);
        List<TaskDone> GetAllTaskDone();
        void PostTaskDone(TaskDone data);
        void PutTaskDone(long id, [FromBody] TaskDone data);
    }
}