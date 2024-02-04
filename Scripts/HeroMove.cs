
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMove : MonoBehaviour
{
    public float directionX, directionY;
    public float speed;
    public Joystick joystick;
    private Rigidbody2D rigidbody2D;
    private void Start()
    {
        Application.targetFrameRate = 60;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    private void Update()
    {
        Directions();
    }
    private void FixedUpdate()
    {
        MoveHero();
    }

    private void Directions()
    {
        directionX = joystick.Horizontal * speed;
        directionY = joystick.Vertical * speed;
    }    

    private void MoveHero()
    {
        rigidbody2D.velocity = new Vector3(directionX, directionY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        else if (collision.CompareTag("Finish"))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex +1);
        }
    }
}
