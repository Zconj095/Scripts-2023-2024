using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraBrave : MonoBehaviour
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
        ApplyBraveAura();
    }

    public void ApplyBraveAura()
    {
        ApplyBraveToAura(EthericBody);
        ApplyBraveToAura(EmotionalBody);
        ApplyBraveToAura(MentalBody);
        ApplyBraveToAura(AstralBody);
        ApplyBraveToAura(EthericTemplate);
        ApplyBraveToAura(CelestialBody);
        ApplyBraveToAura(CausalBody);
    }

    private void ApplyBraveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Strong and dynamic flow to represent bravery
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 45f; // Bold and determined particle flow for courage
        }
    }
}
