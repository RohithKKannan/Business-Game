using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private LocationsContainer locationsContainer;
    [SerializeField] private LocationCardView locationCardPrefab;

    [SerializeField] private Transform locationCardHolder;

    private GameManager gameManager;

    private List<Location> locations = new();
    private List<LocationCardPresenter> locationCards = new();

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;

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
        LocationCardView locationCardView = GameObject.Instantiate<LocationCardView>(locationCardPrefab, locationCardHolder);

        LocationCardPresenter locationCardPresenter = new LocationCardPresenter(this, locationCardView, location);
        locationCards.Add(locationCardPresenter);
    }
}