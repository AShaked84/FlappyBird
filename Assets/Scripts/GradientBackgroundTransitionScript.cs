using UnityEngine;

public class GradientBackgroundTransitionScript : MonoBehaviour
{
    [SerializeField] Gradient skyGradient;
    [SerializeField] Gradient cloudGradient;
    [SerializeField] private ParticleSystem ps;

    [SerializeField] float cloudDelay = 0.5f;
    [SerializeField] float duration;

    void Update()
    {
        float skyT = Mathf.PingPong(Time.time / duration, 1f);
        skyT = Mathf.SmoothStep(0f, 1f, skyT);

        float cloudT = Mathf.PingPong((Time.time + cloudDelay) / duration, 1f);
        cloudT = Mathf.SmoothStep(0f, 1f, cloudT);

        Color skyColor = skyGradient.Evaluate(skyT);
        Color cloudColor = cloudGradient.Evaluate(cloudT);

        Camera.main.backgroundColor = skyColor;

        var main = ps.main;
        main.startColor = cloudColor;

        var renderer = ps.GetComponent<ParticleSystemRenderer>();
        renderer.material.color = cloudColor;
    }
}

/*using UnityEngine;

public class GradientBackgroundTransitionScript : MonoBehaviour
{
    [SerializeField] Gradient skyGradient;
    [SerializeField] Gradient cloudGradient;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] float cloudDelay = 0.5f; 
    [SerializeField] float duration;
    private float t = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //normalize time loop and ping-pong through it
        t = Mathf.PingPong(Time.time / duration, 1f);
        t = Mathf.SmoothStep(0f, 1f, t);

        //evaluate color at time t and apply to background
        Color skyColor = skyGradient.Evaluate(t);
        Color cloudColor = cloudGradient.Evaluate(t);
        //background
        Camera.main.backgroundColor = skyColor;
        var main = ps.main;
        main.startColor = cloudColor;
        var renderer = ps.GetComponent<ParticleSystemRenderer>();
        renderer.material.color = cloudColor;
    }
}*/
