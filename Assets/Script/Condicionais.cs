using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    float _f1;
    float _f2;

    [SerializeField] int _i1;
    [SerializeField] int _i2;

    string _s1;
    string _s2;

    bool _b1;
    bool _b2;

    // > Maior
    // < Menor
    // >= Maior ou igual 
    // <= Menor ou igual
    // != Diferente
    // == igual

    // Start is called before the first frame update
    void Start()
    {
        if (_i1==1) {
            Debug.Log("_i1 � igual a 1");

        }

        if (_i1==_i2)  {
            Debug.Log("_i1 � igual a _i2");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
