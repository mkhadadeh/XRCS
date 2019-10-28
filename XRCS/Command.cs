﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[System.Serializable]
public enum Test
{
    EQUAL, NOT_EQUAL, LESS_THAN, GREATER_THAN, LESS_THAN_OR_EQUAL, GREATER_THAN_OR_EQUAL, SEND_VALUE
};

public enum TestResult
{
    TRUE, FALSE, NA
};

[System.Serializable]
public enum Feature
{
    BATTERY_LEVEL_FLOAT,
    CENTER_EYE_ACCELERATION_VECTOR3,
    CENTER_EYE_ANGULAR_ACCELERATION_VECTOR3,
    CENTER_EYE_ANGULAR_VELOCITY_VECTOR3,
    CENTER_EYE_POSITION_VECTOR3,
    CENTER_EYE_ROTATION_QUATERNION,
    CENTER_EYE_VELOCITY_VECTOR3,
    COLOR_CAMERA_ACCELERATION_VECTOR3,
    COLOR_CAMERA_ANGULAR_ACCELERATION_VECTOR3,
    COLOR_CAMERA_ANGULAR_VELOCITY_VECTOR3,
    COLOR_CAMERA_POSITION_VECTOR3,
    COLOR_CAMERA_ROTATION_QUATERNION,
    COLOR_CAMERA_VELOCITY_VECTOR3,
    DEVICE_ACCELERATION_VECTOR3,
    DEVICE_ANGULAR_ACCELERATION_VECTOR3,
    DEVICE_ANGULAR_VELOCITY_VECTOR3,
    DEVICE_POSITION_VECTOR3,
    DEVICE_ROTATION_QUATERNION,
    DEVICE_VELOCITY_VECTOR3,
    D_PAD_VECTOR2,
    EYES_DATA_EYES,
    GRIP_FLOAT,
    GRIP_BUTTON_BOOL,
    HAND_DATA_HAND,
    INDEX_FINGER_FLOAT,
    INDEX_TOUCH_FLOAT,
    IS_TRACKED_BOOL,
    LEFT_EYE_ACCELERATION_VECTOR3,
    LEFT_EYE_ANGULAR_ACCELERATION_VECTOR3,
    LEFT_EYE_ANGULAR_VELOCITY_VECTOR3,
    LEFT_EYE_POSITION_VECTOR3,
    LEFT_EYE_ROTATION_QUATERNION,
    LEFT_EYE_VELOCITY_VECTOR3,
    MENU_BUTTON_BOOL,
    MIDDLE_FINGER_FLOAT,
    PINKY_FINGER_FLOAT,
    PRIMARY_2D_AXIS_VECTOR2,
    PRIMARY_2D_AXIS_CLICK_BOOL,
    PRIMARY_2D_AXIS_TOUCH_BOOL,
    PRIMARY_BUTTON_BOOL,
    PRIMARY_TOUCH_BOOL,
    RIGHT_EYE_ACCELERATION_VECTOR3,
    RIGHT_EYE_ANGULAR_ACCELERATION_VECTOR3,
    RIGHT_EYE_ANGULAR_VELOCITY_VECTOR3,
    RIGHT_EYE_POSITION_VECTOR3,
    RIGHT_EYE_ROTATION_QUATERNION,
    RIGHT_EYE_VELOCITY_VECTOR3,
    RING_FINGER_FLOAT,
    SECONDARY_2D_AXIS_VECTOR2,
    SECONDARY_BUTTON_BOOL,
    SECONDARY_TOUCH_BOOL,
    THUMBREST_BOOL,
    THUMBTOUCH_FLOAT,
    TRACKING_STATE_INPUTTRACKINGSTATE,
    TRIGGER_FLOAT,
    TRIGGER_BUTTON_BOOL
}

[System.Serializable]
[CreateAssetMenu(fileName = "Command", menuName = "ScriptableObjects/Command", order = 1)]
public class Command : ScriptableObject
{
    public string commandName;

    public XRNode node;
    public Test test;
    public Feature feature;
    public VRCommand commandToRun;

    public float float_value;
    public bool bool_value;
    public Vector3 vector3_value;
    public Vector2 vector2_value;
    public InputTrackingState inputTrackingState_value;
    public Quaternion quaternion_value;

    
}
