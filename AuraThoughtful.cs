using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraThoughtful : MonoBehaviour
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
        ApplyThoughtfulAura();
    }

    public void ApplyThoughtfulAura()
    {
        ApplyThoughtfulToAura(EthericBody);
        ApplyThoughtfulToAura(EmotionalBody);
        ApplyThoughtfulToAura(MentalBody);
        ApplyThoughtfulToAura(AstralBody);
        ApplyThoughtfulToAura(EthericTemplate);
        ApplyThoughtfulToAura(CelestialBody);
        ApplyThoughtfulToAura(CausalBody);
    }

    private void ApplyThoughtfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Steady, calm flow reflecting thoughtful action
            main.startSize = 0.4f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Gentle, fluid particle flow symbolizing clarity and thoughtfulness
        }
    }
}
