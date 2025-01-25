using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private LocationsContainer locationsContainer;
    [SerializeField] private LocationCardViewPrefabContainer locationCardViewPrefabContainer;
    [SerializeField] private Transform locationCardsParent;

    private GameManager gameManager;
    private LocationCardViewFactory locationCardViewFactory;

    private List<Location> locations = new();
    private List<LocationCardPresenter> locationCards = new();

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;

        locationCardViewFactory = new LocationCardViewFactory(locationCardViewPrefabContainer);

        InitializeLocations();
        CreateCards();
    }

    private void InitializeLocations()
    {
        List<LocationData> tempLocations = locationsContainer.LocationsContent.locations;

        for (int i = 0; i < tempLocations.Count; i++)
        {
            Location location = new Location(tempLocations[i]);
            locations.Add(location);
        }
    }

    private void CreateCards()
    {
        for (int i = 0; i < locations.Count; i++)
        {
            CreateLocationCard(locations[i]);
        }
    }

    public void CreateLocationCard(Location location)
    {
        ILocationCardView locationCardView = locationCardViewFactory.CreateLocationCardView(location.LocationData, locationCardsParent);

        LocationCardPresenter locationCardPresenter = new LocationCardPresenter(this, locationCardView, location);
        locationCards.Add(locationCardPresenter);
    }
}