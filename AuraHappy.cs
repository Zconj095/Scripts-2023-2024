using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHappy : MonoBehaviour
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
        ApplyHappyAura();
    }

    public void ApplyHappyAura()
    {
        ApplyHappyToAura(EthericBody);
        ApplyHappyToAura(EmotionalBody);
        ApplyHappyToAura(MentalBody);
        ApplyHappyToAura(AstralBody);
        ApplyHappyToAura(EthericTemplate);
        ApplyHappyToAura(CelestialBody);
        ApplyHappyToAura(CausalBody);
    }

    private void ApplyHappyToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fast-moving and bright flow for happiness
            main.startSize = Random.Range(0.5f, 0.6f); // Lively particle flow to reflect joy
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy output for positive feelings
        }
    }
}
