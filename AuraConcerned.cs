using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraConcerned : MonoBehaviour
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
        ApplyConcernedAura();
    }

    public void ApplyConcernedAura()
    {
        ApplyConcernedToAura(EthericBody);
        ApplyConcernedToAura(EmotionalBody);
        ApplyConcernedToAura(MentalBody);
        ApplyConcernedToAura(AstralBody);
        ApplyConcernedToAura(EthericTemplate);
        ApplyConcernedToAura(CelestialBody);
        ApplyConcernedToAura(CausalBody);
    }

    private void ApplyConcernedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Fluctuating flow to represent tension of concern
            main.startSize = 0.4f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Slightly erratic flow to symbolize the inner tension of concern
        }
    }
}
