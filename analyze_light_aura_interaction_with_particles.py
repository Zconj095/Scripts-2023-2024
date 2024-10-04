import datetime
from astral import LocationInfo
from astral.sun import sun
import ephem
import numpy as np
import pytz

def analyze_light_aura_interaction_with_particles(latitude, longitude, birth_season, birth_time, 
                                                  brainwave_data, light_source, intensity, color_temperature, date=None):
    """
    Analyzes the interaction between natural/artificial light, human aura, 
    and brainwave patterns, incorporating the influence of color particles 
    that add shininess and crispness to the aura's colors.

    Args:
        latitude (float): The latitude of the location.
        longitude (float): The longitude of the location.
        birth_season (str): The season in which the person was born 
                            ("Spring", "Summer", "Autumn", "Winter").
        birth_time (str): The time of day the person was born ("Day", "Night").
        brainwave_data (list): A list of brainwave frequency values (Hz).
        light_source (str): The source of the light ("Natural" or "Artificial").
        intensity (int): The light intensity on a scale of 0-100.
        color_temperature (int): The color temperature of the light in Kelvin.
        date (datetime.date, optional): The date for which to calculate light levels. 
                                        Defaults to the current date.

    Returns:
        A dictionary containing insights into the light-aura-brainwave interaction,
        including the influence of color particles.
    """

    if date is None:
        date = datetime.date.today()

    # Get sunrise and sunset times using astral
    location = LocationInfo(latitude=latitude, longitude=longitude)
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

    # Base aura resonance based on birth season and time
    base_aura_resonance_day = {
        "Spring": 60, "Summer": 80, "Autumn": 50, "Winter": 30
    }
    base_aura_resonance_night = {
        "Spring": 30, "Summer": 10, "Autumn": 40, "Winter": 60
    }

    # Adjust base resonance if birth time doesn't match current time
    if birth_time == "Day" and is_night:
        base_resonance = base_aura_resonance_night[birth_season] * 0.8
    elif birth_time == "Night" and not is_night:
        base_resonance = base_aura_resonance_day[birth_season] * 0.8
    else:
        base_resonance = base_aura_resonance_day[birth_season] if not is_night else base_aura_resonance_night[birth_season]

    # Light influence on aura resonance
    if light_source == "Natural":
        if is_night:
            # Moonlight calculations
            observer = ephem.Observer()
            observer.lat = str(latitude)
            observer.lon = str(longitude)
            observer.date = date

            moon = ephem.Moon()
            moon.compute(observer)
            illuminated_fraction = moon.phase / 100
            light_influence = illuminated_fraction * 20
        else:
            # Sunlight calculations (simplified)
            day_length_hours = (sunset - sunrise).seconds / 3600
            light_influence = (day_length_hours - 12) * 2 + intensity * 0.5 - abs(color_temperature - 5000) / 1000
    else:  # Artificial light
        light_influence = intensity * 0.3 - abs(color_temperature - 4000) / 2000

    # Brainwave influence on aura resonance
    brainwave_influence = np.mean(brainwave_data) / 30  # Simplified, adjust as needed

    # Particle influence on aura
    particle_influence = 0  # Initialize

    if light_source == "Natural":
        particle_influence += intensity * 0.2  # Sunlight generally enhances particle activity

        if not is_night:
            if color_temperature < 5000:  # Warmer colors, more vibrant particles
                particle_influence += 10
            else:
                particle_influence += 5
        else:  # Moonlight
            particle_influence += 5  # Subtler effect
    else:  # Artificial light
        if color_temperature < 3000:  # Warmer artificial light
            particle_influence += 3
        elif color_temperature < 4000:
            particle_influence += 2
        else:
            particle_influence += 1

    # Brainwave influence on particles
    particle_influence += np.std(brainwave_data)  # Higher variability, more active particles

    # Calculate final aura resonance and particle activity
    final_aura_resonance = base_resonance + light_influence + brainwave_influence + particle_influence
    particle_activity = particle_influence / 20  # Scale for interpretation

    # Interpret the results
    analysis = {
        "aura_resonance": final_aura_resonance,
        "light_influence": light_influence,
        "brainwave_influence": brainwave_influence,
        "particle_activity": particle_activity
    }

    return analysis


# Example usage (hypothetical data)
latitude = 40.7128  # New York City
longitude = -74.0060
birth_season = "Summer"
birth_time = "Day"
brainwave_data = [10, 12, 9, 11]  # Example alpha wave frequencies
light_source = "Natural"
intensity = 70
color_temperature = 5500

analysis = analyze_light_aura_interaction_with_particles(latitude, longitude, birth_season, birth_time, 
                                                        brainwave_data, light_source, intensity, color_temperature)
print(analysis)
