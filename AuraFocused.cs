using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraFocused : MonoBehaviour
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
        ApplyFocusedAura();
    }

    public void ApplyFocusedAura()
    {
        ApplyFocusedToAura(EthericBody);
        ApplyFocusedToAura(EmotionalBody);
        ApplyFocusedToAura(MentalBody);
        ApplyFocusedToAura(AstralBody);
        ApplyFocusedToAura(EthericTemplate);
        ApplyFocusedToAura(CelestialBody);
        ApplyFocusedToAura(CausalBody);
    }

    private void ApplyFocusedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Sharp and steady flow for focus
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Controlled and concentrated flow reflecting clarity
        }
    }
}
