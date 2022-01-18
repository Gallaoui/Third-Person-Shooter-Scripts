using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movements : MonoBehaviour
{
    private CharacterController cc;
    private Animator an;
    private PlayerControls pc;
    private InputAction mv;
    public Vector2 Pos;

    private float Walks;
    private float Sides;
    private bool isRunning;
    private float transition = 2.0f;

    private void Awake()
    {
        an = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
        pc = new PlayerControls();
        //InvokeRepeating("stand", 0f, IdleTime);
    }
    private void OnEnable()
    {
        pc.Enable();
        mv = pc.Player.Movements;
        pc.Player.Run.started += DoRun;
        pc.Player.Run.canceled += DoRun;
    }
    private void DoRun(InputAction.CallbackContext obj)
    {
        isRunning = obj.ReadValueAsButton();
    }

    private void OnDisable()
    {
        pc.Disable();
    }
    private void Update()
    {
        Pos = mv.ReadValue<Vector2>();
        float timing = Time.deltaTime * transition;
        if (Pos.y > 0)
        {
            if (Walks < 1.0f)
                Walks += timing;
        }
        if (Pos.y < 0)
        {
            if (Walks > -1.0f)
                Walks -= timing;
        }
        if (Pos.x > 0)
        {
            if (Sides < 1.0f)
                Sides += timing;
        }
        if (Pos.x < 0)
        {
            if (Sides > -1.0f)
                Sides -= timing;
        }

        if (Pos.x != 0 && Pos.y == 0)
        {    
             if (Walks < 0.0f) Walks += timing;
             if (Walks > 0.0f) Walks -= timing;
        }
        if (Pos.y != 0 && Pos.x == 0)
        {
            if (Sides < 0.0f) Sides += timing;
            if (Sides > 0.0f) Sides -= timing;
        }

        if(Pos == Vector2.zero)
        {
                if (Walks > 0.0f)
                {
                    Walks -= timing;
                }
                if (Walks < 0.0f)
                {
                    Walks += timing;
                }
            
            
                if (Sides > 0.0f)
                {
                    Sides -= timing;
                }
                if (Sides < 0.0f)
                {
                    Sides += timing;
                }
        }
        if(isRunning && Walks < 2.0f)
        {
            Walks += timing;
        }
        if(!isRunning && Walks > 2.0f)
        {
            Walks -= timing;
        }

        an.SetFloat("Walk", Walks);
        an.SetFloat("Sides", Sides);
        Vector3 Moves = (Sides * transform.right + Walks * transform.forward);
        cc.Move(Moves * Time.deltaTime);
    }
    void stand()
    {
        if (mv.ReadValue<Vector2>() == Vector2.zero)
            Walks = 0.5f;
        else
            an.SetFloat("Walk", 0);
    }
}
