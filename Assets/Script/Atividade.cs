using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar 3 classes de texto
    [SerializeField] string _dataDia = "19";
    [SerializeField] string _dataMes;
    [SerializeField] string _dataAno;

    //Implementar valor somente na 1�
    //Alterar a 1� variavel
    //Na fun��o Start
    //Concatenar a 1� e 2� na 3� Variavel

    // Start is called before the first frame update
    void Start()
    {
        _dataDia = "20"; 
        _dataAno = _dataDia + " " + "de" + " " + _dataMes + " " + "de" + " " + "2023";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
