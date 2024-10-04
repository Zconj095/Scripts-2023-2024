using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraCalmFeeling : MonoBehaviour
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
        ApplyCalmAura();
    }

    public void ApplyCalmAura()
    {
        ApplyCalmToAura(EthericBody);
        ApplyCalmToAura(EmotionalBody);
        ApplyCalmToAura(MentalBody);
        ApplyCalmToAura(AstralBody);
        ApplyCalmToAura(EthericTemplate);
        ApplyCalmToAura(CelestialBody);
        ApplyCalmToAura(CausalBody);
    }

    private void ApplyCalmToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.8f; // Slow-moving particles for calmness
            main.startSize = 0.5f;
            main.startLifetime = 5.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 10f; // Low particle count, steady flow to maintain peaceful energy
        }
    }
}
