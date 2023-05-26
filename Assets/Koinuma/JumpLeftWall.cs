using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpLeftWall : MonoBehaviour
{
    [SerializeField] PlayerController controller = default;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.SetDirection(new Vector2(1, 1).normalized);
        controller._jump = 1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        controller.SetDirection(new Vector2(0, 1).normalized);
        controller._jump = 0;
    }
}
