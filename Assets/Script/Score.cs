using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   int count = 0;
   void OnCollisionEnter(Collision collision)
   {


      if (collision.collider.CompareTag("Fears"))
      {
         count++;
         Destroy(collision.gameObject);
         Debug.Log("Fears: ");
      }

   }
}