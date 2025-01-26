using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using Unity.Transforms;
using UnityEngine;

namespace AussieClassics.Utilities
{
    public class CustomPizzaIngredient
    {

        private static FieldInfo _Sets = ReflectionUtils.GetField<ItemGroup>("Sets");
        private static FieldInfo _Processes = ReflectionUtils.GetField<Item>("Processes");
        private static FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
        
        public static void AddPizzaIngredientToPrefabs(GameData gameData, GameObject rawPrefab, Item rawItem, GameObject cookedPrefab, Item cookedItem, string ColorBlindTag)
        {
            if (gameData.TryGet(ItemGroupReferences.PizzaRaw, out ItemGroup PizzaRaw))
                {
                    GameObject ingredientRaw1 = GameObject.Instantiate(rawPrefab);
                    GameObject ingredientRaw2 = GameObject.Instantiate(rawPrefab);
                    GameObject ingredientRaw3 = GameObject.Instantiate(rawPrefab);
                    GameObject ingredientRaw4 = GameObject.Instantiate(rawPrefab);
                    
                    ingredientRaw1.transform.SetParent(PizzaRaw.Prefab.GetChild("Pizza Slice").transform);
                    ingredientRaw1.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientRaw1.transform.localRotation = Quaternion.identity;

                    ingredientRaw2.transform.SetParent(PizzaRaw.Prefab.GetChild("Pizza Slice (1)").transform);
                    ingredientRaw2.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientRaw2.transform.localRotation = Quaternion.identity;

                    ingredientRaw3.transform.SetParent(PizzaRaw.Prefab.GetChild("Pizza Slice (2)").transform);
                    ingredientRaw3.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientRaw3.transform.localRotation = Quaternion.identity;

                    ingredientRaw4.transform.SetParent(PizzaRaw.Prefab.GetChild("Pizza Slice (3)").transform);
                    ingredientRaw4.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientRaw4.transform.localRotation = Quaternion.identity;

                    ItemGroupView itemGroupView = PizzaRaw.Prefab.GetComponent<ItemGroupView>();

                    itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                    {
                        Objects = new List<GameObject>
                        {
                            ingredientRaw1,
                            ingredientRaw2,
                            ingredientRaw3,
                            ingredientRaw4,
                        },
                        DrawAll = true,
                        Item = rawItem
                    });
                    
                    List<ItemGroupView.ColourBlindLabel> ComponentLabels = (List<ItemGroupView.ColourBlindLabel>)_ComponentLabels.GetValue(itemGroupView);
                    ComponentLabels.Add(new ItemGroupView.ColourBlindLabel
                    {
                        Item = rawItem,
                        Text = ColorBlindTag
                    });
                    _ComponentLabels.SetValue(itemGroupView, ComponentLabels);

                    List<ItemGroup.ItemSet> Sets = (List<ItemGroup.ItemSet>)_Sets.GetValue(PizzaRaw);
                    Sets.Add(new ItemGroup.ItemSet
                    {
                        Items = new List<Item>
                        {
                            rawItem
                        },
                        Min = 0,
                        Max = 1,
                        RequiresUnlock = true
                    });
                    _Sets.SetValue(PizzaRaw, Sets);
                }
            
            if (gameData.TryGet(ItemGroupReferences.PizzaCooked, out ItemGroup PizzaCooked))
                {
                    GameObject ingredientCooked1 = GameObject.Instantiate(cookedPrefab);
                    GameObject ingredientCooked2 = GameObject.Instantiate(cookedPrefab);
                    GameObject ingredientCooked3 = GameObject.Instantiate(cookedPrefab);
                    GameObject ingredientCooked4 = GameObject.Instantiate(cookedPrefab);
                    
                    ingredientCooked1.transform.SetParent(PizzaCooked.Prefab.GetChild("Pizza Slice").transform);
                    ingredientCooked1.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientCooked1.transform.localRotation = Quaternion.identity;
                    
                    ingredientCooked2.transform.SetParent(PizzaCooked.Prefab.GetChild("Pizza Slice (1)").transform);
                    ingredientCooked2.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientCooked2.transform.localRotation = Quaternion.identity;
                    
                    ingredientCooked3.transform.SetParent(PizzaCooked.Prefab.GetChild("Pizza Slice (2)").transform);
                    ingredientCooked3.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientCooked3.transform.localRotation = Quaternion.identity;
                    
                    ingredientCooked4.transform.SetParent(PizzaCooked.Prefab.GetChild("Pizza Slice (3)").transform);
                    ingredientCooked4.transform.localPosition = new Vector3(0, 0, 0);
                    ingredientCooked4.transform.localRotation = Quaternion.identity;

                    ItemGroupView itemGroupView = PizzaCooked.Prefab.GetComponent<ItemGroupView>();
                    
                    itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                    {
                        Objects = new List<GameObject>
                        {
                            ingredientCooked1,
                            ingredientCooked2,
                            ingredientCooked3,
                            ingredientCooked4,
                        },
                        DrawAll = true,
                        Item = cookedItem
                    });

                    List<ItemGroupView.ColourBlindLabel> ComponentLabels = (List<ItemGroupView.ColourBlindLabel>)_ComponentLabels.GetValue(itemGroupView);
                    ComponentLabels.Add(new ItemGroupView.ColourBlindLabel
                    {
                        Item = cookedItem,
                        Text = ColorBlindTag
                    });
                    _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
                }
            
            if (gameData.TryGet(ItemGroupReferences.PizzaSlice, out ItemGroup PizzaSlice))
            {
                GameObject ingredientCooked1 = GameObject.Instantiate(cookedPrefab);
                    
                ingredientCooked1.transform.SetParent(PizzaSlice.Prefab.transform);
                ingredientCooked1.transform.localPosition = new Vector3(0, 0, 0);
                ingredientCooked1.transform.localRotation = Quaternion.identity;

                ItemGroupView itemGroupView = PizzaSlice.Prefab.GetComponent<ItemGroupView>();
                    
                itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                {
                    GameObject = ingredientCooked1,
                    DrawAll = true,
                    Item = cookedItem
                });
            }
                
            if (gameData.TryGet(ItemGroupReferences.PizzaPlated, out ItemGroup PizzaPlated))
            {
                GameObject ingredientCooked1 = GameObject.Instantiate(cookedPrefab);
                    
                ingredientCooked1.transform.SetParent(PizzaPlated.Prefab.GetChild("Pizza Slice").transform);
                ingredientCooked1.transform.localPosition = new Vector3(0, 0, 0);
                ingredientCooked1.transform.localRotation = Quaternion.identity;

                ItemGroupView itemGroupView = PizzaPlated.Prefab.GetComponent<ItemGroupView>();
                    
                itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                {
                    GameObject = ingredientCooked1,
                    DrawAll = true,
                    Item = cookedItem
                });
                    
                List<ItemGroupView.ColourBlindLabel> ComponentLabels = (List<ItemGroupView.ColourBlindLabel>)_ComponentLabels.GetValue(itemGroupView);
                ComponentLabels.Add(new ItemGroupView.ColourBlindLabel
                {
                    Item = cookedItem,
                    Text = ColorBlindTag
                });
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
                    
                List<ItemGroup.ItemSet> Sets = (List<ItemGroup.ItemSet>)_Sets.GetValue(PizzaPlated);
                Sets.Add(new ItemGroup.ItemSet
                {
                    Items = new List<Item>
                    {
                        cookedItem
                    },
                    Min = 0,
                    Max = 1,
                    RequiresUnlock = true
                });
                _Sets.SetValue(PizzaPlated, Sets);
            }
        }
    }
}