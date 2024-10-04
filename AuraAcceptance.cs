using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraAcceptance : MonoBehaviour
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
        ApplyAcceptanceAura();
    }

    public void ApplyAcceptanceAura()
    {
        ApplyAcceptanceToAura(EthericBody);
        ApplyAcceptanceToAura(EmotionalBody);
        ApplyAcceptanceToAura(MentalBody);
        ApplyAcceptanceToAura(AstralBody);
        ApplyAcceptanceToAura(EthericTemplate);
        ApplyAcceptanceToAura(CelestialBody);
        ApplyAcceptanceToAura(CausalBody);
    }

    private void ApplyAcceptanceToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Smooth, steady flow to symbolize acceptance
            main.startSize = 0.4f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Steady and even particle emission for openness
        }
    }
}
