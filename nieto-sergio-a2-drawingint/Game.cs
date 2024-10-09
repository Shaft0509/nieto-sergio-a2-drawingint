
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
            
          



                       
 

        }
    }
}
