import numpy as np

def discern_particles(frequency_data, movement_pattern_data):
    """
    Discerns between energy particles and subatomic particles based on their 
    frequency and movement pattern characteristics.

    Args:
        frequency_data (list): A list of frequency values (Hz) representing the particle's vibrations.
        movement_pattern_data (array): An array representing the particle's movement pattern over time.

    Returns:
        str: The estimated particle type ("Energy" or "Subatomic").
    """

    # Analyze frequency characteristics
    mean_frequency = np.mean(frequency_data)
    frequency_range = np.max(frequency_data) - np.min(frequency_data)

    # Energy particles tend to have higher frequencies and wider frequency ranges
    if mean_frequency > 1e12 and frequency_range > 1e10:
        return "Energy"

    # Subatomic particles typically have lower frequencies and narrower frequency ranges
    elif mean_frequency < 1e12 and frequency_range < 1e10:
        return "Subatomic"

    # Analyze movement pattern characteristics
    pattern_complexity = calculate_pattern_complexity(movement_pattern_data)  # Implement this function

    # Energy particles often exhibit more complex and unpredictable movement patterns
    if pattern_complexity > 0.8:
        return "Energy"

    # Subatomic particles tend to have more regular and predictable movement patterns
    elif pattern_complexity < 0.8:
        return "Subatomic"

    # If both analyses are inconclusive, further investigation is needed
    return "Inconclusive"

# Helper function to calculate pattern complexity (implementation depends on data format)
def calculate_pattern_complexity(movement_pattern_data):
    # ... (Implement logic to analyze pattern complexity)
    pass

# Example usage (hypothetical data)
frequency_data_1 = [1e15, 1.2e15, 0.9e15]  # High frequencies, wide range
movement_pattern_data_1 = ...  # Complex, unpredictable pattern

frequency_data_2 = [1e9, 1.1e9, 0.95e9]   # Lower frequencies, narrow range
movement_pattern_data_2 = ...  # Regular, predictable pattern

particle_type_1 = discern_particles(frequency_data_1, movement_pattern_data_1)
particle_type_2 = discern_particles(frequency_data_2, movement_pattern_data_2)

print("Particle type 1:", particle_type_1)
print("Particle type 2:", particle_type_2)