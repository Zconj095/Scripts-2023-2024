using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraGraceful : MonoBehaviour
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
        ApplyGracefulAura();
    }

    public void ApplyGracefulAura()
    {
        ApplyGracefulToAura(EthericBody);
        ApplyGracefulToAura(EmotionalBody);
        ApplyGracefulToAura(MentalBody);
        ApplyGracefulToAura(AstralBody);
        ApplyGracefulToAura(EthericTemplate);
        ApplyGracefulToAura(CelestialBody);
        ApplyGracefulToAura(CausalBody);
    }

    private void ApplyGracefulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.0f; // Smooth and fluid flow for grace
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 20f; // Elegant and vivid flow symbolizing gracefulness
        }
    }
}
