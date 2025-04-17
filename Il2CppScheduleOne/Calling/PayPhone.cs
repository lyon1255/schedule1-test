using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004AD RID: 1197
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x06006985 RID: 27013 RVA: 0x001D88EC File Offset: 0x001D6AEC
		// Note: this type is marked as 'beforefieldinit'.
		static PayPhone()
		{
			Il2CppClassPointerStore<PayPhone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "PayPhone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPhone>.NativeClassPtr);
			PayPhone.NativeFieldInfoPtr_RING_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_INTERVAL");
			PayPhone.NativeFieldInfoPtr_RING_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_RANGE");
			PayPhone.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "Light");
			PayPhone.NativeFieldInfoPtr_RingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RingSound");
			PayPhone.NativeFieldInfoPtr_AnswerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "AnswerSound");
			PayPhone.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "IntObj");
			PayPhone.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "CameraPosition");
			PayPhone.NativeFieldInfoPtr_timeSinceLastRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "timeSinceLastRing");
			PayPhone.NativeFieldInfoPtr_ringRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "ringRangeSquared");
			PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676705);
			PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676706);
			PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676707);
			PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676708);
			PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676709);
			PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676710);
			PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676711);
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06006986 RID: 27014 RVA: 0x001D8A5C File Offset: 0x001D6C5C
		public unsafe PhoneCallData QueuedCall
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 212839, RefRangeEnd = 212844, XrefRangeStart = 212835, XrefRangeEnd = 212839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x001D8A9C File Offset: 0x001D6C9C
		public unsafe PhoneCallData ActiveCall
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 212848, RefRangeEnd = 212851, XrefRangeStart = 212844, XrefRangeEnd = 212848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212851, XrefRangeEnd = 212881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x001D8B10 File Offset: 0x001D6D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212881, XrefRangeEnd = 212883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x001D8B44 File Offset: 0x001D6D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212883, XrefRangeEnd = 212903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x001D8B78 File Offset: 0x001D6D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212915, RefRangeEnd = 212917, XrefRangeStart = 212903, XrefRangeEnd = 212915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x001D8BB4 File Offset: 0x001D6DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212917, XrefRangeEnd = 212918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayPhone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPhone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		public PayPhone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x001D8BF0 File Offset: 0x001D6DF0
		// (set) Token: 0x0600698F RID: 27023 RVA: 0x00031DC9 File Offset: 0x0002FFC9
		public unsafe static float RING_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x001D8C0C File Offset: 0x001D6E0C
		// (set) Token: 0x06006991 RID: 27025 RVA: 0x00031DD7 File Offset: 0x0002FFD7
		public unsafe static float RING_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06006992 RID: 27026 RVA: 0x001D8C28 File Offset: 0x001D6E28
		// (set) Token: 0x06006993 RID: 27027 RVA: 0x00031DE5 File Offset: 0x0002FFE5
		public unsafe BlinkingLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06006994 RID: 27028 RVA: 0x001D8C58 File Offset: 0x001D6E58
		// (set) Token: 0x06006995 RID: 27029 RVA: 0x00031E04 File Offset: 0x00030004
		public unsafe AudioSourceController RingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x001D8C88 File Offset: 0x001D6E88
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x00031E23 File Offset: 0x00030023
		public unsafe AudioSourceController AnswerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x001D8CB8 File Offset: 0x001D6EB8
		// (set) Token: 0x06006999 RID: 27033 RVA: 0x00031E42 File Offset: 0x00030042
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x001D8CE8 File Offset: 0x001D6EE8
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x00031E61 File Offset: 0x00030061
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600699C RID: 27036 RVA: 0x001D8D18 File Offset: 0x001D6F18
		// (set) Token: 0x0600699D RID: 27037 RVA: 0x00031E80 File Offset: 0x00030080
		public unsafe float timeSinceLastRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing)) = value;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x001D8D40 File Offset: 0x001D6F40
		// (set) Token: 0x0600699F RID: 27039 RVA: 0x00031E9B File Offset: 0x0003009B
		public unsafe static float ringRangeSquared
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&value));
			}
		}

		// Token: 0x0400484D RID: 18509
		private static readonly IntPtr NativeFieldInfoPtr_RING_INTERVAL;

		// Token: 0x0400484E RID: 18510
		private static readonly IntPtr NativeFieldInfoPtr_RING_RANGE;

		// Token: 0x0400484F RID: 18511
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04004850 RID: 18512
		private static readonly IntPtr NativeFieldInfoPtr_RingSound;

		// Token: 0x04004851 RID: 18513
		private static readonly IntPtr NativeFieldInfoPtr_AnswerSound;

		// Token: 0x04004852 RID: 18514
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004853 RID: 18515
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004854 RID: 18516
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastRing;

		// Token: 0x04004855 RID: 18517
		private static readonly IntPtr NativeFieldInfoPtr_ringRangeSquared;

		// Token: 0x04004856 RID: 18518
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0;

		// Token: 0x04004857 RID: 18519
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0;

		// Token: 0x04004858 RID: 18520
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04004859 RID: 18521
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400485A RID: 18522
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400485B RID: 18523
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x0400485C RID: 18524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
