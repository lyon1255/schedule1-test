using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000092 RID: 146
	[OriginalName("Assembly-CSharp.dll", "VLB", "DynamicOcclusionUpdateRate")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x0400060F RID: 1551
		Never = 1,
		// Token: 0x04000610 RID: 1552
		OnEnable = 2,
		// Token: 0x04000611 RID: 1553
		OnBeamMove = 4,
		// Token: 0x04000612 RID: 1554
		EveryXFrames = 8,
		// Token: 0x04000613 RID: 1555
		OnBeamMoveAndEveryXFrames = 12
	}
}
