using DAL.Models;
using System.Collections.Generic;
using System;

namespace DAL.EF
{
    public class _507SAInitializer : System.Data.Entity.CreateDatabaseIfNotExists<_507SAContext>
    {
        protected override void Seed(_507SAContext context)
        {
            var userList = new List<User>()
            {
                new User (){ FirstName = "Ольга",LastName="Атаманюк", Email="olyaatamanyuk@gmail.com", Password="123456", Info="Some info",Phone=0501087980, PictureId=1},
                new User (){ FirstName = "Марина", LastName = "Волощук", Email = "voloshuk@gmail.com" , Password = "123456", Phone = 0992162576, Info="Some info",PictureId=2 },
                new User (){ FirstName = "Василь", LastName = "Косован", Email = "kosovan@gmail.com", Password = "123456" , Phone = 0993512958 ,Info="Some info", PictureId=3},
                new User (){ FirstName = "Андрій", LastName = "Курган", Email = "kurgan@gmail.com", Password = "123456" , Phone = 0968078354 ,Info="Some info", PictureId=4},
                new User (){ FirstName = "Степан", LastName = "Миронюк", Email = "myronjuk@gmail.com", Password = "123456", Phone=0500000000,Info="Some info", PictureId=5 },
                new User (){ FirstName = "Ігор", LastName = "Панчук", Email = "panchuk@gmail.com", Password = "123456" , Phone = 0955095293, Info="Some info",PictureId=6 },
                new User (){ FirstName = "Вікторія", LastName = "Якозина", Email = "yakozina@gmail.com", Password = "123456" , Phone = 0508596211, Info="Some info",PictureId=7 }
            };

            userList.ForEach(s => context.User.Add(s));
            //context.SaveChanges();

            var subjectList = new List<Subject>()
            {
                new Subject(){ Name = "C# programming", IsExam = true },
                new Subject() { Name = "Java programming", IsExam = true },
                new Subject(){ Name = "JS programming", IsExam = false },
            };

            subjectList.ForEach(c => context.Subject.Add(c));
            //context.SaveChanges();

            var noweltiesList = new List<Nowelty>()
            {
                new Nowelty(){  Description="First news", Text="So, i`m a first news!" , Date=DateTime.Now},
                new Nowelty(){  Description="Second news", Text="So, i`m a second news!" , Date=DateTime.Now},
                new Nowelty(){  Description="Third news", Text="So, i`m a third news!" , Date=DateTime.Now},
                new Nowelty(){  Description="Fourth news", Text="So, i`m a fourth news!" , Date=DateTime.Now}
            };

            noweltiesList.ForEach(c => context.Nowelty.Add(c));

            context.SaveChanges();

            base.Seed(context);
        }

        //public override void InitializeDatabase(_507SAContext context)
        //{
        //    context.Database.CreateIfNotExists();

        //    base.InitializeDatabase(context);
        //}
    }
}
