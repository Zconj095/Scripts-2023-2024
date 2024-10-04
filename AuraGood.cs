using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraGood : MonoBehaviour
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
        ApplyGoodAura();
    }

    public void ApplyGoodAura()
    {
        ApplyGoodToAura(EthericBody);
        ApplyGoodToAura(EmotionalBody);
        ApplyGoodToAura(MentalBody);
        ApplyGoodToAura(AstralBody);
        ApplyGoodToAura(EthericTemplate);
        ApplyGoodToAura(CelestialBody);
        ApplyGoodToAura(CausalBody);
    }

    private void ApplyGoodToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.1f; // Smooth and balanced flow for positivity
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Radiant and steady flow reflecting satisfaction
        }
    }
}
