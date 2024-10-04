using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraCourageous : MonoBehaviour
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
        ApplyCourageousAura();
    }

    public void ApplyCourageousAura()
    {
        ApplyCourageousToAura(EthericBody);
        ApplyCourageousToAura(EmotionalBody);
        ApplyCourageousToAura(MentalBody);
        ApplyCourageousToAura(AstralBody);
        ApplyCourageousToAura(EthericTemplate);
        ApplyCourageousToAura(CelestialBody);
        ApplyCourageousToAura(CausalBody);
    }

    private void ApplyCourageousToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Bold and dynamic flow for courage
            main.startSize = 0.6f;
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // Strong and focused flow symbolizing bravery
        }
    }
}
