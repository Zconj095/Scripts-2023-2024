using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSensitive : MonoBehaviour
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
        ApplySensitiveAura();
    }

    public void ApplySensitiveAura()
    {
        ApplySensitiveToAura(EthericBody);
        ApplySensitiveToAura(EmotionalBody);
        ApplySensitiveToAura(MentalBody);
        ApplySensitiveToAura(AstralBody);
        ApplySensitiveToAura(EthericTemplate);
        ApplySensitiveToAura(CelestialBody);
        ApplySensitiveToAura(CausalBody);
    }

    private void ApplySensitiveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.6f; // Fluctuating and dynamic flow for sensitivity
            main.startSize = 0.4f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Reactive and soft flow symbolizing heightened awareness
        }
    }
}
