using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OverrideMouse : BaseInput
{
    public OVRInput.Button clickButton = OVRInput.Button.PrimaryIndexTrigger;
    public OVRInput.Controller controller = OVRInput.Controller.All;

    protected override void Awake()
    {
        GetComponent<BaseInputModule>().inputOverride = this;
    }

    public override bool GetMouseButton(int button)
    {
        return true;
    }

    public override bool GetMouseButtonDown(int button)
    {
        return true;
    }

    public override bool GetMouseButtonUp(int button)
    {
        return true;
    }

    public override Vector2 mousePosition
    {
        get
        {
            return Vector2.zero;
        }
    }
}
