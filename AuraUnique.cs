using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraUnique : MonoBehaviour
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
        ApplyUniqueAura();
    }

    public void ApplyUniqueAura()
    {
        ApplyUniqueToAura(EthericBody);
        ApplyUniqueToAura(EmotionalBody);
        ApplyUniqueToAura(MentalBody);
        ApplyUniqueToAura(AstralBody);
        ApplyUniqueToAura(EthericTemplate);
        ApplyUniqueToAura(CelestialBody);
        ApplyUniqueToAura(CausalBody);
    }

    private void ApplyUniqueToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Slightly irregular and radiant flow for uniqueness
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Distinct, patterned flow symbolizing individuality and specialness
        }
    }
}
