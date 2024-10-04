using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraLove : MonoBehaviour
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
        ApplyLoveAura();
    }

    public void ApplyLoveAura()
    {
        ApplyLoveToAura(EthericBody);
        ApplyLoveToAura(EmotionalBody);
        ApplyLoveToAura(MentalBody);
        ApplyLoveToAura(AstralBody);
        ApplyLoveToAura(EthericTemplate);
        ApplyLoveToAura(CelestialBody);
        ApplyLoveToAura(CausalBody);
    }

    private void ApplyLoveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.1f; // Gentle and expansive flow for love
            main.startSize = 0.6f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Warm, gentle flow representing the depth of love
        }
    }
}
