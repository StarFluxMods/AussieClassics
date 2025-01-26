using System.Collections.Generic;
using KitchenLib.Utils;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AussieClassics.Views.Local
{
    public class CarView : MonoBehaviour
    {
        public Animator animator;
        public GameObject Car;

        private Dictionary<Renderer, List<int>> BodyRenderers = new Dictionary<Renderer, List<int>>();
        private Dictionary<Renderer, List<int>> BumperRenderers = new Dictionary<Renderer, List<int>>();
        
        private static readonly int ShouldDrive = Animator.StringToHash("ShouldDrive");
        private static readonly int CarSpeed = Animator.StringToHash("CarSpeed");

        private void Awake()
        {
            if (Car == null) return;
            
            BodyRenderers.Clear();
            BumperRenderers.Clear();
            
            foreach (Renderer renderer in Car.GetComponentsInChildren<Renderer>())
            {
                for (var i = 0; i < renderer.materials.Length; i++)
                {
                    var material = renderer.materials[i];
                    if (material.name.Contains("DUMMY_BODY"))
                    {
                        if (!BodyRenderers.ContainsKey(renderer))
                            BodyRenderers.Add(renderer, new List<int>());
                        BodyRenderers[renderer].Add(i);
                    }

                    if (material.name.Contains("DUMMY_BUMPER"))
                    {
                        if (!BumperRenderers.ContainsKey(renderer))
                            BumperRenderers.Add(renderer, new List<int>());
                        BumperRenderers[renderer].Add(i);
                    }
                }
            }
        }
        
        private void FixedUpdate()
        {
            if (animator != null)
            {
                if (animator.GetBool(ShouldDrive))
                {
                    animator.SetBool(ShouldDrive, false);
                }
            }

            if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle")
            {
                float result = Random.value;
                if (result < 0.01f)
                {
                    (Material, Material) materialPair = GetMaterialPair();
                    UpdateMaterials(materialPair.Item1, materialPair.Item2);
                    DriveCar();
                }
            }
        }
        private void DriveCar()
        {
            if (animator == null) return;
            
            animator.SetBool(ShouldDrive, true);
            animator.SetFloat(CarSpeed, Random.Range(1, 3));
        }

        private void UpdateMaterials(Material Body, Material Bumper)
        {
            foreach (Renderer renderer in BodyRenderers.Keys)
            {
                List<Material> materials = new List<Material>();
                for (var i = 0; i < renderer.materials.Length; i++)
                {
                    var material = renderer.materials[i];
                    if (BodyRenderers[renderer].Contains(i))
                    {
                        materials.Add(Body);
                    }
                    else
                    {
                        materials.Add(material);
                    }
                }
                renderer.materials = materials.ToArray();
            }
            
            foreach (Renderer renderer in BumperRenderers.Keys)
            {
                List<Material> materials = new List<Material>();
                for (var i = 0; i < renderer.materials.Length; i++)
                {
                    var material = renderer.materials[i];
                    if (BumperRenderers[renderer].Contains(i))
                    {
                        materials.Add(Bumper);
                    }
                    else
                    {
                        materials.Add(material);
                    }
                }
                renderer.materials = materials.ToArray();
            }
        }

        private static List<(Material, Material)> materialPairs = new List<(Material, Material)>
        {
            (MaterialUtils.GetExistingMaterial("Balloon - Red"), MaterialUtils.GetExistingMaterial("Book Cover - Red")),
            (MaterialUtils.GetExistingMaterial("Balloon - Blue"), MaterialUtils.GetExistingMaterial("Book Cover - Blue")),
            (MaterialUtils.GetExistingMaterial("Balloon - Green"), MaterialUtils.GetExistingMaterial("Book Cover - Green")),
            (MaterialUtils.GetExistingMaterial("Coffee - Latte"), MaterialUtils.GetExistingMaterial("Coffee Bean 1")),
            (MaterialUtils.GetExistingMaterial("Lettuce"), MaterialUtils.GetExistingMaterial("Lily Pad Green")),
            (MaterialUtils.GetExistingMaterial("Tomato"), MaterialUtils.GetExistingMaterial("Tomato Soup")),
            (MaterialUtils.GetExistingMaterial("Crystal - Purple Rock"), MaterialUtils.GetExistingMaterial("Crystal - Purple")),
            (MaterialUtils.GetExistingMaterial("Clothing Purple"), MaterialUtils.GetExistingMaterial("Clothing Medium Purple")),
        };

        private (Material, Material) GetMaterialPair()
        {
            return materialPairs[Random.Range(0, materialPairs.Count - 1)];
        }
    }
}