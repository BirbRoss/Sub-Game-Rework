using UnityEngine;
using UnityEngine.UI;

public class DestroyOnDie : MonoBehaviour
{
    //destroys object it's attatched to
    public void Die()
    {
        Destroy(gameObject);
    }
}
