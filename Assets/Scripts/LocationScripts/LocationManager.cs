using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private LocationsContainer locationsContainer;

    private GameManager gameManager;

    private List<Location> locations = new();

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;

        InitializeLocations();
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
}