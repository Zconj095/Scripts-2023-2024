using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraOffensive : MonoBehaviour
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
        ApplyOffensiveAura();
    }

    public void ApplyOffensiveAura()
    {
        ApplyOffensiveToAura(EthericBody);
        ApplyOffensiveToAura(EmotionalBody);
        ApplyOffensiveToAura(MentalBody);
        ApplyOffensiveToAura(AstralBody);
        ApplyOffensiveToAura(EthericTemplate);
        ApplyOffensiveToAura(CelestialBody);
        ApplyOffensiveToAura(CausalBody);
    }

    private void ApplyOffensiveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 2.0f; // Sharp and fast flow for aggressive action
            main.startSize = 0.6f;
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // Intense and pointed flow symbolizing offensive readiness
        }
    }
}
