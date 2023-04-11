using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   int fear;
   public Text text;
   
   public void AddFear()
   {
        fear++;
        text.text = "Fears: " + fear;
   }

}