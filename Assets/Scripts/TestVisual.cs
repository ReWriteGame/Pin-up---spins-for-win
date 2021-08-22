using UnityEngine;
using UnityEngine.UI;

public class TestVisual : MonoBehaviour
{
    [SerializeField] private Text output;
    [SerializeField] private Test scoreCounter;


    private void Start()
    {
        updateScore();
    }

    
    public void updateScore()
    {
        output.text = $"{scoreCounter.Score}";
    }

    private void OnEnable()
    {
        scoreCounter.changeScoreEvent.AddListener(updateScore);
    }
    private void OnDisable()
    {
        scoreCounter.changeScoreEvent.RemoveListener(updateScore);
    }
}
