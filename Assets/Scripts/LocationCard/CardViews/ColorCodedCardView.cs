using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorCodedCardView : MonoBehaviour, ILocationCardView
{
    [SerializeField] private Image image_LocationColor;
    [SerializeField] private TMP_Text label_LocationName;
    [SerializeField] private TMP_Text label_Rent;
    [SerializeField] private TMP_Text[] label_RentsWithHouses;
    [SerializeField] private TMP_Text label_RentWithHotel;
    [SerializeField] private TMP_Text label_MortgageValue;
    [SerializeField] private TMP_Text label_HouseCost;
    [SerializeField] private TMP_Text label_HotelCost;

    public void UpdateLocationColor(ColorCode colorCode)
    {
        image_LocationColor.color = UtilityService.Instance.GetColorForColorCode(colorCode);
    }

    public void UpdateLocationName(string locationName)
    {
        label_LocationName.text = locationName;
    }

    public void UpdateLocationRent(float locationRent)
    {
        label_Rent.text = "$" + Mathf.RoundToInt(locationRent).ToString();
    }

    public void UpdateRentsWithHouses(List<float> rentsWithHouses)
    {
        for (int i = 0; i < 3; i++)
        {
            label_RentsWithHouses[i].text = "$" + Mathf.RoundToInt(rentsWithHouses[i]).ToString();
        }
    }

    public void UpdateRentWithHotel(float rentWithHotel)
    {
        int rent = Mathf.RoundToInt(rentWithHotel);
        label_RentWithHotel.text = $"With Hotel ${rent}";
    }

    public void UpdateMortgageValue(float mortgageValue)
    {
        int mortgage = Mathf.RoundToInt(mortgageValue);
        label_MortgageValue.text = $"Mortgage Value ${mortgage}";
    }

    public void UpdateHouseCost(float upgradeCost)
    {
        int cost = Mathf.RoundToInt(upgradeCost);
        label_HouseCost.text = $"Houses cost ${cost} each";
    }

    public void UpdateHotelCost(float upgradeCost)
    {
        int cost = Mathf.RoundToInt(upgradeCost);
        label_HotelCost.text = $"Hotels ${cost} plus 4 houses";
    }

    public void UpdateRailroadRents(List<float> rents)
    {
    }
}
