using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraThankful : MonoBehaviour
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
        ApplyThankfulAura();
    }

    public void ApplyThankfulAura()
    {
        ApplyThankfulToAura(EthericBody);
        ApplyThankfulToAura(EmotionalBody);
        ApplyThankfulToAura(MentalBody);
        ApplyThankfulToAura(AstralBody);
        ApplyThankfulToAura(EthericTemplate);
        ApplyThankfulToAura(CelestialBody);
        ApplyThankfulToAura(CausalBody);
    }

    private void ApplyThankfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Light, steady flow to reflect thankfulness and relief
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 35f; // Soothing, comforting particle flow reflecting gratitude and emotional release
        }
    }
}
