using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraAmused : MonoBehaviour
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
        ApplyAmusedAura();
    }

    public void ApplyAmusedAura()
    {
        ApplyAmusedToAura(EthericBody);
        ApplyAmusedToAura(EmotionalBody);
        ApplyAmusedToAura(MentalBody);
        ApplyAmusedToAura(AstralBody);
        ApplyAmusedToAura(EthericTemplate);
        ApplyAmusedToAura(CelestialBody);
        ApplyAmusedToAura(CausalBody);
    }

    private void ApplyAmusedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.6f; // Light and lively flow for amusement
            main.startSize = 0.4f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Playful and quick particle emission to reflect amusement
        }
    }
}
