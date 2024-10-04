using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraCheerful : MonoBehaviour
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
        ApplyCheerfulAura();
    }

    public void ApplyCheerfulAura()
    {
        ApplyCheerfulToAura(EthericBody);
        ApplyCheerfulToAura(EmotionalBody);
        ApplyCheerfulToAura(MentalBody);
        ApplyCheerfulToAura(AstralBody);
        ApplyCheerfulToAura(EthericTemplate);
        ApplyCheerfulToAura(CelestialBody);
        ApplyCheerfulToAura(CausalBody);
    }

    private void ApplyCheerfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.6f; // Fast-moving particles for cheerfulness
            main.startSize = Random.Range(0.4f, 0.7f); // Random size for dynamic energy
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // High energy output for a lively and joyful atmosphere
        }
    }
}
