using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraPeaceful : MonoBehaviour
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
        ApplyPeacefulAura();
    }

    public void ApplyPeacefulAura()
    {
        ApplyPeacefulToAura(EthericBody);
        ApplyPeacefulToAura(EmotionalBody);
        ApplyPeacefulToAura(MentalBody);
        ApplyPeacefulToAura(AstralBody);
        ApplyPeacefulToAura(EthericTemplate);
        ApplyPeacefulToAura(CelestialBody);
        ApplyPeacefulToAura(CausalBody);
    }

    private void ApplyPeacefulToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 0.8f; // Slow, steady flow for peacefulness
            main.startSize = 0.4f;
            main.startLifetime = 4.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 20f; // Gentle and slow flow representing peace and relaxation
        }
    }
}
