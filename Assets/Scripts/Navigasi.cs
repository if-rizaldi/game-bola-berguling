using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigasi : MonoBehaviour
{
   void Retry()
   {
       Application.LoadLevel(Application.loadedLevel);
   }

   void Keluar()
   {
       Application.Quit();
   }
}
