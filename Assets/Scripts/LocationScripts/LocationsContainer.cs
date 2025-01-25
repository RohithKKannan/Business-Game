using System;
using System.Collections.Generic;
using UnityEngine;
using NorskaLib.Spreadsheets;

[Serializable]
public class LocationsContent
{
    [SpreadsheetPage("Locations")]
    public List<LocationData> locations;
}

[CreateAssetMenu(fileName = "LocationContainer", menuName = "Containers/New LocationContainer")]
public class LocationsContainer : SpreadsheetsContainerBase
{
    [SpreadsheetContent]
    [SerializeField] private LocationsContent locationsContent;

    public LocationsContent LocationsContent => locationsContent;
}
