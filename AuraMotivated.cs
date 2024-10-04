using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraMotivated : MonoBehaviour
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
        ApplyMotivatedAura();
    }

    public void ApplyMotivatedAura()
    {
        ApplyMotivatedToAura(EthericBody);
        ApplyMotivatedToAura(EmotionalBody);
        ApplyMotivatedToAura(MentalBody);
        ApplyMotivatedToAura(AstralBody);
        ApplyMotivatedToAura(EthericTemplate);
        ApplyMotivatedToAura(CelestialBody);
        ApplyMotivatedToAura(CausalBody);
    }

    private void ApplyMotivatedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Dynamic and fast-moving flow for motivation
            main.startSize = 0.6f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // Bold and energetic flow symbolizing passion and determination
        }
    }
}
