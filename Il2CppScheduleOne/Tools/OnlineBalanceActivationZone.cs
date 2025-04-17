using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000541 RID: 1345
	public class OnlineBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x0600772E RID: 30510 RVA: 0x00205558 File Offset: 0x00203758
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineBalanceActivationZone()
		{
			Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OnlineBalanceActivationZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr);
			OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "ActivationDistance");
			OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "exclude");
			OnlineBalanceActivationZone.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "collider");
			OnlineBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678314);
			OnlineBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678315);
			OnlineBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678316);
			OnlineBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678317);
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00205614 File Offset: 0x00203814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231382, XrefRangeEnd = 231389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00205648 File Offset: 0x00203848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231389, XrefRangeEnd = 231396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x0020567C File Offset: 0x0020387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231396, XrefRangeEnd = 231412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x002056C0 File Offset: 0x002038C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231412, XrefRangeEnd = 231420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineBalanceActivationZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00038738 File Offset: 0x00036938
		public OnlineBalanceActivationZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x06007734 RID: 30516 RVA: 0x002056FC File Offset: 0x002038FC
		// (set) Token: 0x06007735 RID: 30517 RVA: 0x00038741 File Offset: 0x00036941
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x00205718 File Offset: 0x00203918
		// (set) Token: 0x06007737 RID: 30519 RVA: 0x0003874F File Offset: 0x0003694F
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x00205748 File Offset: 0x00203948
		// (set) Token: 0x06007739 RID: 30521 RVA: 0x0003876E File Offset: 0x0003696E
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005159 RID: 20825
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x0400515A RID: 20826
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x0400515B RID: 20827
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x0400515C RID: 20828
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400515D RID: 20829
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x0400515E RID: 20830
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x0400515F RID: 20831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
