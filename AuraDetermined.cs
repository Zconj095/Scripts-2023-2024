using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraDetermined : MonoBehaviour
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
        ApplyDeterminedAura();
    }

    public void ApplyDeterminedAura()
    {
        ApplyDeterminedToAura(EthericBody);
        ApplyDeterminedToAura(EmotionalBody);
        ApplyDeterminedToAura(MentalBody);
        ApplyDeterminedToAura(AstralBody);
        ApplyDeterminedToAura(EthericTemplate);
        ApplyDeterminedToAura(CelestialBody);
        ApplyDeterminedToAura(CausalBody);
    }

    private void ApplyDeterminedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Bold and focused flow for determination
            main.startSize = 0.6f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // Intense and steady flow reflecting motivated action
        }
    }
}
