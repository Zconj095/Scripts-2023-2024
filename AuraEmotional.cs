using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraEmotional : MonoBehaviour
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
        ApplyEmotionalAura();
    }

    public void ApplyEmotionalAura()
    {
        ApplyEmotionalToAura(EthericBody);
        ApplyEmotionalToAura(EmotionalBody);
        ApplyEmotionalToAura(MentalBody);
        ApplyEmotionalToAura(AstralBody);
        ApplyEmotionalToAura(EthericTemplate);
        ApplyEmotionalToAura(CelestialBody);
        ApplyEmotionalToAura(CausalBody);
    }

    private void ApplyEmotionalToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fluctuating and dynamic flow for emotional complexity
            main.startSize = Random.Range(0.5f, 0.7f); // Varying particle size to reflect emotional layers
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 45f; // Complex particle emission for emotional layers
        }
    }
}
