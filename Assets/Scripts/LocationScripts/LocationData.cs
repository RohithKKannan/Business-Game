using System;

/// <summary>
/// Base location data
/// </summary>
[Serializable]
public class LocationData
{
    public int LocationID;
    public string Name;
    public LocationType LocationType;
    public ColorCode ColorCode;
    public float Cost;
    public float Rent;
    public float UpgradeCost;
    public float UpgradeRentMultiplier;
    public int MaxUpgrades;
    public float MortgageValue;
}

public enum LocationType
{
    ColorCoded,
    Utility,
    Railroad
}

public enum ColorCode
{
    None,
    Brown,
    LightBlue,
    Pink,
    Orange,
    Red,
    Yellow,
    Green,
    DarkBlue,
}
