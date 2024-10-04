using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraEmpathic : MonoBehaviour
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
        ApplyEmpathicAura();
    }

    public void ApplyEmpathicAura()
    {
        ApplyEmpathicToAura(EthericBody);
        ApplyEmpathicToAura(EmotionalBody);
        ApplyEmpathicToAura(MentalBody);
        ApplyEmpathicToAura(AstralBody);
        ApplyEmpathicToAura(EthericTemplate);
        ApplyEmpathicToAura(CelestialBody);
        ApplyEmpathicToAura(CausalBody);
    }

    private void ApplyEmpathicToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Smooth, interconnected flow to reflect empathy
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Gentle and interconnected flow for sensitivity to emotions
        }
    }
}
