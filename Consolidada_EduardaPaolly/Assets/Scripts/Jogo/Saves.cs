using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saves : MonoBehaviour
{
    const string SAVE_VOLUME_MUSICA = "VOLUME MUSICA";
    const string SAVE_TELA_CHEIA = "TELA CHEIA";
    const string SAVE_RESOLUCAO = "RESOLUCAO";

    public static float CarregaVolumeMusica()
    {
       return PlayerPrefs.GetFloat(SAVE_VOLUME_MUSICA, 0.5f);
    } 

    public static void SalvaVolumeMusica(float volumeParaSalvar)
    {
        PlayerPrefs.SetFloat(SAVE_VOLUME_MUSICA, volumeParaSalvar);
    }

    public static bool CarregaTelaCheia()
    {
        if (PlayerPrefs.HasKey(SAVE_TELA_CHEIA))
        {
            if (PlayerPrefs.GetInt(SAVE_TELA_CHEIA) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
        
    }

    public static void SalvaTelaCheia(bool telaParaSalvar)
    {
        PlayerPrefs.SetInt(SAVE_TELA_CHEIA, telaParaSalvar ? 1 : 0);
    }

    public static int CarregaResolucao(int indiceResolucaoPadrao)
    {
        if (PlayerPrefs.HasKey(SAVE_RESOLUCAO))
        {
            return PlayerPrefs.GetInt(SAVE_RESOLUCAO);
        }
        else
        {
            PlayerPrefs.SetInt(SAVE_RESOLUCAO, indiceResolucaoPadrao);
            return indiceResolucaoPadrao;
        }
    }

    public static void SalvaResolucao(int indiceParaSalvar)
    {
        PlayerPrefs.SetInt(SAVE_RESOLUCAO, indiceParaSalvar);
    }

}
