using EFDBFrist;
using EFDBFrist.Models;
using EFDBFrist.Models.DTOModels;
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
        public static async Task<List<PersonDto>> GetAllPersons()
        {
            var data = await repository.GetListAsync<Person,PersonDto>(s=>s.Status==true,t=>new PersonDto()
            {
                Id=t.Id,
                Name=t.Name,
                Description=t.Description,
                CreateAt=t.CreateAt,
                Status=t.Status,
                Address=t.Address,
                UpdateAt=t.UpdateAt,
                CreateById =t.CreateById,
                Email=t.Email,
                UpdateById=t.UpdateById,
                IsDeleted=t.IsDeleted,
                PhoneNumber=t.PhoneNumber,
            });
            return data;

        }
        public static void DeleteExpPerson()
        {
            //var data = repository.Delete(new Person() { Id=1});
           
            var data2 = repository.Delete(s=>s.Id!=Guid.Empty);
           
        }
    }

}
