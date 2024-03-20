using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipesApi.Entities
{
  
    public class Category
    {
       
        public int code { get; set; }
       
        public string name { get; set; }
        public string icon { get; set; }

        public Category(int id, string name, string path)
        {
            code = id;
            this.name = name;
            icon = path;
        }
    }
}
