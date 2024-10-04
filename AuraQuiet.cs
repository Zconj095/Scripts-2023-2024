using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraQuiet : MonoBehaviour
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
        ApplyQuietAura();
    }

    public void ApplyQuietAura()
    {
        ApplyQuietToAura(EthericBody);
        ApplyQuietToAura(EmotionalBody);
        ApplyQuietToAura(MentalBody);
        ApplyQuietToAura(AstralBody);
        ApplyQuietToAura(EthericTemplate);
        ApplyQuietToAura(CelestialBody);
        ApplyQuietToAura(CausalBody);
    }

    private void ApplyQuietToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.6f; // Slow and subtle energy for quietness
            main.startSize = 0.3f;
            main.startLifetime = 5.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 15f; // Low emission rate reflecting a soft and quiet energy
        }
    }
}
