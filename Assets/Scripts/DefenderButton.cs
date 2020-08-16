using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer m_SpriteRender;
    SpawnDefender spawnDefender;
    private void Start() {
      spawnDefender = FindObjectOfType<SpawnDefender>();
    }
    [SerializeField] public Defenders defenderPrefab; //Select which defender to spawn
    private void OnMouseDown()
    {
        /*  At the start both button becomes inactive but the button we clicked will become active
         when we click on any other button again each button will become inactive but the button 
         we clicked will become active */


        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons) 
        
        /* we use foreach loop to iterate through 
        multiple items in a list or collection, here buttons is a collection of button which
        contain an object of type DefenderButton */
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(75, 62, 62, 255); /* both buttons are inactive */
        }
        //Pass the selected defender for spawning
        spawnDefender.SetSelectedDefender(defenderPrefab);

        m_SpriteRender = GetComponent<SpriteRenderer>();
        m_SpriteRender.color = Color.white;  /* The button is active */

    }
}
