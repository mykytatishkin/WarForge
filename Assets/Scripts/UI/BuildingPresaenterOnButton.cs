using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingPresaenterOnButton : MonoBehaviour
{
    public Text BuildingName;
    public Image Icon;

    public void Present(BuildingProfile profile)
    {
        Icon.sprite = profile.Icon;
        BuildingName.text = profile.Name;
    }
}
