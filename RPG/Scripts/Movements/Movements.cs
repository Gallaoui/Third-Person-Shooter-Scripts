using UnityEngine.InputSystem;
using UnityEngine;

public class Movements : MonoBehaviour
{
    private PlayerControls pc;
    private InputAction movements;
    private Animator animator;
    private CharacterController cc;
    public Vector2 Pos;

    private float transition = 2.0f;
    private float Walk;
    private float Side;

    // Start is called before the first frame update
    void Awake()
    {
        pc = new PlayerControls();
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        pc.Enable();
        movements = pc.Movements.Moves;
    }

    private void OnDisable()
    {
        pc.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Pos = movements.ReadValue<Vector2>();
        float timing = Time.deltaTime * transition;

        if(Pos.y > 0)
        {
            if(Walk < 1.0f)
            Walk += timing;
        }
        if (Pos.y < 0)
        {
           if(Walk > -1.0f)
            Walk -= timing;
        }

        if (Pos.x > 0)
        {
            if(Side < 1.0f)
            Side += timing;
        }
        if (Pos.x < 0)
        {
            if(Side > -1.0f)
            Side -= timing;
        }

        if(Pos.x != 0 && Pos.y == 0)
        {
            if (Walk < 0.0f)
                Walk += timing;
            if (Walk > 0.0f)
                Walk -= timing;
        }

        if(Pos.y != 0 && Pos.x == 0)
        {
            if (Side < 0.0f)
                Side += timing;
            if (Side > 0.0f)
                Side -= timing;
        }

        if(Pos == Vector2.zero)
        {
            if (Walk > 0.0f)
                Walk -= timing;
            if (Walk < 0.0f)
                Walk += timing;


            if (Side > 0.0f)
                Side -= timing;
            if (Side < 0.0f)
                Side += timing;
            
        }

        animator.SetFloat("Walk", Walk);
        animator.SetFloat("Side", Side);
        Vector3 Moves = (Side * transform.right + Walk * transform.forward);
        cc.Move(Moves * Time.deltaTime * 10f);
    }
}
