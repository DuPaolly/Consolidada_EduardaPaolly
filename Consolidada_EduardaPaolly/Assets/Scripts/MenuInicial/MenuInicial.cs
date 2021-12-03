using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] GameObject menuOpcoes;
    [SerializeField] GameObject menuSair;

    void Start()
    {
        menuOpcoes.SetActive(false);
        menuSair.SetActive(false);
    }

    public void BotaoJogar()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void BotaoOpcoes()
    {
        menuOpcoes.SetActive(true);
    }

    public void BotaoSair()
    {
        menuSair.SetActive(true);
    }

}
