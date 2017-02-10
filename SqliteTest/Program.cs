using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //SQLiteConnection conn = new SQLiteConnection("data Source=test.sqlite;password=123456");
            //conn.Open();
            //conn.ChangePassword("123456");

            ISessionFactory sessionFactory = Fluently.Configure()
                .BuildConfiguration()
                .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            int returnCount = session.CreateSQLQuery("create table s_user(id text,name text);insert into s_user values('1','1')")
                .ExecuteUpdate();

        }
    }
}
