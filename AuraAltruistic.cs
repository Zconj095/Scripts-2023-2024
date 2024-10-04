using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraAltruistic : MonoBehaviour
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
        ApplyAltruisticAura();
    }

    public void ApplyAltruisticAura()
    {
        ApplyAltruisticToAura(EthericBody);
        ApplyAltruisticToAura(EmotionalBody);
        ApplyAltruisticToAura(MentalBody);
        ApplyAltruisticToAura(AstralBody);
        ApplyAltruisticToAura(EthericTemplate);
        ApplyAltruisticToAura(CelestialBody);
        ApplyAltruisticToAura(CausalBody);
    }

    private void ApplyAltruisticToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Steady, strong flow for altruistic connection
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Steady and purposeful flow to symbolize altruism
        }
    }
}
