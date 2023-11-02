using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
   [SerializeField] Slider volumeBotao;

   void Start(){
        if(PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume" , 1);
            Load();
        } else{
            Load();
        }
   }

   public void MudarVolume(){
        AudioListener.volume = volumeBotao.value;
        Save();
   }

   private void Load(){
        volumeBotao.value = PlayerPrefs.GetFloat("musicVolume");
   }

   private void Save(){
        PlayerPrefs.SetFloat("musicVolume" , volumeBotao.value);
   }
}
