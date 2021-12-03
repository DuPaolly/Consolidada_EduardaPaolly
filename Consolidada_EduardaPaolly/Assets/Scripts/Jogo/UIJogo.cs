using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIJogo : MonoBehaviour
{
    [SerializeField] GameObject menuPause;
    [SerializeField] GameObject menuOpcoes;
    [SerializeField] GameObject menuSairParaMenu;
    [SerializeField] GameObject menuSairJogo;


    void Start()
    {
        menuPause.SetActive(false);
        menuOpcoes.SetActive(false);
        menuSairParaMenu.SetActive(false);
        menuSairJogo.SetActive(false);
    }

    public void AbrirMenuPause()
    {
        Time.timeScale = 0;
        menuPause.SetActive(true);
    }

    public void FecharMenuPause()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1;
    }

    public void AbrirMenuOpcoes()
    {
        menuOpcoes.SetActive(true);
    }

    public void AbrirMenuSairParaMenu()
    {
        menuSairParaMenu.SetActive(true);
    }

    public void SimMenuInicial()
    {
        SceneManager.LoadScene("MenuIncial");
    }

    public void NaoMenuInicial()
    {
        menuSairParaMenu.SetActive(false);
    }

    public void AbrirMenuSairJogo()
    {
        menuSairJogo.SetActive(true);
    }

}
