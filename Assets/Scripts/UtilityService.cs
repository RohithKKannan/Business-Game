using System;
using System.Collections.Generic;
using UnityEngine;

public class UtilityService : MonoBehaviour
{
    public static UtilityService Instance;

    [SerializeField] private List<LocationTypeColor> locationTypeColors = new();

    private Dictionary<LocationType, Color> colorForLocationType = new();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this);

        Initialize();
    }

    private void Initialize()
    {
        foreach (LocationTypeColor locationTypeColor in locationTypeColors)
        {
            colorForLocationType.Add(locationTypeColor.locationType, locationTypeColor.color);
        }
    }

    public Color GetColorForLocationType(LocationType locationType)
    {
        if (colorForLocationType.ContainsKey(locationType))
            return colorForLocationType[locationType];

        return Color.white;
    }
}

[Serializable]
public class LocationTypeColor
{
    public LocationType locationType;
    public Color color;
}