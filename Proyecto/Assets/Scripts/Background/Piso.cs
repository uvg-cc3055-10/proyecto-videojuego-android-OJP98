﻿/*
            Proyecto Final Plataformas Moviles y Juegos
    Autores: 
        Jose Cifuentes - 17509 
        Oscar Juarez   - 17315

    Fecha:
        22/05/2018 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    Rigidbody2D rb2d;    
    float speed = 5f;    

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = PlayerPrefs.GetFloat("velocidad");// se extrae la variable guardada en memoria 

        // si no ha perdido el jugador
        if (!GameController.instance.gameOver)
        {
            /*movemos el piso de posicion */
            rb2d.transform.Translate(Vector2.left * speed * Time.deltaTime);

            /*si el piso sale del area visible se destruye el objeto*/
            if (rb2d.transform.position.x < -20)
            {
                Destroy(gameObject);
            }
        }

    }
}