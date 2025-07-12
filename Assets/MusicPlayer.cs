using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            // Ya existe otro MusicPlayer: destruye este
            Destroy(gameObject);
            return;
        }

        // Este es el primero, lo marcamos y no lo destruimos al cambiar de escena
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
