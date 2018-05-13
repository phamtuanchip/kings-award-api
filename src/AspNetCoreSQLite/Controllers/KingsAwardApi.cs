using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet5SQLite.Repositories;
using AspNetCoreSQLite.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNet5SQLite.Controllers
{
    [Route("kingsaward")]
    public class KingsAwardApi : Controller

    {
        private readonly IDataBase _dataBase;

        public KingsAwardApi(IDataBase data)
        {
            _dataBase = data;
        }

        // GET: api/<controller>

        
        [HttpGet("tasks")]
        public  IEnumerable<AspNetCoreSQLite.Model.Task> tasks(string name)
        {
            if(name != null) return _dataBase.GetTaskByName(name);
            return _dataBase.GetAllTask();
        }

        // GET api/<controller>/5
         
        [HttpGet("tasks/{id}")]
        public AspNetCoreSQLite.Model.Task tasks(int id)
        {
            return _dataBase.GetTask(id);
        }
        
        // POST api/<controller>
        [HttpPost("tasks")]
        public void Post([FromBody]AspNetCoreSQLite.Model.Task value)
        {
            _dataBase.PostTask(value);
        }

        // PUT api/<controller>/5
        [HttpPut("tasks/{id}")]
        public void Put(int id, [FromBody]AspNetCoreSQLite.Model.Task value)
        {
            _dataBase.PutTask(id, value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("tasks/{id}")]
        public void Delete(int id)
        {
            _dataBase.DeleteTask(id);
        }
    }
}
