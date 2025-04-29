using UnityEngine;

public class colisao : MonoBehaviour
{
    void OnCollisionEnter (Collision2D colisao){
        Debug.Log("Game Over!!!"+ colisao. gameObject.name);

    }
}
