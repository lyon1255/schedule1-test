﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000200 RID: 512
	public class Pourable : Draggable
	{
		// Token: 0x06002A42 RID: 10818 RVA: 0x000F6634 File Offset: 0x000F4834
		// Note: this type is marked as 'beforefieldinit'.
		static Pourable()
		{
			Il2CppClassPointerStore<Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pourable>.NativeClassPtr);
			Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<IsPouring>k__BackingField");
			Pourable.NativeFieldInfoPtr_onInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "onInitialPour");
			Pourable.NativeFieldInfoPtr_Unlimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "Unlimited");
			Pourable.NativeFieldInfoPtr_StartQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "StartQuantity");
			Pourable.NativeFieldInfoPtr_PourRate_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourRate_L");
			Pourable.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AngleFromUpToPour");
			Pourable.NativeFieldInfoPtr_ShakeBoostRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ShakeBoostRate");
			Pourable.NativeFieldInfoPtr_AffectsCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AffectsCoverage");
			Pourable.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMinMultiplier");
			Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMaxMultiplier");
			Pourable.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourParticles");
			Pourable.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourPoint");
			Pourable.NativeFieldInfoPtr_PourLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourLoop");
			Pourable.NativeFieldInfoPtr_TrashItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TrashItem");
			Pourable.NativeFieldInfoPtr_TargetPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TargetPot");
			Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			Pourable.NativeFieldInfoPtr_currentQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "currentQuantity");
			Pourable.NativeFieldInfoPtr_hasPoured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "hasPoured");
			Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "autoSetCurrentQuantity");
			Pourable.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMinSizes");
			Pourable.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMaxSizes");
			Pourable.NativeFieldInfoPtr_accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "accelerometer");
			Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668054);
			Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668055);
			Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668056);
			Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668057);
			Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668058);
			Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668059);
			Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668060);
			Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668061);
			Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668062);
			Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668063);
			Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668064);
			Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668065);
			Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668066);
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000F6920 File Offset: 0x000F4B20
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x000F695C File Offset: 0x000F4B5C
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000F699C File Offset: 0x000F4B9C
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x000F69D8 File Offset: 0x000F4BD8
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000F6A18 File Offset: 0x000F4C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120455, XrefRangeEnd = 120482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000F6A54 File Offset: 0x000F4C54
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000F6A90 File Offset: 0x000F4C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120482, XrefRangeEnd = 120483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000F6ACC File Offset: 0x000F4CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120483, XrefRangeEnd = 120514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000F6B08 File Offset: 0x000F4D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120514, XrefRangeEnd = 120515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShakeBoost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000F6B44 File Offset: 0x000F4D44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120529, RefRangeEnd = 120532, XrefRangeStart = 120515, XrefRangeEnd = 120529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000F6B90 File Offset: 0x000F4D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120542, RefRangeEnd = 120543, XrefRangeStart = 120532, XrefRangeEnd = 120542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPourPointOverPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000F6BCC File Offset: 0x000F4DCC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000F6C14 File Offset: 0x000F4E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120544, RefRangeEnd = 120547, XrefRangeStart = 120543, XrefRangeEnd = 120544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00016E09 File Offset: 0x00015009
		public Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000F6C50 File Offset: 0x000F4E50
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x00016E12 File Offset: 0x00015012
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000F6C78 File Offset: 0x000F4E78
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x00016E2D File Offset: 0x0001502D
		public unsafe Action onInitialPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000F6CA8 File Offset: 0x000F4EA8
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x00016E4C File Offset: 0x0001504C
		public unsafe bool Unlimited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited)) = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000F6CD0 File Offset: 0x000F4ED0
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x00016E67 File Offset: 0x00015067
		public unsafe float StartQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity)) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000F6CF8 File Offset: 0x000F4EF8
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x00016E82 File Offset: 0x00015082
		public unsafe float PourRate_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L)) = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000F6D20 File Offset: 0x000F4F20
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x00016E9D File Offset: 0x0001509D
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000F6D48 File Offset: 0x000F4F48
		// (set) Token: 0x06002A5E RID: 10846 RVA: 0x00016EB8 File Offset: 0x000150B8
		public unsafe float ShakeBoostRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate)) = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000F6D70 File Offset: 0x000F4F70
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x00016ED3 File Offset: 0x000150D3
		public unsafe bool AffectsCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage)) = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000F6D98 File Offset: 0x000F4F98
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x00016EEE File Offset: 0x000150EE
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x000F6DC0 File Offset: 0x000F4FC0
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00016F09 File Offset: 0x00015109
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000F6DE8 File Offset: 0x000F4FE8
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x00016F24 File Offset: 0x00015124
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000F6E18 File Offset: 0x000F5018
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x00016F43 File Offset: 0x00015143
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000F6E48 File Offset: 0x000F5048
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x00016F62 File Offset: 0x00015162
		public unsafe AudioSourceController PourLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x000F6E78 File Offset: 0x000F5078
		// (set) Token: 0x06002A6C RID: 10860 RVA: 0x00016F81 File Offset: 0x00015181
		public unsafe TrashItem TrashItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000F6EA8 File Offset: 0x000F50A8
		// (set) Token: 0x06002A6E RID: 10862 RVA: 0x00016FA0 File Offset: 0x000151A0
		public unsafe Pot TargetPot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetPot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetPot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000F6ED8 File Offset: 0x000F50D8
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x00016FBF File Offset: 0x000151BF
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000F6F00 File Offset: 0x000F5100
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x00016FDA File Offset: 0x000151DA
		public unsafe float currentQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_currentQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_currentQuantity)) = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000F6F28 File Offset: 0x000F5128
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x00016FF5 File Offset: 0x000151F5
		public unsafe bool hasPoured
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured)) = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000F6F50 File Offset: 0x000F5150
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x00017010 File Offset: 0x00015210
		public unsafe bool autoSetCurrentQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity)) = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000F6F78 File Offset: 0x000F5178
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x0001702B File Offset: 0x0001522B
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000F6FA8 File Offset: 0x000F51A8
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0001704A File Offset: 0x0001524A
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000F6FD8 File Offset: 0x000F51D8
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x00017069 File Offset: 0x00015269
		public unsafe AverageAcceleration accelerometer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeFieldInfoPtr_onInitialPour;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeFieldInfoPtr_Unlimited;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeFieldInfoPtr_StartQuantity;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr_PourRate_L;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr_ShakeBoostRate;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr_AffectsCoverage;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr_PourLoop;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr_TrashItem;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr_TargetPot;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr_currentQuantity;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeFieldInfoPtr_hasPoured;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeFieldInfoPtr_autoSetCurrentQuantity;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeFieldInfoPtr_accelerometer;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_GetShakeBoost_Private_Single_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
