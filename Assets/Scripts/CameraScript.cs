using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _OVRCamera;

    [SerializeField]
    private GameObject _menuShow;

    [SerializeField]
    private GameObject _menuHide;

    [SerializeField]
    private GameObject _leaveCar;
    [SerializeField]
    private GameObject _enterCar;

    private Vector3 _sittingPos;

    private bool _isActive;

    private void Update() {
        if(Input.GetAxis("Vertical") != 0){
            _isActive = true;
            Hide();
        }else{
            _isActive = false;
        }
    }

    private void Start()
    {
        _menuHide.SetActive(true);
        _menuShow.SetActive(false);
        _enterCar.SetActive(false);
        _leaveCar.SetActive(true);
    }

    public void MoveLeft()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(-0.1f, 0, 0);
    }

    public void MoveRight()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(0.1f, 0, 0);
    }

    public void MoveForward()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(0, 0, 0.1f);
    }

    public void MoveBack()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(0, 0, -0.1f);
    }

    public void MoveUp()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(0, 0.1f, 0);
    }

    public void MoveDown()
    {
        _OVRCamera.transform.position = _OVRCamera.transform.position + new Vector3(0, -0.1f, 0);
    }

    public void RotateLeft()
    {
        _OVRCamera.transform.Rotate(new Vector3(0,-10f,0));
    }

    public void RotateRight()
    {
        _OVRCamera.transform.Rotate(new Vector3(0, 10f, 0));
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        _menuShow.SetActive(true);
        _leaveCar.SetActive(false);
        _menuHide.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
        _menuShow.SetActive(false);
        _leaveCar.SetActive(true);
        _menuHide.SetActive(true);
    }

    public void LeaveCar()
    {
        if(!_isActive){
            _sittingPos = _OVRCamera.transform.position;
            _enterCar.SetActive(true);
            _OVRCamera.transform.position = gameObject.transform.position + new Vector3(0.5f, -0.9f, -1.7f);
        }
    }

    public void EnterCar()
    {
        _OVRCamera.transform.position = _sittingPos;
        _enterCar.SetActive(false);
    }
}
