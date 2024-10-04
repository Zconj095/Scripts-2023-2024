using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraCourage : MonoBehaviour
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
        ApplyCourageAura();
    }

    public void ApplyCourageAura()
    {
        ApplyCourageToAura(EthericBody);
        ApplyCourageToAura(EmotionalBody);
        ApplyCourageToAura(MentalBody);
        ApplyCourageToAura(AstralBody);
        ApplyCourageToAura(EthericTemplate);
        ApplyCourageToAura(CelestialBody);
        ApplyCourageToAura(CausalBody);
    }

    private void ApplyCourageToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Bold, strong flow to reflect courage
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Steady, powerful energy to symbolize courage and bravery
        }
    }
}
