using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadCinematic(){
        SceneManager.LoadScene("cinematic");
    }

    public void LoadOpcoes(){
        SceneManager.LoadScene("opcoes");
    }

    public void LoadCreditos(){
        SceneManager.LoadScene("creditos");
    }

    public void CloseApplication(){
        Application.Quit();
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
    }
}
