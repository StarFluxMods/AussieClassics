using AussieClassics.Components;
using Kitchen;
using KitchenMods;
using MessagePack;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace AussieClassics.Views
{
    public class KoalaView : UpdatableObjectView<KoalaView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CKoala), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using var entities = Views.ToEntityArray(Allocator.Temp);
                using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

                for (var i = 0; i < views.Length; i++)
                {
                    var view = views[i];

                    if (Require(entities[i], out CKoala cKoala))
                    {
                        ViewData data = new ViewData
                        {
                            AnimationState = 0
                        };
                        float random = Random.value;
                        if (random < 0.01f)
                        {
                            float random2 = Random.value;
                            if (random2 < 0.5f)
                            {
                                data.AnimationState = 1;
                            }
                            else
                            {
                                data.AnimationState = 2;
                            }
                        }
                        SendUpdate(view, data);
                    }
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(1)] public int AnimationState;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<KoalaView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return AnimationState != cached.AnimationState;
            }
        }

        private static readonly int AnimationState = Animator.StringToHash("AnimationState");
        public Animator animator;

        protected override void UpdateData(ViewData view_data)
        {
            animator.SetInteger(AnimationState, view_data.AnimationState);
        }
    }
}