using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenManager : MonoBehaviour
{
    // Elevators
    public Transform paperPlane, avoidanceElevator, toBigWheelElevator, toValleyElevator, 
    toRotatingCubesElevator, toMazeElevator, toShipElevator, toFinishElevator;

    // Punch Obstacles
    public Transform[] punchesGroup_1;
    public Transform[] punchesGroup_2;
    // Valley
    public Transform[] valleyRightGroup;
    public Transform[] valleyLeftGroup;
    // Big Wheel
    public Transform bigWheel;
    // Beam Obstacle
    public Transform topCylinder;
    public Transform bottomCylinder;
    // Hammers
    public Transform[] hammerRight;
    public Transform[] hammerLeft;
    // Rotating Cubes
    public Transform[] rotatingCubes_1;
    public Transform[] rotatingCubes_2;
    // Public Ease
    public Ease elevatorEase; 
    // Rotating Cube Obstacles

    // Ship
    public Transform ship;
    void Start()
    {
        DOTween.KillAll();

        PaperPlane();
        PunchesGroup_1();
        PunchesGroup_2();
        ToValleyElevator();
        ValleyLeftGroup();
        ValleyRightGroup();
        ToBigWheelElevator();
        BigWheelRotation();
        BeamRotation();
        AvoidanceElevator();
        HammerRotate();
        ToRotatingCubesElevator();
        RotatingCubes_1();
        RotatingCubes_2();
        ToMazeElevator();
        ToShipElevator();
        ShipRotation();
        ToFinishElevator();
    }

    // Paper plane movement
    public void PaperPlane()
    {
        paperPlane.DOLocalMove(new Vector3(-0.7f,22f,-14.5f), 5f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }

    // Punches movement
    public void PunchesGroup_1()
    {
        foreach (Transform punch in punchesGroup_1)
        {
            punch.DOLocalMoveX(2f, 1.2f, false)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutElastic);
        }
    }
    public void PunchesGroup_2()
    {
        foreach (Transform punch in punchesGroup_2)
        {
            punch.DOLocalMoveX(-2f, 1.2f, false)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutElastic);
        }
    }

    // toValleyElevator movement
    public void ToValleyElevator()
    {
        toValleyElevator.DOLocalMove(new  Vector3(60f,70f,32.9f), 3f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    
    // ValleyObstacles
    public void ValleyLeftGroup()
    {
        foreach (Transform plate in valleyLeftGroup)
        {
            plate.DOLocalMoveZ(6.8f, 3.5f, false)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
        }
    }
    public void ValleyRightGroup()
    {
        foreach (Transform plate in valleyRightGroup)
        {
            plate.DOLocalMoveZ(-2.4f, 3.5f, false)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
        }
    }

    // toBigWheelElevator movement
    public void ToBigWheelElevator()
    {
        toBigWheelElevator.DOLocalMoveY(90f, 4f, false)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    // BigWheel movement
    public void BigWheelRotation()
    {
        bigWheel.transform.DORotate(new Vector3(360f,0, 0), 70f, RotateMode.Fast)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);
    }
    
    // AvoidanceElevator movement
    public void AvoidanceElevator()
    {
        avoidanceElevator.DOLocalMove(new Vector3(5f,-3.5f,0.48f), 12f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    // toRotatingCubesElevator
    public void ToRotatingCubesElevator()
    {
        toRotatingCubesElevator.DOLocalMove(new Vector3(-91.75f,97.6f,7.6f), 8f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }

    //rotatingCubes animations
    public void RotatingCubes_1()
    {
        foreach (Transform cubes in rotatingCubes_1)
        {
            cubes.transform.DORotate(new Vector3(360f, 0, 0), 7f, RotateMode.Fast)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative()
            .SetEase(Ease.Linear);
        }
    }
    public void RotatingCubes_2()
    {
        foreach (Transform cubes in rotatingCubes_2)
        {
            cubes.transform.DORotate(new Vector3(0, 0, 360f), 15f, RotateMode.Fast)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative()
            .SetEase(Ease.Linear);
        }
    }

    // toMazeElevator movement
    public void ToMazeElevator()
    {
        toMazeElevator.DOLocalMoveY(110f, 5f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    // toShipElevator movement
    public void ToShipElevator()
    {
        toShipElevator.DOLocalMove(new Vector3(15.61f,128f,7.76f), 8f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    // Ship movement
    public void ShipRotation()
    {
        ship.transform.DOLocalRotate(new Vector3(-45f, 90f, 0f), 7f, RotateMode.Fast)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Unset);
    }

    // toFinishElevator movement
    public void ToFinishElevator()
    {
        toFinishElevator.DOLocalMove(new  Vector3(109.24f,180f,7.5f), 8f, false)
        .SetDelay(1)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.Linear);
    }
    // Beam movement
    public void BeamRotation()
    {
        // Top 
        topCylinder.transform.DORotate(new Vector3(0, 360f, 0), 6f, RotateMode.Fast)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);

        // Bottom
        bottomCylinder.transform.DORotate(new Vector3(0, 360f, 0), 4f, RotateMode.Fast)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);
    }

    // Hammers
    public void HammerRotate()
    {
        //-90 <--> 90

        foreach (Transform hammer in hammerRight)
        {
            hammer.DOLocalRotate(new Vector3(0f, 0f, 90f), 2f, RotateMode.Fast)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Unset);
        }

        foreach (Transform hammer in hammerLeft)
        {
            hammer.DOLocalRotate(new Vector3(0,0f,-90f), 2f, RotateMode.Fast)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Unset);
        }

    }


}
