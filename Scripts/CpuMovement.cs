using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuMovement : MonoBehaviour
{
    Animator anim;
    public float smooth = 1f;
    public float speed = 2.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float airSpeed = 10.0F;
    private Quaternion lookLeft;
    private Quaternion lookRight;
    private Vector3 moveDirection = Vector3.zero;
    public int actionSelect;

    void Start()
    {
        Cursor.visible = false;
        anim = GetComponent<Animator>();
        Time.timeScale = 1;

        lookRight = transform.rotation;
        lookLeft = lookRight * Quaternion.Euler(0, 180, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RandomAttack();
        }
    }

    void RandomAttack()
    {
        actionSelect = Random.Range(1, 3);
        if(actionSelect == 1)
        {
            anim.SetTrigger("Punching");
        }
        else if(actionSelect == 2)
        {
            anim.SetTrigger("Kicking");
        }
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            anim.SetBool("IsFalling", false);
            anim.SetBool("IsRunning", false);


            moveDirection = new Vector3(0f, 0f, Input.GetAxis("Horizontal") * speed);

            /*if (Input.GetButtonDown("Jump"))
            {
                anim.SetTrigger("IsJumping");
                moveDirection.y = jumpSpeed;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                anim.SetTrigger("Punching");
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                anim.SetTrigger("Kicking");
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                anim.SetTrigger("Parrying");
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {

                transform.rotation = lookLeft;
                moveDirection = transform.TransformDirection(-moveDirection);
                moveDirection *= speed;


                anim.SetBool("IsRunning", true);

                if (Input.GetButtonDown("Jump"))
                {
                    anim.SetTrigger("IsJumping");
                    anim.SetBool("IsRunning", false);
                    moveDirection.y = jumpSpeed;
                }

            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = lookRight;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;


                anim.SetBool("IsRunning", true);

                if (Input.GetButtonDown("Jump"))
                {
                    anim.SetTrigger("IsJumping");
                    anim.SetBool("IsRunning", false);
                    moveDirection.y = jumpSpeed;
                }
            }
            */



        }

        /*else if(controller.isGrounded == false)
        {
            anim.SetBool("IsRunning", false);
            anim.SetBool("IsFalling", true);
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                moveDirection.x += airSpeed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                moveDirection.x -= airSpeed * Time.deltaTime;
            }

        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    */}
}
