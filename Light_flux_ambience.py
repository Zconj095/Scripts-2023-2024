def natural_light_by_season(latitude):
    """
    Estimates natural light intensity per season based on seasonal patterns and night cycles.

    Args:
        latitude: The latitude of the location (degrees).

    Returns:
        A dictionary mapping season names to estimated light intensity levels (0-100).
    """

    # Basic estimations based on typical seasonal patterns
    light_levels = {
        "Spring": 50,  # Increasing daylight, variable weather
        "Summer": 90,  # Maximum daylight, clear skies
        "Autumn": 40,  # Decreasing daylight, variable weather
        "Winter": 20   # Minimum daylight, variable weather
    }

    # Adjust based on latitude
    latitude_factor = 1 - abs(latitude) / 90  # Closer to equator, less variation
    for season in light_levels:
        light_levels[season] *= latitude_factor

    return light_levels

# Example usage
latitude = 41.0  # Findlay, Ohio
light_estimates = natural_light_by_season(latitude)
for season, intensity in light_estimates.items():
    print(f"{season}: {intensity:.1f}")