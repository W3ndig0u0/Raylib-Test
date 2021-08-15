using System;
using System.Numerics;
using Raylib_cs;

namespace Raylib_Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.ToggleFullscreen();
      Raylib.InitWindow(800, 600, "Hello World");

      Color newPink = new Color(255, 105, 180, 255);
      Color white = Color.WHITE;
      Raylib.SetExitKey(KeyboardKey.KEY_ESCAPE);
      Rectangle playerRect = new Rectangle(300, 150, 250, 100);

      while (!Raylib.WindowShouldClose())
      {
        string Pressed = "Not Pressing";
        Vector2 mousePos = Raylib.GetMousePosition();
        bool areOverlapping = Raylib.CheckCollisionPointRec(mousePos, playerRect);

        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
          Pressed = "Pressing!";
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerRect.y != 600)
        {
          playerRect.y++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && playerRect.y != 0)
        {
          playerRect.y--;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerRect.x != 800)
        {
          playerRect.x++;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerRect.x != 0)
        {
          playerRect.x--;
        }


        Raylib.BeginDrawing();
        Raylib.ClearBackground(white);

        Raylib.DrawText(mousePos.ToString(), 10, 10, 30, Color.ORANGE);
        Raylib.DrawText("Press Spacebar", 300, 200, 30, Color.GRAY);
        Raylib.DrawText(Pressed, 250, 300, 60, Color.BLACK);
        Raylib.DrawText(areOverlapping.ToString(), 10, 40, 30, Color.BLACK);

        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);

        Raylib.EndDrawing();
      }
    }
  }
}
