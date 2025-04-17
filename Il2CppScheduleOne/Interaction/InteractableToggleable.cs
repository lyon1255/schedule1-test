using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F0 RID: 1008
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x06005364 RID: 21348 RVA: 0x00188F08 File Offset: 0x00187108
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableToggleable()
		{
			Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableToggleable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr);
			InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "<IsActivated>k__BackingField");
			InteractableToggleable.NativeFieldInfoPtr_ActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "ActivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "DeactivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "CoolDown");
			InteractableToggleable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "IntObj");
			InteractableToggleable.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onToggle");
			InteractableToggleable.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onActivate");
			InteractableToggleable.NativeFieldInfoPtr_onDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onDeactivate");
			InteractableToggleable.NativeFieldInfoPtr_lastActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "lastActivated");
			InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673722);
			InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673723);
			InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673724);
			InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673725);
			InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673726);
			InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673727);
			InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673728);
			InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673729);
			InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673730);
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x001890A0 File Offset: 0x001872A0
		// (set) Token: 0x06005366 RID: 21350 RVA: 0x001890DC File Offset: 0x001872DC
		public unsafe bool IsActivated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x0018911C File Offset: 0x0018731C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178920, XrefRangeEnd = 178934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00189150 File Offset: 0x00187350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178934, XrefRangeEnd = 178937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00189184 File Offset: 0x00187384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178942, RefRangeEnd = 178943, XrefRangeStart = 178937, XrefRangeEnd = 178942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x001891B8 File Offset: 0x001873B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178942, RefRangeEnd = 178943, XrefRangeStart = 178942, XrefRangeEnd = 178943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x001891EC File Offset: 0x001873EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178945, RefRangeEnd = 178946, XrefRangeStart = 178943, XrefRangeEnd = 178945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x0018922C File Offset: 0x0018742C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178946, XrefRangeEnd = 178950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00189260 File Offset: 0x00187460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178950, XrefRangeEnd = 178972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableToggleable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00027CAA File Offset: 0x00025EAA
		public InteractableToggleable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x0018929C File Offset: 0x0018749C
		// (set) Token: 0x06005370 RID: 21360 RVA: 0x00027CB3 File Offset: 0x00025EB3
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x001892C4 File Offset: 0x001874C4
		// (set) Token: 0x06005372 RID: 21362 RVA: 0x00027CCE File Offset: 0x00025ECE
		public unsafe string ActivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x001892EC File Offset: 0x001874EC
		// (set) Token: 0x06005374 RID: 21364 RVA: 0x00027CED File Offset: 0x00025EED
		public unsafe string DeactivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x00189314 File Offset: 0x00187514
		// (set) Token: 0x06005376 RID: 21366 RVA: 0x00027D0C File Offset: 0x00025F0C
		public unsafe float CoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown)) = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x0018933C File Offset: 0x0018753C
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x00027D27 File Offset: 0x00025F27
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x0018936C File Offset: 0x0018756C
		// (set) Token: 0x0600537A RID: 21370 RVA: 0x00027D46 File Offset: 0x00025F46
		public unsafe UnityEvent onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x0018939C File Offset: 0x0018759C
		// (set) Token: 0x0600537C RID: 21372 RVA: 0x00027D65 File Offset: 0x00025F65
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x001893CC File Offset: 0x001875CC
		// (set) Token: 0x0600537E RID: 21374 RVA: 0x00027D84 File Offset: 0x00025F84
		public unsafe UnityEvent onDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x001893FC File Offset: 0x001875FC
		// (set) Token: 0x06005380 RID: 21376 RVA: 0x00027DA3 File Offset: 0x00025FA3
		public unsafe float lastActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated)) = value;
			}
		}

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeFieldInfoPtr_ActivateMessage;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeFieldInfoPtr_DeactivateMessage;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivate;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeFieldInfoPtr_lastActivated;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_0;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeMethodInfoPtr_PoliceDetected_Public_Void_0;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
