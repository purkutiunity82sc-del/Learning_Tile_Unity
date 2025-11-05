using UnityEngine;

public class Elevation_Entry_Tiles : MonoBehaviour
{
    public Collider2D[] mountainColliders;




    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = false;
             
            }

            
            collision.GetComponent<SpriteRenderer>().sortingOrder = 20;
           
        }
    }

   

}
