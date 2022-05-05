using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
namespace LevelUP.Dial
{
    public class Rotator : MonoBehaviour, IDial
    {
        [SerializeField] Transform linkedDial, dial2, DIALE3;
        [SerializeField] private int snapRotationAmount = 25;
        [SerializeField] private float angleTolerance;
        [SerializeField] private GameObject RighthandModel;
        [SerializeField] private GameObject LefthandModel;
        [SerializeField] bool shouldUseDummyHands;

        private XRBaseInteractor interactor;
        private float startAngle;
        private bool requiresStartAngle = true;
        private bool shouldGetHandRotation = false;
        public float rotza, ROTZAB;
        private XRGrabInteractable grabInteractor => GetComponent<XRGrabInteractable>();
        public void DialChanged(float dialvalue)
        {
            Debug.Log("Hola");
        }
        private void OnEnable()
        {
            grabInteractor.onSelectEntered.AddListener(GrabbedBy);
            grabInteractor.onSelectExited.AddListener(GrabEnd);
        }
        private void OnDisable()
        {
            grabInteractor.onSelectEntered.RemoveListener(GrabbedBy);
            grabInteractor.onSelectExited.RemoveListener(GrabEnd);
        }

        private void GrabEnd(XRBaseInteractor arg0)
        {
            shouldGetHandRotation = false;
            requiresStartAngle = true;
            HandModelVisibility(false);
        }

        private void GrabbedBy(XRBaseInteractor arg0)
        {
            interactor = GetComponent<XRGrabInteractable>().selectingInteractor;
            interactor.GetComponent<XRDirectInteractor>().hideControllerOnSelect = true;

            shouldGetHandRotation = true;
            startAngle = 0f;

            HandModelVisibility(true);
        }

        private void HandModelVisibility(bool visibilityState)
        {
            if (!shouldUseDummyHands)
                return;

            if (interactor.CompareTag("RightHand"))
                RighthandModel.SetActive(visibilityState);
            else
                LefthandModel.SetActive(visibilityState);
        }

        void Update()
        {
            if (shouldGetHandRotation)
            {
                var rotationAngle = GetInteractorRotation(); //gets the current controller angle
                GetRotationDistance(rotationAngle);
            }

            DialCalculate();           
        }

        public float GetInteractorRotation() => interactor.GetComponent<Transform>().eulerAngles.z;

        #region TheMath!
        private void GetRotationDistance(float currentAngle)
        {
            if (!requiresStartAngle)
            {
                var angleDifference = Mathf.Abs(startAngle - currentAngle);

                if (angleDifference > angleTolerance)
                {
                    if (angleDifference > 270f) //checking to see if the user has gone from 0-360 - a very tiny movement but will trigger the angletolerance
                    {
                        float angleCheck;

                        if (startAngle < currentAngle) 
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                                return;
                            else
                            {
                                RotateDialClockwise();
                                startAngle = currentAngle;
                            }
                        }
                        else if (startAngle > currentAngle) 
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                                return;
                            else
                            {
                                RotateDialAntiClockwise();
                                startAngle = currentAngle;
                            }
                        }
                    }
                    else
                    {
                        if (startAngle < currentAngle)
                        {
                            RotateDialAntiClockwise();
                            startAngle = currentAngle;
                        }
                        else if (startAngle > currentAngle)
                        {
                            RotateDialClockwise();
                            startAngle = currentAngle;
                        }
                    }
                }
            }
            else
            {
                requiresStartAngle = false;
                startAngle = currentAngle;
            }
        }
        #endregion

        private float CheckAngle(float currentAngle, float startAngle) => (360f - currentAngle) + startAngle;

        private void RotateDialClockwise()
        {
            linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, 
                                                      linkedDial.localEulerAngles.y, 
                                                      linkedDial.localEulerAngles.z + snapRotationAmount);

            if (TryGetComponent<IDial>(out IDial dial))
                dial.DialChanged(linkedDial.localEulerAngles.z);
        }

        private void RotateDialAntiClockwise()
        {
            linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, 
                                                      linkedDial.localEulerAngles.y, 
                                                      linkedDial.localEulerAngles.z - snapRotationAmount);

            if(TryGetComponent<IDial>(out IDial dial))
                dial.DialChanged(linkedDial.localEulerAngles.z);
        }

        void DialCalculate()
        {
            Vector2 dir = dial2.position - DIALE3.position;
            float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
             angle = (angle <= 0) ? (360 + angle) : angle;
             ROTZAB = angle;
             angle = ((angle >= 315) ? (angle - 360) : angle) + 45;
            //Debug.Log(dialvalue);
            Debug.Log(angle);
            rotza = angle;

        }
    }

}
