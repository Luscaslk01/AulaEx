using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    float _f1;
    float _f2;

    [SerializeField] int _i1;
    [SerializeField] int _i2;

    [SerializeField] string _t1;
    [SerializeField] string _t2;

    [SerializeField] bool _b1;
    bool _b2;

    // > Maior
    // < Menor
    // >= Maior ou igual 
    // <= Menor ou igual
    // != Diferente
    // == igual
    // && e
    // || ou

    // Start is called before the first frame update
    void Start()
    {
        if (_t1 == "Multiplicação")
        {
            // Debug.Log (_i1 * _i2);

        }
        else
        {
            // Debug.Log (_i1 + _i2);
        }
      


        if (_i1 == 2)
        {
            _t1 = "passgaem liberada";
        }
        else
        {
            _t1 = "passagem bloqueada";
        }
        // Debug.log (_t1);

        if(_i1 == _i2 && _b1 == true)
        {
            // Debug.Log("Encontrar na Fase")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
