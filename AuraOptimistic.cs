using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraOptimistic : MonoBehaviour
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
        ApplyOptimisticAura();
    }

    public void ApplyOptimisticAura()
    {
        ApplyOptimisticToAura(EthericBody);
        ApplyOptimisticToAura(EmotionalBody);
        ApplyOptimisticToAura(MentalBody);
        ApplyOptimisticToAura(AstralBody);
        ApplyOptimisticToAura(EthericTemplate);
        ApplyOptimisticToAura(CelestialBody);
        ApplyOptimisticToAura(CausalBody);
    }

    private void ApplyOptimisticToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Uplifting and smooth flow for optimism
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Light and steady flow reflecting hope and positivity
        }
    }
}
