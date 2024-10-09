
using System;
using System.Data;
using System.Numerics;


namespace Game10003
{

    public class Game
    {
           


        public void Setup()
        {
            Window.SetTitle("Cotidianity Changes");
            Window.SetSize(800, 600);


        }


        public void Update()
        {
                Window.ClearBackground(Color.Blue);
         

            // Draw rectangles

            Draw.FillColor = Color.Green;
            Draw.Rectangle(0, 450, 800, 150);
            
          
            Draw.FillColor = Color.Red;
            Draw.Rectangle(200, 300, 350, 280);

            Draw.FillColor = Color.White;
            Draw.Rectangle(250, 375, 100, 50);

            Draw.FillColor = Color.White;
            Draw.Rectangle(400, 375, 100, 50);

            Draw.FillColor = Color.Black;
            Draw.Rectangle(300, 450, 150, 130);
           
            
            //Draw Triangle
           
            Draw.FillColor = Color.LightGray;

            float x1 = 150;
            float y1 = 300;
            float x2 = 350;
            float y2 = 100;
            float x3 = 600;
            float y3 = 300;

            Draw.Triangle(150, 300, 375, 100, 605, 300);
            
          



                       
 

        }
    }
}
