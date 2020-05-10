using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Crafting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Geral/source/repos/IDJ_CraftingSystem/Crafting_System/SerializeItens/bin/Debug/netcoreapp3.1";
            string deserialize = File.ReadAllText(path);
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(deserialize);

        }
    }
}
