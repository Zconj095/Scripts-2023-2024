using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraCollected : MonoBehaviour
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
        ApplyCollectedAura();
    }

    public void ApplyCollectedAura()
    {
        ApplyCollectedToAura(EthericBody);
        ApplyCollectedToAura(EmotionalBody);
        ApplyCollectedToAura(MentalBody);
        ApplyCollectedToAura(AstralBody);
        ApplyCollectedToAura(EthericTemplate);
        ApplyCollectedToAura(CelestialBody);
        ApplyCollectedToAura(CausalBody);
    }

    private void ApplyCollectedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.1f; // Calm, steady flow for collected feelings
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Balanced particle flow to reflect calm and focus
        }
    }
}
