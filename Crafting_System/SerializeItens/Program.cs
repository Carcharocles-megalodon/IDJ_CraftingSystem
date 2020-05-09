using System;
using System.Collections.Generic;
using Crafting_System;

namespace SerializeItens
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Item>> items = new Dictionary<string, List<Item>>();
            List<Item> hams = new List<Item>()
            {
                new Item()
                {
                    title = "Big Mac",
                    id = 1,
                    stats =
                    {
                        
                    }

                    }
                },

                
                

           

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            string json = JsonConvert.SerializeObject(items, settings);

            File.WriteAllText("output.json", json);
        }
    }
}
