using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSerious : MonoBehaviour
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
        ApplySeriousAura();
    }

    public void ApplySeriousAura()
    {
        ApplySeriousToAura(EthericBody);
        ApplySeriousToAura(EmotionalBody);
        ApplySeriousToAura(MentalBody);
        ApplySeriousToAura(AstralBody);
        ApplySeriousToAura(EthericTemplate);
        ApplySeriousToAura(CelestialBody);
        ApplySeriousToAura(CausalBody);
    }

    private void ApplySeriousToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Steady and focused flow to reflect discipline
            main.startSize = 0.4f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Controlled and precise particle emission for serious focus
        }
    }
}
