using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHope : MonoBehaviour
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
        ApplyHopeAura();
    }

    public void ApplyHopeAura()
    {
        ApplyHopeToAura(EthericBody);
        ApplyHopeToAura(EmotionalBody);
        ApplyHopeToAura(MentalBody);
        ApplyHopeToAura(AstralBody);
        ApplyHopeToAura(EthericTemplate);
        ApplyHopeToAura(CelestialBody);
        ApplyHopeToAura(CausalBody);
    }

    private void ApplyHopeToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Steady, upward flow for perseverance
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Continuous upward flow to symbolize hope
        }
    }
}
