using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000570 RID: 1392
	public class PalletSlotDetector : MonoBehaviour
	{
		// Token: 0x06007A90 RID: 31376 RVA: 0x0020FEA0 File Offset: 0x0020E0A0
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlotDetector()
		{
			Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlotDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr);
			PalletSlotDetector.NativeFieldInfoPtr_pallet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, "pallet");
			PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100678649);
			PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100678650);
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x0020FF0C File Offset: 0x0020E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234672, XrefRangeEnd = 234674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x0020FF5C File Offset: 0x0020E15C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlotDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x0003A44E File Offset: 0x0003864E
		public PalletSlotDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x0020FF98 File Offset: 0x0020E198
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x0003A457 File Offset: 0x00038657
		public unsafe Pallet pallet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400536C RID: 21356
		private static readonly IntPtr NativeFieldInfoPtr_pallet;

		// Token: 0x0400536D RID: 21357
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x0400536E RID: 21358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
