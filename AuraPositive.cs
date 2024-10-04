using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraPositive : MonoBehaviour
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
        ApplyPositiveAura();
    }

    public void ApplyPositiveAura()
    {
        ApplyPositiveToAura(EthericBody);
        ApplyPositiveToAura(EmotionalBody);
        ApplyPositiveToAura(MentalBody);
        ApplyPositiveToAura(AstralBody);
        ApplyPositiveToAura(EthericTemplate);
        ApplyPositiveToAura(CelestialBody);
        ApplyPositiveToAura(CausalBody);
    }

    private void ApplyPositiveToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Smooth and radiant flow for positivity
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Bright and continuous flow symbolizing positivity and higher values
        }
    }
}
