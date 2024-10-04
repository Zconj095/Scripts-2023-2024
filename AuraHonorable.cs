using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraHonorable : MonoBehaviour
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
        ApplyHonorableAura();
    }

    public void ApplyHonorableAura()
    {
        ApplyHonorableToAura(EthericBody);
        ApplyHonorableToAura(EmotionalBody);
        ApplyHonorableToAura(MentalBody);
        ApplyHonorableToAura(AstralBody);
        ApplyHonorableToAura(EthericTemplate);
        ApplyHonorableToAura(CelestialBody);
        ApplyHonorableToAura(CausalBody);
    }

    private void ApplyHonorableToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.3f; // Steady and calm flow to symbolize honor
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 30f; // Graceful, reliable flow to reflect commitment and honor
        }
    }
}
