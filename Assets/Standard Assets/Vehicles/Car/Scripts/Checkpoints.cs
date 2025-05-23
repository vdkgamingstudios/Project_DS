using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Checkpoints : MonoBehaviour
{
   public bool CheckPoint1 = true;
   public bool CheckPoint2 = false;

   private void OnTriggerEnter(Collider other)
   {
        if (other.gameObject.CompareTag("Player"))
        {
            if(CheckPoint1 == true)
            {
                SaveScript.ThisCheckPoint1 = SaveScript.GameTime;
                SaveScript.CheckPointPass1 = true;
            }

            if (CheckPoint2 == true)
            {
                SaveScript.ThisCheckPoint2 = SaveScript.GameTime;
                SaveScript.CheckPointPass2 = true;
            }
        }
   }
}
