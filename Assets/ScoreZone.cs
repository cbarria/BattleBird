using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        // Busca el objeto con el tag Logic (ponle ese tag al GameObject que tenga LogicScript)
        if (logic == null)
            logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bird") // o compara por tag
        {
            logic.addScore();
        }
    }
}
