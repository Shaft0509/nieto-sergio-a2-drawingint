
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

                       
 

        }
    }
}
