using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraFaithFeeling : MonoBehaviour
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
        ApplyFaithAura();
    }

    public void ApplyFaithAura()
    {
        ApplyFaithToAura(EthericBody);
        ApplyFaithToAura(EmotionalBody);
        ApplyFaithToAura(MentalBody);
        ApplyFaithToAura(AstralBody);
        ApplyFaithToAura(EthericTemplate);
        ApplyFaithToAura(CelestialBody);
        ApplyFaithToAura(CausalBody);
    }

    private void ApplyFaithToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Steady and smooth flow for inner belief
            main.startSize = 0.4f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Calm and harmonious flow to reflect strong internal faith
        }
    }
}
