using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSurprised : MonoBehaviour
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
        ApplySurprisedAura();
    }

    public void ApplySurprisedAura()
    {
        ApplySurprisedToAura(EthericBody);
        ApplySurprisedToAura(EmotionalBody);
        ApplySurprisedToAura(MentalBody);
        ApplySurprisedToAura(AstralBody);
        ApplySurprisedToAura(EthericTemplate);
        ApplySurprisedToAura(CelestialBody);
        ApplySurprisedToAura(CausalBody);
    }

    private void ApplySurprisedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 2.0f; // Quick, sharp flow to reflect surprise
            main.startSize = 0.5f;
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // Dynamic flow symbolizing the sudden feeling of joy and surprise
        }
    }
}
