using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054A RID: 1354
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x060077A2 RID: 30626 RVA: 0x00206B08 File Offset: 0x00204D08
		// Note: this type is marked as 'beforefieldinit'.
		static RigidbodyEventBroadcaster()
		{
			Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RigidbodyEventBroadcaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr);
			RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, "onTriggerEnter");
			RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678358);
			RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678359);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00206B74 File Offset: 0x00204D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231835, XrefRangeEnd = 231838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00206BB8 File Offset: 0x00204DB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidbodyEventBroadcaster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00038A6F File Offset: 0x00036C6F
		public RigidbodyEventBroadcaster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x060077A6 RID: 30630 RVA: 0x00206BF4 File Offset: 0x00204DF4
		// (set) Token: 0x060077A7 RID: 30631 RVA: 0x00038A78 File Offset: 0x00036C78
		public unsafe UnityEvent<Collider> onTriggerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051A0 RID: 20896
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerEnter;

		// Token: 0x040051A1 RID: 20897
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x040051A2 RID: 20898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
