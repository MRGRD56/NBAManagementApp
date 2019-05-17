namespace NBAManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BasketballSystemModel : DbContext
    {
        // Контекст настроен для использования строки подключения "BasketballSystemModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "NBAManagement.Model.BasketballSystemModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "BasketballSystemModel" 
        // в файле конфигурации приложения.
        public BasketballSystemModel()
            : base("name=BasketballSystemModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<PlayerPosition> PlayerPositions { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}