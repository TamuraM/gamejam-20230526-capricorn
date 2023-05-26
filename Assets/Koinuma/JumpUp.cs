using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUp : MonoBehaviour
{
    [SerializeField] PlayerController controller = default;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.JumpVectUp(true);
        controller._jump = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        controller.JumpVectUp(false);
        controller._jump = 0;
    }
}
