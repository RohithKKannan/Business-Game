using UnityEngine;

public class UtilityService : MonoBehaviour
{
    public static UtilityService Instance;

    [SerializeField] private ColorCodeColorContainer colorCodeColorContainer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this);
    }

    public Color GetColorForColorCode(ColorCode colorCode)
    {
        if (colorCodeColorContainer != null)
            return colorCodeColorContainer.GetColorForColorCode(colorCode);

        return Color.white;
    }
}