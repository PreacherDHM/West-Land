using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private IMovementInput move;
    private IInvintoryInput invintoryInput;
    private IItemContainer itemContainer;
    public float speed;
    private Rigidbody2D rb;
    private bool OpenInvintory;
    public GameObject invintory;
    [SerializeField] Animator animator;
    private Vector2 Movement;

    private void OnValidate()
    {
        invintory = GameObject.FindGameObjectWithTag("Invintory");
    }

    void Start()
    {
        itemContainer = invintory.GetComponent<IItemContainer>();
        move = GetComponent<IMovementInput>();
        invintoryInput = GetComponent<IInvintoryInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        animator.SetFloat("Horazontel", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);

        
        invintory.SetActive(invintoryInput.OpenInvintory);
        if (!invintoryInput.OpenInvintory)
        {
            Movement = move.MoveDirection;

        }
        else
        {
            Movement = Movement * 0;
        }
        
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = Movement * speed;
    }
}
