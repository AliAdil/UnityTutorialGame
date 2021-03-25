using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace alistudios
{
    public class CameraShake : MonoBehaviour
    {
        // Transform of the camera to shake. Grabs the gameObject's transform
        // if null.
        public Transform camTransform;

        // How long the object should shake for.
        public float shakeDuration = 0f;

        // Amplitude of the shake. A larger value shakes the camera harder.
        public float shakeAmount = 0.7f;
        public float decreaseFactor = 1.0f;

        Vector3 originalPos;


        // Audio Source Array

        public AudioSource[] soundFX;

        void Awake()
        {
            if (camTransform == null)
            {
                camTransform = GetComponent(typeof(Transform)) as Transform;
            }
        }

        void OnEnable()
        {
            originalPos = camTransform.localPosition;
        }

        void Update()
        {
            if (shakeDuration > 0)
            {
                camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

                shakeDuration -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                shakeDuration = 0f;
                camTransform.localPosition = originalPos;
            }

            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {

                // Setting animation to idle state
                soundFX[0].Pause();
                soundFX[1].Pause();
                soundFX[2].Pause();
                soundFX[3].Pause();
                if (!soundFX[4].isPlaying)
                {
                    soundFX[4].Play();
                }

                return;
            }
            // when no button is pressed 
            if (!VirtualInputManager.Instance.MoveLeft && !VirtualInputManager.Instance.MoveRight)
            { // Setting animation to idle state
                soundFX[0].Pause();
                soundFX[1].Pause();
                soundFX[2].Pause();
                soundFX[3].Pause();
                if (!soundFX[4].isPlaying)
                {
                    soundFX[4].Play();
                }

            }

            if (VirtualInputManager.Instance.MoveRight)
            {


                if (Input.GetKey(KeyCode.D))
                {

                    soundFX[1].Pause();
                    soundFX[2].Pause();
                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[0].isPlaying)
                    {
                        soundFX[0].Play();
                    }

                }

                if (Input.GetKey(KeyCode.C))
                {
                    soundFX[0].Pause();
                    soundFX[2].Pause();
                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[1].isPlaying)
                    {
                        soundFX[1].Play();
                    }

                }

                if (Input.GetKey(KeyCode.E))
                {
                    soundFX[0].Pause();
                    soundFX[1].Pause();

                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[2].isPlaying)
                    {
                        soundFX[2].Play();
                    }
                }

                if (Input.GetKey(KeyCode.N))
                {
                    soundFX[0].Pause();
                    soundFX[1].Pause();
                    soundFX[2].Pause();
                    soundFX[4].Pause();

                    if (!soundFX[3].isPlaying)
                    {
                        soundFX[3].Play();
                    }



                }
            }


            // when left button is pressed 
            if (VirtualInputManager.Instance.MoveLeft)
            {


                if (Input.GetKey(KeyCode.A))
                {

                    soundFX[1].Pause();
                    soundFX[2].Pause();
                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[0].isPlaying)
                    {
                        soundFX[0].Play();
                    }


                }

                if (Input.GetKey(KeyCode.Z))
                {
                    soundFX[0].Pause();
                    soundFX[2].Pause();
                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[1].isPlaying)
                    {
                        soundFX[1].Play();
                    }

                }

                if (Input.GetKey(KeyCode.Q))
                {
                    soundFX[0].Pause();
                    soundFX[1].Pause();
                    soundFX[3].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[2].isPlaying)
                    {
                        soundFX[2].Play();
                    }

                }

                if (Input.GetKey(KeyCode.V))
                {
                    soundFX[0].Pause();
                    soundFX[1].Pause();
                    soundFX[2].Pause();
                    soundFX[4].Pause();
                    if (!soundFX[3].isPlaying)
                    {
                        soundFX[3].Play();
                    }

                }
            }

        }
    }
}
