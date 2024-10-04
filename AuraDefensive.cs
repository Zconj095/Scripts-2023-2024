using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraDefensive : MonoBehaviour
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
        ApplyDefensiveAura();
    }

    public void ApplyDefensiveAura()
    {
        ApplyDefensiveToAura(EthericBody);
        ApplyDefensiveToAura(EmotionalBody);
        ApplyDefensiveToAura(MentalBody);
        ApplyDefensiveToAura(AstralBody);
        ApplyDefensiveToAura(EthericTemplate);
        ApplyDefensiveToAura(CelestialBody);
        ApplyDefensiveToAura(CausalBody);
    }

    private void ApplyDefensiveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fast-moving particles to reflect defensive alertness
            main.startSize = 0.6f;
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy output with rapid changes for defensive behavior
        }
    }
}
