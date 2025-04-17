using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000094 RID: 148
	[OriginalName("Assembly-CSharp.dll", "VLB", "ShadowUpdateRate")]
	[Flags]
	public enum ShadowUpdateRate
	{
		// Token: 0x04000619 RID: 1561
		Never = 1,
		// Token: 0x0400061A RID: 1562
		OnEnable = 2,
		// Token: 0x0400061B RID: 1563
		OnBeamMove = 4,
		// Token: 0x0400061C RID: 1564
		EveryXFrames = 8,
		// Token: 0x0400061D RID: 1565
		OnBeamMoveAndEveryXFrames = 12
	}
}
