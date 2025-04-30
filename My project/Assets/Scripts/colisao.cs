
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moreu : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D other)
{
if (other.CompareTag("Player"))
{
Debug.Log("Game Over");
SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
}
}
}