using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000534 RID: 1332
	public class DemoBoundary : MonoBehaviour
	{
		// Token: 0x060076AA RID: 30378 RVA: 0x00203BB4 File Offset: 0x00201DB4
		// Note: this type is marked as 'beforefieldinit'.
		static DemoBoundary()
		{
			Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DemoBoundary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr);
			DemoBoundary.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, "Collider");
			DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678242);
			DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678243);
			DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678244);
			DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678245);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00203C48 File Offset: 0x00201E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230915, XrefRangeEnd = 230923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00203C7C File Offset: 0x00201E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230923, XrefRangeEnd = 230926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00203CB0 File Offset: 0x00201EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230926, XrefRangeEnd = 230942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00203CE4 File Offset: 0x00201EE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoBoundary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x000383D1 File Offset: 0x000365D1
		public DemoBoundary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x00203D20 File Offset: 0x00201F20
		// (set) Token: 0x060076B1 RID: 30385 RVA: 0x000383DA File Offset: 0x000365DA
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005109 RID: 20745
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x0400510A RID: 20746
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400510B RID: 20747
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400510C RID: 20748
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundary_Private_Void_0;

		// Token: 0x0400510D RID: 20749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
