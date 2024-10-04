using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraLoved : MonoBehaviour
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
        ApplyLovedAura();
    }

    public void ApplyLovedAura()
    {
        ApplyLovedToAura(EthericBody);
        ApplyLovedToAura(EmotionalBody);
        ApplyLovedToAura(MentalBody);
        ApplyLovedToAura(AstralBody);
        ApplyLovedToAura(EthericTemplate);
        ApplyLovedToAura(CelestialBody);
        ApplyLovedToAura(CausalBody);
    }

    private void ApplyLovedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.1f; // Warm and steady flow to reflect love
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Comforting and gentle flow symbolizing love and safety
        }
    }
}
