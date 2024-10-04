import datetime
from astral import LocationInfo
from astral.sun import sun
import ephem
import math

def natural_light_by_season(latitude, longitude, date=None):
    """
    Estimates natural light intensity per season, considering both sunlight 
    during the day and moonlight at night.

    Args:
        latitude: The latitude of the location (degrees).
        longitude: The longitude of the location (degrees).
        date: Optional datetime.date object to calculate for a specific date. 
              If None, uses the current date.

    Returns:
        A dictionary mapping season names to estimated light intensity levels (0-100).
    """

    if date is None:
        date = datetime.date.today()

    # Get sun information for the location and date
    location = LocationInfo("", "", "UTC", latitude, longitude)
    s = sun(location.observer, date=date)

    # Determine if it's day or night
    now = datetime.datetime.now(location.tzinfo)
    is_night = now < s['sunrise'] or now > s['sunset']

    # Determine season based on month
    month = date.month
    if 3 <= month <= 5:
        season = "Spring"
    elif 6 <= month <= 8:
        season = "Summer"
    elif 9 <= month <= 11:
        season = "Autumn"
    else:
        season = "Winter"

    if not is_night:
        # Daylight calculations
        day_length_hours = (s['sunset'] - s['sunrise']).total_seconds() / 3600

        light_levels = {
            "Spring": 50 + (day_length_hours - 12) * 2, 
            "Summer": 90 + (day_length_hours - 12) * 1,  
            "Autumn": 40 + (day_length_hours - 12) * 2, 
            "Winter": 20 + (day_length_hours - 12) * 3   
        }

        # Adjust based on latitude
        latitude_factor = 1 - abs(latitude) / 90 
        for season in light_levels:
            light_levels[season] *= latitude_factor

        # Simplified weather adjustment (replace with actual weather data if available)
        weather_factor = 0.8  # Example: cloudy day reduces light by 20%
        for season in light_levels:
            light_levels[season] *= weather_factor

        # Solar elevation adjustment
        solar_elevation = calculate_solar_elevation(latitude, longitude, now)
        elevation_factor = math.sin(math.radians(solar_elevation))
        light_levels[season] *= elevation_factor

    else:
        # Moonlight calculations
        observer = ephem.Observer()
        observer.lat = str(latitude)
        observer.lon = str(longitude)
        observer.date = date

        moon = ephem.Moon()
        moon.compute(observer)

        # Simplified moonlight estimation based on moon phase
        illuminated_fraction = moon.phase / 100  # 0 (new moon) to 1 (full moon)
        light_levels = {
            "Spring": illuminated_fraction * 5,  # Moonlight is generally much weaker than sunlight
            "Summer": illuminated_fraction * 5,
            "Autumn": illuminated_fraction * 5,
            "Winter": illuminated_fraction * 5
        }

    # Ensure light levels are within 0-100 range
    light_levels[season] = max(0, min(100, light_levels[season]))

    return {season: light_levels[season]}

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

# Test for daytime
day_time = datetime.datetime(2023, 6, 21, 12, 0)  # Noon on summer solstice
light_estimate = natural_light_by_season(latitude, longitude, day_time.date())
print(f"Daytime (Summer Solstice):")
for season, intensity in light_estimate.items():
    print(f"{season}: {intensity:.1f}")

# Test for nighttime
night_time = datetime.datetime(2023, 6, 21, 0, 0)  # Midnight on summer solstice
light_estimate = natural_light_by_season(latitude, longitude, night_time.date())
print(f"\nNighttime (Summer Solstice):")
for season, intensity in light_estimate.items():
    print(f"{season}: {intensity:.1f}")

# Calculate for each season
for month in [3, 6, 9, 12]:  # March, June, September, December
    date = datetime.date(2023, month, 21)
    day_light = natural_light_by_season(latitude, longitude, date)
    night_light = natural_light_by_season(latitude, longitude, date)
    print(f"\n{date.strftime('%Y-%m-%d')}:")
    for season, intensity in day_light.items():
        print(f"{season} (Day): {intensity:.1f}")
    for season, intensity in night_light.items():
        print(f"{season} (Night): {intensity:.1f}")