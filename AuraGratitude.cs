using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraGratitude : MonoBehaviour
{
    public GameObject EthericBody;
    public GameObject EmotionalBody;
    public GameObject MentalBody;
    public GameObject AstralBody;
    public GameObject EthericTemplate;
    public GameObject CelestialBody;
    public GameObject CausalBody;

    void Start()
    {
        ApplyGratitudeAura();
    }

    public void ApplyGratitudeAura()
    {
        ApplyGratitudeToAura(EthericBody);
        ApplyGratitudeToAura(EmotionalBody);
        ApplyGratitudeToAura(MentalBody);
        ApplyGratitudeToAura(AstralBody);
        ApplyGratitudeToAura(EthericTemplate);
        ApplyGratitudeToAura(CelestialBody);
        ApplyGratitudeToAura(CausalBody);
    }

    private void ApplyGratitudeToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Warm and soft flow for appreciation
            main.startSize = 0.4f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Gentle flow reflecting thankfulness and gratitude
        }
    }
}
