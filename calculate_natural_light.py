import datetime
from astral import LocationInfo
from astral.sun import sun
import ephem
import pytz

def calculate_natural_light(latitude, longitude, birth_season, birth_time, date=None):
    """
    Calculates estimated natural light levels based on location, birth season, 
    birth time, and current date/time, considering both sunlight and moonlight.

    Args:
        latitude (float): The latitude of the location.
        longitude (float): The longitude of the location.
        birth_season (str): The season in which the person was born 
                            ("Spring", "Summer", "Autumn", "Winter").
        birth_time (str): The time of day the person was born ("Day", "Night").
        date (datetime.date, optional): The date for which to calculate light levels. 
                                        Defaults to the current date.

    Returns:
        float: The estimated natural light level (0-100).
    """

    if date is None:
        date = datetime.date.today()

    # Create location info for astral to calculate sun times
    location = LocationInfo(latitude=latitude, longitude=longitude)
    
    # Get sunrise and sunset times using astral and calculate the sun times for the given date
    s = sun(location.observer, date=date)

    # Get the correct timezone from astral LocationInfo
    timezone = pytz.timezone(location.timezone)

    # Make the current time timezone-aware
    now = datetime.datetime.now(timezone)

    # Convert sunrise and sunset to timezone-aware datetimes
    sunrise = s['sunrise'].astimezone(timezone)
    sunset = s['sunset'].astimezone(timezone)

    # Determine if it's day or night
    is_night = now < sunrise or now > sunset

    # Base light levels based on birth season and time
    base_levels_day = {
        "Spring": 60, "Summer": 80, "Autumn": 50, "Winter": 30
    }
    base_levels_night = {
        "Spring": 30, "Summer": 10, "Autumn": 40, "Winter": 60
    }

    # Adjust base levels if birth time doesn't match current time
    if birth_time == "Day" and is_night:
        base_level = base_levels_night[birth_season] * 0.8
    elif birth_time == "Night" and not is_night:
        base_level = base_levels_day[birth_season] * 0.8
    else:
        base_level = base_levels_day[birth_season] if not is_night else base_levels_night[birth_season]

    if not is_night:
        # Daylight adjustments
        day_length_hours = (sunset - sunrise).seconds / 3600
        light_level = base_level + (day_length_hours - 12) * 2 

        # Latitude and weather adjustments (simplified)
        latitude_factor = 1 - abs(latitude) / 90 
        weather_factor = 0.8  # Example: cloudy day
        light_level *= latitude_factor * weather_factor

        # Additional solar elevation adjustments could be applied here for more precision
    else:
        # Moonlight calculations
        observer = ephem.Observer()
        observer.lat = str(latitude)
        observer.lon = str(longitude)
        observer.date = date

        moon = ephem.Moon()
        moon.compute(observer)

        illuminated_fraction = moon.phase / 100 
        light_level = base_level + illuminated_fraction * 20 

    return light_level

# Example usage
latitude = 40.7128  # New York City
longitude = -74.0060
birth_season = "Summer"
birth_time = "Day"

light_level = calculate_natural_light(latitude, longitude, birth_season, birth_time)
print(f"Estimated natural light level: {light_level:.1f}")
