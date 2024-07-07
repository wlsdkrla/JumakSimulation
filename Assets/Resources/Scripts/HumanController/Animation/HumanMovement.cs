using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HumanMovement : MonoBehaviour
{
    public Animator animator;
    abstract public void Move();

}
