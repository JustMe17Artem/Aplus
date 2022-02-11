﻿using System.Collections.Generic;
using SQLite;

namespace Aplus.DataBase
{
    class ProjectsStorage
    {
        SQLiteConnection database;
        public ProjectsStorage(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Project>();
        }
        public IEnumerable<Project> GetItems()
        {
            return database.Table<Project>().ToList();
        }
        public Project GetItem(int id)
        {
            return database.Get<Project>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Project>(id);
        }
        public int SaveItem(Project item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
