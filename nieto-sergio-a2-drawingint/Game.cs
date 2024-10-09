
using System;
using System.Data;
using System.Numerics;


namespace Game10003
{

    public class Game
    {


        // Keeps track of time for day/night switching
        private double timeElapsed = 0;

        // True if it's day, false if it's night
        private bool isDay = true;

        // X position of the circle
        private float circleX = 650;

        // Speed of the circle moving left
        private const float circleSpeed = 100;

        // Colors for the rectangles
        private Color[] rectColors = { Color.Green, Color.Red, Color.White, Color.White, Color.Black };
      
        
        
      
        public void Setup()
        {
            Window.SetTitle("Cotidianity Changes");
            Window.SetSize(800, 600);


        }


        public void Update()
        {
           
            // Increment time for day and night switching
            timeElapsed += Time.DeltaTime;
            if (timeElapsed >= 5)
            {
                isDay = !isDay;
                timeElapsed = 0;
            }

            // Set background and circle color based on day/night


            Window.ClearBackground(isDay ? Color.White : Color.Blue);
            Draw.FillColor = isDay ? Color.Yellow : Color.Gray;


            // Move the circle left, reset to right when it is off the window/screen
            circleX -= circleSpeed * Time.DeltaTime;
            if (circleX < -50) circleX = 850;


            // Draw the  circle
            Draw.Circle(circleX, 100, 50);






        }
    }
}
