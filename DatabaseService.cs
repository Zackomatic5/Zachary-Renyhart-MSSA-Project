using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zachary_Renyhart_MSSA_Project.NewFolder2;

namespace Zachary_Renyhart_MSSA_Project
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SystemInfo>().Wait();
        }

        public Task<int> RegisterUserAsync(SystemInfo user)
        {
            return _database.InsertAsync(user);
        }

        public Task<SystemInfo> LoginUserAsync(string email, string password)
        {
            return _database.Table<SystemInfo>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public Task<SystemInfo> GetUserByEmailAsync(string email)
        {
            return _database.Table<SystemInfo>().FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
