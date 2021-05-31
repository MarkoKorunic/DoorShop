using System;
using System.Collections.Generic;
using System.Text;

namespace DoorShop
{
    class Door
    {
        DoorType doorType { get; set; }
        DoorColor doorColor { get; set; }
        FrameColor frameColor { get; set; }
        FireproofLevel fireproofLevel { get; set; }

        float Height { get; set; }
        float Width { get; set; }
        float price { get; set; }

        
        
    }
}
enum DoorType
{
    Alpha = 1,
    Beta = 2,
    Gamen = 3
}
enum DoorColor
{
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
enum FireproofLevel
{
    m30 = 1,
    m60 = 2,
    m90 = 3
}
enum FrameColor
{
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
