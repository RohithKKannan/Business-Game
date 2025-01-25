using System;

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

    public Location(LocationData locationData)
    {
        this.locationData = locationData;
        this.owner = "";
        this.currentUpgrade = 0;
        this.isMortgaged = false;
    }
}