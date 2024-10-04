using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraGrateful : MonoBehaviour
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
        ApplyGratefulAura();
    }

    public void ApplyGratefulAura()
    {
        ApplyGratefulToAura(EthericBody);
        ApplyGratefulToAura(EmotionalBody);
        ApplyGratefulToAura(MentalBody);
        ApplyGratefulToAura(AstralBody);
        ApplyGratefulToAura(EthericTemplate);
        ApplyGratefulToAura(CelestialBody);
        ApplyGratefulToAura(CausalBody);
    }

    private void ApplyGratefulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Gentle and warm for gratitude
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 20f; // Gentle and steady flow symbolizing appreciation
        }
    }
}
