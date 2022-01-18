using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private Transform CameraTransform;
    private Movements movements;
    private CharacterController cc;

    private float turnSmooth;

    // Start is called before the first frame update
    void Awake()
    {
        movements = GetComponent<Movements>();
        CameraTransform = Camera.main.transform;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movements.Pos != Vector2.zero)
        {
            float targetAngle = CameraTransform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmooth, 0.2f);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 Directions = Quaternion.Euler(0f, targetAngle, 0f) * (Vector3.forward + Vector3.back);
            cc.Move(Directions * Time.deltaTime);
        }
    }
}
