using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSerenity : MonoBehaviour
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
        ApplySerenityAura();
    }

    public void ApplySerenityAura()
    {
        ApplySerenityToAura(EthericBody);
        ApplySerenityToAura(EmotionalBody);
        ApplySerenityToAura(MentalBody);
        ApplySerenityToAura(AstralBody);
        ApplySerenityToAura(EthericTemplate);
        ApplySerenityToAura(CelestialBody);
        ApplySerenityToAura(CausalBody);
    }

    private void ApplySerenityToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.8f; // Slow and balanced flow for serenity
            main.startSize = 0.5f;
            main.startLifetime = 5.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 20f; // Gentle, smooth particle flow to reflect calm understanding
        }
    }
}
