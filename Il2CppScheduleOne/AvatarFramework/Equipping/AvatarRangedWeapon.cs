using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000600 RID: 1536
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x0600874D RID: 34637 RVA: 0x0023B79C File Offset: 0x0023999C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarRangedWeapon()
		{
			Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarRangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr);
			AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaycastLayers");
			AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MagazineSize");
			AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "ReloadTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxFireRate");
			AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "CanShootWhileMoving");
			AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "EquipTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaiseTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "Damage");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MinRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MaxRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MuzzlePoint");
			AvatarRangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "FireSound");
			AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "LoweredAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaisedAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RecoilAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<IsRaised>k__BackingField");
			AvatarRangedWeapon.NativeFieldInfoPtr_isReloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "isReloading");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeEquipped");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeRaised");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeSinceLastShot");
			AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "currentAmmo");
			AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680186);
			AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680187);
			AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680188);
			AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680189);
			AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680190);
			AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680191);
			AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680192);
			AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680193);
			AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680194);
			AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680195);
			AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680196);
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x0023BA4C File Offset: 0x00239C4C
		// (set) Token: 0x0600874F RID: 34639 RVA: 0x0023BA88 File Offset: 0x00239C88
		public unsafe bool IsRaised
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x0023BAC8 File Offset: 0x00239CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251375, XrefRangeEnd = 251382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x0023BB18 File Offset: 0x00239D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251382, XrefRangeEnd = 251386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x0023BB64 File Offset: 0x00239D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251386, XrefRangeEnd = 251389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x0023BB98 File Offset: 0x00239D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251389, XrefRangeEnd = 251401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x0023BBF8 File Offset: 0x00239DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251401, RefRangeEnd = 251402, XrefRangeStart = 251401, XrefRangeEnd = 251401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x0023BC34 File Offset: 0x00239E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251421, RefRangeEnd = 251423, XrefRangeStart = 251402, XrefRangeEnd = 251421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x0023BC80 File Offset: 0x00239E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251423, XrefRangeEnd = 251428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x0023BCC0 File Offset: 0x00239EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251473, RefRangeEnd = 251474, XrefRangeStart = 251428, XrefRangeEnd = 251473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerInLoS(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x0023BD10 File Offset: 0x00239F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251474, XrefRangeEnd = 251475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarRangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00040650 File Offset: 0x0003E850
		public AvatarRangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600875A RID: 34650 RVA: 0x0023BD4C File Offset: 0x00239F4C
		// (set) Token: 0x0600875B RID: 34651 RVA: 0x00040659 File Offset: 0x0003E859
		public unsafe static Il2CppStringArray RaycastLayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x0023BD74 File Offset: 0x00239F74
		// (set) Token: 0x0600875D RID: 34653 RVA: 0x0004066B File Offset: 0x0003E86B
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600875E RID: 34654 RVA: 0x0023BD9C File Offset: 0x00239F9C
		// (set) Token: 0x0600875F RID: 34655 RVA: 0x00040686 File Offset: 0x0003E886
		public unsafe float ReloadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime)) = value;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x0023BDC4 File Offset: 0x00239FC4
		// (set) Token: 0x06008761 RID: 34657 RVA: 0x000406A1 File Offset: 0x0003E8A1
		public unsafe float MaxFireRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate)) = value;
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x0023BDEC File Offset: 0x00239FEC
		// (set) Token: 0x06008763 RID: 34659 RVA: 0x000406BC File Offset: 0x0003E8BC
		public unsafe bool CanShootWhileMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving)) = value;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06008764 RID: 34660 RVA: 0x0023BE14 File Offset: 0x0023A014
		// (set) Token: 0x06008765 RID: 34661 RVA: 0x000406D7 File Offset: 0x0003E8D7
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06008766 RID: 34662 RVA: 0x0023BE3C File Offset: 0x0023A03C
		// (set) Token: 0x06008767 RID: 34663 RVA: 0x000406F2 File Offset: 0x0003E8F2
		public unsafe float RaiseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime)) = value;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06008768 RID: 34664 RVA: 0x0023BE64 File Offset: 0x0023A064
		// (set) Token: 0x06008769 RID: 34665 RVA: 0x0004070D File Offset: 0x0003E90D
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600876A RID: 34666 RVA: 0x0023BE8C File Offset: 0x0023A08C
		// (set) Token: 0x0600876B RID: 34667 RVA: 0x00040728 File Offset: 0x0003E928
		public unsafe float HitChange_MinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange)) = value;
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600876C RID: 34668 RVA: 0x0023BEB4 File Offset: 0x0023A0B4
		// (set) Token: 0x0600876D RID: 34669 RVA: 0x00040743 File Offset: 0x0003E943
		public unsafe float HitChange_MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange)) = value;
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600876E RID: 34670 RVA: 0x0023BEDC File Offset: 0x0023A0DC
		// (set) Token: 0x0600876F RID: 34671 RVA: 0x0004075E File Offset: 0x0003E95E
		public unsafe Transform MuzzlePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06008770 RID: 34672 RVA: 0x0023BF0C File Offset: 0x0023A10C
		// (set) Token: 0x06008771 RID: 34673 RVA: 0x0004077D File Offset: 0x0003E97D
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x0023BF3C File Offset: 0x0023A13C
		// (set) Token: 0x06008773 RID: 34675 RVA: 0x0004079C File Offset: 0x0003E99C
		public unsafe string LoweredAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x06008774 RID: 34676 RVA: 0x0023BF64 File Offset: 0x0023A164
		// (set) Token: 0x06008775 RID: 34677 RVA: 0x000407BB File Offset: 0x0003E9BB
		public unsafe string RaisedAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x0023BF8C File Offset: 0x0023A18C
		// (set) Token: 0x06008777 RID: 34679 RVA: 0x000407DA File Offset: 0x0003E9DA
		public unsafe string RecoilAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x0023BFB4 File Offset: 0x0023A1B4
		// (set) Token: 0x06008779 RID: 34681 RVA: 0x000407F9 File Offset: 0x0003E9F9
		public unsafe bool _IsRaised_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField)) = value;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600877A RID: 34682 RVA: 0x0023BFDC File Offset: 0x0023A1DC
		// (set) Token: 0x0600877B RID: 34683 RVA: 0x00040814 File Offset: 0x0003EA14
		public unsafe bool isReloading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading)) = value;
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600877C RID: 34684 RVA: 0x0023C004 File Offset: 0x0023A204
		// (set) Token: 0x0600877D RID: 34685 RVA: 0x0004082F File Offset: 0x0003EA2F
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600877E RID: 34686 RVA: 0x0023C02C File Offset: 0x0023A22C
		// (set) Token: 0x0600877F RID: 34687 RVA: 0x0004084A File Offset: 0x0003EA4A
		public unsafe float timeRaised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised)) = value;
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x06008780 RID: 34688 RVA: 0x0023C054 File Offset: 0x0023A254
		// (set) Token: 0x06008781 RID: 34689 RVA: 0x00040865 File Offset: 0x0003EA65
		public unsafe float timeSinceLastShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06008782 RID: 34690 RVA: 0x0023C07C File Offset: 0x0023A27C
		// (set) Token: 0x06008783 RID: 34691 RVA: 0x00040880 File Offset: 0x0003EA80
		public unsafe int currentAmmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo)) = value;
			}
		}

		// Token: 0x04005C0A RID: 23562
		private static readonly IntPtr NativeFieldInfoPtr_RaycastLayers;

		// Token: 0x04005C0B RID: 23563
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005C0C RID: 23564
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTime;

		// Token: 0x04005C0D RID: 23565
		private static readonly IntPtr NativeFieldInfoPtr_MaxFireRate;

		// Token: 0x04005C0E RID: 23566
		private static readonly IntPtr NativeFieldInfoPtr_CanShootWhileMoving;

		// Token: 0x04005C0F RID: 23567
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x04005C10 RID: 23568
		private static readonly IntPtr NativeFieldInfoPtr_RaiseTime;

		// Token: 0x04005C11 RID: 23569
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005C12 RID: 23570
		private static readonly IntPtr NativeFieldInfoPtr_HitChange_MinRange;

		// Token: 0x04005C13 RID: 23571
		private static readonly IntPtr NativeFieldInfoPtr_HitChange_MaxRange;

		// Token: 0x04005C14 RID: 23572
		private static readonly IntPtr NativeFieldInfoPtr_MuzzlePoint;

		// Token: 0x04005C15 RID: 23573
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005C16 RID: 23574
		private static readonly IntPtr NativeFieldInfoPtr_LoweredAnimationTrigger;

		// Token: 0x04005C17 RID: 23575
		private static readonly IntPtr NativeFieldInfoPtr_RaisedAnimationTrigger;

		// Token: 0x04005C18 RID: 23576
		private static readonly IntPtr NativeFieldInfoPtr_RecoilAnimationTrigger;

		// Token: 0x04005C19 RID: 23577
		private static readonly IntPtr NativeFieldInfoPtr__IsRaised_k__BackingField;

		// Token: 0x04005C1A RID: 23578
		private static readonly IntPtr NativeFieldInfoPtr_isReloading;

		// Token: 0x04005C1B RID: 23579
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x04005C1C RID: 23580
		private static readonly IntPtr NativeFieldInfoPtr_timeRaised;

		// Token: 0x04005C1D RID: 23581
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04005C1E RID: 23582
		private static readonly IntPtr NativeFieldInfoPtr_currentAmmo;

		// Token: 0x04005C1F RID: 23583
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0;

		// Token: 0x04005C20 RID: 23584
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0;

		// Token: 0x04005C21 RID: 23585
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C22 RID: 23586
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005C23 RID: 23587
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005C24 RID: 23588
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0;

		// Token: 0x04005C25 RID: 23589
		private static readonly IntPtr NativeMethodInfoPtr_CanShoot_Public_Boolean_0;

		// Token: 0x04005C26 RID: 23590
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0;

		// Token: 0x04005C27 RID: 23591
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Private_IEnumerator_0;

		// Token: 0x04005C28 RID: 23592
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0;

		// Token: 0x04005C29 RID: 23593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF8 RID: 2808
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon+<Reload>d__30")]
		public sealed class _Reload_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D5DD RID: 54749 RVA: 0x0032F09C File Offset: 0x0032D29C
			// Note: this type is marked as 'beforefieldinit'.
			static _Reload_d__30()
			{
				Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<Reload>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr);
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>1__state");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>2__current");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>4__this");
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680198);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680199);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680200);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680201);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680202);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680203);
			}

			// Token: 0x0600D5DE RID: 54750 RVA: 0x0032F17C File Offset: 0x0032D37C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reload_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5DF RID: 54751 RVA: 0x0032F1C4 File Offset: 0x0032D3C4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E0 RID: 54752 RVA: 0x0032F1F8 File Offset: 0x0032D3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251365, XrefRangeEnd = 251370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700424A RID: 16970
			// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x0032F234 File Offset: 0x0032D434
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5E2 RID: 54754 RVA: 0x0032F274 File Offset: 0x0032D474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251370, XrefRangeEnd = 251375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700424B RID: 16971
			// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x0032F2A8 File Offset: 0x0032D4A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5E4 RID: 54756 RVA: 0x0006815B File Offset: 0x0006635B
			public _Reload_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004247 RID: 16967
			// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x0032F2E8 File Offset: 0x0032D4E8
			// (set) Token: 0x0600D5E6 RID: 54758 RVA: 0x00068164 File Offset: 0x00066364
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x0032F310 File Offset: 0x0032D510
			// (set) Token: 0x0600D5E8 RID: 54760 RVA: 0x0006817F File Offset: 0x0006637F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004249 RID: 16969
			// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x0032F340 File Offset: 0x0032D540
			// (set) Token: 0x0600D5EA RID: 54762 RVA: 0x0006819E File Offset: 0x0006639E
			public unsafe AvatarRangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FDA RID: 36826
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FDB RID: 36827
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FDC RID: 36828
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FDD RID: 36829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FDE RID: 36830
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FDF RID: 36831
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FE0 RID: 36832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FE1 RID: 36833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FE2 RID: 36834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
