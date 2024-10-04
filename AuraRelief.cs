using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraRelief : MonoBehaviour
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
        ApplyReliefAura();
    }

    public void ApplyReliefAura()
    {
        ApplyReliefToAura(EthericBody);
        ApplyReliefToAura(EmotionalBody);
        ApplyReliefToAura(MentalBody);
        ApplyReliefToAura(AstralBody);
        ApplyReliefToAura(EthericTemplate);
        ApplyReliefToAura(CelestialBody);
        ApplyReliefToAura(CausalBody);
    }

    private void ApplyReliefToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.1f; // Light and uplifting flow to symbolize relief
            main.startSize = 0.5f;
            main.startLifetime = 4.0f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 25f; // Soothing and comforting flow symbolizing the release of tension
        }
    }
}
