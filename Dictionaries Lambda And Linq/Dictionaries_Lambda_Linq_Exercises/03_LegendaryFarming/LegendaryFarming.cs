namespace _03_LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LegendaryFarming
    {
        public static void Main()
        {
            var dictionaryOfMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0}
            };
            var junk = new Dictionary<string, int>();
            ;
            var curentQuantity = 0;
            var curentMaterial = "";
            while (true)
            {
                var materials = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < materials.Length - 1; i+=2)
                {

                    curentQuantity = int.Parse(materials[i]);
                    curentMaterial = materials[i + 1];

                    
                    if (dictionaryOfMaterials.ContainsKey(curentMaterial))
                    {
                        dictionaryOfMaterials[curentMaterial] += curentQuantity;
                        if (dictionaryOfMaterials[curentMaterial] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(curentMaterial))
                        {
                            junk[curentMaterial] = 0;
                        }
                        junk[curentMaterial] += curentQuantity;
                    }
                }
                
                if (dictionaryOfMaterials["shards"] >= 250)
                {
                    Console.WriteLine($"Shadowmourne obtained!");
                    dictionaryOfMaterials["shards"] -= 250;
                    foreach (var material in dictionaryOfMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"{material.Key}: {material.Value}");
                    }
                    foreach (var item in junk.OrderBy(j => j.Key))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    break;
                }
                else if (dictionaryOfMaterials["fragments"] >= 250)
                {
                    Console.WriteLine($"Valanyr obtained!");
                    dictionaryOfMaterials["fragments"] -= 250;
                    foreach (var material in dictionaryOfMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"{material.Key}: {material.Value}");
                    }
                    foreach (var item in junk.OrderBy(j => j.Key))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    break;
                }
                else if (dictionaryOfMaterials["motes"] >= 250)
                {
                    Console.WriteLine($"Dragonwrath obtained!");
                    dictionaryOfMaterials["motes"] -= 250;
                    foreach (var material in dictionaryOfMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"{material.Key}: {material.Value}");
                    }
                    foreach (var item in junk.OrderBy(j => j.Key))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    break;

                }
            }
            
        }
    }
}

