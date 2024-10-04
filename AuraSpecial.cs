using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSpecial : MonoBehaviour
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
        ApplySpecialAura();
    }

    public void ApplySpecialAura()
    {
        ApplySpecialToAura(EthericBody);
        ApplySpecialToAura(EmotionalBody);
        ApplySpecialToAura(MentalBody);
        ApplySpecialToAura(AstralBody);
        ApplySpecialToAura(EthericTemplate);
        ApplySpecialToAura(CelestialBody);
        ApplySpecialToAura(CausalBody);
    }

    private void ApplySpecialToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Unique and radiant flow for individuality
            main.startSize = 0.6f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Slightly irregular particle pattern symbolizing uniqueness and abstraction
        }
    }
}
