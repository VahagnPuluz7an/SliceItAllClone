using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform knife;
    [SerializeField] private Rigidbody knifeRb;
    [SerializeField] private Vector3 force;

    public void TouchDown()
    {
        StartCoroutine(RotateKnife());
        AddForceKnife();
    }

    private void AddForceKnife()
    {
        knifeRb.AddForce(force, ForceMode.Impulse);
    }

    private IEnumerator RotateKnife()
    {
        float delayTime = 0f;
        for (int i = 0;i < 72;i++)
        {
            knife.Rotate(5,0,0);
            
            yield return new WaitForSeconds(delayTime);
            delayTime += 0.00001f;
        }
    }
}
