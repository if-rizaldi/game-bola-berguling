using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigasi : MonoBehaviour
{
   public void Retry()
   {
       Application.LoadLevel(Application.loadedLevel);
   }

   public void Keluar()
   {
       Application.Quit();
   }
}
