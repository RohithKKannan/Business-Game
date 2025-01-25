using UnityEngine;

public class LocationCardViewFactory : ILocationCardViewFactory
{
    private readonly LocationCardViewPrefabContainer locationCardViewPrefabContainer;

    public LocationCardViewFactory(LocationCardViewPrefabContainer locationCardViewPrefabContainer)
    {
        this.locationCardViewPrefabContainer = locationCardViewPrefabContainer;
    }

    public ILocationCardView CreateLocationCardView(LocationData locationData, Transform parent)
    {
        GameObject cardView = locationCardViewPrefabContainer.GetPrefab(locationData.LocationType);
        cardView.name = locationData.Name;
        return GameObject.Instantiate(cardView, parent).GetComponent<ILocationCardView>(); ;
    }
}