using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiculosmanager : MonoBehaviour
{
    public Vehiculo vehiculoScipt;
    // Start is called before the first frame update
    void Start()
    {
        int cantRuedasVehiculo = vehiculoScipt.cantRuedas;
        Debug.Log("Cant ruedas: " + cantRuedasVehiculo);
        if(cantRuedasVehiculo < 6 )
        {
            vehiculoScipt.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
