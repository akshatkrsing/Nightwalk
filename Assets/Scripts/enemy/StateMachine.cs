using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
    // Start is called before the first frame update
    public void Initialise()
    {
        ChangeState(new PatrolState());
    }
    
    // Update is called once per frame
    void Update()
    {
        if (activeState != null)
        {
            activeState.Perform();
        }
    }

    public void ChangeState(BaseState newState)
    {
        if (activeState != null)
        {
            activeState.Exit();
        }
        activeState = newState;
        if (activeState != null)
        {
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}
