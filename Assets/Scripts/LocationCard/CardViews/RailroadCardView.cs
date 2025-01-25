using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RailroadCardView : MonoBehaviour, ILocationCardView
{
    [SerializeField] private TMP_Text label_LocationName;
    [SerializeField] private TMP_Text label_MortgageValue;
    [SerializeField] private TMP_Text[] label_Rents;

    public void UpdateHotelCost(float upgradeCost)
    {
    }

    public void UpdateHouseCost(float upgradeCost)
    {
    }

    public void UpdateLocationColor(ColorCode colorCode)
    {
    }

    public void UpdateLocationName(string locationName)
    {
        label_LocationName.text = locationName;
    }

    public void UpdateLocationRent(float locationRent)
    {
    }

    public void UpdateMortgageValue(float mortgageValue)
    {
        int mortgage = Mathf.RoundToInt(mortgageValue);
        label_MortgageValue.text = $"Mortgage Value ${mortgage}";
    }

    public void UpdateRailroadRents(List<float> rents)
    {
        for (int i = 0; i < label_Rents.Length; i++)
        {
            label_Rents[i].text = "$" + Mathf.RoundToInt(rents[i]).ToString();
        }
    }

    public void UpdateRentsWithHouses(List<float> rentsWithHouses)
    {
    }

    public void UpdateRentWithHotel(float rentWithHotel)
    {
    }

    public void UpdateUtilityDescription(string description)
    {
    }
}
