using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraJoyful : MonoBehaviour
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
        ApplyJoyfulAura();
    }

    public void ApplyJoyfulAura()
    {
        ApplyJoyfulToAura(EthericBody);
        ApplyJoyfulToAura(EmotionalBody);
        ApplyJoyfulToAura(MentalBody);
        ApplyJoyfulToAura(AstralBody);
        ApplyJoyfulToAura(EthericTemplate);
        ApplyJoyfulToAura(CelestialBody);
        ApplyJoyfulToAura(CausalBody);
    }

    private void ApplyJoyfulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Fast and vibrant for joy
            main.startSize = Random.Range(0.5f, 0.7f); // Dynamic, fluctuating size for joyfulness
            main.startLifetime = 2.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // High particle emission for the energetic joy
        }
    }
}
