using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057F RID: 1407
	public class StoredItemRandomRotation : MonoBehaviour
	{
		// Token: 0x06007BEB RID: 31723 RVA: 0x002152F4 File Offset: 0x002134F4
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItemRandomRotation()
		{
			Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItemRandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr);
			StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, "ItemContainer");
			StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678837);
			StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678838);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x00215360 File Offset: 0x00213560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236973, XrefRangeEnd = 236977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x00215394 File Offset: 0x00213594
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItemRandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x0003ACC5 File Offset: 0x00038EC5
		public StoredItemRandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x002153D0 File Offset: 0x002135D0
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x0003ACCE File Offset: 0x00038ECE
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005464 RID: 21604
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005465 RID: 21605
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005466 RID: 21606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
