using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMenu : MonoBehaviour
{
    [SerializeField] GameObject _painelIniciar;
    [SerializeField] GameObject _painelCarregar;
    [SerializeField] GameObject _painelPerson;

    public void AtivaPainelIniciar()
    {
        _painelIniciar.SetActive(true);
        _painelCarregar.SetActive(false);
        _painelPerson.SetActive(false);
    }

    public void AtivaPainelCarregar()
    {
        _painelIniciar.SetActive(false);
        _painelCarregar.SetActive(true);
        _painelPerson.SetActive(false);
    }

    public void AtivaPainelPerson()
    {
        _painelIniciar.SetActive(false);
        _painelCarregar.SetActive(false);
        _painelPerson.SetActive(true);
    }

    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
