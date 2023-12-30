using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float jumpDistance = 1.0f; // Die Distanz, um die sich der Charakter bewegen soll
    public Animator anim;
    public int value = 1;

    public AudioSource audioPlayer;

   void Start()
    {
       
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        // Überprüfen, ob die Leertaste (Space-Taste) gedrückt wurde
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Bewegungsfunktion aufrufen, um den Charakter nach oben zu bewegen
            audioPlayer.Play();
            MoveUp();
            Score.instance.IncreaseCoins(value);
            
        }
    }

    // Funktion, um den Charakter nach oben zu bewegen
    void MoveUp()
    {
        anim.SetTrigger("Swim");
        // Aktuelle Position des Charakters
        Vector3 currentPosition = transform.position;

        // Neue Position nach dem Bewegen um 'jumpDistance' Einheiten nach oben
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + jumpDistance, currentPosition.z);

        // Die Position des Charakters aktualisieren
        transform.position = newPosition;
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); 
        }
    }

}
