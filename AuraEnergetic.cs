using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraEnergetic : MonoBehaviour
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
        ApplyEnergeticAura();
    }

    public void ApplyEnergeticAura()
    {
        ApplyEnergeticToAura(EthericBody);
        ApplyEnergeticToAura(EmotionalBody);
        ApplyEnergeticToAura(MentalBody);
        ApplyEnergeticToAura(AstralBody);
        ApplyEnergeticToAura(EthericTemplate);
        ApplyEnergeticToAura(CelestialBody);
        ApplyEnergeticToAura(CausalBody);
    }

    private void ApplyEnergeticToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 2.0f; // Fast and charged particles for high energy
            main.startSize = 0.6f;
            main.startLifetime = 2.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 55f; // Very high emission rate reflecting an energized state
        }
    }
}
