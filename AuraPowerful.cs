using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraPowerful : MonoBehaviour
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
        ApplyPowerfulAura();
    }

    public void ApplyPowerfulAura()
    {
        ApplyPowerfulToAura(EthericBody);
        ApplyPowerfulToAura(EmotionalBody);
        ApplyPowerfulToAura(MentalBody);
        ApplyPowerfulToAura(AstralBody);
        ApplyPowerfulToAura(EthericTemplate);
        ApplyPowerfulToAura(CelestialBody);
        ApplyPowerfulToAura(CausalBody);
    }

    private void ApplyPowerfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Bold and dynamic flow for power
            main.startSize = 0.7f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // Strong and forceful flow symbolizing capability and authority
        }
    }
}
