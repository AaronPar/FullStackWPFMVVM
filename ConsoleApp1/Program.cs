using FullStackWPFMVVM.Domain.Models;
using FullStackWPFMVVM.Domain.Services;
using FullStackWPFMVVM.EntityFramework;
using FullStackWPFMVVM.EntityFramework.Services;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new FullStackWPFMVVMDBContextFactory());
            //userService.Create(new User { Username = "Test" }).Wait();
            Console.WriteLine(userService.Delete(1).Result);
        }
    }
}
