using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MrzApp.Data
{
    public class MrzItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MrzItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<MrzItem>().Wait();
        }

        public Task<List<MrzItem>> GetItemsAsync()
        {
            return database.Table<MrzItem>().ToListAsync();
        }

        public Task<List<MrzItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<MrzItem>("SELECT * FROM [MrzItem]");
        }

        public Task<MrzItem> GetItemAsync(int id)
        {
            return database.Table<MrzItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(MrzItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(MrzItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
