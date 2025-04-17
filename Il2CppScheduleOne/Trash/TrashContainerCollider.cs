using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051E RID: 1310
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x060074BB RID: 29883 RVA: 0x001FCB38 File Offset: 0x001FAD38
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerCollider()
		{
			Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr);
			TrashContainerCollider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, "Container");
			TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677977);
			TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677978);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x001FCBA4 File Offset: 0x001FADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228038, XrefRangeEnd = 228047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x001FCBE8 File Offset: 0x001FADE8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x00037635 File Offset: 0x00035835
		public TrashContainerCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060074BF RID: 29887 RVA: 0x001FCC24 File Offset: 0x001FAE24
		// (set) Token: 0x060074C0 RID: 29888 RVA: 0x0003763E File Offset: 0x0003583E
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FBA RID: 20410
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004FBB RID: 20411
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04004FBC RID: 20412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
