using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float smooth = 1f;
    private Vector3 targetAngle;
    private Quaternion startRotation;
    public int turns;
    public int rotations;

    void Start()
    {
        startRotation = transform.localRotation;
    }

    
    void Update()
    {
        CheckTurns();
        CheckRotations();

       
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 targetAngle = transform.eulerAngles + 1080f * Vector3.back;
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, targetAngle, smooth * Time.deltaTime);
        }    */
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetAngle = transform.eulerAngles + 360f * Vector3.back;
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, targetAngle, smooth * Time.deltaTime);
            turns++;
        }
    }

    private void CheckTurns()
    {
        if (turns == 10)
        {
            Debug.Log("10 turns completed");
            turns = 0;
            rotations++;
        }
    }

    private void CheckRotations()
    {
        if (rotations == 2)
        {
            Destroy(this.gameObject);
        }
    }
}
