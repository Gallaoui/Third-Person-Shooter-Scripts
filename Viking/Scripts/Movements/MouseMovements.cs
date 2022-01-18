using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovements : MonoBehaviour
{
    private Transform CameraTrans;
    private Movements mv;
    private CharacterController cc;

    private float turnSmooth;

    private void Awake()
    {
        mv = GetComponent<Movements>();
        cc = GetComponent<CharacterController>();
        CameraTrans = Camera.main.transform;
    }
    private void Update()
    {
        if(mv.Pos != Vector2.zero)
        {
            float targetAngle = CameraTrans.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmooth, 0.2f);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * (Vector3.forward + Vector3.back);
            cc.Move(moveDirection * Time.deltaTime);
        }
    }
}
