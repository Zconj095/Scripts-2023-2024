def analyze_light(light_source, intensity, color_temperature):
    """
    Analyzes a light source based on its intensity, color temperature, 
    and potential source (natural or artificial) to provide insights 
    into its warmth and color characteristics.

    Args:
        light_source (str): The potential source of the light ("Natural" or "Artificial").
        intensity (int): The light intensity on a scale of 0-100.
        color_temperature (int): The color temperature of the light in Kelvin.

    Returns:
        A dictionary containing the analyzed warmth and color characteristics of the light.
    """

    analysis = {}

    # Warmth analysis
    if light_source == "Natural":
        if intensity > 80:
            analysis["warmth"] = "Intense and warm, like the midday sun."
        elif intensity > 50:
            analysis["warmth"] = "Pleasant and warm, similar to morning or afternoon sunlight."
        else:
            analysis["warmth"] = "Soft and warm, reminiscent of sunrise or sunset."
    else:  # Artificial light
        if color_temperature < 3000:
            analysis["warmth"] = "Warm and cozy, like candlelight or incandescent bulbs."
        elif color_temperature < 4000:
            analysis["warmth"] = "Neutral and balanced, typical of halogen or some LED lights."
        else:
            analysis["warmth"] = "Cool and invigorating, similar to fluorescent or daylight LEDs."

    # Color analysis
    if light_source == "Natural":
        if color_temperature < 5000:
            analysis["color"] = "Golden or reddish hues, often seen at sunrise or sunset."
        else:
            analysis["color"] = "Bluish-white, characteristic of daylight."
    else:  # Artificial light
        if color_temperature < 3000:
            analysis["color"] = "Yellowish or reddish tones, creating a relaxing atmosphere."
        elif color_temperature < 4000:
            analysis["color"] = "Neutral white, providing a balanced and versatile lighting."
        else:
            analysis["color"] = "Bluish-white, promoting alertness and focus."

    return analysis

# Example usage
natural_light_analysis = analyze_light("Natural", 70, 5500)
artificial_light_analysis = analyze_light("Artificial", 60, 2700)

print("Natural light analysis:", natural_light_analysis)
print("Artificial light analysis:", artificial_light_analysis)