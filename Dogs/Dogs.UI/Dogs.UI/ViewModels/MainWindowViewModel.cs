using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dogs.UI.Services;

namespace Dogs.UI.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(IDogData dogService)
        {
            DogName = "Roxy";
           
            DogList = dogService.GetDogName();

            Breeds = dogService.GetDogBreeds();


        }
        public string DogName { get; private set; }
        public List<string> DogList { get; set; }
        public List<String> Breeds { get; set; }


    }
}
