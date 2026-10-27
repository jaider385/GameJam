using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public InputActionAsset playerInput;
    public float smooth = 5f;
    public Vector3 offset = new Vector3(0, 2, -10);
    public float arcIntensity = 1.5f;

    private void LateUpdate()
    {
        if (!player) return;
        {
            float moveDir = 0f;
            if (Keyboard.current != null)
            {
                if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                {
                    moveDir = -1;
                }
                if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                {
                    moveDir = 1;
                }
            }

            Vector3 targetPos = new Vector3(player.position.x + offset.x - (moveDir * arcIntensity), player.position.y + offset.y, player.position.z + offset.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, smooth * Time.deltaTime);
            transform.LookAt(player);
        }
    }
}
