using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LocationViewPrefabContainer", menuName = "Containers/New LocationViewPrefabContainer SO")]
public class LocationCardViewPrefabContainer : ScriptableObject
{
    public List<LocationTypeAndViewPrefab> locationTypeAndViewPrefabs = new();

    public GameObject GetPrefab(LocationType locationType)
    {
        foreach (var item in locationTypeAndViewPrefabs)
        {
            if (item.locationType == locationType)
            {
                return item.locationViewPrefab;
            }
        }
        Debug.LogError($"Prefab for LocationType {locationType} not found!");
        return null;
    }
}

[Serializable]
public class LocationTypeAndViewPrefab
{
    public LocationType locationType;
    public GameObject locationViewPrefab;
}