using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSair : MonoBehaviour
{
    [SerializeField] GameObject menuSair;

    public void BotaoSim()
    {
        Application.Quit();
    }

    public void BotaoNao()
    {
        menuSair.SetActive(false);
    }
}
