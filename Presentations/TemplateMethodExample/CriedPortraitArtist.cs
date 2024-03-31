using Godot;

namespace TemplateMethodExample;

public partial class CriedPortraitArtist : PortraitArtist
{
    protected override (Vector2 position, Vector2 size) DrawFace()
    {
        Vector2 position = new(0, 0);
        Vector2 size = new(500, 500);
        DrawRect(rect: new(position, size), Colors.Yellow);
        return (position, size);
    }

    protected override (Vector2 position, Vector2 size) DrawLEye((Vector2 position, Vector2 size) face)
    {
        Vector2 position = face.position + new Vector2(100, 100);
        Vector2 size = new(50, 50);
        DrawRect(rect: new(position + new Vector2(0, size.Y / 2),
                size + new Vector2(0, 100)), Colors.Blue);
        DrawCircle(position, radius: size.X / 2, Colors.Black);
        return (position, size);
    }

    protected override (Vector2 position, Vector2 size) DrawREye((Vector2 position, Vector2 size) face)
    {
        Vector2 position = face.position + new Vector2(300, 100);
        Vector2 size = new(50, 50);
        DrawCircle(position, radius: size.X / 2, Colors.Black);
        return (position, size);
    }

    protected override (Vector2 position, Vector2 size) DrawNose((Vector2 position, Vector2 size) lEye, (Vector2 position, Vector2 size) rEye)
    {
        Vector2 position = lEye.position + new Vector2(150, 100);
        Vector2 size = new(50, 100);
        DrawRect(rect: new(position, size), Colors.Black);
        return (position, size);
    }

    protected override (Vector2 position, Vector2 size) DrawMouth((Vector2 position, Vector2 size) nose)
    {
        Vector2 postion = nose.position + new Vector2(0, 300);
        Vector2 size = new(200, 200);
        DrawArc(
            center: postion,
            radius: size.X / 2,
            startAngle: Mathf.DegToRad(225),
              endAngle: Mathf.DegToRad(315),
            pointCount: 10,
            Colors.Crimson,
            width: 10,
            antialiased: true);
        return (postion, size);
    }
}
