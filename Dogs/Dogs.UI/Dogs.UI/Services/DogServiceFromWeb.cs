using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.UI.Services
{
    public class DogServiceFromWeb : IDogData
    {
        public List<string> GetDogName()
        {
            return new List<string>
            {
                "Paulio", "Danger", "Stevio"
            };
        }

        public List<string> GetDogBreeds()
        {
            return new List<string>
            {
                "Labrador", "Rockwieler", "Service"
            };
        }
    }
}
