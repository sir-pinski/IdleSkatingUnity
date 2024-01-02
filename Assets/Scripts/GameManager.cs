using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Skater skater; // Instance of Skater

    private float _gameTimer;

    private void Start()
    {
        // Initialize the skater here or load existing data
        skater = new Skater("SkaterName", 20);

        // Initialize game timer
        _gameTimer = 0;
    }

    private void Update()
    {
        // Update game timer based on real time
        _gameTimer += Time.deltaTime;

        // Example: Every 1 real-time second corresponds to 1 game hour
        if (_gameTimer >= 1.0f)
        {
            // Update the game state based on the passage of time
            UpdateGameState();

            // Reset the timer
            _gameTimer = 0;
        }
    }

    private void UpdateGameState()
    {
        // Modify values in Skater or other classes based on game logic
        // For example, decrease freeHours, increase skills, manage resources, etc.

        // This is where you can call methods like skater.Train(...) based on game conditions
    }
}