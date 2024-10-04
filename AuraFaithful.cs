using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraFaithful : MonoBehaviour
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
        ApplyFaithfulAura();
    }

    public void ApplyFaithfulAura()
    {
        ApplyFaithfulToAura(EthericBody);
        ApplyFaithfulToAura(EmotionalBody);
        ApplyFaithfulToAura(MentalBody);
        ApplyFaithfulToAura(AstralBody);
        ApplyFaithfulToAura(EthericTemplate);
        ApplyFaithfulToAura(CelestialBody);
        ApplyFaithfulToAura(CausalBody);
    }

    private void ApplyFaithfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.4f; // Steady and continuous flow for loyalty and commitment
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Consistent particle emission to reflect dedication and faithfulness
        }
    }
}
