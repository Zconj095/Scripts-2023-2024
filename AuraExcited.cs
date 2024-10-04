using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraExcited : MonoBehaviour
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
        ApplyExcitedAura();
    }

    public void ApplyExcitedAura()
    {
        ApplyExcitedToAura(EthericBody);
        ApplyExcitedToAura(EmotionalBody);
        ApplyExcitedToAura(MentalBody);
        ApplyExcitedToAura(AstralBody);
        ApplyExcitedToAura(EthericTemplate);
        ApplyExcitedToAura(CelestialBody);
        ApplyExcitedToAura(CausalBody);
    }

    private void ApplyExcitedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 2.2f; // Fast and vibrant particles for excitement
            main.startSize = Random.Range(0.5f, 0.7f); // Fluctuating particle size for dynamic excitement
            main.startLifetime = 2.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy output for heightened excitement
        }
    }
}
