using EFDBFrist;
using EFDBFrist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataAcess.MangOnDataBAse
{
    public static class AccessToData
    {
        public static Repository<Person> repository = new Repository<Person>();

        public static void GetAllPerson()
        {
            var data = repository.ListData();
            foreach (var item in data)
            {
                Console.WriteLine("Id :" + item.Id + "    Name Is : " + item.Name);
            }
        }
        public static void DeleteExpPerson()
        {
            //var data = repository.Delete(new Person() { Id=1});
           
            var data2 = repository.Delete(s=>s.Id>=2);
           
        }
    }

}
