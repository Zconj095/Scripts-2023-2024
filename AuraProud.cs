using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraProud : MonoBehaviour
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
        ApplyProudAura();
    }

    public void ApplyProudAura()
    {
        ApplyProudToAura(EthericBody);
        ApplyProudToAura(EmotionalBody);
        ApplyProudToAura(MentalBody);
        ApplyProudToAura(AstralBody);
        ApplyProudToAura(EthericTemplate);
        ApplyProudToAura(CelestialBody);
        ApplyProudToAura(CausalBody);
    }

    private void ApplyProudToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.5f; // Steady and bold flow for pride
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Radiant and confident particle flow reflecting pride and fulfillment
        }
    }
}
