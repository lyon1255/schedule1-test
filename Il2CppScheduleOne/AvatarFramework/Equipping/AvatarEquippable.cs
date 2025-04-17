using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020005FD RID: 1533
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x06008714 RID: 34580 RVA: 0x0023AD58 File Offset: 0x00238F58
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippable()
		{
			Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr);
			AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AlignmentPoint");
			AvatarEquippable.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Suspiciousness");
			AvatarEquippable.NativeFieldInfoPtr_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Hand");
			AvatarEquippable.NativeFieldInfoPtr_TriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "TriggerType");
			AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AnimationTrigger");
			AvatarEquippable.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AssetPath");
			AvatarEquippable.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "avatar");
			AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680160);
			AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680161);
			AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680162);
			AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680163);
			AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680164);
			AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680165);
			AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680166);
			AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680167);
			AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680168);
			AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680169);
			AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680170);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0023AEF0 File Offset: 0x002390F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251115, XrefRangeEnd = 251129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x0023AF24 File Offset: 0x00239124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251129, XrefRangeEnd = 251141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0023AF60 File Offset: 0x00239160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251165, RefRangeEnd = 251168, XrefRangeStart = 251141, XrefRangeEnd = 251165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x0023AFB0 File Offset: 0x002391B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251168, XrefRangeEnd = 251170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x0023AFEC File Offset: 0x002391EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251170, XrefRangeEnd = 251180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x0023B028 File Offset: 0x00239228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251194, RefRangeEnd = 251195, XrefRangeStart = 251180, XrefRangeEnd = 251194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionAnimationModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x0023B05C File Offset: 0x0023925C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 251211, RefRangeEnd = 251218, XrefRangeStart = 251195, XrefRangeEnd = 251211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x0023B0A0 File Offset: 0x002392A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251234, RefRangeEnd = 251237, XrefRangeStart = 251218, XrefRangeEnd = 251234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string anim, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x0023B0F0 File Offset: 0x002392F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251253, RefRangeEnd = 251258, XrefRangeStart = 251237, XrefRangeEnd = 251253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x0023B134 File Offset: 0x00239334
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveMessage(string message, Il2CppSystem.Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x0023B194 File Offset: 0x00239394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251258, XrefRangeEnd = 251266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00040453 File Offset: 0x0003E653
		public AvatarEquippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x0023B1D0 File Offset: 0x002393D0
		// (set) Token: 0x06008722 RID: 34594 RVA: 0x0004045C File Offset: 0x0003E65C
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x06008723 RID: 34595 RVA: 0x0023B200 File Offset: 0x00239400
		// (set) Token: 0x06008724 RID: 34596 RVA: 0x0004047B File Offset: 0x0003E67B
		public unsafe float Suspiciousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x06008725 RID: 34597 RVA: 0x0023B228 File Offset: 0x00239428
		// (set) Token: 0x06008726 RID: 34598 RVA: 0x00040496 File Offset: 0x0003E696
		public unsafe AvatarEquippable.EHand Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand)) = value;
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x06008727 RID: 34599 RVA: 0x0023B250 File Offset: 0x00239450
		// (set) Token: 0x06008728 RID: 34600 RVA: 0x000404B1 File Offset: 0x0003E6B1
		public unsafe AvatarEquippable.ETriggerType TriggerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType)) = value;
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06008729 RID: 34601 RVA: 0x0023B278 File Offset: 0x00239478
		// (set) Token: 0x0600872A RID: 34602 RVA: 0x000404CC File Offset: 0x0003E6CC
		public unsafe string AnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600872B RID: 34603 RVA: 0x0023B2A0 File Offset: 0x002394A0
		// (set) Token: 0x0600872C RID: 34604 RVA: 0x000404EB File Offset: 0x0003E6EB
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600872D RID: 34605 RVA: 0x0023B2C8 File Offset: 0x002394C8
		// (set) Token: 0x0600872E RID: 34606 RVA: 0x0004050A File Offset: 0x0003E70A
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BE8 RID: 23528
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04005BE9 RID: 23529
		private static readonly IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x04005BEA RID: 23530
		private static readonly IntPtr NativeFieldInfoPtr_Hand;

		// Token: 0x04005BEB RID: 23531
		private static readonly IntPtr NativeFieldInfoPtr_TriggerType;

		// Token: 0x04005BEC RID: 23532
		private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

		// Token: 0x04005BED RID: 23533
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005BEE RID: 23534
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005BEF RID: 23535
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0;

		// Token: 0x04005BF0 RID: 23536
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005BF1 RID: 23537
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0;

		// Token: 0x04005BF2 RID: 23538
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0;

		// Token: 0x04005BF3 RID: 23539
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04005BF4 RID: 23540
		private static readonly IntPtr NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0;

		// Token: 0x04005BF5 RID: 23541
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0;

		// Token: 0x04005BF6 RID: 23542
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0;

		// Token: 0x04005BF7 RID: 23543
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0;

		// Token: 0x04005BF8 RID: 23544
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005BF9 RID: 23545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF4 RID: 2804
		[OriginalName("Assembly-CSharp.dll", "", "ETriggerType")]
		public enum ETriggerType
		{
			// Token: 0x04008FC8 RID: 36808
			Trigger,
			// Token: 0x04008FC9 RID: 36809
			Bool
		}

		// Token: 0x02000AF5 RID: 2805
		[OriginalName("Assembly-CSharp.dll", "", "EHand")]
		public enum EHand
		{
			// Token: 0x04008FCB RID: 36811
			Left,
			// Token: 0x04008FCC RID: 36812
			Right
		}
	}
}
