using FeralCommon.Config;

namespace FeralBright;

public static class Config
{
    public static class Flashlight
    {
        public static readonly FloatConfig Intensity = new FloatConfig("Flashlight", "Intensity")
            .WithDescription("Determines the intensity of the light. The higher the value, the brighter the light will be.")
            .WithDefaultValue(800F)
            .WithMin(0F)
            .WithMax(25_000F)
            .WithStep(1F);

        public static readonly FloatConfig Range = new FloatConfig("Flashlight", "Range")
            .WithDescription("Determines the range of the light. The higher the value, the further the light will reach.")
            .WithDefaultValue(99_999F)
            .WithMin(0F)
            .WithMax(99_999F)
            .WithStep(1F);

        public static readonly FloatConfig Spread = new FloatConfig("Flashlight", "Spread")
            .WithDescription("Determines the spread of the light. The higher the value, the wider the light will be.")
            .WithDefaultValue(130F)
            .WithMin(1F)
            .WithMax(179F)
            .WithStep(1F);

        public static readonly ColorConfig Color = new ColorConfig("Flashlight", "Color")
            .WithDescription(
                """
                Determines the color of the light. The color is represented as a hexadecimal string.
                An example of a valid color is #FF0000, which represents red.
                You can use a color picker by searching for 'color picker' on your favorite search engine:
                https://www.google.com/search?q=color+picker
                """
            )
            .WithDefaultValue("#FFFFFF");

        public static readonly FloatConfig OffsetX = new FloatConfig("Flashlight", "X Offset")
            .WithDescription(
                """
                Determines the offset of the light on the X-axis. A value of 1 will place the light 1 unit to the right of the player.
                The further the value is from 0, the further left or right the light will be.
                """
            )
            .WithDefaultValue(0F)
            .WithMin(-10F)
            .WithMax(10F)
            .WithStep(0.1F);

        public static readonly FloatConfig OffsetY = new FloatConfig("Flashlight", "Y Offset")
            .WithDescription(
                """
                Determines the offset of the light on the Y-axis. A value of 0 will place the light at the player's eye level.
                The further the value is from 0, the higher or lower the light will be.
                """
            )
            .WithDefaultValue(1.5F)
            .WithMin(-10F)
            .WithMax(10F)
            .WithStep(0.1F);

        public static readonly FloatConfig OffsetZ = new FloatConfig("Flashlight", "Z Offset")
            .WithDescription(
                """
                Determines the offset of the light on the Z-axis. A value of 1 will place the light 1 unit in front of the player.
                The further the value is from 0, the further in front or behind the light will be.
                """
            )
            .WithDefaultValue(0F)
            .WithMin(-10F)
            .WithMax(10F)
            .WithStep(0.1F);

        public static readonly FloatConfig Pitch = new FloatConfig("Flashlight", "Pitch")
            .WithDescription(
                """
                Determines the pitch of the light. The pitch is the side-to-side rotation of the light.
                A negative value will aim the light to the left, while a positive value will aim the light to the right.
                """
            )
            .WithDefaultValue(0F)
            .WithMin(-180F)
            .WithMax(180F)
            .WithStep(1F);

        public static readonly FloatConfig Yaw = new FloatConfig("Flashlight", "Yaw")
            .WithDescription(
                """
                Determines the yaw of the light. The yaw is the up-and-down rotation of the light.
                A negative value will aim the light down, while a positive value will aim the light up.
                """
            )
            .WithDefaultValue(0F)
            .WithMin(-180F)
            .WithMax(180F)
            .WithStep(1F);
    }

    public static class Sun
    {
        public static readonly FloatConfig InsideIntensity = new FloatConfig("Sun", "Inside Intensity")
            .WithDescription(
                """
                Determines the intensity of the sun's light while inside the facility.
                The higher the value, the brighter the light will be.
                """
            )
            .WithDefaultValue(25F)
            .WithMin(0F)
            .WithMax(100F)
            .WithStep(1F);

        public static readonly BoolConfig EnablePositionOverride = new BoolConfig("Sun", "Enable Position Override")
            .WithDescription(
                """
                Determines whether the sun's position should be overridden.
                If enabled, the sun's position will be determined by the 'Position Override' setting.
                """
            )
            .WithDefaultValue(true);

        public static readonly FloatConfig PositionOverride = new FloatConfig("Sun", "Position Override")
            .WithDescription(
                """
                Determines the lifecycle position of the sun. The higher the value, the closer the sun will be to the end of its lifecycle.
                The lowest lifecycle position is 0, but the day actually starts at around 0.092, which represents 7:40AM.
                The lifecycle position at 0.333 represents 12:00PM, which is the highest point of the sun.
                The highest lifecycle position is 1, which represents 12:00AM.
                """
            )
            .WithDefaultValue(0.333F)
            .WithMin(0F)
            .WithMax(1F)
            .WithStep(0.001F);
    }
}
