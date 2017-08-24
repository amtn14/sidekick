using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Sabio.Data;
using sidekick.Models.Request;
using sidekick.Models.Domain;
using System.Data.SqlClient;

namespace sidekick.Services
{
    public class ToDoServices : BaseService
    {
        public static int InsertToDoTask(ToDoRequest model)
        {
            int returnedId = 0;
            //make connection to DB - stored proc
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.toDo_InsertTask",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                    {
                        //empty container for returning ID from storedProc
                        SqlParameter p = new SqlParameter("@id", System.Data.SqlDbType.Int);
                        p.Direction = System.Data.ParameterDirection.Output;
                        paramCollection.Add(p);

                        paramCollection.AddWithValue("@task", model.Task);
                        paramCollection.AddWithValue("@priority", model.Priority);
                        paramCollection.AddWithValue("@deleted", false);
                    }, returnParameters: delegate (SqlParameterCollection param)
                    {
                        int.TryParse(param["@Id"].Value.ToString(), out returnedId);
                    });

            return returnedId;
        }

        public static List<toDo> GetAllTasks()
        {
            List<toDo> listOfTasks = null;

            DataProvider.ExecuteCmd(GetConnection, "dbo.toDo_GetAllTasks", 
                inputParamMapper: delegate(SqlParameterCollection paramCollection) {
                    //no params to send over to the db
                },
                map: delegate (IDataReader reader, short set)
                {
                    toDo task = new toDo();
                    int startingIndex = 0;

                    //getsafe - part of sabio.data - protects us from nullable values
                    task.Id = reader.GetSafeInt32(startingIndex++);
                    task.Task = reader.GetSafeString(startingIndex++);
                    task.Priority = reader.GetSafeString(startingIndex++);
                    task.Created = reader.GetSafeDateTime(startingIndex++);
                    task.Deleted = reader.GetSafeBool(startingIndex++);

                    if (listOfTasks == null)
                    {
                        listOfTasks = new List<toDo>();
                    }

                    listOfTasks.Add(task);
                });
            return listOfTasks;
        }
    }
}//end of toDoServices.cs