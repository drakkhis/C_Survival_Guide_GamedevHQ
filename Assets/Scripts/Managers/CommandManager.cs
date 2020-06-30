using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoSingleton<CommandManager>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();
    public bool isPlaying { get; private set; } = false;
    public override void Init()
    {
        base.Init();
        
        
    }

    public void Record(ICommand command)
    {
        if (isPlaying == false)
            _commandBuffer.Add(command);
    }
    
    public void Play()
    {
        if (isPlaying == false)
        StartCoroutine(PlayRoutine());
    }

    public IEnumerator PlayRoutine()
    {
        isPlaying = true;
        foreach (var command in _commandBuffer)
        {
            command.Exicute();
            yield return new WaitForSeconds(1);
        }
        isPlaying = false;
    }
    
    public void Rewind()
    {
        if (isPlaying == false)
        StartCoroutine(RewindRoutine());
    }

    public IEnumerator RewindRoutine()
    {
        isPlaying = true;
        foreach (var command in Enumerable.Reverse(_commandBuffer))
        {

            command.Undo();
            yield return new WaitForSeconds(1);
        }
        isPlaying = false;
    }

    public void Done()
    {
        if (isPlaying == false)
            GameObject.FindGameObjectsWithTag("Cube").ToList().ForEach(g => g.GetComponent<MeshRenderer>().material.color = Color.white);
    }

    public void Reset()
    {
        if (isPlaying == false)
            _commandBuffer.Clear();
    }

}
