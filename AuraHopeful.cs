using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHopeful : MonoBehaviour
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
        ApplyHopefulAura();
    }

    public void ApplyHopefulAura()
    {
        ApplyHopefulToAura(EthericBody);
        ApplyHopefulToAura(EmotionalBody);
        ApplyHopefulToAura(MentalBody);
        ApplyHopefulToAura(AstralBody);
        ApplyHopefulToAura(EthericTemplate);
        ApplyHopefulToAura(CelestialBody);
        ApplyHopefulToAura(CausalBody);
    }

    private void ApplyHopefulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Light and smooth upward flow for hope
            main.startSize = 0.4f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Continuous particle flow reflecting faith and hope
        }
    }
}
