using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSelfless : MonoBehaviour
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
        ApplySelflessAura();
    }

    public void ApplySelflessAura()
    {
        ApplySelflessToAura(EthericBody);
        ApplySelflessToAura(EmotionalBody);
        ApplySelflessToAura(MentalBody);
        ApplySelflessToAura(AstralBody);
        ApplySelflessToAura(EthericTemplate);
        ApplySelflessToAura(CelestialBody);
        ApplySelflessToAura(CausalBody);
    }

    private void ApplySelflessToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Soft and harmonious flow for selflessness
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Calm, outward-flowing particles symbolizing focus on others
        }
    }
}
