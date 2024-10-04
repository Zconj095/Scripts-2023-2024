def differentiate_idea_epiphany(concept, emotional_intensity, novelty, impact, clarity):
    """
    Differentiates between an idea and an epiphany based on various factors.

    Args:
        concept (str): A description of the concept or thought.
        emotional_intensity (int): The level of emotional arousal associated with the concept (0-100).
        novelty (int): The perceived originality and uniqueness of the concept (0-100).
        impact (int): The potential significance and consequences of the concept (0-100).
        clarity (int): The level of understanding and coherence of the concept (0-100).

    Returns:
        str: "Idea" or "Epiphany" based on the analysis.
    """

    # An epiphany often involves a sudden, profound realization
    if emotional_intensity > 80 and novelty > 70 and impact > 60 and clarity > 50:
        return "Epiphany"

    # An idea is a more general concept or thought
    else:
        return "Idea"

# Example usage
concept_1 = "A new way to solve a complex problem"
emotional_intensity_1 = 90
novelty_1 = 85
impact_1 = 75
clarity_1 = 60

concept_2 = "A possible solution to a minor issue"
emotional_intensity_2 = 50
novelty_2 = 40
impact_2 = 30
clarity_2 = 70

result_1 = differentiate_idea_epiphany(concept_1, emotional_intensity_1, novelty_1, impact_1, clarity_1)
result_2 = differentiate_idea_epiphany(concept_2, emotional_intensity_2, novelty_2, impact_2, clarity_2)

print(f"Concept 1: {result_1}")
print(f"Concept 2: {result_2}")