public class LocationCardPresenter
{
    private LocationManager locationManager;
    private LocationCardModel locationCardModel;
    private LocationCardView locationCardView;

    public LocationCardPresenter(LocationManager locationManager, LocationCardView locationCardView, Location location)
    {
        this.locationManager = locationManager;
        this.locationCardModel = new LocationCardModel(location);
        this.locationCardView = locationCardView;

        UpdateCardView();
    }

    private void UpdateCardView()
    {
        locationCardView.UpdateLocationType(locationCardModel.Location.LocationData.LocationType);
        locationCardView.UpdateLocationName(locationCardModel.Location.LocationData.Name);
        locationCardView.UpdateLocationRent(locationCardModel.Location.LocationData.Rent);
        locationCardView.UpdateRentsWithHouses(locationCardModel.Location.RentsWithHouses);
        locationCardView.UpdateRentWithHotel(locationCardModel.Location.RentWithHotel);
        locationCardView.UpdateMortgageValue(locationCardModel.Location.LocationData.MortgageValue);
        locationCardView.UpdateHouseCost(locationCardModel.Location.LocationData.UpgradeCost);
        locationCardView.UpdateHotelCost(locationCardModel.Location.LocationData.UpgradeCost);
    }
}