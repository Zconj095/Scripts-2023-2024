using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraBeautiful : MonoBehaviour
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
        ApplyBeautifulAura();
    }

    public void ApplyBeautifulAura()
    {
        ApplyBeautifulToAura(EthericBody);
        ApplyBeautifulToAura(EmotionalBody);
        ApplyBeautifulToAura(MentalBody);
        ApplyBeautifulToAura(AstralBody);
        ApplyBeautifulToAura(EthericTemplate);
        ApplyBeautifulToAura(CelestialBody);
        ApplyBeautifulToAura(CausalBody);
    }

    private void ApplyBeautifulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Smooth and radiant flow to reflect beauty
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Soft, harmonious particle flow symbolizing beauty
        }
    }
}
