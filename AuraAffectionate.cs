using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraAffectionate : MonoBehaviour
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
        ApplyAffectionateAura();
    }

    public void ApplyAffectionateAura()
    {
        ApplyAffectionateToAura(EthericBody);
        ApplyAffectionateToAura(EmotionalBody);
        ApplyAffectionateToAura(MentalBody);
        ApplyAffectionateToAura(AstralBody);
        ApplyAffectionateToAura(EthericTemplate);
        ApplyAffectionateToAura(CelestialBody);
        ApplyAffectionateToAura(CausalBody);
    }

    private void ApplyAffectionateToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Gentle and dynamic flow representing affection
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Warm, fluctuating energy symbolizing affectionate feelings
        }
    }
}
