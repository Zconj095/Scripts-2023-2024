using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraFullOfPurpose : MonoBehaviour
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
        ApplyFullOfPurposeAura();
    }

    public void ApplyFullOfPurposeAura()
    {
        ApplyFullOfPurposeToAura(EthericBody);
        ApplyFullOfPurposeToAura(EmotionalBody);
        ApplyFullOfPurposeToAura(MentalBody);
        ApplyFullOfPurposeToAura(AstralBody);
        ApplyFullOfPurposeToAura(EthericTemplate);
        ApplyFullOfPurposeToAura(CelestialBody);
        ApplyFullOfPurposeToAura(CausalBody);
    }

    private void ApplyFullOfPurposeToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Steady and directed flow for purpose
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Strong and purposeful flow symbolizing meaning and dedication
        }
    }
}
