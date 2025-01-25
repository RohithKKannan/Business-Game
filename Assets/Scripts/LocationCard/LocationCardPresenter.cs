public class LocationCardPresenter
{
    private LocationManager locationManager;
    private LocationCardModel locationCardModel;
    private ILocationCardView locationCardView;

    public LocationCardPresenter(LocationManager locationManager, ILocationCardView locationCardView, Location location)
    {
        this.locationManager = locationManager;
        this.locationCardModel = new LocationCardModel(location);
        this.locationCardView = locationCardView;

        UpdateCardView();
    }

    private void UpdateCardView()
    {
        locationCardView.UpdateLocationColor(locationCardModel.Location.LocationData.ColorCode);
        locationCardView.UpdateLocationName(locationCardModel.Location.LocationData.Name);
        locationCardView.UpdateLocationRent(locationCardModel.Location.LocationData.Rent);
        locationCardView.UpdateRentsWithHouses(locationCardModel.Location.RentsWithHouses);
        locationCardView.UpdateRentWithHotel(locationCardModel.Location.RentWithHotel);
        locationCardView.UpdateMortgageValue(locationCardModel.Location.LocationData.MortgageValue);
        locationCardView.UpdateHouseCost(locationCardModel.Location.LocationData.UpgradeCost);
        locationCardView.UpdateHotelCost(locationCardModel.Location.LocationData.UpgradeCost);
        locationCardView.UpdateRailroadRents(locationCardModel.Location.RailroadRents);
    }
}