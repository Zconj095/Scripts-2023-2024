import datetime
from astral import LocationInfo
from astral.sun import sun
import ephem
import math

def natural_light_by_season_and_birth(latitude, longitude, birth_season, birth_time, date=None):
    """
    Estimates natural light intensity per season based on seasonal patterns, 
    night cycles, day length, and birth season/time, with separate patterns 
    for day and night.

    Args:
        latitude: The latitude of the location (degrees).
        longitude: The longitude of the location (degrees).
        birth_season: The season in which the individual was born ("Spring", "Summer", "Autumn", "Winter").
        birth_time: The approximate time of day the individual was born ("Day", "Night").
        date: Optional datetime.date object to calculate for a specific date. 
              If None, uses the current date.

    Returns:
        A dictionary mapping season names to estimated light intensity levels (0-100),
        with separate values for day and night.
    """

    if date is None:
        date = datetime.date.today()

    # Get sun information for the location and date
    location = LocationInfo("", "", "UTC", latitude, longitude)
    s = sun(location.observer, date=date)

    # Determine if it's day or night
    now = datetime.datetime.now(location.tzinfo)
    is_night = now < s['sunrise'] or now > s['sunset']

    # Base light levels based on season and birth season/time
    base_light_levels_day = {
        "Spring": {"Spring": 60, "Summer": 70, "Autumn": 50, "Winter": 40},
        "Summer": {"Spring": 70, "Summer": 80, "Autumn": 60, "Winter": 50},
        "Autumn": {"Spring": 50, "Summer": 60, "Autumn": 40, "Winter": 30},
        "Winter": {"Spring": 40, "Summer": 50, "Autumn": 30, "Winter": 20}
    }

    base_light_levels_night = {
        "Spring": {"Spring": 30, "Summer": 20, "Autumn": 40, "Winter": 50},
        "Summer": {"Spring": 20, "Summer": 10, "Autumn": 30, "Winter": 40},
        "Autumn": {"Spring": 40, "Summer": 30, "Autumn": 50, "Winter": 60},
        "Winter": {"Spring": 50, "Summer": 40, "Autumn": 60, "Winter": 70}
    }

    # Select base levels based on current time (day/night) and birth time
    if is_night:
        if birth_time == "Day":
            base_light_levels = {season: {s: levels[s] * 0.8 for s in levels} for season, levels in base_light_levels_night.items()}
        else:
            base_light_levels = base_light_levels_night
    else:
        if birth_time == "Night":
            base_light_levels = {season: {s: levels[s] * 0.8 for s in levels} for season, levels in base_light_levels_day.items()}
        else:
            base_light_levels = base_light_levels_day

    # Get base level for the current season based on birth season
    light_levels = base_light_levels[birth_season]

    if not is_night:
        # Daylight adjustments
        day_length_hours = (s['sunset'] - s['sunrise']).total_seconds() / 3600
        for season in light_levels:
            light_levels[season] += (day_length_hours - 12) * 2  # Adjust as needed

        # Latitude and weather adjustments
        latitude_factor = 1 - abs(latitude) / 90 
        weather_factor = 0.8  # Example: cloudy day reduces light by 20%
        for season in light_levels:
            light_levels[season] *= latitude_factor * weather_factor

        # Solar elevation adjustment
        solar_elevation = calculate_solar_elevation(latitude, longitude, now)
        elevation_factor = math.sin(math.radians(solar_elevation))
        for season in light_levels:
            light_levels[season] *= elevation_factor

    else:
        # Moonlight calculations
        observer = ephem.Observer()
        observer.lat = str(latitude)
        observer.lon = str(longitude)
        observer.date = date

        moon = ephem.Moon()
        moon.compute(observer)

        illuminated_fraction = moon.phase / 100 
        for season in light_levels:
            light_levels[season] += illuminated_fraction * 20  # Adjust as needed

    # Ensure light levels are within 0-100 range
    for season in light_levels:
        light_levels[season] = max(0, min(100, light_levels[season]))

    return light_levels

def calculate_solar_elevation(latitude, longitude, time):
    """
    Calculate the solar elevation angle for a given location and time.
    
    Args:
        latitude: The latitude of the location (degrees).
        longitude: The longitude of the location (degrees).
        time: A datetime object representing the time for which to calculate the solar elevation.
    
    Returns:
        The solar elevation angle in degrees.
    """
    observer = ephem.Observer()
    observer.lat = str(latitude)
    observer.lon = str(longitude)
    observer.date = time

    sun = ephem.Sun()
    sun.compute(observer)

    return math.degrees(sun.alt)

# Example usage
latitude = 40.7128  # New York City
longitude = -74.0060
birth_season = "Summer"
birth_time = "Night"

# Test for daytime
day_time = datetime.datetime(2023, 6, 21, 12, 0)  # Noon on summer solstice
light_estimates = natural_light_by_season_and_birth(latitude, longitude, birth_season, birth_time, day_time.date())
print(f"Daytime (Summer Solstice):")
for season, intensity in light_estimates.items():
    print(f"{season}: {intensity:.1f}")

# Test for nighttime
night_time = datetime.datetime(2023, 6, 21, 0, 0)  # Midnight on summer solstice
light_estimates = natural_light_by_season_and_birth(latitude, longitude, birth_season, birth_time, night_time.date())
print(f"\nNighttime (Summer Solstice):")
for season, intensity in light_estimates.items():
    print(f"{season}: {intensity:.1f}")

# Calculate for each season
for month in [3, 6, 9, 12]:  # March, June, September, December
    date = datetime.date(2023, month, 21)
    day_light = natural_light_by_season_and_birth(latitude, longitude, birth_season, birth_time, date)
    night_light = natural_light_by_season_and_birth(latitude, longitude, birth_season, birth_time, date)
    print(f"\n{date.strftime('%Y-%m-%d')}:")
    for season, intensity in day_light.items():
        print(f"{season} (Day): {intensity:.1f}")
    for season, intensity in night_light.items():
        print(f"{season} (Night): {intensity:.1f}")