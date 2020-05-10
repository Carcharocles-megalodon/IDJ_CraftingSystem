using System;
using System.Collections.Generic;
using System.IO;
using Crafting_System;
using Newtonsoft.Json;

namespace SerializeItens
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
              new Item()
              {
                Title = "Sword",
                Id = 101
              },new Item()
              {
                Title = "Stick",
                Id = 01
              },
              new Item()
              {
                Title = "Metal",
                Id = 02
              },
              new Item()
              {
                Title = "Shield",
                Id = 102
              }
            };
            string json = JsonConvert.SerializeObject(items);
            File.WriteAllText("items.json", json);
            items.ToArray();
            List<Recipe> recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    Name = "Sword Recipe",
                    RequiredItemsID = new List<int>()
                    {
                        01,
                        02
                    },
                    OutputItemID = 101       
                }
            };
        }
    }
}

