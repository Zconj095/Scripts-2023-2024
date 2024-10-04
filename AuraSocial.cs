using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSocial : MonoBehaviour
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
        ApplySocialAura();
    }

    public void ApplySocialAura()
    {
        ApplySocialToAura(EthericBody);
        ApplySocialToAura(EmotionalBody);
        ApplySocialToAura(MentalBody);
        ApplySocialToAura(AstralBody);
        ApplySocialToAura(EthericTemplate);
        ApplySocialToAura(CelestialBody);
        ApplySocialToAura(CausalBody);
    }

    private void ApplySocialToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.5f; // Lively and interconnected flow for social interaction
            main.startSize = 0.5f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 45f; // Dynamic, outward-flowing particles symbolizing openness and communication
        }
    }
}
