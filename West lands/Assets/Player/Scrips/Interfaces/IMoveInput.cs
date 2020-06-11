using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IMovementInput
{
    Vector2 MoveDirection { get; }
    bool isSprinting { get; }
    void isDashing();
}
