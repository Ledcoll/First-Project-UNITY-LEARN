using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
   
    private float speed = 20f;
    private float turnSpeed = 26f;
    private float horizontalImput;
    private float verticalImput;

  

   

    // Update is called once per frame
    void Update()
    {
        // AQUI VOCÊ MOVE BURRO
        horizontalImput = Input.GetAxis("Horizontal");
        verticalImput = Input.GetAxis("Vertical");


        // Move o Ricardo com base nos eixos da vertical (trás e frente)
        transform.Translate (Vector3.forward * Time.deltaTime * speed * verticalImput );

        // Move o Ricardo baseado nos eixos da horizontal (esquerda e direita)
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalImput  );
    }
}
