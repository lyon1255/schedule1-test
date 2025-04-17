using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x0200008F RID: 143
	[OriginalName("Assembly-CSharp.dll", "VLB", "RenderQueue")]
	public enum RenderQueue
	{
		// Token: 0x04000601 RID: 1537
		Custom,
		// Token: 0x04000602 RID: 1538
		Background = 1000,
		// Token: 0x04000603 RID: 1539
		Geometry = 2000,
		// Token: 0x04000604 RID: 1540
		AlphaTest = 2450,
		// Token: 0x04000605 RID: 1541
		GeometryLast = 2500,
		// Token: 0x04000606 RID: 1542
		Transparent = 3000,
		// Token: 0x04000607 RID: 1543
		Overlay = 4000
	}
}
