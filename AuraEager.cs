using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraEager : MonoBehaviour
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
        ApplyEagerAura();
    }

    public void ApplyEagerAura()
    {
        ApplyEagerToAura(EthericBody);
        ApplyEagerToAura(EmotionalBody);
        ApplyEagerToAura(MentalBody);
        ApplyEagerToAura(AstralBody);
        ApplyEagerToAura(EthericTemplate);
        ApplyEagerToAura(CelestialBody);
        ApplyEagerToAura(CausalBody);
    }

    private void ApplyEagerToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.9f; // Fast and lively flow for eagerness
            main.startSize = 0.5f;
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // High energy output to reflect anticipation
        }
    }
}
