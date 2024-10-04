using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraConfident : MonoBehaviour
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
        ApplyConfidentAura();
    }

    public void ApplyConfidentAura()
    {
        ApplyConfidentToAura(EthericBody);
        ApplyConfidentToAura(EmotionalBody);
        ApplyConfidentToAura(MentalBody);
        ApplyConfidentToAura(AstralBody);
        ApplyConfidentToAura(EthericTemplate);
        ApplyConfidentToAura(CelestialBody);
        ApplyConfidentToAura(CausalBody);
    }

    private void ApplyConfidentToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.5f; // Strong and bold particle flow for confidence
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Consistent and steady flow symbolizing self-assurance
        }
    }
}
