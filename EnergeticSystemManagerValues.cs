using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergeticSystemManagerValues : MonoBehaviour
{
    public ZodiacSign zodiacSign;
    public GameObject chakraPrefab; // Prefab for chakras
    public GameObject auraPrefab; // Prefab for auras

    private Dictionary<ZodiacSign, (float speed, float size, float lifetime, float emissionRate)> chakraParticleBehaviors = new Dictionary<ZodiacSign, (float speed, float size, float lifetime, float emissionRate)>();
    private Dictionary<ZodiacSign, (float speed, float size, float lifetime, float emissionRate)> auraParticleBehaviors = new Dictionary<ZodiacSign, (float speed, float size, float lifetime, float emissionRate)>();

    void Start()
    {
        // Assign chakra and aura prefabs for the selected zodiac sign
        AttachChakraPrefab(chakraPrefab);
        AttachAuraPrefab(auraPrefab);

        // Set different energetic reactions based on the zodiac sign
        InitializeChakraParticleBehaviors();
        InitializeAuraParticleBehaviors();

        ApplyChakraParticleBehavior();
        ApplyAuraParticleBehavior();
    }

    private void AttachChakraPrefab(GameObject prefab)
    {
        if (prefab != null)
        {
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
            Debug.Log("Aura Prefab attached for " + zodiacSign.ToString());
        }
        else
        {
            Debug.LogError("Aura Prefab is missing!");
        }
    }

    private void InitializeChakraParticleBehaviors()
    {
        chakraParticleBehaviors[ZodiacSign.Aries] = (1.5f, 1.2f, 4.0f, 50f);
        chakraParticleBehaviors[ZodiacSign.Taurus] = (0.8f, 1.0f, 6.0f, 20f);
        chakraParticleBehaviors[ZodiacSign.Gemini] = (1.0f, 0.9f, 5.0f, 30f);
        chakraParticleBehaviors[ZodiacSign.Cancer] = (0.9f, 1.1f, 6.5f, 25f);
        chakraParticleBehaviors[ZodiacSign.Leo] = (2.0f, 1.5f, 4.5f, 60f);
        chakraParticleBehaviors[ZodiacSign.Virgo] = (1.0f, 0.8f, 5.0f, 30f);
        chakraParticleBehaviors[ZodiacSign.Libra] = (1.2f, 1.0f, 5.5f, 35f);
        chakraParticleBehaviors[ZodiacSign.Scorpio] = (1.8f, 1.3f, 4.0f, 50f);
        chakraParticleBehaviors[ZodiacSign.Sagittarius] = (1.6f, 1.2f, 5.0f, 40f);
        chakraParticleBehaviors[ZodiacSign.Capricorn] = (0.7f, 0.9f, 6.5f, 20f);
        chakraParticleBehaviors[ZodiacSign.Aquarius] = (1.5f, 1.3f, 5.0f, 45f);
        chakraParticleBehaviors[ZodiacSign.Pisces] = (1.0f, 1.1f, 6.0f, 30f);
    }

    private void InitializeAuraParticleBehaviors()
    {
        auraParticleBehaviors[ZodiacSign.Aries] = (1.8f, 1.2f, 3.5f, 55f);
        auraParticleBehaviors[ZodiacSign.Taurus] = (0.7f, 1.0f, 6.5f, 20f);
        auraParticleBehaviors[ZodiacSign.Gemini] = (1.3f, 0.9f, 5.0f, 35f);
        auraParticleBehaviors[ZodiacSign.Cancer] = (0.9f, 1.1f, 6.0f, 25f);
        auraParticleBehaviors[ZodiacSign.Leo] = (2.0f, 1.5f, 4.0f, 65f);
        auraParticleBehaviors[ZodiacSign.Virgo] = (1.0f, 0.8f, 5.5f, 30f);
        auraParticleBehaviors[ZodiacSign.Libra] = (1.1f, 1.0f, 5.5f, 35f);
        auraParticleBehaviors[ZodiacSign.Scorpio] = (1.9f, 1.3f, 3.5f, 55f);
        auraParticleBehaviors[ZodiacSign.Sagittarius] = (1.7f, 1.2f, 4.5f, 40f);
        auraParticleBehaviors[ZodiacSign.Capricorn] = (0.8f, 0.9f, 6.5f, 20f);
        auraParticleBehaviors[ZodiacSign.Aquarius] = (1.6f, 1.3f, 4.5f, 45f);
        auraParticleBehaviors[ZodiacSign.Pisces] = (1.1f, 1.1f, 6.0f, 30f);
    }

    private void ApplyChakraParticleBehavior()
    {
        if (chakraPrefab != null && chakraParticleBehaviors.ContainsKey(zodiacSign))
        {
            ParticleSystem[] chakraParticleSystems = chakraPrefab.GetComponentsInChildren<ParticleSystem>();
            foreach (ParticleSystem ps in chakraParticleSystems)
            {
                var mainModule = ps.main;
                mainModule.simulationSpeed = chakraParticleBehaviors[zodiacSign].speed;
                mainModule.startSize = chakraParticleBehaviors[zodiacSign].size;
                mainModule.startLifetime = chakraParticleBehaviors[zodiacSign].lifetime;

                var emissionModule = ps.emission;
                emissionModule.rateOverTime = chakraParticleBehaviors[zodiacSign].emissionRate;
            }
            Debug.Log("Applied Chakra Particle Behavior for " + zodiacSign);
        }
        else
        {
            Debug.LogError("No chakra particle system found or behavior missing for " + zodiacSign);
        }
    }

    private void ApplyAuraParticleBehavior()
    {
        if (auraPrefab != null && auraParticleBehaviors.ContainsKey(zodiacSign))
        {
            ParticleSystem[] auraParticleSystems = auraPrefab.GetComponentsInChildren<ParticleSystem>();
            foreach (ParticleSystem ps in auraParticleSystems)
            {
                var mainModule = ps.main;
                mainModule.simulationSpeed = auraParticleBehaviors[zodiacSign].speed;
                mainModule.startSize = auraParticleBehaviors[zodiacSign].size;
                mainModule.startLifetime = auraParticleBehaviors[zodiacSign].lifetime;

                var emissionModule = ps.emission;
                emissionModule.rateOverTime = auraParticleBehaviors[zodiacSign].emissionRate;
            }
            Debug.Log("Applied Aura Particle Behavior for " + zodiacSign);
        }
        else
        {
            Debug.LogError("No aura particle system found or behavior missing for " + zodiacSign);
        }
    }
}
