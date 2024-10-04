using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraThrilled : MonoBehaviour
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
        ApplyThrilledAura();
    }

    public void ApplyThrilledAura()
    {
        ApplyThrilledToAura(EthericBody);
        ApplyThrilledToAura(EmotionalBody);
        ApplyThrilledToAura(MentalBody);
        ApplyThrilledToAura(AstralBody);
        ApplyThrilledToAura(EthericTemplate);
        ApplyThrilledToAura(CelestialBody);
        ApplyThrilledToAura(CausalBody);
    }

    private void ApplyThrilledToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.9f; // Energetic, vibrant flow reflecting immense satisfaction
            main.startSize = 0.6f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // Dynamic, lively particle flow symbolizing excitement and joy
        }
    }
}
