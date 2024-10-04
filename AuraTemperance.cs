using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraTemperance : MonoBehaviour
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
        ApplyTemperanceAura();
    }

    public void ApplyTemperanceAura()
    {
        ApplyTemperanceToAura(EthericBody);
        ApplyTemperanceToAura(EmotionalBody);
        ApplyTemperanceToAura(MentalBody);
        ApplyTemperanceToAura(AstralBody);
        ApplyTemperanceToAura(EthericTemplate);
        ApplyTemperanceToAura(CelestialBody);
        ApplyTemperanceToAura(CausalBody);
    }

    private void ApplyTemperanceToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Slow and gentle for temperance
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Warm, steady flow representing peaceful surroundings
        }
    }
}
