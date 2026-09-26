using MiraAPI.Colors;
using UnityEngine;

namespace MaxsColours;

[RegisterCustomColors]
public static class CustomColours
{
    public static CustomColor Voltron { get; } =
        new("Blush", new Color32(198, 163, 162, 255))
        {
            ColorBrightness = CustomColorBrightness.Darker,
        };

    public static CustomColor Mogol { get; } =
        new("Mogol", new Color32(124, 100, 133, 255))
        {
            ColorBrightness = CustomColorBrightness.Lighter,
        };

    public static CustomColor WetSand { get; } =
        new("Wet Sand", new Color32(176, 178, 130, 255))
        {
            ColorBrightness = CustomColorBrightness.Lighter,
        };

    public static CustomColor Colour { get; } =
        new("Colour", new Color32(253, 240, 0, 255))
        {
            ColorBrightness = CustomColorBrightness.Lighter,
        };
}
