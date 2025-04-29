using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;

    void Start () {}

    void Update (){
        float movimentoHorizontal = 0f;
        if (Input.GetKey(KeyCode.A)) { movimentoHorizontal = 1f; }
        else if (Input.GetKey(KeyCode.D)) { movimentoHorizontal = -1f; }
        else {movimentoHorizontal = 0f; }
        transform.position += new Vector3( movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;

       
    }
}