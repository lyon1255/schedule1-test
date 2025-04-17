using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055A RID: 1370
	public class PlantGrowthStage : MonoBehaviour
	{
		// Token: 0x06007897 RID: 30871 RVA: 0x002094B0 File Offset: 0x002076B0
		// Note: this type is marked as 'beforefieldinit'.
		static PlantGrowthStage()
		{
			Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantGrowthStage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr);
			PlantGrowthStage.NativeFieldInfoPtr_GrowthSites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, "GrowthSites");
			PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, 100678427);
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00209508 File Offset: 0x00207708
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantGrowthStage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00039392 File Offset: 0x00037592
		public PlantGrowthStage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x00209544 File Offset: 0x00207744
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x0003939B File Offset: 0x0003759B
		public unsafe Il2CppReferenceArray<Transform> GrowthSites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005229 RID: 21033
		private static readonly IntPtr NativeFieldInfoPtr_GrowthSites;

		// Token: 0x0400522A RID: 21034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
