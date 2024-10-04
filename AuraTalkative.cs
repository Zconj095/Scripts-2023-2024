using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraTalkative : MonoBehaviour
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
        ApplyTalkativeAura();
    }

    public void ApplyTalkativeAura()
    {
        ApplyTalkativeToAura(EthericBody);
        ApplyTalkativeToAura(EmotionalBody);
        ApplyTalkativeToAura(MentalBody);
        ApplyTalkativeToAura(AstralBody);
        ApplyTalkativeToAura(EthericTemplate);
        ApplyTalkativeToAura(CelestialBody);
        ApplyTalkativeToAura(CausalBody);
    }

    private void ApplyTalkativeToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fast-moving particles to reflect energetic speech
            main.startSize = Random.Range(0.5f, 0.6f); // Slight variation for dynamic talkative energy
            main.startLifetime = 3.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // High particle output for continuous communication energy
        }
    }
}
