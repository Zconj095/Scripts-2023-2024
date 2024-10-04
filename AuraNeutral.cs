using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraNeutral : MonoBehaviour
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
        ApplyNeutralAura();
    }

    public void ApplyNeutralAura()
    {
        ApplyNeutralToAura(EthericBody);
        ApplyNeutralToAura(EmotionalBody);
        ApplyNeutralToAura(MentalBody);
        ApplyNeutralToAura(AstralBody);
        ApplyNeutralToAura(EthericTemplate);
        ApplyNeutralToAura(CelestialBody);
        ApplyNeutralToAura(CausalBody);
    }

    private void ApplyNeutralToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Balanced, steady energy for neutrality
            main.startSize = 0.5f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Moderate flow with no extremes, reflecting a neutral state
        }
    }
}
