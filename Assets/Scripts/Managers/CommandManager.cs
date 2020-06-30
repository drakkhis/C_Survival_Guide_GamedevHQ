using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoSingleton<CommandManager>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();
    public override void Init()
    {
        base.Init();

    }

    public void Record(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    public IEnumerator Play()
    {
        foreach (var command in _commandBuffer)
        {
            command.Exicute();
            yield return new WaitForSeconds(1);
        }
    }

    public IEnumerator Rewind()
    {
        _commandBuffer.Reverse();
        foreach (var command in _commandBuffer)
        {

            command.Exicute();
            yield return new WaitForSeconds(1);
        }
    }

    public void Done()
    {
        GameObject.FindGameObjectsWithTag("Cube").ToList().ForEach(g => g.GetComponent<MeshRenderer>().material.color = Color.white);
    }

    public void Reset()
    {
        _commandBuffer.Clear();
    }

}
