using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.UI.Services
{
    public class DogServiceFromDb : IDogData
    {
        public List<string> GetDogBreeds()
        {
            return new List<string>();
        }

        public List<string> GetDogName()
        {
            return new List<string>
            {
                "Peter", "Digby", "Sam", "Paul"
            };
        }
    }
}
