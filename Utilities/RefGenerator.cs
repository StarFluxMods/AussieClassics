using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using KitchenData;
using KitchenLib.Customs;
using UnityEngine;

namespace AussieClassics.Utilities
{
    public static class RefGenerator
    {
        private static Type GetGDOType(Type type)
        {
            return type.Namespace.Contains("KitchenLib") ? type : GetGDOType(type.BaseType);
        }

        public static void GenerateGDOReferences(Assembly assembly, string file, string prefix = "", string protectionLevel = "public")
        {
            List<string> lines = new List<string>();
            Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(CustomGameDataObject).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    if (!categories.ContainsKey(GetGDOType(type).Name.Replace("Custom", "")))
                    {
                        categories.Add(GetGDOType(type).Name.Replace("Custom", ""), new List<string>());
                    }

                    categories[GetGDOType(type).Name.Replace("Custom", "")].Add($"{protectionLevel} static {GetGDOType(type).Name.Replace("Custom", "")} {prefix}{type.Name} => ({GetGDOType(type).Name.Replace("Custom", "")})GDOUtils.GetCustomGameDataObject<{type.Name}>().GameDataObject;");
                }
            }

            foreach (string category in categories.Keys)
            {
                lines.Add("#region " + category);
                foreach (string codeLine in categories[category])
                {
                    lines.Add(codeLine);
                }

                lines.Add("#endregion");
                lines.Add("");
            }

            File.WriteAllLines(file, lines.ToArray());
            Application.Quit();
        }

        public static string Cleanup(this string target)
        {
            return target.Replace(",", "").Replace("\n", "\\n");
        }

        public static void LocalisationDumper(string directory)
        {
            List<string> recipes = new List<string>();
            List<string> unlocks = new List<string>();

            recipes.Add("ID,InternalName,Name,Recipe");
            unlocks.Add("ID,InternalName,Name,Description,FlavourText");
            
            foreach (Dish dish in GameData.Main.Get<Dish>())
            {
                string id = dish.ID.ToString().Cleanup();
                string internalName = dish.name.Cleanup();
                string name = dish.Name.Cleanup();
                string recipe = GameData.Main.GlobalLocalisation[dish.ID].Cleanup();
                recipes.Add($"{id},{internalName},{name},{recipe}");
            }
            
            foreach (Unlock unlock in GameData.Main.Get<Unlock>())
            {
                string id = unlock.ID.ToString().Cleanup();
                string internalName = unlock.name.Cleanup();
                string name = unlock.Name.Cleanup();
                string description = unlock.Description.Cleanup();
                string flavortext = unlock.FlavourText.Cleanup();
                unlocks.Add($"{id},{internalName},{name},{description},{flavortext}");
            }

            if (!Directory.Exists(directory)) 
                Directory.CreateDirectory(directory);
            
            File.WriteAllLines(Path.Combine(directory, "recipes.csv"), recipes);
            File.WriteAllLines(Path.Combine(directory, "unlocks.csv"), unlocks);
        }
    }
}