using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5f;

    [Header("Audio")]
    public AudioSource sfxSource;    // Arrastrar aquí el AudioSource del pájaro
    public AudioClip jumpClip;       // Asignar tu jump.wav
    public AudioClip deathClip;      // Asignar tu death.wav

    // Dispositivos del Input System
    Keyboard keyboard;
    Mouse mouse;
    Touchscreen touchscreen;

    void Awake()
    {
        // Cacheamos los dispositivos
        keyboard = Keyboard.current;
        mouse = Mouse.current;
        touchscreen = Touchscreen.current;
    }

    void Update()
    {
        bool shouldFlap = false;

        // Teclado (Espacio)
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
            shouldFlap = true;

        // Click izquierdo (Mouse)
        if (mouse != null && mouse.leftButton.wasPressedThisFrame)
            shouldFlap = true;

        // Tap en pantalla (Touchscreen)
        if (touchscreen != null && touchscreen.primaryTouch.press.wasPressedThisFrame)
            shouldFlap = true;

        if (shouldFlap)
            Flap();
    }

    void Flap()
    {
        // Sonido de salto
        if (sfxSource != null && jumpClip != null)
            sfxSource.PlayOneShot(jumpClip);

        // Física (usar velocity en lugar de linearVelocity)
        myRigidbody.linearVelocity = Vector2.up * flapStrength;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Sonido de muerte
        if (sfxSource != null && deathClip != null)
            sfxSource.PlayOneShot(deathClip);

        // Obtenemos el score final del LogicScript
        int finalScore = FindObjectOfType<LogicScript>().playerScore;

        // Llamamos al GameManager para que maneje el Game Over
        GameManager.Instance.GameOver(finalScore);
    }
}
