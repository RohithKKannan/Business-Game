using System;
using System.Collections.Generic;

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

    public Location(LocationData locationData)
    {
        this.locationData = locationData;
        this.owner = "";
        this.currentUpgrade = 0;
        this.isMortgaged = false;
        SetHouseBasedRent();
        SetRentWithHotel();
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

    public LocationData LocationData => locationData;
    public string Owner => owner;
    public int CurrentUpgrade => currentUpgrade;
    public bool IsMortgaged => isMortgaged;
    public List<float> RentsWithHouses => rentsWithHouses;
    public float RentWithHotel => rentWithHotel;

    public void SetOwner(string owner) => this.owner = owner;
    public void SetCurrentUpgrade(int currentUpgrade) => this.currentUpgrade = currentUpgrade;
    public void SetIsMorgaged(bool isMortgaged) => this.isMortgaged = isMortgaged;
}