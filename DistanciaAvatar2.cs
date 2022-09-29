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
    // Start is called before the first frame update
    void Start()
    {
        distancia = Vector3.Distance(fruidor.GetComponent<Transform>().position, avatar.GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        if (distancia < distanciaAvatar)
        {

            switch (cambio){

                case 0:
                    avatar.transform.position = Vector3.MoveTowards(avatar.transform.position, pos1.transform.position, velocidad * Time.deltaTime);
                    cambio = cambio + 1;
                    break;
                case 1:
                    avatar.transform.position = Vector3.MoveTowards(avatar.transform.position, pos2.transform.position, velocidad * Time.deltaTime);
                    cambio = cambio + 1;
                    break;
                case 2:
                    avatar.transform.position = Vector3.MoveTowards(avatar.transform.position, pos3.transform.position, velocidad * Time.deltaTime);
                    cambio = cambio + 1;
                    break;
            }
        }
    }
}
