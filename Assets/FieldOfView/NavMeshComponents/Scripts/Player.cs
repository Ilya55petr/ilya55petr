using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class Player : MonoBehaviour
{

    
    private NavMeshAgent _agent;
    [SerializeField] private Transform target;
    private Animator _anim;



    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }
    
    private void Update()
    {

        _agent.SetDestination(target.position);
        print(_agent.velocity.magnitude);
        _anim.SetFloat("Speed", _agent.velocity.magnitude);

    } 
    
}
