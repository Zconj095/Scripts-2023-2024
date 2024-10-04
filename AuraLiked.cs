using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraLiked : MonoBehaviour
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
        ApplyLikedAura();
    }

    public void ApplyLikedAura()
    {
        ApplyLikedToAura(EthericBody);
        ApplyLikedToAura(EmotionalBody);
        ApplyLikedToAura(MentalBody);
        ApplyLikedToAura(AstralBody);
        ApplyLikedToAura(EthericTemplate);
        ApplyLikedToAura(CelestialBody);
        ApplyLikedToAura(CausalBody);
    }

    private void ApplyLikedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Soft and gentle flow for acceptance
            main.startSize = 0.4f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Smooth and interconnected particle flow reflecting positive connection
        }
    }
}
