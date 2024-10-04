using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraSensational : MonoBehaviour
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
        ApplySensationalAura();
    }

    public void ApplySensationalAura()
    {
        ApplySensationalToAura(EthericBody);
        ApplySensationalToAura(EmotionalBody);
        ApplySensationalToAura(MentalBody);
        ApplySensationalToAura(AstralBody);
        ApplySensationalToAura(EthericTemplate);
        ApplySensationalToAura(CelestialBody);
        ApplySensationalToAura(CausalBody);
    }

    private void ApplySensationalToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.8f; // Vibrant and dynamic flow to reflect heightened sensory experience
            main.startSize = 0.5f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 50f; // Fast-moving and energetic flow symbolizing sensory excitement
        }
    }
}
