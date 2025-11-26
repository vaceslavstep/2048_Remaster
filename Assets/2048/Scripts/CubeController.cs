using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    public int CubeNumber = 2;
  [SerializeField]  private float JumpForce = 2f;
  [SerializeField] private Text[] cubeInfo;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void UpdateInformation ()
    {
        for (int i = 0; i < cubeInfo.Length; i++)
        {
            cubeInfo[i].text = $"{CubeNumber}";
        }
    }


}
