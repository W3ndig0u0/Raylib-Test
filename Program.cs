﻿using System;
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
      Rectangle playerRect = new Rectangle(150, 150, 50, 50);

      while (!Raylib.WindowShouldClose())
      {
        Vector2 mousePos = Raylib.GetMousePosition();
        bool areOverlapping = Raylib.CheckCollisionPointRec(mousePos, playerRect);

        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerRect.y != 550)
        {
          playerRect.y += Convert.ToSingle(0.5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && playerRect.y != 0)
        {
          playerRect.y -= Convert.ToSingle(0.5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerRect.x != 750)
        {
          playerRect.x += Convert.ToSingle(0.5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerRect.x != 0)
        {
          playerRect.x -= Convert.ToSingle(0.5);
        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(white);

        Raylib.DrawText(mousePos.ToString(), 10, 10, 25, Color.ORANGE);

        Raylib.DrawText(playerRect.y.ToString(), 10, 40, 20, Color.ORANGE);
        Raylib.DrawText(playerRect.x.ToString(), 60, 40, 20, Color.ORANGE);

        Raylib.DrawText(areOverlapping.ToString(), 10, 60, 20, Color.BLACK);

        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);

        Raylib.EndDrawing();
      }
    }
  }
}
