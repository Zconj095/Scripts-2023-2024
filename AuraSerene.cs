using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSerene : MonoBehaviour
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
        ApplySereneAura();
    }

    public void ApplySereneAura()
    {
        ApplySereneToAura(EthericBody);
        ApplySereneToAura(EmotionalBody);
        ApplySereneToAura(MentalBody);
        ApplySereneToAura(AstralBody);
        ApplySereneToAura(EthericTemplate);
        ApplySereneToAura(CelestialBody);
        ApplySereneToAura(CausalBody);
    }

    private void ApplySereneToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.9f; // Slow, smooth flow for calmness and serenity
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 20f; // Gentle flow to symbolize serenity and balance
        }
    }
}
