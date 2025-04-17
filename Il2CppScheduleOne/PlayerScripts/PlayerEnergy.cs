using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E5 RID: 997
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x060050AD RID: 20653 RVA: 0x00180A88 File Offset: 0x0017EC88
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergy()
		{
			Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerEnergy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr);
			PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "CRITICAL_THRESHOLD");
			PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "MAX_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "SPRINT_DRAIN_MULTIPLIER");
			PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<CurrentEnergy>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<EnergyDrinksConsumed>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "DEBUG_DISABLE_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyDuration_Hours");
			PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyRechargeTime_Hours");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyChanged");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyDepleted");
			PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673427);
			PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673428);
			PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673429);
			PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673430);
			PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673431);
			PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673432);
			PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673433);
			PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673434);
			PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673435);
			PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673436);
			PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673437);
			PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673438);
			PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673439);
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x00180C84 File Offset: 0x0017EE84
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x00180CC0 File Offset: 0x0017EEC0
		public unsafe float CurrentEnergy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x00180D00 File Offset: 0x0017EF00
		// (set) Token: 0x060050B1 RID: 20657 RVA: 0x00180D3C File Offset: 0x0017EF3C
		public unsafe int EnergyDrinksConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00180D7C File Offset: 0x0017EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175225, XrefRangeEnd = 175263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00180DB8 File Offset: 0x0017EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175263, XrefRangeEnd = 175278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00180DEC File Offset: 0x0017EFEC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEnergy(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00180E2C File Offset: 0x0017F02C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnergy(float newEnergy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newEnergy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00180E6C File Offset: 0x0017F06C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00180EA0 File Offset: 0x0017F0A0
		[CallerCount(0)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00180ED4 File Offset: 0x0017F0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175278, RefRangeEnd = 175279, XrefRangeStart = 175278, XrefRangeEnd = 175278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00180F08 File Offset: 0x0017F108
		[CallerCount(0)]
		public unsafe void ResetEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00180F3C File Offset: 0x0017F13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175279, XrefRangeEnd = 175280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x000265AB File Offset: 0x000247AB
		public PlayerEnergy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x00180F78 File Offset: 0x0017F178
		// (set) Token: 0x060050BD RID: 20669 RVA: 0x000265B4 File Offset: 0x000247B4
		public unsafe static float CRITICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x060050BE RID: 20670 RVA: 0x00180F94 File Offset: 0x0017F194
		// (set) Token: 0x060050BF RID: 20671 RVA: 0x000265C2 File Offset: 0x000247C2
		public unsafe static float MAX_ENERGY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&value));
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x00180FB0 File Offset: 0x0017F1B0
		// (set) Token: 0x060050C1 RID: 20673 RVA: 0x000265D0 File Offset: 0x000247D0
		public unsafe static float SPRINT_DRAIN_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x00180FCC File Offset: 0x0017F1CC
		// (set) Token: 0x060050C3 RID: 20675 RVA: 0x000265DE File Offset: 0x000247DE
		public unsafe float _CurrentEnergy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField)) = value;
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x00180FF4 File Offset: 0x0017F1F4
		// (set) Token: 0x060050C5 RID: 20677 RVA: 0x000265F9 File Offset: 0x000247F9
		public unsafe int _EnergyDrinksConsumed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x0018101C File Offset: 0x0017F21C
		// (set) Token: 0x060050C7 RID: 20679 RVA: 0x00026614 File Offset: 0x00024814
		public unsafe bool DEBUG_DISABLE_ENERGY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY)) = value;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x00181044 File Offset: 0x0017F244
		// (set) Token: 0x060050C9 RID: 20681 RVA: 0x0002662F File Offset: 0x0002482F
		public unsafe float EnergyDuration_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours)) = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x0018106C File Offset: 0x0017F26C
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x0002664A File Offset: 0x0002484A
		public unsafe float EnergyRechargeTime_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours)) = value;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x00181094 File Offset: 0x0017F294
		// (set) Token: 0x060050CD RID: 20685 RVA: 0x00026665 File Offset: 0x00024865
		public unsafe UnityEvent onEnergyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x001810C4 File Offset: 0x0017F2C4
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00026684 File Offset: 0x00024884
		public unsafe UnityEvent onEnergyDepleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeFieldInfoPtr_CRITICAL_THRESHOLD;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ENERGY;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEnergy_k__BackingField;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeFieldInfoPtr_EnergyDuration_Hours;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeFieldInfoPtr_EnergyRechargeTime_Hours;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyChanged;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyDepleted;

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeMethodInfoPtr_RestoreEnergy_Public_Void_0;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
