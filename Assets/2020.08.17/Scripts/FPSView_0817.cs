using UnityEngine;

public class FPSView_0817 : MonoBehaviour
{
    public float updateInterval = 1f;
    private float accum = 0;
    private int frames = 0;
    private float timeleft;
    private string stringFPS;

    private void Start ()
    {
        timeleft = updateInterval;
    }

    private void Update ()
    {
        timeleft -= Time.deltaTime;
        Debug.Log("timeLeft:"+timeleft);
        accum += Time.timeScale / Time.deltaTime;
        Debug.Log("Accum:"+accum);
        ++frames;
        Debug.Log("Frames:"+frames);
        if (timeleft <= 0.0)
        {
            float fps = accum / frames;
            Debug.Log("fps:"+fps);
            string format = System.String.Format ("{0:F2} FPS", fps);
            stringFPS = format;
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    private void OnGUI ()
    {
        GUIStyle gUIStyle=GUIStyle.none;
        gUIStyle.fontSize=30;
        gUIStyle.normal.textColor=Color.red;
        gUIStyle.alignment=TextAnchor.UpperLeft;
        Rect rect=new Rect(40,0,100,100);
        GUI.Label(rect,stringFPS,gUIStyle);
    }
}