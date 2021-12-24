using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    

    public class PlayerContoller : MonoBehaviour
    {
        public float JumpPower;
        private Animator Anim;
        private bool OpenDoor = false;
        [SerializeField] private bool IsGrounded;
        private Vector3 Movement;
        private PlayerMovement PlayerMovement;
        [SerializeField] private GameObject PartycleObj;
        [SerializeField] private MeshRenderer PlayerRender;
        

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
            PlayerRender = GetComponent<MeshRenderer>();
            JumpPower = 200;
        }
        void Update()
        {
            float Horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float Vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);
            Movement = new Vector3(Horizontal, 0, Vertical).normalized;
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)  //
            {
                IsGrounded = false;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Нажата Е");
                OpenDoor = true;
            }
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(Movement);
        }

        

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ground"))
            {
                IsGrounded = true;
            }
            if (other.CompareTag("Teleport"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (other.CompareTag("DieObj"))
            {
                PlayerRender.enabled = false;
                GetComponent<Rigidbody>().isKinematic = true;
                PartycleObj.SetActive(true);
                StartCoroutine(ReloadScene());
            }
            if (other.CompareTag("Door"))
            {
                Anim = other.GetComponent<Animator>();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Door"))
            {
                if (OpenDoor)
                {
                    Anim.SetBool("OpenDoor", true);
                    
                    OpenDoor = false;
                    Debug.Log("Должна открыться");
                }
            }
        }

        private IEnumerator ReloadScene()
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

    }

}
