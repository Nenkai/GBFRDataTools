using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public class FsmEditorSettings
{
    public Vector2 ViewportSize { get; set; }
    public Vector2 ViewportLocation { get; set; }
    public float ViewportZoom { get; set; } = 1.0f;
}
