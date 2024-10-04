using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraGreat : MonoBehaviour
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
        ApplyGreatAura();
    }

    public void ApplyGreatAura()
    {
        ApplyGreatToAura(EthericBody);
        ApplyGreatToAura(EmotionalBody);
        ApplyGreatToAura(MentalBody);
        ApplyGreatToAura(AstralBody);
        ApplyGreatToAura(EthericTemplate);
        ApplyGreatToAura(CelestialBody);
        ApplyGreatToAura(CausalBody);
    }

    private void ApplyGreatToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Strong and radiant flow for positivity
            main.startSize = 0.6f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 40f; // Confident and bright flow to reflect feeling great
        }
    }
}
