using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float for_speed;
    public Transform center_pos;
    public Transform left_pos;
    public Transform right_pos;

    private int current_pos;

    // Start is called before the first frame update
    void Start()
    {
        //curent_pos 0 = center, current_pos 1 = left, current_pos 2 = right
        current_pos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + for_speed * Time.deltaTime);

        if (current_pos == 0)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);

        }
        else if (current_pos == 1)
        {

            transform.position = new Vector3(-2.25f, transform.position.y, transform.position.z);

        }
        else if (current_pos == 2)
        {
            transform.position = new Vector3(2.25f, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (current_pos == 0)
            {
                current_pos = 1;
            }
            else if (current_pos == 2)
            {
                current_pos = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (current_pos == 0)
            {
                current_pos = 2;
            }
            else if (current_pos == 1)
            {
                current_pos = 0;
            }
        }

    }
}
