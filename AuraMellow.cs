using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraMellow : MonoBehaviour
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
        ApplyMellowAura();
    }

    public void ApplyMellowAura()
    {
        ApplyMellowToAura(EthericBody);
        ApplyMellowToAura(EmotionalBody);
        ApplyMellowToAura(MentalBody);
        ApplyMellowToAura(AstralBody);
        ApplyMellowToAura(EthericTemplate);
        ApplyMellowToAura(CelestialBody);
        ApplyMellowToAura(CausalBody);
    }

    private void ApplyMellowToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.8f; // Slow and gentle for mellow energy
            main.startSize = 0.4f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 15f; // Low and steady flow to represent a calm and gentle state
        }
    }
}
