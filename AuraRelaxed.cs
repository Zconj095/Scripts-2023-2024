using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraRelaxed : MonoBehaviour
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
        ApplyRelaxedAura();
    }

    public void ApplyRelaxedAura()
    {
        ApplyRelaxedToAura(EthericBody);
        ApplyRelaxedToAura(EmotionalBody);
        ApplyRelaxedToAura(MentalBody);
        ApplyRelaxedToAura(AstralBody);
        ApplyRelaxedToAura(EthericTemplate);
        ApplyRelaxedToAura(CelestialBody);
        ApplyRelaxedToAura(CausalBody);
    }

    private void ApplyRelaxedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.7f; // Slow, relaxed flow to reflect ease and comfort
            main.startSize = 0.4f;
            main.startLifetime = 5.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 15f; // Low emission rate to maintain a smooth, calm energy
        }
    }
}
