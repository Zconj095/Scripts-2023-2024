using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraFascinated : MonoBehaviour
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
        ApplyFascinatedAura();
    }

    public void ApplyFascinatedAura()
    {
        ApplyFascinatedToAura(EthericBody);
        ApplyFascinatedToAura(EmotionalBody);
        ApplyFascinatedToAura(MentalBody);
        ApplyFascinatedToAura(AstralBody);
        ApplyFascinatedToAura(EthericTemplate);
        ApplyFascinatedToAura(CelestialBody);
        ApplyFascinatedToAura(CausalBody);
    }

    private void ApplyFascinatedToAura(GameObject auraLayer)
    {
        ParticleSystem particleSystem = auraLayer.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            var main = particleSystem.main;
            main.simulationSpeed = 1.7f; // Vibrant and energetic flow to reflect fascination
            main.startSize = 0.5f;
            main.startLifetime = 3.5f;

            var emission = particleSystem.emission;
            emission.rateOverTime = 45f; // High energy flow to reflect engagement and satisfaction with experiences
        }
    }
}
