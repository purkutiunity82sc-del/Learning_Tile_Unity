using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public Rigidbody2D rb;
    public Animator animator;
    public float movementSpeed = 5f;

    public int playerDirection = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        rb= GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        if( Horizontal > 0 && transform.localScale.x > 0 || Horizontal < 0 && transform.localScale.x < 0 )
        {
            Flip();
        }


        animator.SetFloat("horizontal", Mathf.Abs(Horizontal));
        animator.SetFloat("vertical", Mathf.Abs(Vertical));

       rb.linearVelocity = new Vector2 (Horizontal, Vertical) * movementSpeed;
    }



    void Flip()
    {
        playerDirection *= -1;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y , transform.localScale.z);

    }
}
