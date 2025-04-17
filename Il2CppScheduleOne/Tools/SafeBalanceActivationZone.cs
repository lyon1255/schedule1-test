using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054C RID: 1356
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x060077B2 RID: 30642 RVA: 0x00206DA8 File Offset: 0x00204FA8
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBalanceActivationZone()
		{
			Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SafeBalanceActivationZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr);
			SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "ActivationDistance");
			SafeBalanceActivationZone.NativeFieldInfoPtr_Safe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "Safe");
			SafeBalanceActivationZone.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "exclude");
			SafeBalanceActivationZone.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "colliders");
			SafeBalanceActivationZone.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "active");
			SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678362);
			SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678363);
			SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678364);
			SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678365);
			SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678366);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00206EA0 File Offset: 0x002050A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231864, XrefRangeEnd = 231874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00206ED4 File Offset: 0x002050D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231874, XrefRangeEnd = 231882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00206F08 File Offset: 0x00205108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231882, RefRangeEnd = 231883, XrefRangeStart = 231882, XrefRangeEnd = 231882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00206F3C File Offset: 0x0020513C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231883, XrefRangeEnd = 231903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00206F80 File Offset: 0x00205180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231903, XrefRangeEnd = 231911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeBalanceActivationZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00038AF5 File Offset: 0x00036CF5
		public SafeBalanceActivationZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x00206FBC File Offset: 0x002051BC
		// (set) Token: 0x060077BA RID: 30650 RVA: 0x00038AFE File Offset: 0x00036CFE
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x00206FD8 File Offset: 0x002051D8
		// (set) Token: 0x060077BC RID: 30652 RVA: 0x00038B0C File Offset: 0x00036D0C
		public unsafe Safe Safe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Safe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060077BD RID: 30653 RVA: 0x00207008 File Offset: 0x00205208
		// (set) Token: 0x060077BE RID: 30654 RVA: 0x00038B2B File Offset: 0x00036D2B
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060077BF RID: 30655 RVA: 0x00207038 File Offset: 0x00205238
		// (set) Token: 0x060077C0 RID: 30656 RVA: 0x00038B4A File Offset: 0x00036D4A
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060077C1 RID: 30657 RVA: 0x00207068 File Offset: 0x00205268
		// (set) Token: 0x060077C2 RID: 30658 RVA: 0x00038B69 File Offset: 0x00036D69
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x040051A8 RID: 20904
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x040051A9 RID: 20905
		private static readonly IntPtr NativeFieldInfoPtr_Safe;

		// Token: 0x040051AA RID: 20906
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x040051AB RID: 20907
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x040051AC RID: 20908
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x040051AD RID: 20909
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051AE RID: 20910
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x040051AF RID: 20911
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;

		// Token: 0x040051B0 RID: 20912
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040051B1 RID: 20913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
