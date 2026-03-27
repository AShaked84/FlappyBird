using UnityEngine;
using UnityEngine.InputSystem;


public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicManagerScript logic;
    public bool birdIsAlive = true;
    public Sprite[] skins;
    private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        int selected = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Debug.Log("Selected index: " + selected);
        sr.sprite = skins[selected];
        
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive) 
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

        if (myRigidBody.transform.position.y < -15 || myRigidBody.transform.position.y > 25)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
