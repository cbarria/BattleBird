using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MatchWidth : MonoBehaviour
{
    [Tooltip("Ancho en unidades de mundo que quieres que siempre se vea")]
    public float targetWorldWidth = 8f;

    void Update()
    {
        // Sólo aplicamos en Play Mode
        if (!Application.isPlaying)
            return;

        var cam = GetComponent<Camera>();
        float windowAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = targetWorldWidth / (2f * windowAspect);
    }
}
