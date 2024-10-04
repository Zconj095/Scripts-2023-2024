using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHonor : MonoBehaviour
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
        ApplyHonorAura();
    }

    public void ApplyHonorAura()
    {
        ApplyHonorToAura(EthericBody);
        ApplyHonorToAura(EmotionalBody);
        ApplyHonorToAura(MentalBody);
        ApplyHonorToAura(AstralBody);
        ApplyHonorToAura(EthericTemplate);
        ApplyHonorToAura(CelestialBody);
        ApplyHonorToAura(CausalBody);
    }

    private void ApplyHonorToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Strong and steady flow to reflect duty and honor
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Calm yet powerful flow to symbolize higher purpose
        }
    }
}
