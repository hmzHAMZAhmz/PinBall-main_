using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappers : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;
    public bool isButtonPressed;


    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();

        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (isButtonPressed) 
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    
    }

    public void FlipperActionStart()
    {
        isButtonPressed = true;
    }


    public void FlipperActionEnd()
    {
        isButtonPressed = false;
    }

}
