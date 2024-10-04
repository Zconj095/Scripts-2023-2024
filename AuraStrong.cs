using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraStrong : MonoBehaviour
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
        ApplyStrongAura();
    }

    public void ApplyStrongAura()
    {
        ApplyStrongToAura(EthericBody);
        ApplyStrongToAura(EmotionalBody);
        ApplyStrongToAura(MentalBody);
        ApplyStrongToAura(AstralBody);
        ApplyStrongToAura(EthericTemplate);
        ApplyStrongToAura(CelestialBody);
        ApplyStrongToAura(CausalBody);
    }

    private void ApplyStrongToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Bold and steady flow reflecting strength and willpower
            main.startSize = 0.6f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // Powerful, steady flow symbolizing resilience and determination
        }
    }
}
