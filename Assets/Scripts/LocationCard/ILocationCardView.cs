using System.Collections.Generic;

public interface ILocationCardView
{
    public void UpdateLocationName(string locationName);
    public void UpdateMortgageValue(float mortgageValue);

    public void UpdateLocationColor(ColorCode colorCode);
    public void UpdateLocationRent(float locationRent);
    public void UpdateRentsWithHouses(List<float> rentsWithHouses);
    public void UpdateRentWithHotel(float rentWithHotel);
    public void UpdateHouseCost(float upgradeCost);
    public void UpdateHotelCost(float upgradeCost);

    public void UpdateRailroadRents(List<float> rents);
}
