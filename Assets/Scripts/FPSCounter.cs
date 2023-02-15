using UnityEngine;
using TMPro; 

public class FPSCounter : MonoBehaviour
{

    public TextMeshProUGUI FpsText;
    private int frameCount;
    private float deltatime;
    public float pollingTime = 1f;

    // Update is called once per frame
    void Update()
    {
        deltatime += Time.deltaTime;
        frameCount++;
        if (deltatime >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / deltatime);
            FpsText.text = frameRate.ToString() + " FPS";

            deltatime -= pollingTime;
            frameCount = 0; 
        }
    }
}
