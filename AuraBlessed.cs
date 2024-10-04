using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraBlessed : MonoBehaviour
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
        ApplyBlessedAura();
    }

    public void ApplyBlessedAura()
    {
        ApplyBlessedToAura(EthericBody);
        ApplyBlessedToAura(EmotionalBody);
        ApplyBlessedToAura(MentalBody);
        ApplyBlessedToAura(AstralBody);
        ApplyBlessedToAura(EthericTemplate);
        ApplyBlessedToAura(CelestialBody);
        ApplyBlessedToAura(CausalBody);
    }

    private void ApplyBlessedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Warm and soft flow for feeling blessed
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Gentle and steady flow reflecting contentment and thankfulness
        }
    }
}
