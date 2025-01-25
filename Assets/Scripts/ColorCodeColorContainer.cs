using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorCodeColorContainer", menuName = "Containers/New ColorCodeColorContainer SO")]
public class ColorCodeColorContainer : ScriptableObject
{
    public List<ColorCodeColor> colorCodeColors = new();

    public Color GetColorForColorCode(ColorCode colorCode)
    {
        for (int i = 0; i < colorCodeColors.Count; i++)
        {
            if (colorCodeColors[i].colorCode == colorCode)
                return colorCodeColors[i].color;
        }

        return Color.white;
    }
}

[Serializable]
public class ColorCodeColor
{
    public ColorCode colorCode;
    public Color color;
}