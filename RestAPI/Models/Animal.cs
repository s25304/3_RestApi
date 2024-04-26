using System.Security.Cryptography;
using System.Xml.Linq;

namespace RestAPI.Models
{
    public class Animal
    {
        private int id;
        private string name;
        private string description;
        private string category;
        private string area;
        public Animal(int id, string name, string description, string category, string area)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.area = area;
        }

        
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        
        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        
        public string GetCategory()
        {
            return this.category;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        
        public string GetArea()
        {
            return this.area;
        }

        public void SetArea(string area)
        {
            this.area = area;
        }
    }
}
