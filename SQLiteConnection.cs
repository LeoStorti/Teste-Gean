using System;
using System.Data;

namespace SeuNamespace
{
    internal class SQLiteConnection
    {
        private string connectionString;

        public SQLiteConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}