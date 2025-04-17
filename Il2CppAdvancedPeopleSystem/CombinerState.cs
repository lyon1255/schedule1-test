using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000141 RID: 321
	[OriginalName("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CombinerState")]
	public enum CombinerState : byte
	{
		// Token: 0x040011D1 RID: 4561
		NotCombined,
		// Token: 0x040011D2 RID: 4562
		InProgressCombineMesh,
		// Token: 0x040011D3 RID: 4563
		InProgressBlendshapeTransfer,
		// Token: 0x040011D4 RID: 4564
		InProgressClear,
		// Token: 0x040011D5 RID: 4565
		Combined,
		// Token: 0x040011D6 RID: 4566
		UsedPreBuitMeshes
	}
}
