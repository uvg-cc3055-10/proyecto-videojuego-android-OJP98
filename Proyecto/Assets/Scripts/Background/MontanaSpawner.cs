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

public class MontanaSpawner : MonoBehaviour
{

    public GameObject montana;
    public float spawnTime = 0.2f;
    public float elapsedTime = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // si no ha perdido el jugador
        if (!GameController.instance.gameOver)
        {
            /*se incrementa el lapso de la creacion de montanas*/
            if (elapsedTime < spawnTime)
            {
                float random = Random.Range(70, 200);
                elapsedTime += Time.deltaTime/random;
            }
            else
            {                
                /*se crea una montana en una posicion al azar, partiendo desde arriba*/
                Instantiate(montana, new Vector3(37,2, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }

    }
}
