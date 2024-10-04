using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraNarrative : MonoBehaviour
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
        ApplyNarrativeAura();
    }

    public void ApplyNarrativeAura()
    {
        ApplyNarrativeToAura(EthericBody);
        ApplyNarrativeToAura(EmotionalBody);
        ApplyNarrativeToAura(MentalBody);
        ApplyNarrativeToAura(AstralBody);
        ApplyNarrativeToAura(EthericTemplate);
        ApplyNarrativeToAura(CelestialBody);
        ApplyNarrativeToAura(CausalBody);
    }

    private void ApplyNarrativeToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Flowing, dynamic energy for expression
            main.startSize = Random.Range(0.5f, 0.7f); // Fluctuating size for emphasis in narrative
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Changing intensity to reflect narrative emphasis
        }
    }
}
