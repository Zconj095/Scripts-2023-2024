using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraJoy : MonoBehaviour
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
        ApplyJoyAura();
    }

    public void ApplyJoyAura()
    {
        ApplyJoyToAura(EthericBody);
        ApplyJoyToAura(EmotionalBody);
        ApplyJoyToAura(MentalBody);
        ApplyJoyToAura(AstralBody);
        ApplyJoyToAura(EthericTemplate);
        ApplyJoyToAura(CelestialBody);
        ApplyJoyToAura(CausalBody);
    }

    private void ApplyJoyToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.9f; // Fast, energetic flow for joy
            main.startSize = Random.Range(0.5f, 0.7f); // Bright, fluctuating particles for joy
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High energy output for overwhelming happiness
        }
    }
}
