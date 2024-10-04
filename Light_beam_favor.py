import datetime
import math
from astral import LocationInfo
from astral.sun import sun

def natural_light_by_season(latitude, longitude, date=None):
    """
    Estimates natural light intensity per season based on seasonal patterns, 
    night cycles, day length, solar elevation, and weather (simplified).

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

    # Calculate day length
    day_length_hours = (s['sunset'] - s['sunrise']).total_seconds() / 3600

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

    # Basic estimations based on typical seasonal patterns, adjusted for day length
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
    noon_elevation = calculate_solar_elevation(latitude, longitude, s['noon'])
    elevation_factor = math.sin(math.radians(noon_elevation))
    light_levels[season] *= elevation_factor

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
    # Convert latitude and longitude to radians
    lat_rad = math.radians(latitude)
    lon_rad = math.radians(longitude)

    # Calculate the day of the year
    day_of_year = time.timetuple().tm_yday

    # Calculate the declination angle
    declination = 23.45 * math.sin(math.radians((360/365) * (day_of_year - 81)))
    declination_rad = math.radians(declination)

    # Calculate the hour angle
    hour_angle = (time.hour + time.minute / 60 + time.second / 3600 - 12) * 15
    hour_angle_rad = math.radians(hour_angle)

    # Calculate the solar elevation angle
    sin_elevation = (math.sin(lat_rad) * math.sin(declination_rad) + 
                     math.cos(lat_rad) * math.cos(declination_rad) * math.cos(hour_angle_rad))
    elevation = math.degrees(math.asin(sin_elevation))

    return elevation

# Example usage
latitude = 40.7128  # New York City
longitude = -74.0060
date = datetime.date(2023, 6, 21)  # Summer solstice
light_estimate = natural_light_by_season(latitude, longitude, date)
for season, intensity in light_estimate.items():
    print(f"{season}: {intensity:.1f}")

# Calculate for each season
for month in [3, 6, 9, 12]:  # March, June, September, December
    date = datetime.date(2023, month, 21)
    light_estimate = natural_light_by_season(latitude, longitude, date)
    for season, intensity in light_estimate.items():
        print(f"{date.strftime('%Y-%m-%d')} - {season}: {intensity:.1f}")