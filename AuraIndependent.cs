using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraIndependent : MonoBehaviour
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
        ApplyIndependentAura();
    }

    public void ApplyIndependentAura()
    {
        ApplyIndependentToAura(EthericBody);
        ApplyIndependentToAura(EmotionalBody);
        ApplyIndependentToAura(MentalBody);
        ApplyIndependentToAura(AstralBody);
        ApplyIndependentToAura(EthericTemplate);
        ApplyIndependentToAura(CelestialBody);
        ApplyIndependentToAura(CausalBody);
    }

    private void ApplyIndependentToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Strong and steady flow for independence
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Confident and calm flow symbolizing self-reliance
        }
    }
}
