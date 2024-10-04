import numpy as np
import matplotlib.pyplot as plt
from matplotlib.colors import hsv_to_rgb

def visualize_particle_resonance(analysis_data):
    """
    Visualizes the frequency flux and particle resonance data, reflecting the 
    multidimensionality and color scheme of the patterns.

    Args:
        analysis_data (dict): The output from the `analyze_particle_resonance_flux` function.
    """

    # Extract data
    base_resonance = analysis_data["base_resonance_frequency"]
    final_resonance = analysis_data["final_resonance_frequency"]
    flux = analysis_data["frequency_flux"]

    # Create a colormap based on resonance and flux
    hue = (final_resonance / base_resonance) % 1  # Normalize and cycle hues
    saturation = 1 - (flux / (flux + 1))  # Higher flux, lower saturation
    value = 1  # Full brightness

    # hsv_to_rgb expects arrays or tuples
    color = hsv_to_rgb([hue, saturation, value])

    # Visualize the data
    fig, ax = plt.subplots()

    # Plot base resonance as a horizontal line
    ax.axhline(y=base_resonance, color='gray', linestyle='--', label='Base Resonance')

    # Plot final resonance as a point
    ax.plot(1, final_resonance, marker='o', markersize=10, color=color, label='Final Resonance')

    # Plot flux as a variation over time (simple time series for visualization)
    time = np.linspace(0, 1, 100)  # Mock time data
    flux_variation = base_resonance + flux * np.sin(2 * np.pi * time)  # Sinusoidal flux variation

    ax.plot(time, flux_variation, color='blue', label='Flux Variation')

    # Add annotations and labels
    ax.set_xlabel('Time (relative)')
    ax.set_ylabel('Frequency')
    ax.set_title('Particle Resonance and Flux Visualization')
    ax.legend()

    plt.show()

# Example usage (hypothetical data)
analysis_data = {
    "base_resonance_frequency": 5.0,
    "final_resonance_frequency": 7.2,
    "frequency_flux": 0.8
}

visualize_particle_resonance(analysis_data)
