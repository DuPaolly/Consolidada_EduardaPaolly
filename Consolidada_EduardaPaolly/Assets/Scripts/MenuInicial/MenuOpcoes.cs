using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOpcoes : MonoBehaviour
{
    [SerializeField] AudioMixer mixerMenu;
    [SerializeField] GameObject menuOpcoes;
    [SerializeField] Dropdown resolutionsDropdown;
    [SerializeField] Slider sliderDeVolume;
    [SerializeField] Toggle toggleTelaCheia;
    Resolution[] resolutions;

    

    private void Start()
    {
        float volumeArmazenado = Saves.CarregaVolumeMusica();
        sliderDeVolume.value = volumeArmazenado;
        AlterarVolumeMenuInicial(volumeArmazenado);

        bool telaArmazenada = Saves.CarregaTelaCheia();
        toggleTelaCheia.isOn = telaArmazenada;
        TelaCheia(telaArmazenada);

        resolutions = Screen.resolutions;
        resolutionsDropdown.ClearOptions();
        int indexResolutions = 0;
        List<string> opcoes = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string opcao = resolutions[i].width + " x " + resolutions[i].height;
            opcoes.Add(opcao);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                indexResolutions = i;
            }
        }

        resolutionsDropdown.AddOptions(opcoes);
        resolutionsDropdown.value = Saves.CarregaResolucao(resolutions.Length - 1);
        resolutionsDropdown.RefreshShownValue();
        menuOpcoes.SetActive(false);
    }

    public void BotaoSair()
    {
        menuOpcoes.SetActive(false);
    }

    public void AlterarVolumeMenuInicial(float novoVolume)
    {
        Saves.SalvaVolumeMusica(novoVolume);
        novoVolume = Mathf.Log10(novoVolume) * 20;
        mixerMenu.SetFloat("VolumeMenuInicial", novoVolume);
    }

    public void TelaCheia(bool queroTelaCheia)
    {
        Saves.SalvaTelaCheia(queroTelaCheia);
        Screen.fullScreen = queroTelaCheia;        
    }

    public void MudarResolucao(int resolutionIndex)
    {
        Resolution resolucao = resolutions[resolutionIndex];
        Screen.SetResolution(resolucao.width, resolucao.height, Screen.fullScreen);
        Saves.SalvaResolucao(resolutionIndex);
    }
}
