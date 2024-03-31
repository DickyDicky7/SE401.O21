using Godot;

namespace TemplateMethodExample;

[GlobalClass]
public abstract partial class PortraitArtist : Node2D
{
    protected abstract (Vector2 position, Vector2 size) DrawFace();
    protected abstract (Vector2 position, Vector2 size) DrawLEye((Vector2 position, Vector2 size) face);
    protected abstract (Vector2 position, Vector2 size) DrawREye((Vector2 position, Vector2 size) face);
    protected abstract (Vector2 position, Vector2 size) DrawNose((Vector2 position, Vector2 size) lEye, (Vector2 position, Vector2 size) rEye);
    protected abstract (Vector2 position, Vector2 size) DrawMouth((Vector2 position, Vector2 size) nose);

    public override sealed void _Draw()
    {
        base._Draw();
        (Vector2 position, Vector2 size) face = DrawFace();
        (Vector2 position, Vector2 size) lEye = DrawLEye(face);
        (Vector2 position, Vector2 size) rEye = DrawREye(face);
        (Vector2 position, Vector2 size) nose = DrawNose(lEye, rEye);
        (Vector2 position, Vector2 size) mouth = DrawMouth(nose);
    }
}
