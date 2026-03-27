using UnityEngine;

public class GradientBackgroundTransitionScript : MonoBehaviour
{
    [SerializeField] Gradient gradient;
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

        if (t > 1.0f)
        {
            t = 0f;
        }

        //evaluate color at time t and apply to background
        Color color = gradient.Evaluate(t);
        //background
        Camera.main.backgroundColor = color;
    }
}
