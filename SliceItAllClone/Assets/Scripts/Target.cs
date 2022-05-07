using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject perfectTarget;
    [SerializeField] private GameObject frontTarget;
    [SerializeField] private GameObject backTarget;
    [SerializeField] private AudioSource audio;
    [SerializeField] private Collider collider;
    [SerializeField] private ParticleSystem impactFX;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            perfectTarget.SetActive(false);
            frontTarget.SetActive(true);
            backTarget.SetActive(true);
            collider.enabled = false;
            impactFX.Play();
            audio.Play();
        }
    }
}
