using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Machine
{
    public class Recipe
    {
        private string Name;
        private string[] Steps;
        private string[] Images;

        public Recipe(string Name, string[] Steps, string[] Images)
        {
            this.Name = Name;
            this.Steps = Steps;
            this.Images = Images;
        }

        public string GetName()
        {
            return Name;
        }

        public string[] GetSteps()
        {
            return Steps;
        }

        public string[] GetImages()
        {
            return Images;
        }
    }
}
