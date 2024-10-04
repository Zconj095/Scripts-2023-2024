using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraLoud : MonoBehaviour
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
        ApplyLoudAura();
    }

    public void ApplyLoudAura()
    {
        ApplyLoudToAura(EthericBody);
        ApplyLoudToAura(EmotionalBody);
        ApplyLoudToAura(MentalBody);
        ApplyLoudToAura(AstralBody);
        ApplyLoudToAura(EthericTemplate);
        ApplyLoudToAura(CelestialBody);
        ApplyLoudToAura(CausalBody);
    }

    private void ApplyLoudToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 2.0f; // Rapid and intense energy for loudness
            main.startSize = 0.7f;
            main.startLifetime = 2.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // High, intense bursts of particles to represent loud energy
        }
    }
}
