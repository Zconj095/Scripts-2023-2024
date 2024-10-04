import numpy as np

def discern_light_source_in_rendering(pixel_data, scene_information):
    """
    Analyzes pixel data and scene information to estimate whether a light source 
    in a rendered image is natural or artificial.

    Args:
        pixel_data (array): An array representing the color and intensity values of each pixel in the image.
        scene_information (dict): A dictionary containing information about the scene, 
                                  such as light sources, object positions, and materials.

    Returns:
        str: The estimated light source ("Natural" or "Artificial") for the dominant light in the scene.
    """
    
    # Step 1: Analyze shadow distribution
    shadow_threshold = 0.1  # Arbitrary threshold for shadow detection (customizable)
    shadow_regions = np.where(pixel_data[:, :, 3] < shadow_threshold)  # Assuming alpha channel contains opacity

    # Count the number of large shadow regions vs small defined ones
    large_shadows = len(shadow_regions[0]) > (pixel_data.shape[0] * pixel_data.shape[1] * 0.2)  # 20%+ is large shadow
    has_large_soft_shadows = large_shadows  # Large soft shadows imply natural light
    has_sharp_shadows = not large_shadows  # Sharp, small shadows imply artificial light

    # Step 2: Analyze color temperature and intensity gradients
    avg_color = np.mean(pixel_data[:, :, :3], axis=(0, 1))  # Mean of RGB channels
    warm_threshold = 4000  # Color temp threshold for warm light (customizable)
    
    # Calculate overall warmth of the scene by approximating color temperature based on pixel data
    is_warm = avg_color[0] > avg_color[2]  # More red than blue suggests a warmer light
    color_gradient = np.gradient(pixel_data[:, :, :3], axis=0)  # Calculate intensity/color gradient
    
    smooth_gradients = np.mean(color_gradient) < 50  # Small gradients suggest smoother transitions (natural light)
    abrupt_changes = np.mean(color_gradient) > 50  # Abrupt color changes suggest artificial light

    # Step 3: Consider scene information for known light sources
    known_light_sources = scene_information.get("light_sources", [])
    directional_light_count = sum(1 for source in known_light_sources if source['type'] == 'Directional')
    point_or_area_light_count = sum(1 for source in known_light_sources if source['type'] in ['Point', 'Area'])

    # Assume natural light if there's a dominant directional light source
    has_dominant_sunlight = directional_light_count > 0 and directional_light_count > point_or_area_light_count

    # Step 4: Weigh the factors
    natural_score = 0
    artificial_score = 0

    # Natural light factors
    if has_large_soft_shadows:
        natural_score += 1
    if smooth_gradients and is_warm:
        natural_score += 1
    if has_dominant_sunlight:
        natural_score += 2

    # Artificial light factors
    if has_sharp_shadows:
        artificial_score += 1
    if abrupt_changes:
        artificial_score += 1
    if point_or_area_light_count > directional_light_count:
        artificial_score += 2

    # Step 5: Final decision
    if natural_score > artificial_score:
        estimated_light_source = "Natural"
    else:
        estimated_light_source = "Artificial"

    return estimated_light_source

# Example usage (hypothetical)
pixel_data = np.random.rand(100, 100, 4)  # Example pixel data (randomized for demo)
scene_information = {
    "light_sources": [
        {"type": "Directional", "intensity": 80},  # Example of sun-like light source
        {"type": "Point", "intensity": 30},        # Example of an artificial light source
    ]
}

light_source = discern_light_source_in_rendering(pixel_data, scene_information)
print("Estimated light source:", light_source)
