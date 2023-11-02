using UnityEngine;

public class musica : MonoBehaviour
{
    private static musica instancia;

    void Awake()
    {
        if (instancia == null){
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }
}