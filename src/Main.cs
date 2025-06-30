using Godot;
using System;

public partial class Main : Node2D
{
    private bool GameActive;
    private Ball ball;
    private Label player1ScoreLabel;
    private Label player2ScoreLabel;
    private Label startGameLabel;
    private int player1Score;
    private int player2Score;
    private float leftBound;
    private float rightBound;



    public override void _Ready()
    {
        GameActive = false;
        player1Score = 0;
        player2Score = 0;
        leftBound = 0;
        rightBound = GetViewportRect().Size.X;
        ball = GetNode<Ball>("Ball");
        startGameLabel = GetNode<Label>("StartGame");
        player1ScoreLabel = GetNode<Label>("Player1Score");
        player2ScoreLabel = GetNode<Label>("Player2Score");
        UpdateScoreLabel(player1ScoreLabel, player1Score);
        UpdateScoreLabel(player2ScoreLabel, player2Score);
    }

    private void UpdateScoreLabel(Label playerLabel, int score)
    {
        playerLabel.Text = score.ToString();
    }




    public override void _Process(double delta)
    {

        if (!GameActive && Input.IsActionPressed("start_game"))
        {
            GameActive = true;
            startGameLabel.Visible = false;
            ball.StartBall();
        }

        if (GameActive)
        {
            if (ball.GlobalPosition.X < leftBound)
            {
                player2Score++;
                UpdateScoreLabel(player2ScoreLabel, player2Score);
                GameActive = false;
                startGameLabel.Visible = true;
                ball.ResetBall();
            }
            else if (ball.GlobalPosition.X > rightBound)
            {
                player1Score++;
                UpdateScoreLabel(player1ScoreLabel, player1Score);
                GameActive = false;
                startGameLabel.Visible = true;
                ball.ResetBall();
            }
        }
    }



}
