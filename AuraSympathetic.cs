using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSympathetic : MonoBehaviour
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
        ApplySympatheticAura();
    }

    public void ApplySympatheticAura()
    {
        ApplySympatheticToAura(EthericBody);
        ApplySympatheticToAura(EmotionalBody);
        ApplySympatheticToAura(MentalBody);
        ApplySympatheticToAura(AstralBody);
        ApplySympatheticToAura(EthericTemplate);
        ApplySympatheticToAura(CelestialBody);
        ApplySympatheticToAura(CausalBody);
    }

    private void ApplySympatheticToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.2f; // Soft, smooth flow for empathy and connection
            main.startSize = 0.5f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Gentle, interconnected flow symbolizing compassion and understanding
        }
    }
}
