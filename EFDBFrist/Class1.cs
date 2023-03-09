using EFDBFrist.Models;

namespace EFDBFrist
{
    public class Class1
    {
        Repository<Person> repository =new Repository<Person>();

        public async void GetAllPerson()
        {
          var data = await repository.ListDataAsync();
           // data.
        }
    }
}