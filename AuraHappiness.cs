using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHappiness : MonoBehaviour
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
        ApplyHappinessAura();
    }

    public void ApplyHappinessAura()
    {
        ApplyHappinessToAura(EthericBody);
        ApplyHappinessToAura(EmotionalBody);
        ApplyHappinessToAura(MentalBody);
        ApplyHappinessToAura(AstralBody);
        ApplyHappinessToAura(EthericTemplate);
        ApplyHappinessToAura(CelestialBody);
        ApplyHappinessToAura(CausalBody);
    }

    private void ApplyHappinessToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fast and bright flow for happiness
            main.startSize = Random.Range(0.5f, 0.6f); // Lively particle size for joy and positivity
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy output for dynamic joy
        }
    }
}
