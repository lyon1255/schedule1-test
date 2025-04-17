using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C1 RID: 1473
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x0600810A RID: 33034 RVA: 0x00227250 File Offset: 0x00225450
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_MeleeWeapon()
		{
			Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_MeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr);
			Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<IsAttacking>k__BackingField");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactType");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "Range");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "HitRadius");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxLoadTime");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSoundPitch");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "SwingAnimationTrigger");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "load");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "remainingCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "hitRoutine");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "loadQueued");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "clickReleased");
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679471);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679472);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679473);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679474);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679475);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679476);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679477);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679478);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679479);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679480);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679481);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679482);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679483);
			Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679484);
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x00227578 File Offset: 0x00225778
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600810C RID: 33036 RVA: 0x002275B4 File Offset: 0x002257B4
		// (set) Token: 0x0600810D RID: 33037 RVA: 0x002275F0 File Offset: 0x002257F0
		public unsafe bool IsAttacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00227630 File Offset: 0x00225830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244749, XrefRangeEnd = 244757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x0022766C File Offset: 0x0022586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244757, XrefRangeEnd = 244758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x002276BC File Offset: 0x002258BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244758, XrefRangeEnd = 244767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x002276F8 File Offset: 0x002258F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244767, XrefRangeEnd = 244769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x0022772C File Offset: 0x0022592C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244777, RefRangeEnd = 244778, XrefRangeStart = 244769, XrefRangeEnd = 244777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00227760 File Offset: 0x00225960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244778, XrefRangeEnd = 244782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x0022779C File Offset: 0x0022599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244782, XrefRangeEnd = 244801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x002277D0 File Offset: 0x002259D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244801, XrefRangeEnd = 244848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x00227804 File Offset: 0x00225A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244863, RefRangeEnd = 244864, XrefRangeStart = 244848, XrefRangeEnd = 244863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00227844 File Offset: 0x00225A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244864, XrefRangeEnd = 244939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00227884 File Offset: 0x00225A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244939, XrefRangeEnd = 244940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_MeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		public Equippable_MeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x002278C0 File Offset: 0x00225AC0
		// (set) Token: 0x0600811B RID: 33051 RVA: 0x0003D3D9 File Offset: 0x0003B5D9
		public unsafe bool _IsAttacking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField)) = value;
			}
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600811C RID: 33052 RVA: 0x002278E8 File Offset: 0x00225AE8
		// (set) Token: 0x0600811D RID: 33053 RVA: 0x0003D3F4 File Offset: 0x0003B5F4
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600811E RID: 33054 RVA: 0x00227910 File Offset: 0x00225B10
		// (set) Token: 0x0600811F RID: 33055 RVA: 0x0003D40F File Offset: 0x0003B60F
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x00227938 File Offset: 0x00225B38
		// (set) Token: 0x06008121 RID: 33057 RVA: 0x0003D42A File Offset: 0x0003B62A
		public unsafe float HitRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius)) = value;
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x00227960 File Offset: 0x00225B60
		// (set) Token: 0x06008123 RID: 33059 RVA: 0x0003D445 File Offset: 0x0003B645
		public unsafe float MaxLoadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime)) = value;
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06008124 RID: 33060 RVA: 0x00227988 File Offset: 0x00225B88
		// (set) Token: 0x06008125 RID: 33061 RVA: 0x0003D460 File Offset: 0x0003B660
		public unsafe float MinCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown)) = value;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06008126 RID: 33062 RVA: 0x002279B0 File Offset: 0x00225BB0
		// (set) Token: 0x06008127 RID: 33063 RVA: 0x0003D47B File Offset: 0x0003B67B
		public unsafe float MaxCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown)) = value;
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06008128 RID: 33064 RVA: 0x002279D8 File Offset: 0x00225BD8
		// (set) Token: 0x06008129 RID: 33065 RVA: 0x0003D496 File Offset: 0x0003B696
		public unsafe float MinHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay)) = value;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600812A RID: 33066 RVA: 0x00227A00 File Offset: 0x00225C00
		// (set) Token: 0x0600812B RID: 33067 RVA: 0x0003D4B1 File Offset: 0x0003B6B1
		public unsafe float MaxHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay)) = value;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600812C RID: 33068 RVA: 0x00227A28 File Offset: 0x00225C28
		// (set) Token: 0x0600812D RID: 33069 RVA: 0x0003D4CC File Offset: 0x0003B6CC
		public unsafe float MinDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage)) = value;
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600812E RID: 33070 RVA: 0x00227A50 File Offset: 0x00225C50
		// (set) Token: 0x0600812F RID: 33071 RVA: 0x0003D4E7 File Offset: 0x0003B6E7
		public unsafe float MaxDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage)) = value;
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x06008130 RID: 33072 RVA: 0x00227A78 File Offset: 0x00225C78
		// (set) Token: 0x06008131 RID: 33073 RVA: 0x0003D502 File Offset: 0x0003B702
		public unsafe float MinForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce)) = value;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06008132 RID: 33074 RVA: 0x00227AA0 File Offset: 0x00225CA0
		// (set) Token: 0x06008133 RID: 33075 RVA: 0x0003D51D File Offset: 0x0003B71D
		public unsafe float MaxForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce)) = value;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06008134 RID: 33076 RVA: 0x00227AC8 File Offset: 0x00225CC8
		// (set) Token: 0x06008135 RID: 33077 RVA: 0x0003D538 File Offset: 0x0003B738
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x00227AF0 File Offset: 0x00225CF0
		// (set) Token: 0x06008137 RID: 33079 RVA: 0x0003D553 File Offset: 0x0003B753
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06008138 RID: 33080 RVA: 0x00227B18 File Offset: 0x00225D18
		// (set) Token: 0x06008139 RID: 33081 RVA: 0x0003D56E File Offset: 0x0003B76E
		public unsafe AudioSourceController WhooshSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600813A RID: 33082 RVA: 0x00227B48 File Offset: 0x00225D48
		// (set) Token: 0x0600813B RID: 33083 RVA: 0x0003D58D File Offset: 0x0003B78D
		public unsafe float WhooshSoundPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch)) = value;
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x00227B70 File Offset: 0x00225D70
		// (set) Token: 0x0600813D RID: 33085 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600813E RID: 33086 RVA: 0x00227BA0 File Offset: 0x00225DA0
		// (set) Token: 0x0600813F RID: 33087 RVA: 0x0003D5C7 File Offset: 0x0003B7C7
		public unsafe string SwingAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x00227BC8 File Offset: 0x00225DC8
		// (set) Token: 0x06008141 RID: 33089 RVA: 0x0003D5E6 File Offset: 0x0003B7E6
		public unsafe float load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load)) = value;
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06008142 RID: 33090 RVA: 0x00227BF0 File Offset: 0x00225DF0
		// (set) Token: 0x06008143 RID: 33091 RVA: 0x0003D601 File Offset: 0x0003B801
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x00227C18 File Offset: 0x00225E18
		// (set) Token: 0x06008145 RID: 33093 RVA: 0x0003D61C File Offset: 0x0003B81C
		public unsafe Coroutine hitRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x00227C48 File Offset: 0x00225E48
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x0003D63B File Offset: 0x0003B83B
		public unsafe bool loadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued)) = value;
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x00227C70 File Offset: 0x00225E70
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x0003D656 File Offset: 0x0003B856
		public unsafe bool clickReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased)) = value;
			}
		}

		// Token: 0x040057DA RID: 22490
		private static readonly IntPtr NativeFieldInfoPtr__IsAttacking_k__BackingField;

		// Token: 0x040057DB RID: 22491
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x040057DC RID: 22492
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x040057DD RID: 22493
		private static readonly IntPtr NativeFieldInfoPtr_HitRadius;

		// Token: 0x040057DE RID: 22494
		private static readonly IntPtr NativeFieldInfoPtr_MaxLoadTime;

		// Token: 0x040057DF RID: 22495
		private static readonly IntPtr NativeFieldInfoPtr_MinCooldown;

		// Token: 0x040057E0 RID: 22496
		private static readonly IntPtr NativeFieldInfoPtr_MaxCooldown;

		// Token: 0x040057E1 RID: 22497
		private static readonly IntPtr NativeFieldInfoPtr_MinHitDelay;

		// Token: 0x040057E2 RID: 22498
		private static readonly IntPtr NativeFieldInfoPtr_MaxHitDelay;

		// Token: 0x040057E3 RID: 22499
		private static readonly IntPtr NativeFieldInfoPtr_MinDamage;

		// Token: 0x040057E4 RID: 22500
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x040057E5 RID: 22501
		private static readonly IntPtr NativeFieldInfoPtr_MinForce;

		// Token: 0x040057E6 RID: 22502
		private static readonly IntPtr NativeFieldInfoPtr_MaxForce;

		// Token: 0x040057E7 RID: 22503
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x040057E8 RID: 22504
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x040057E9 RID: 22505
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSound;

		// Token: 0x040057EA RID: 22506
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSoundPitch;

		// Token: 0x040057EB RID: 22507
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x040057EC RID: 22508
		private static readonly IntPtr NativeFieldInfoPtr_SwingAnimationTrigger;

		// Token: 0x040057ED RID: 22509
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x040057EE RID: 22510
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x040057EF RID: 22511
		private static readonly IntPtr NativeFieldInfoPtr_hitRoutine;

		// Token: 0x040057F0 RID: 22512
		private static readonly IntPtr NativeFieldInfoPtr_loadQueued;

		// Token: 0x040057F1 RID: 22513
		private static readonly IntPtr NativeFieldInfoPtr_clickReleased;

		// Token: 0x040057F2 RID: 22514
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x040057F3 RID: 22515
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0;

		// Token: 0x040057F4 RID: 22516
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0;

		// Token: 0x040057F5 RID: 22517
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057F6 RID: 22518
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057F7 RID: 22519
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057F8 RID: 22520
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x040057F9 RID: 22521
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040057FA RID: 22522
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x040057FB RID: 22523
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x040057FC RID: 22524
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x040057FD RID: 22525
		private static readonly IntPtr NativeMethodInfoPtr_Hit_Private_Void_Single_0;

		// Token: 0x040057FE RID: 22526
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x040057FF RID: 22527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADF RID: 2783
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4FC RID: 54524 RVA: 0x0032C908 File Offset: 0x0032AB08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "power");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679485);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679486);
			}

			// Token: 0x0600D4FD RID: 54525 RVA: 0x0032C984 File Offset: 0x0032AB84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4FE RID: 54526 RVA: 0x0032C9C0 File Offset: 0x0032ABC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244744, XrefRangeEnd = 244749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x00067A30 File Offset: 0x00065C30
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FE RID: 16894
			// (get) Token: 0x0600D500 RID: 54528 RVA: 0x0032CA00 File Offset: 0x0032AC00
			// (set) Token: 0x0600D501 RID: 54529 RVA: 0x00067A39 File Offset: 0x00065C39
			public unsafe Equippable_MeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FF RID: 16895
			// (get) Token: 0x0600D502 RID: 54530 RVA: 0x0032CA30 File Offset: 0x0032AC30
			// (set) Token: 0x0600D503 RID: 54531 RVA: 0x00067A58 File Offset: 0x00065C58
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x04008F49 RID: 36681
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F4A RID: 36682
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04008F4B RID: 36683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F4C RID: 36684
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C64 RID: 3172
			[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0+<<Hit>g__HitRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E44D RID: 58445 RVA: 0x003589BC File Offset: 0x00356BBC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<<Hit>g__HitRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679487);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679488);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679489);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679490);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679491);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679492);
				}

				// Token: 0x0600E44E RID: 58446 RVA: 0x00358A9C File Offset: 0x00356C9C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E44F RID: 58447 RVA: 0x00358AE4 File Offset: 0x00356CE4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E450 RID: 58448 RVA: 0x00358B18 File Offset: 0x00356D18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244726, XrefRangeEnd = 244739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046E9 RID: 18153
				// (get) Token: 0x0600E451 RID: 58449 RVA: 0x00358B54 File Offset: 0x00356D54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E452 RID: 58450 RVA: 0x00358B94 File Offset: 0x00356D94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244739, XrefRangeEnd = 244744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046EA RID: 18154
				// (get) Token: 0x0600E453 RID: 58451 RVA: 0x00358BC8 File Offset: 0x00356DC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E454 RID: 58452 RVA: 0x0006F4ED File Offset: 0x0006D6ED
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046E6 RID: 18150
				// (get) Token: 0x0600E455 RID: 58453 RVA: 0x00358C08 File Offset: 0x00356E08
				// (set) Token: 0x0600E456 RID: 58454 RVA: 0x0006F4F6 File Offset: 0x0006D6F6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046E7 RID: 18151
				// (get) Token: 0x0600E457 RID: 58455 RVA: 0x00358C30 File Offset: 0x00356E30
				// (set) Token: 0x0600E458 RID: 58456 RVA: 0x0006F511 File Offset: 0x0006D711
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046E8 RID: 18152
				// (get) Token: 0x0600E459 RID: 58457 RVA: 0x00358C60 File Offset: 0x00356E60
				// (set) Token: 0x0600E45A RID: 58458 RVA: 0x0006F530 File Offset: 0x0006D730
				public unsafe Equippable_MeleeWeapon.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098B8 RID: 39096
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098B9 RID: 39097
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098BA RID: 39098
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098BB RID: 39099
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098BC RID: 39100
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098BD RID: 39101
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098BE RID: 39102
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098BF RID: 39103
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098C0 RID: 39104
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
