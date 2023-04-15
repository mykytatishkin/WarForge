using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuildingsPanel : MonoBehaviour
{
    public GameObject BuldingButtonTemplate;
    [SerializeField]
    private Transform ButtonParent;
    private List<BuildingProfile> _buildings;

    private void Start()
    {
        _buildings = Resources.LoadAll<BuildingProfile>("Buildings/").ToList();

        foreach (var buildings in _buildings)
        {
            var buttonGo = Instantiate(BuldingButtonTemplate, ButtonParent);
            buttonGo.SetActive(true);
            buttonGo.GetComponent<BuildingPresaenterOnButton>().Present(buildings);
        }
    }

    private void Update()
    {

    }
}
