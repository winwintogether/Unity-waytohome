using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Destroy(this.gameObject);
    }
}
