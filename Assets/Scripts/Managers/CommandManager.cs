using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoSingleton<CommandManager>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();
    public bool isPlaying { get; private set; } = false;
    List<GameObject> cubes = new List<GameObject>();
    public override void Init()
    {
        base.Init();
        cubes = GameObject.FindGameObjectsWithTag("Cube").ToList();
        foreach (var cube in cubes)
        {
            ICommand start = new ClickCommand(cube,Color.white);
            Record(start);
        }
        
    }

    public void Record(ICommand command)
    {
        _commandBuffer.Add(command);
    }
    
    public void Play()
    {
        if (isPlaying == false)
        StartCoroutine(IPlay());
    }

    public IEnumerator IPlay()
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
        StartCoroutine(IRewind());
    }

    public IEnumerator IRewind()
    {
        isPlaying = true;
        _commandBuffer.Reverse();
        foreach (var command in _commandBuffer)
        {

            command.Exicute();
            yield return new WaitForSeconds(1);
        }
        _commandBuffer.Reverse();
        isPlaying = false;
    }

    public void Done()
    {
        GameObject.FindGameObjectsWithTag("Cube").ToList().ForEach(g => g.GetComponent<MeshRenderer>().material.color = Color.white);
    }

    public void Reset()
    {
        _commandBuffer.Clear();
        foreach (var cube in cubes)
        {
            ICommand start = new ClickCommand(cube,Color.white);
            Record(start);
        }
    }

}
