using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ZodiacSign
{
    Aries,
    Taurus,
    Gemini,
    Cancer,
    Leo,
    Virgo,
    Libra,
    Scorpio,
    Sagittarius,
    Capricorn,
    Aquarius,
    Pisces
}

public class EnergeticSystemManager : MonoBehaviour
{
    public ZodiacSign zodiacSign;
    public GameObject chakraPrefab; // Prefab for chakras
    public GameObject auraPrefab; // Prefab for auras

    private Dictionary<ZodiacSign, string> chakraReactions = new Dictionary<ZodiacSign, string>();
    private Dictionary<ZodiacSign, string> auraReactions = new Dictionary<ZodiacSign, string>();

    void Start()
    {
        // Assign chakra and aura prefabs for the selected zodiac sign
        AttachChakraPrefab(chakraPrefab);
        AttachAuraPrefab(auraPrefab);

        // Set different energetic reactions based on the zodiac sign
        InitializeEnergeticReactions();
        ApplyChakraReaction();
        ApplyAuraReaction();
    }

    private void AttachChakraPrefab(GameObject prefab)
    {
        if (prefab != null)
        {
            // Assuming the Chakra Prefab is structured with the required chakra layers
            Debug.Log("Chakra Prefab attached for " + zodiacSign.ToString());
        }
        else
        {
            Debug.LogError("Chakra Prefab is missing!");
        }
    }

    private void AttachAuraPrefab(GameObject prefab)
    {
        if (prefab != null)
        {
            // Assuming the Aura Prefab is structured with the required aura layers
            Debug.Log("Aura Prefab attached for " + zodiacSign.ToString());
        }
        else
        {
            Debug.LogError("Aura Prefab is missing!");
        }
    }

    private void InitializeEnergeticReactions()
    {
        // Different reactions for chakras based on zodiac sign
        chakraReactions[ZodiacSign.Aries] = "High intensity, fast chakra flow";
        chakraReactions[ZodiacSign.Taurus] = "Stable and slow chakra flow";
        chakraReactions[ZodiacSign.Gemini] = "Dual-flow, oscillating chakra energy";
        chakraReactions[ZodiacSign.Cancer] = "Calm but deep, lunar-influenced flow";
        chakraReactions[ZodiacSign.Leo] = "Radiant and strong, with bursts of energy";
        chakraReactions[ZodiacSign.Virgo] = "Structured, balanced, and controlled flow";
        chakraReactions[ZodiacSign.Libra] = "Balanced and harmonious chakra energy";
        chakraReactions[ZodiacSign.Scorpio] = "Intense, transformative energy flow";
        chakraReactions[ZodiacSign.Sagittarius] = "Expansive, free-flowing chakra energy";
        chakraReactions[ZodiacSign.Capricorn] = "Grounded, disciplined, steady flow";
        chakraReactions[ZodiacSign.Aquarius] = "Unpredictable, high-vibration energy";
        chakraReactions[ZodiacSign.Pisces] = "Fluid, dream-like chakra flow";

        // Different reactions for auras based on zodiac sign
        auraReactions[ZodiacSign.Aries] = "Fiery and dynamic aura vibration";
        auraReactions[ZodiacSign.Taurus] = "Earthy, steady aura pulse";
        auraReactions[ZodiacSign.Gemini] = "Shifting, dual-layered aura waves";
        auraReactions[ZodiacSign.Cancer] = "Soft, nurturing, reflective aura field";
        auraReactions[ZodiacSign.Leo] = "Radiant, golden, strong aura presence";
        auraReactions[ZodiacSign.Virgo] = "Precise, methodical, clean aura pattern";
        auraReactions[ZodiacSign.Libra] = "Harmonious, symmetrical, balanced aura";
        auraReactions[ZodiacSign.Scorpio] = "Deep, intense, and transformative aura";
        auraReactions[ZodiacSign.Sagittarius] = "Expansive, adventurous, wide-reaching aura";
        auraReactions[ZodiacSign.Capricorn] = "Grounded, disciplined, robust aura";
        auraReactions[ZodiacSign.Aquarius] = "Electrifying, innovative, and fluctuating aura";
        auraReactions[ZodiacSign.Pisces] = "Misty, dreamlike, flowing aura energy";
    }

    private void ApplyChakraReaction()
    {
        if (chakraReactions.ContainsKey(zodiacSign))
        {
            Debug.Log("Chakra Reaction for " + zodiacSign + ": " + chakraReactions[zodiacSign]);
            // Here you can apply specific changes to the particle systems in the Chakra prefab
        }
        else
        {
            Debug.LogError("No chakra reaction found for " + zodiacSign);
        }
    }

    private void ApplyAuraReaction()
    {
        if (auraReactions.ContainsKey(zodiacSign))
        {
            Debug.Log("Aura Reaction for " + zodiacSign + ": " + auraReactions[zodiacSign]);
            // Here you can apply specific changes to the particle systems in the Aura prefab
        }
        else
        {
            Debug.LogError("No aura reaction found for " + zodiacSign);
        }
    }
}
