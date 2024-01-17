using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// This a simplified version of a Queue system
public class CommandManager : MonoBehaviour
{
    Queue<string> commandQueue = new Queue<string>();
    [SerializeField] TMP_Text queueText;

    public void AddCommand(string command)
    {
        commandQueue.Enqueue(command);

        UpdateQueuedCommandsText();
    }

    public void RunNextCommand()
    {
        if (commandQueue.Count == 0)
        {
            return;
        }

        string cmd = commandQueue.Dequeue();
        Debug.Log(cmd);

        UpdateQueuedCommandsText();
    }

    void UpdateQueuedCommandsText() 
    {
        queueText.text = string.Empty;

        foreach (string command in commandQueue)
        {
            queueText.text += command + ", ";
        }
    }
}
