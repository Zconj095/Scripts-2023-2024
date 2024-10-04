using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraAdmiration : MonoBehaviour
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
        ApplyAdmirationAura();
    }

    public void ApplyAdmirationAura()
    {
        ApplyAdmirationToAura(EthericBody);
        ApplyAdmirationToAura(EmotionalBody);
        ApplyAdmirationToAura(MentalBody);
        ApplyAdmirationToAura(AstralBody);
        ApplyAdmirationToAura(EthericTemplate);
        ApplyAdmirationToAura(CelestialBody);
        ApplyAdmirationToAura(CausalBody);
    }

    private void ApplyAdmirationToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Slightly faster flow to reflect admiration
            main.startSize = 0.5f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Positive energy flow to symbolize respect and admiration
        }
    }
}
