using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LocationManager locationManager;

    public void Awake()
    {
        locationManager.Init(this);
    }
}