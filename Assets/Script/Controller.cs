using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public InputSystem_Actions inputs;


    public WeaponBase SelectedWeapon;

    public Vector2 MoveInput;

    public UnityEvent OnAttackFBX;
    public UnityEvent OnDeadFBX;
    public UnityEvent OnJumpFBX;

    private void Awake()
    {
        inputs = new();
    }
    private void OnEnable()
    {
        inputs.Enable();

        inputs.CustomMap.Movement.performed += OnMovement;
        inputs.CustomMap.Movement.canceled += OnMovementStop;


        inputs.CustomMap.Attack.performed += OnAttack;
    }

    private void OnMovementStop(InputAction.CallbackContext context)
    {
        MoveInput = Vector2.zero; 
    }

    private void OnMovement(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        print("Hola");
        //SelectedWeapon.Excecute();
        OnAttackFBX?.Invoke();
    }
    public float speed;//->1000
    public float vida;//->1000
    void Start()
    {
        /* vida += 19999;

         vida = Mathf.Clamp(vida, 0, 100);

         Debug.Log(Mathf.Clamp(speed, 0, 100));
         Debug.Log(Mathf.Clamp01(-1000));

         Debug.Log(Mathf.Abs(-20));//->20



         Debug.Log(Mathf.Min(10, 30));//->10 

         Debug.Log(Mathf.Max(10, 30)); //->30
         Debug.Log(Mathf.Round(5.8f));//->6

         Debug.Log(Mathf.Floor(5.99999f));//->5
         Debug.Log(Mathf.Ceil(5.0000001f));//->6
         Debug.Log(Mathf.Sqrt(25)); //-> 5
         Debug.Log(Mathf.Pow(2, 3)); //-> 8   2*2*2*/
        
    }

    
    void Update()
    {

        //speed = Mathf.Lerp(0, 10, Time.deltaTime);

        /*speed = Mathf.PingPong(Time.time * 1.5f, 5);

        transform.position = new Vector3(speed, 0, speed);*/
    }
}
