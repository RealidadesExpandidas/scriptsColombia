using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaAvatar2 : MonoBehaviour
{
    public float distanciaAvatar;
    public float velocidad;
    [Header("Personajes")]
    public GameObject avatar;
    public GameObject fruidor;
    [Header("PosicionesAvatar")]
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    float distancia;
    int cambio = 0;
    int posicion = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distancia = Vector3.Distance(fruidor.GetComponent<Transform>().position, avatar.GetComponent<Transform>().position);
       
        print("distancia" + distancia + "   " + cambio);

        // primer ciclo deteccion y movimiento

        if (distancia < distanciaAvatar && cambio == 0) // primera deteccion y movimiento
        {
                       cambio = 1;
        }

        if (cambio == 1)// se mueve hasta la primera posición
        {
            avatar.transform.position = Vector3.MoveTowards(avatar.transform.position, pos1.transform.position, velocidad * Time.deltaTime);
        }


        if (avatar.transform.position == pos1.transform.position)//si llega a la primera posición 
        {
            cambio = 2;
        }

        // segundo ciclo deteccion y movimiento

        if (distancia < distanciaAvatar && cambio == 2) // segunda  deteccion y movimiento
        {
            cambio = 3;
        }

        if (cambio == 3)// se mueve a la segunda posicion
        {
            avatar.transform.position = Vector3.MoveTowards(avatar.transform.position, pos2.transform.position, velocidad * Time.deltaTime);
        }
        if (avatar.transform.position == pos2.transform.position)//si llega a la segunda posición 
        {
            cambio = 4;
        }
    }

   
}

