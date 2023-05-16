using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

enum ControlMode
{
    Guided,
    Walk
}

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private GameObject _agentCam;
    //[SerializeField] private NavMeshAgent ai;
    [SerializeField] private FollowCam followCamScript;
    [SerializeField] private Transform[] targetAreas;
    [SerializeField] private ControlMode _controlMode;
    [SerializeField] private GameObject[] _virtualCams;

    private int _currentCamID;

    public Transform indexTransform { get; private set; }

    public void SwitchCam(int camID)
    {
        _virtualCams[_currentCamID].SetActive(false);
        _virtualCams[camID].SetActive(true);
        _agentCam.SetActive(false);
        _currentCamID = camID;
    }

    public void SwitchToFP()
    {
        _virtualCams[_currentCamID].SetActive(false);
        _agentCam.SetActive(true);
    }

    public void TargetToSelectedBuilding(int index)
    {
        target.position = new(targetAreas[index].position.x, target.position.y, targetAreas[index].position.z);
    }

    public void EnableFollowCamScript()
    {
        followCamScript.enabled = true;
        //ai.speed = 0;
    }

    public void DisableFollowCamScript()
    {
        followCamScript.enabled = false;
        //ai.speed = 10;
    }

    public void GenerateRandomID()
    {
        int rndNum = Random.Range(0, _virtualCams.Length);
        SwitchCam(rndNum);
        Debug.Log(rndNum);
    }
}
