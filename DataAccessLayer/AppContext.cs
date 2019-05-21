namespace DataAccessLayer
{
    using DataAccessLayer.Models;
    using DataAccessLayer.Settings;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        // Контекст настроен для использования строки подключения "AppContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "DataAccessLayer.AppContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "AppContext" 
        // в файле конфигурации приложения.
        public AppContext()
            : base("name=AppContext.cs")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}