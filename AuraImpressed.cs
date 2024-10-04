using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraImpressed : MonoBehaviour
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
        ApplyImpressedAura();
    }

    public void ApplyImpressedAura()
    {
        ApplyImpressedToAura(EthericBody);
        ApplyImpressedToAura(EmotionalBody);
        ApplyImpressedToAura(MentalBody);
        ApplyImpressedToAura(AstralBody);
        ApplyImpressedToAura(EthericTemplate);
        ApplyImpressedToAura(CelestialBody);
        ApplyImpressedToAura(CausalBody);
    }

    private void ApplyImpressedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.6f; // Fast and dynamic flow for impressed feelings
            main.startSize = 0.5f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy flow symbolizing the excitement of being impressed
        }
    }
}
