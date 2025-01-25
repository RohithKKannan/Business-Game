using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Data for a location during gameplay
/// </summary>
[Serializable]
public class Location
{
    private LocationData locationData;
    private string owner;
    private int currentUpgrade;
    private bool isMortgaged;

    private List<float> rentsWithHouses = new();
    private float rentWithHotel;

    private List<float> railroadRents = new();

    public Location(LocationData locationData)
    {
        this.locationData = locationData;
        this.owner = "";
        this.currentUpgrade = 0;
        this.isMortgaged = false;
        SetHouseBasedRent();
        SetRentWithHotel();
        SetRailroadRents();
    }

    private void SetHouseBasedRent()
    {
        for (int i = 0; i < 3; i++)
        {
            rentsWithHouses.Add(locationData.Rent * locationData.UpgradeRentMultiplier * (i + 1));
        }
    }

    private void SetRentWithHotel()
    {
        rentWithHotel = locationData.Rent * locationData.UpgradeRentMultiplier * 5;
    }

    private void SetRailroadRents()
    {
        railroadRents.Add(locationData.Rent);

        for (int i = 1; i < 4; i++)
        {
            railroadRents.Add(railroadRents[i - 1] * 2);
        }
    }

    public LocationData LocationData => locationData;
    public string Owner => owner;
    public int CurrentUpgrade => currentUpgrade;
    public bool IsMortgaged => isMortgaged;
    public List<float> RentsWithHouses => rentsWithHouses;
    public float RentWithHotel => rentWithHotel;
    public List<float> RailroadRents => railroadRents;

    public void SetOwner(string owner) => this.owner = owner;
    public void SetCurrentUpgrade(int currentUpgrade) => this.currentUpgrade = currentUpgrade;
    public void SetIsMorgaged(bool isMortgaged) => this.isMortgaged = isMortgaged;
}