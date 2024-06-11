using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionAreaScript : MonoBehaviour
{
    public int puntos;
    public Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PickUpScript objeto;
        objeto = other.GetComponent<PickUpScript>();
        if (objeto.esComida == true)
        {
            Destroy(other.gameObject);
            Debug.Log("Era comida");
            puntos += objeto.puntosItem;
            puntaje.text = puntos.ToString();
        }
        else if (objeto.esComida == false)
        {
            puntos += objeto.puntosItem;
            puntaje.text = puntos.ToString();
        }
    }
}
