def discern_light_source(intensity, color_temperature):
    """
    Discerns whether a light source is natural or artificial based on its intensity 
    and color temperature.

    Args:
        intensity (int): The light intensity on a scale of 0-100.
        color_temperature (int): The color temperature of the light in Kelvin.

    Returns:
        str: The estimated light source ("Natural" or "Artificial").
    """

    # Natural light tends to have higher intensity and a wider range of color temperatures
    if intensity > 70 and (color_temperature < 4000 or color_temperature > 6500):
        return "Natural"

    # Artificial light typically has lower intensity and a narrower color temperature range
    elif intensity <= 70 and 2700 <= color_temperature <= 6500:
        return "Artificial"

    # If the values fall outside these ranges, it's inconclusive
    else:
        return "Inconclusive"

# Example usage
light_source_1 = discern_light_source(85, 7000)  # Likely natural (bright, bluish)
light_source_2 = discern_light_source(40, 3000)  # Likely artificial (dim, warm)
light_source_3 = discern_light_source(60, 5000)  # Inconclusive (could be either)

print("Light source 1:", light_source_1)
print("Light source 2:", light_source_2)
print("Light source 3:", light_source_3)