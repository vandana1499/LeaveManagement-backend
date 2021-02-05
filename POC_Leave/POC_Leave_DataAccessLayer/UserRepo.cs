using MongoDB.Driver;
using POC_Leave_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_DataAccessLayer
{
    public class UserRepo : IUserRepo
    {
        private readonly IMongoCollection<User> _user;
        public UserRepo(LeaveDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.LeaveCollectionName);
        }

      
        public User GetDetailsByEmpID(string EmpId)
        {
            return _user.Find<User>(u => u.EmpId == EmpId).FirstOrDefault();
        }


    }
}
