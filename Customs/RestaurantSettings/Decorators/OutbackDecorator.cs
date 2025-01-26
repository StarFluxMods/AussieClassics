using System.Collections.Generic;
using AussieClassics.Utilities;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using UnityEngine;

namespace AussieClassics.Customs.RestaurantSettings.Decorators
{
    public class OutbackDecorator : Decorator
    {
        public override bool Decorate(Room room)
        {
            DecorationsConfiguration decorationsConfiguration = Configuration as DecorationsConfiguration;
            if (decorationsConfiguration != null)
            {
                Bounds innerBounds = Blueprint.GetBounds();
                Bounds blacklistBounds = innerBounds;
                Bounds roadBounds = new Bounds(new Vector3(innerBounds.min.x - 4.5f, innerBounds.center.y, 0), new Vector3(5,60,0));
                blacklistBounds.Expand(new Vector3(2.5f, 2));
                blacklistBounds.Encapsulate(new Vector3(blacklistBounds.center.x, blacklistBounds.min.y - 10f));
                Bounds outerBounds = innerBounds;
                outerBounds.Expand(new Vector3(((innerBounds.max.x - innerBounds.min.x) * 1.25f), ((innerBounds.max.y - innerBounds.min.y) * 1.25f)));
                Vector3 frontDoor = Blueprint.GetFrontDoor();
                NewPiece(decorationsConfiguration.Ground, 0, 0);
                
                for (float x = outerBounds.min.x; x < outerBounds.max.x; x++)
                {
                    for (float y = outerBounds.min.y; y < outerBounds.max.y; y++)
                    {
                        if (!blacklistBounds.Contains(new Vector3(x, y)) && !roadBounds.Contains(new Vector3(x, y)))
                        {
                            foreach (DecorationsConfiguration.Scatter scatter in decorationsConfiguration.Scatters)
                            {
                                if (Random.value < scatter.Probability)
                                {
                                    NewPiece(scatter.Appliance, x, y);
                                }
                            }
                        }
                    }
                }

                if (decorationsConfiguration.IncludeRoad)
                {
                    NewPiece(GDOReferences.RoadWithCars, innerBounds.min.x - 0.5f, 0);
                }

                NewPiece(GDOReferences.RoughTerrainLeft, innerBounds.min.x - 0.5f, 0);
                NewPiece(GDOReferences.RoughTerrainRight, innerBounds.max.x + 0.5f, 0);
                
                float num6 = ((frontDoor.x < 3f) ? (frontDoor.x + 1f) : (frontDoor.x - 1f));
                NewPiece(AssetReference.Nameplate, num6, innerBounds.min.y - 1f);
                NewPiece(AssetReference.OutdoorMovementBlocker, innerBounds.min.x - 1f, innerBounds.min.y - 1f);
                NewPiece(AssetReference.OutdoorMovementBlocker, innerBounds.min.x - 1f, innerBounds.min.y - 2f);
                NewPiece(AssetReference.OutdoorMovementBlocker, innerBounds.max.x + 1f, innerBounds.min.y - 1f);
                NewPiece(AssetReference.OutdoorMovementBlocker, innerBounds.max.x + 1f, innerBounds.min.y - 2f);
                NewPiece(Profile.ExternalBin, frontDoor.x, frontDoor.z - 3f);
                return true;
            }
            return false;
        }

        public void MarkCorners(Bounds bounds, Appliance appliance)
        {
            NewPiece(appliance, bounds.min.x, bounds.min.y);
            NewPiece(appliance, bounds.max.x, bounds.min.y);
            NewPiece(appliance, bounds.min.x, bounds.max.y);
            NewPiece(appliance, bounds.max.x, bounds.max.y);
        }

        public class DecorationsConfiguration : IDecorationConfiguration
        {
            public IDecorator Decorator => new OutbackDecorator();

            public List<Scatter> Scatters = new List<Scatter>();
            public Appliance Ground;
            public bool IncludeRoad;
            public struct Scatter
            {
                public float Probability;
                public Appliance Appliance;
            }
        }
    }
}