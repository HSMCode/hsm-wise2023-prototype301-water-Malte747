using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementParticles : MonoBehaviour
{
    
    public float jumpDistance = 1.0f; // Die Distanz, um die sich der Charakter bewegen soll
    public int value = 1;


   void Start()
    {
       
  
    }

    void Update()
    {
        // Überprüfen, ob die Leertaste (Space-Taste) gedrückt wurde
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Bewegungsfunktion aufrufen, um den Charakter nach oben zu bewegen
           
            MoveUp();
           
          
            
        }
    }

    // Funktion, um den Charakter nach oben zu bewegen
    void MoveUp()
    {
       
        // Aktuelle Position des Charakters
        Vector3 currentPosition = transform.position;

        // Neue Position nach dem Bewegen um 'jumpDistance' Einheiten nach oben
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + jumpDistance, currentPosition.z);

        // Die Position des Charakters aktualisieren
        transform.position = newPosition;
        
    }


}
