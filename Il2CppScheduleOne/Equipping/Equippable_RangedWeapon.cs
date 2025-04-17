using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C3 RID: 1475
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x06008158 RID: 33112 RVA: 0x00227FCC File Offset: 0x002261CC
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_RangedWeapon()
		{
			Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_RangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr);
			Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "NPC_AIM_DETECTION_RANGE");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Aim>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Accuracy>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<TimeSinceFire>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsReloading>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocked>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocking>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MagazineSize");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimFOVReduction");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FOVChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireSound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "EmptySound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireCooldown");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireAnimTriggers");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AccuracyChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Range");
			Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "RayRadius");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MinSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MaxSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Damage");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ImpactForce");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CanReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "IncrementalReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Magazine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividalTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividualAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadTrash");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MustBeCocked");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "TracerSpeed");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onFire");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadIndividual");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadEnd");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onCockStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "weaponItem");
			Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "fovOverridden");
			Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "aimVelocity");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadRoutine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "shotQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSincePrimaryClick");
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679499);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679500);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679501);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679502);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679503);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679504);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679505);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679506);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679507);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679508);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679509);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679510);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679511);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679512);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679513);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679514);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679515);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679516);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679517);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679518);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679519);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679520);
			Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679521);
			Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679522);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679523);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679524);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679525);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679526);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679527);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679528);
			Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679529);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679530);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679531);
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x00228650 File Offset: 0x00226850
		// (set) Token: 0x0600815A RID: 33114 RVA: 0x0022868C File Offset: 0x0022688C
		public unsafe float Aim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x002286CC File Offset: 0x002268CC
		// (set) Token: 0x0600815C RID: 33116 RVA: 0x00228708 File Offset: 0x00226908
		public unsafe float Accuracy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600815D RID: 33117 RVA: 0x00228748 File Offset: 0x00226948
		// (set) Token: 0x0600815E RID: 33118 RVA: 0x00228784 File Offset: 0x00226984
		public unsafe float TimeSinceFire
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600815F RID: 33119 RVA: 0x002287C4 File Offset: 0x002269C4
		// (set) Token: 0x06008160 RID: 33120 RVA: 0x00228800 File Offset: 0x00226A00
		public unsafe bool IsReloading
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245046, RefRangeEnd = 245047, XrefRangeStart = 245046, XrefRangeEnd = 245046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x06008161 RID: 33121 RVA: 0x00228840 File Offset: 0x00226A40
		// (set) Token: 0x06008162 RID: 33122 RVA: 0x0022887C File Offset: 0x00226A7C
		public unsafe bool IsCocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x002288BC File Offset: 0x00226ABC
		// (set) Token: 0x06008164 RID: 33124 RVA: 0x002288F8 File Offset: 0x00226AF8
		public unsafe bool IsCocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06008165 RID: 33125 RVA: 0x00228938 File Offset: 0x00226B38
		public unsafe int Ammo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x00228974 File Offset: 0x00226B74
		public unsafe float aimFov
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245047, XrefRangeEnd = 245051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x002289B0 File Offset: 0x00226BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245074, RefRangeEnd = 245075, XrefRangeStart = 245051, XrefRangeEnd = 245074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x00228A00 File Offset: 0x00226C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245075, XrefRangeEnd = 245099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x00228A3C File Offset: 0x00226C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245099, XrefRangeEnd = 245114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x00228A78 File Offset: 0x00226C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245216, RefRangeEnd = 245217, XrefRangeStart = 245114, XrefRangeEnd = 245216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00228AAC File Offset: 0x00226CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245217, XrefRangeEnd = 245225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00228AE0 File Offset: 0x00226CE0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00228B1C File Offset: 0x00226D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245362, RefRangeEnd = 245363, XrefRangeStart = 245225, XrefRangeEnd = 245362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00228B58 File Offset: 0x00226D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245363, XrefRangeEnd = 245376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x00228B94 File Offset: 0x00226D94
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00228BD0 File Offset: 0x00226DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245376, RefRangeEnd = 245377, XrefRangeStart = 245376, XrefRangeEnd = 245376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReloadReady(bool ignoreTiming)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreTiming;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x00228C1C File Offset: 0x00226E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245377, XrefRangeEnd = 245407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMagazine(out StorableItemInstance mag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			mag = ((intPtr4 == 0) ? null : new StorableItemInstance(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x00228C88 File Offset: 0x00226E88
		[CallerCount(0)]
		public unsafe bool CanFire(bool checkAmmo = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAmmo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x00228CD4 File Offset: 0x00226ED4
		[CallerCount(0)]
		public unsafe bool CanCock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00228D10 File Offset: 0x00226F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245407, XrefRangeEnd = 245419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x00228D44 File Offset: 0x00226F44
		[CallerCount(0)]
		public unsafe float GetSpread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00228D80 File Offset: 0x00226F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245419, XrefRangeEnd = 245476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAimingAtNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x00228DB4 File Offset: 0x00226FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245476, XrefRangeEnd = 245489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_RangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00228DF0 File Offset: 0x00226FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245489, XrefRangeEnd = 245494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00228E30 File Offset: 0x00227030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245494, XrefRangeEnd = 245499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x0003D6D3 File Offset: 0x0003B8D3
		public Equippable_RangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x00228E70 File Offset: 0x00227070
		// (set) Token: 0x0600817C RID: 33148 RVA: 0x0003D6DC File Offset: 0x0003B8DC
		public unsafe static float NPC_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600817D RID: 33149 RVA: 0x00228E8C File Offset: 0x0022708C
		// (set) Token: 0x0600817E RID: 33150 RVA: 0x0003D6EA File Offset: 0x0003B8EA
		public unsafe float _Aim_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField)) = value;
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600817F RID: 33151 RVA: 0x00228EB4 File Offset: 0x002270B4
		// (set) Token: 0x06008180 RID: 33152 RVA: 0x0003D705 File Offset: 0x0003B905
		public unsafe float _Accuracy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField)) = value;
			}
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06008181 RID: 33153 RVA: 0x00228EDC File Offset: 0x002270DC
		// (set) Token: 0x06008182 RID: 33154 RVA: 0x0003D720 File Offset: 0x0003B920
		public unsafe float _TimeSinceFire_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField)) = value;
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x00228F04 File Offset: 0x00227104
		// (set) Token: 0x06008184 RID: 33156 RVA: 0x0003D73B File Offset: 0x0003B93B
		public unsafe bool _IsReloading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField)) = value;
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x00228F2C File Offset: 0x0022712C
		// (set) Token: 0x06008186 RID: 33158 RVA: 0x0003D756 File Offset: 0x0003B956
		public unsafe bool _IsCocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06008187 RID: 33159 RVA: 0x00228F54 File Offset: 0x00227154
		// (set) Token: 0x06008188 RID: 33160 RVA: 0x0003D771 File Offset: 0x0003B971
		public unsafe bool _IsCocking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x00228F7C File Offset: 0x0022717C
		// (set) Token: 0x0600818A RID: 33162 RVA: 0x0003D78C File Offset: 0x0003B98C
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600818B RID: 33163 RVA: 0x00228FA4 File Offset: 0x002271A4
		// (set) Token: 0x0600818C RID: 33164 RVA: 0x0003D7A7 File Offset: 0x0003B9A7
		public unsafe float AimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration)) = value;
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600818D RID: 33165 RVA: 0x00228FCC File Offset: 0x002271CC
		// (set) Token: 0x0600818E RID: 33166 RVA: 0x0003D7C2 File Offset: 0x0003B9C2
		public unsafe float AimFOVReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction)) = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600818F RID: 33167 RVA: 0x00228FF4 File Offset: 0x002271F4
		// (set) Token: 0x06008190 RID: 33168 RVA: 0x0003D7DD File Offset: 0x0003B9DD
		public unsafe float FOVChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration)) = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x06008191 RID: 33169 RVA: 0x0022901C File Offset: 0x0022721C
		// (set) Token: 0x06008192 RID: 33170 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06008193 RID: 33171 RVA: 0x0022904C File Offset: 0x0022724C
		// (set) Token: 0x06008194 RID: 33172 RVA: 0x0003D817 File Offset: 0x0003BA17
		public unsafe AudioSourceController EmptySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06008195 RID: 33173 RVA: 0x0022907C File Offset: 0x0022727C
		// (set) Token: 0x06008196 RID: 33174 RVA: 0x0003D836 File Offset: 0x0003BA36
		public unsafe float FireCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown)) = value;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06008197 RID: 33175 RVA: 0x002290A4 File Offset: 0x002272A4
		// (set) Token: 0x06008198 RID: 33176 RVA: 0x0003D851 File Offset: 0x0003BA51
		public unsafe Il2CppStringArray FireAnimTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x002290D4 File Offset: 0x002272D4
		// (set) Token: 0x0600819A RID: 33178 RVA: 0x0003D870 File Offset: 0x0003BA70
		public unsafe float AccuracyChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration)) = value;
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x002290FC File Offset: 0x002272FC
		// (set) Token: 0x0600819C RID: 33180 RVA: 0x0003D88B File Offset: 0x0003BA8B
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600819D RID: 33181 RVA: 0x00229124 File Offset: 0x00227324
		// (set) Token: 0x0600819E RID: 33182 RVA: 0x0003D8A6 File Offset: 0x0003BAA6
		public unsafe float RayRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius)) = value;
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600819F RID: 33183 RVA: 0x0022914C File Offset: 0x0022734C
		// (set) Token: 0x060081A0 RID: 33184 RVA: 0x0003D8C1 File Offset: 0x0003BAC1
		public unsafe float MinSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread)) = value;
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x00229174 File Offset: 0x00227374
		// (set) Token: 0x060081A2 RID: 33186 RVA: 0x0003D8DC File Offset: 0x0003BADC
		public unsafe float MaxSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread)) = value;
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x060081A3 RID: 33187 RVA: 0x0022919C File Offset: 0x0022739C
		// (set) Token: 0x060081A4 RID: 33188 RVA: 0x0003D8F7 File Offset: 0x0003BAF7
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x060081A5 RID: 33189 RVA: 0x002291C4 File Offset: 0x002273C4
		// (set) Token: 0x060081A6 RID: 33190 RVA: 0x0003D912 File Offset: 0x0003BB12
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x060081A7 RID: 33191 RVA: 0x002291EC File Offset: 0x002273EC
		// (set) Token: 0x060081A8 RID: 33192 RVA: 0x0003D92D File Offset: 0x0003BB2D
		public unsafe bool CanReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload)) = value;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x060081A9 RID: 33193 RVA: 0x00229214 File Offset: 0x00227414
		// (set) Token: 0x060081AA RID: 33194 RVA: 0x0003D948 File Offset: 0x0003BB48
		public unsafe bool IncrementalReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload)) = value;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x0022923C File Offset: 0x0022743C
		// (set) Token: 0x060081AC RID: 33196 RVA: 0x0003D963 File Offset: 0x0003BB63
		public unsafe StorableItemDefinition Magazine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x060081AD RID: 33197 RVA: 0x0022926C File Offset: 0x0022746C
		// (set) Token: 0x060081AE RID: 33198 RVA: 0x0003D982 File Offset: 0x0003BB82
		public unsafe float ReloadStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime)) = value;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x060081AF RID: 33199 RVA: 0x00229294 File Offset: 0x00227494
		// (set) Token: 0x060081B0 RID: 33200 RVA: 0x0003D99D File Offset: 0x0003BB9D
		public unsafe float ReloadIndividalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime)) = value;
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x060081B1 RID: 33201 RVA: 0x002292BC File Offset: 0x002274BC
		// (set) Token: 0x060081B2 RID: 33202 RVA: 0x0003D9B8 File Offset: 0x0003BBB8
		public unsafe float ReloadEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime)) = value;
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x002292E4 File Offset: 0x002274E4
		// (set) Token: 0x060081B4 RID: 33204 RVA: 0x0003D9D3 File Offset: 0x0003BBD3
		public unsafe string ReloadStartAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x060081B5 RID: 33205 RVA: 0x0022930C File Offset: 0x0022750C
		// (set) Token: 0x060081B6 RID: 33206 RVA: 0x0003D9F2 File Offset: 0x0003BBF2
		public unsafe string ReloadIndividualAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x00229334 File Offset: 0x00227534
		// (set) Token: 0x060081B8 RID: 33208 RVA: 0x0003DA11 File Offset: 0x0003BC11
		public unsafe string ReloadEndAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x060081B9 RID: 33209 RVA: 0x0022935C File Offset: 0x0022755C
		// (set) Token: 0x060081BA RID: 33210 RVA: 0x0003DA30 File Offset: 0x0003BC30
		public unsafe TrashItem ReloadTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x060081BB RID: 33211 RVA: 0x0022938C File Offset: 0x0022758C
		// (set) Token: 0x060081BC RID: 33212 RVA: 0x0003DA4F File Offset: 0x0003BC4F
		public unsafe bool MustBeCocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked)) = value;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x060081BD RID: 33213 RVA: 0x002293B4 File Offset: 0x002275B4
		// (set) Token: 0x060081BE RID: 33214 RVA: 0x0003DA6A File Offset: 0x0003BC6A
		public unsafe float CockTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime)) = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x060081BF RID: 33215 RVA: 0x002293DC File Offset: 0x002275DC
		// (set) Token: 0x060081C0 RID: 33216 RVA: 0x0003DA85 File Offset: 0x0003BC85
		public unsafe string CockAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x00229404 File Offset: 0x00227604
		// (set) Token: 0x060081C2 RID: 33218 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		public unsafe float TracerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed)) = value;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x060081C3 RID: 33219 RVA: 0x0022942C File Offset: 0x0022762C
		// (set) Token: 0x060081C4 RID: 33220 RVA: 0x0003DABF File Offset: 0x0003BCBF
		public unsafe UnityEvent onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x0022945C File Offset: 0x0022765C
		// (set) Token: 0x060081C6 RID: 33222 RVA: 0x0003DADE File Offset: 0x0003BCDE
		public unsafe UnityEvent onReloadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x060081C7 RID: 33223 RVA: 0x0022948C File Offset: 0x0022768C
		// (set) Token: 0x060081C8 RID: 33224 RVA: 0x0003DAFD File Offset: 0x0003BCFD
		public unsafe UnityEvent onReloadIndividual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x002294BC File Offset: 0x002276BC
		// (set) Token: 0x060081CA RID: 33226 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		public unsafe UnityEvent onReloadEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x060081CB RID: 33227 RVA: 0x002294EC File Offset: 0x002276EC
		// (set) Token: 0x060081CC RID: 33228 RVA: 0x0003DB3B File Offset: 0x0003BD3B
		public unsafe UnityEvent onCockStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x0022951C File Offset: 0x0022771C
		// (set) Token: 0x060081CE RID: 33230 RVA: 0x0003DB5A File Offset: 0x0003BD5A
		public unsafe IntegerItemInstance weaponItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x060081CF RID: 33231 RVA: 0x0022954C File Offset: 0x0022774C
		// (set) Token: 0x060081D0 RID: 33232 RVA: 0x0003DB79 File Offset: 0x0003BD79
		public unsafe bool fovOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden)) = value;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x060081D1 RID: 33233 RVA: 0x00229574 File Offset: 0x00227774
		// (set) Token: 0x060081D2 RID: 33234 RVA: 0x0003DB94 File Offset: 0x0003BD94
		public unsafe float aimVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity)) = value;
			}
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x0022959C File Offset: 0x0022779C
		// (set) Token: 0x060081D4 RID: 33236 RVA: 0x0003DBAF File Offset: 0x0003BDAF
		public unsafe Coroutine reloadRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x002295CC File Offset: 0x002277CC
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x0003DBCE File Offset: 0x0003BDCE
		public unsafe bool shotQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued)) = value;
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x002295F4 File Offset: 0x002277F4
		// (set) Token: 0x060081D8 RID: 33240 RVA: 0x0003DBE9 File Offset: 0x0003BDE9
		public unsafe bool reloadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued)) = value;
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x0022961C File Offset: 0x0022781C
		// (set) Token: 0x060081DA RID: 33242 RVA: 0x0003DC04 File Offset: 0x0003BE04
		public unsafe float timeSincePrimaryClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick)) = value;
			}
		}

		// Token: 0x04005809 RID: 22537
		private static readonly IntPtr NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE;

		// Token: 0x0400580A RID: 22538
		private static readonly IntPtr NativeFieldInfoPtr__Aim_k__BackingField;

		// Token: 0x0400580B RID: 22539
		private static readonly IntPtr NativeFieldInfoPtr__Accuracy_k__BackingField;

		// Token: 0x0400580C RID: 22540
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceFire_k__BackingField;

		// Token: 0x0400580D RID: 22541
		private static readonly IntPtr NativeFieldInfoPtr__IsReloading_k__BackingField;

		// Token: 0x0400580E RID: 22542
		private static readonly IntPtr NativeFieldInfoPtr__IsCocked_k__BackingField;

		// Token: 0x0400580F RID: 22543
		private static readonly IntPtr NativeFieldInfoPtr__IsCocking_k__BackingField;

		// Token: 0x04005810 RID: 22544
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005811 RID: 22545
		private static readonly IntPtr NativeFieldInfoPtr_AimDuration;

		// Token: 0x04005812 RID: 22546
		private static readonly IntPtr NativeFieldInfoPtr_AimFOVReduction;

		// Token: 0x04005813 RID: 22547
		private static readonly IntPtr NativeFieldInfoPtr_FOVChangeDuration;

		// Token: 0x04005814 RID: 22548
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005815 RID: 22549
		private static readonly IntPtr NativeFieldInfoPtr_EmptySound;

		// Token: 0x04005816 RID: 22550
		private static readonly IntPtr NativeFieldInfoPtr_FireCooldown;

		// Token: 0x04005817 RID: 22551
		private static readonly IntPtr NativeFieldInfoPtr_FireAnimTriggers;

		// Token: 0x04005818 RID: 22552
		private static readonly IntPtr NativeFieldInfoPtr_AccuracyChangeDuration;

		// Token: 0x04005819 RID: 22553
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x0400581A RID: 22554
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x0400581B RID: 22555
		private static readonly IntPtr NativeFieldInfoPtr_MinSpread;

		// Token: 0x0400581C RID: 22556
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpread;

		// Token: 0x0400581D RID: 22557
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x0400581E RID: 22558
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x0400581F RID: 22559
		private static readonly IntPtr NativeFieldInfoPtr_CanReload;

		// Token: 0x04005820 RID: 22560
		private static readonly IntPtr NativeFieldInfoPtr_IncrementalReload;

		// Token: 0x04005821 RID: 22561
		private static readonly IntPtr NativeFieldInfoPtr_Magazine;

		// Token: 0x04005822 RID: 22562
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartTime;

		// Token: 0x04005823 RID: 22563
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividalTime;

		// Token: 0x04005824 RID: 22564
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndTime;

		// Token: 0x04005825 RID: 22565
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartAnimTrigger;

		// Token: 0x04005826 RID: 22566
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividualAnimTrigger;

		// Token: 0x04005827 RID: 22567
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndAnimTrigger;

		// Token: 0x04005828 RID: 22568
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTrash;

		// Token: 0x04005829 RID: 22569
		private static readonly IntPtr NativeFieldInfoPtr_MustBeCocked;

		// Token: 0x0400582A RID: 22570
		private static readonly IntPtr NativeFieldInfoPtr_CockTime;

		// Token: 0x0400582B RID: 22571
		private static readonly IntPtr NativeFieldInfoPtr_CockAnimTrigger;

		// Token: 0x0400582C RID: 22572
		private static readonly IntPtr NativeFieldInfoPtr_TracerSpeed;

		// Token: 0x0400582D RID: 22573
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x0400582E RID: 22574
		private static readonly IntPtr NativeFieldInfoPtr_onReloadStart;

		// Token: 0x0400582F RID: 22575
		private static readonly IntPtr NativeFieldInfoPtr_onReloadIndividual;

		// Token: 0x04005830 RID: 22576
		private static readonly IntPtr NativeFieldInfoPtr_onReloadEnd;

		// Token: 0x04005831 RID: 22577
		private static readonly IntPtr NativeFieldInfoPtr_onCockStart;

		// Token: 0x04005832 RID: 22578
		private static readonly IntPtr NativeFieldInfoPtr_weaponItem;

		// Token: 0x04005833 RID: 22579
		private static readonly IntPtr NativeFieldInfoPtr_fovOverridden;

		// Token: 0x04005834 RID: 22580
		private static readonly IntPtr NativeFieldInfoPtr_aimVelocity;

		// Token: 0x04005835 RID: 22581
		private static readonly IntPtr NativeFieldInfoPtr_reloadRoutine;

		// Token: 0x04005836 RID: 22582
		private static readonly IntPtr NativeFieldInfoPtr_shotQueued;

		// Token: 0x04005837 RID: 22583
		private static readonly IntPtr NativeFieldInfoPtr_reloadQueued;

		// Token: 0x04005838 RID: 22584
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePrimaryClick;

		// Token: 0x04005839 RID: 22585
		private static readonly IntPtr NativeMethodInfoPtr_get_Aim_Public_get_Single_0;

		// Token: 0x0400583A RID: 22586
		private static readonly IntPtr NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0;

		// Token: 0x0400583B RID: 22587
		private static readonly IntPtr NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0;

		// Token: 0x0400583C RID: 22588
		private static readonly IntPtr NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0;

		// Token: 0x0400583D RID: 22589
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0;

		// Token: 0x0400583E RID: 22590
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0;

		// Token: 0x0400583F RID: 22591
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0;

		// Token: 0x04005840 RID: 22592
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0;

		// Token: 0x04005841 RID: 22593
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0;

		// Token: 0x04005842 RID: 22594
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0;

		// Token: 0x04005843 RID: 22595
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0;

		// Token: 0x04005844 RID: 22596
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0;

		// Token: 0x04005845 RID: 22597
		private static readonly IntPtr NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0;

		// Token: 0x04005846 RID: 22598
		private static readonly IntPtr NativeMethodInfoPtr_get_aimFov_Private_get_Single_0;

		// Token: 0x04005847 RID: 22599
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005848 RID: 22600
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005849 RID: 22601
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400584A RID: 22602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400584B RID: 22603
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnim_Private_Void_0;

		// Token: 0x0400584C RID: 22604
		private static readonly IntPtr NativeMethodInfoPtr_CanAim_Private_Boolean_0;

		// Token: 0x0400584D RID: 22605
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0;

		// Token: 0x0400584E RID: 22606
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0;

		// Token: 0x0400584F RID: 22607
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0;

		// Token: 0x04005850 RID: 22608
		private static readonly IntPtr NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0;

		// Token: 0x04005851 RID: 22609
		private static readonly IntPtr NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0;

		// Token: 0x04005852 RID: 22610
		private static readonly IntPtr NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0;

		// Token: 0x04005853 RID: 22611
		private static readonly IntPtr NativeMethodInfoPtr_CanCock_Private_Boolean_0;

		// Token: 0x04005854 RID: 22612
		private static readonly IntPtr NativeMethodInfoPtr_Cock_Private_Void_0;

		// Token: 0x04005855 RID: 22613
		private static readonly IntPtr NativeMethodInfoPtr_GetSpread_Private_Single_0;

		// Token: 0x04005856 RID: 22614
		private static readonly IntPtr NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0;

		// Token: 0x04005857 RID: 22615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005858 RID: 22616
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005859 RID: 22617
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000AE0 RID: 2784
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Cock>g__CockRoutine|83_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D504 RID: 54532 RVA: 0x0032CA58 File Offset: 0x0032AC58
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Cock>g__CockRoutine|83_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679532);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679533);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679534);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679535);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679536);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679537);
			}

			// Token: 0x0600D505 RID: 54533 RVA: 0x0032CB38 File Offset: 0x0032AD38
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D506 RID: 54534 RVA: 0x0032CB80 File Offset: 0x0032AD80
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D507 RID: 54535 RVA: 0x0032CBB4 File Offset: 0x0032ADB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245007, XrefRangeEnd = 245018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004203 RID: 16899
			// (get) Token: 0x0600D508 RID: 54536 RVA: 0x0032CBF0 File Offset: 0x0032ADF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x0032CC30 File Offset: 0x0032AE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245018, XrefRangeEnd = 245023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004204 RID: 16900
			// (get) Token: 0x0600D50A RID: 54538 RVA: 0x0032CC64 File Offset: 0x0032AE64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D50B RID: 54539 RVA: 0x00067A73 File Offset: 0x00065C73
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004200 RID: 16896
			// (get) Token: 0x0600D50C RID: 54540 RVA: 0x0032CCA4 File Offset: 0x0032AEA4
			// (set) Token: 0x0600D50D RID: 54541 RVA: 0x00067A7C File Offset: 0x00065C7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004201 RID: 16897
			// (get) Token: 0x0600D50E RID: 54542 RVA: 0x0032CCCC File Offset: 0x0032AECC
			// (set) Token: 0x0600D50F RID: 54543 RVA: 0x00067A97 File Offset: 0x00065C97
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004202 RID: 16898
			// (get) Token: 0x0600D510 RID: 54544 RVA: 0x0032CCFC File Offset: 0x0032AEFC
			// (set) Token: 0x0600D511 RID: 54545 RVA: 0x00067AB6 File Offset: 0x00065CB6
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F4D RID: 36685
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F4E RID: 36686
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F4F RID: 36687
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F50 RID: 36688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F51 RID: 36689
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F52 RID: 36690
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F53 RID: 36691
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F54 RID: 36692
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F55 RID: 36693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE1 RID: 2785
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Reload>g__ReloadRoutine|77_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D512 RID: 54546 RVA: 0x0032CD2C File Offset: 0x0032AF2C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Reload>g__ReloadRoutine|77_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<mag>5__2");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679538);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679539);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679540);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679541);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679542);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679543);
			}

			// Token: 0x0600D513 RID: 54547 RVA: 0x0032CE20 File Offset: 0x0032B020
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D514 RID: 54548 RVA: 0x0032CE68 File Offset: 0x0032B068
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D515 RID: 54549 RVA: 0x0032CE9C File Offset: 0x0032B09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245023, XrefRangeEnd = 245041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004209 RID: 16905
			// (get) Token: 0x0600D516 RID: 54550 RVA: 0x0032CED8 File Offset: 0x0032B0D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D517 RID: 54551 RVA: 0x0032CF18 File Offset: 0x0032B118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245041, XrefRangeEnd = 245046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700420A RID: 16906
			// (get) Token: 0x0600D518 RID: 54552 RVA: 0x0032CF4C File Offset: 0x0032B14C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D519 RID: 54553 RVA: 0x00067AD5 File Offset: 0x00065CD5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004205 RID: 16901
			// (get) Token: 0x0600D51A RID: 54554 RVA: 0x0032CF8C File Offset: 0x0032B18C
			// (set) Token: 0x0600D51B RID: 54555 RVA: 0x00067ADE File Offset: 0x00065CDE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004206 RID: 16902
			// (get) Token: 0x0600D51C RID: 54556 RVA: 0x0032CFB4 File Offset: 0x0032B1B4
			// (set) Token: 0x0600D51D RID: 54557 RVA: 0x00067AF9 File Offset: 0x00065CF9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004207 RID: 16903
			// (get) Token: 0x0600D51E RID: 54558 RVA: 0x0032CFE4 File Offset: 0x0032B1E4
			// (set) Token: 0x0600D51F RID: 54559 RVA: 0x00067B18 File Offset: 0x00065D18
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004208 RID: 16904
			// (get) Token: 0x0600D520 RID: 54560 RVA: 0x0032D014 File Offset: 0x0032B214
			// (set) Token: 0x0600D521 RID: 54561 RVA: 0x00067B37 File Offset: 0x00065D37
			public unsafe StorableItemInstance _mag_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F56 RID: 36694
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F57 RID: 36695
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F58 RID: 36696
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F59 RID: 36697
			private static readonly IntPtr NativeFieldInfoPtr__mag_5__2;

			// Token: 0x04008F5A RID: 36698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F5B RID: 36699
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F5C RID: 36700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F5D RID: 36701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F5E RID: 36702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F5F RID: 36703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE2 RID: 2786
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D522 RID: 54562 RVA: 0x0032D044 File Offset: 0x0032B244
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr);
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9");
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9__76_0");
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679545);
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679546);
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x0032D0C0 File Offset: 0x0032B2C0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x0032D0FC File Offset: 0x0032B2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Fire_b__76_0(RaycastHit a, RaycastHit b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D525 RID: 54565 RVA: 0x00067B56 File Offset: 0x00065D56
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700420B RID: 16907
			// (get) Token: 0x0600D526 RID: 54566 RVA: 0x0032D154 File Offset: 0x0032B354
			// (set) Token: 0x0600D527 RID: 54567 RVA: 0x00067B5F File Offset: 0x00065D5F
			public unsafe static Equippable_RangedWeapon.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420C RID: 16908
			// (get) Token: 0x0600D528 RID: 54568 RVA: 0x0032D17C File Offset: 0x0032B37C
			// (set) Token: 0x0600D529 RID: 54569 RVA: 0x00067B71 File Offset: 0x00065D71
			public unsafe static Comparison<RaycastHit> __9__76_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F60 RID: 36704
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F61 RID: 36705
			private static readonly IntPtr NativeFieldInfoPtr___9__76_0;

			// Token: 0x04008F62 RID: 36706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F63 RID: 36707
			private static readonly IntPtr NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}
	}
}
