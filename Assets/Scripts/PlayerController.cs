using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float multiplier;
    int score;
    public Text textScore;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
             
    }


    void Update()
    {
        //Atur inputan
        float moveX = Input.acceleration.x;
        float moveY = Input.acceleration.y;

        //menghubungkan inputan dengan fungsi gerak
        Vector3 posisi = new Vector3(moveX, 0f, moveY);

        //fungsi gerak (menggerakan benda)
        rb.AddForce(posisi*multiplier);
    }


    void OnTriggerEnter(Collider other)
    {
        //jika other itu adalah kubus, 
        if(other.gameObject.tag == "Kubus")
        {
            //maka kubus hilang, skor bertambah, dan tampilkan score
            Destroy(other.gameObject);
            score++;
            textScore.text = "Score : " + score; 
        }
    }
}
