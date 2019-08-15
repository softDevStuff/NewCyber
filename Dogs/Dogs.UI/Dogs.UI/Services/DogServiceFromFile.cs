using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.UI.Services
{
    public interface IDogData
    {
        List<string> GetDogName();
        List<string> GetDogBreeds();
    }
    public class DogServiceFromFile : IDogData
    {
        public List<string> GetDogBreeds()
        {
            throw new NotImplementedException();
        }

        public List<string> GetDogName()
        {
            return new List<string>
            {
                "Peter", "Digby", "Sam", "Paul", "Pedro"
            };
        }
    }
}
