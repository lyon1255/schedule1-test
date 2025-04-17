﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020D RID: 525
	public class SowSeedTask : Task
	{
		// Token: 0x06002B86 RID: 11142 RVA: 0x000FA434 File Offset: 0x000F8634
		// Note: this type is marked as 'beforefieldinit'.
		static SowSeedTask()
		{
			Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "SowSeedTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr);
			SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "<TaskName>k__BackingField");
			SowSeedTask.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "pot");
			SowSeedTask.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "definition");
			SowSeedTask.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seed");
			SowSeedTask.NativeFieldInfoPtr_seedExitedVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedExitedVial");
			SowSeedTask.NativeFieldInfoPtr_seedReachedDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedReachedDestination");
			SowSeedTask.NativeFieldInfoPtr_successfullyPlanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "successfullyPlanted");
			SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "weedSeedStationaryTime");
			SowSeedTask.NativeFieldInfoPtr_capRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "capRemoved");
			SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668180);
			SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668181);
			SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668182);
			SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668183);
			SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668184);
			SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668185);
			SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668186);
			SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668187);
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000FA5B8 File Offset: 0x000F87B8
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x000FA5FC File Offset: 0x000F87FC
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x000FA64C File Offset: 0x000F884C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122346, RefRangeEnd = 122347, XrefRangeStart = 122231, XrefRangeEnd = 122346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SowSeedTask(Pot _pot, SeedDefinition def) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000FA6AC File Offset: 0x000F88AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122347, XrefRangeEnd = 122381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000FA6E8 File Offset: 0x000F88E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122381, XrefRangeEnd = 122417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000FA724 File Offset: 0x000F8924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122417, XrefRangeEnd = 122458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000FA760 File Offset: 0x000F8960
		[CallerCount(0)]
		public unsafe void OnSeedExitVial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000FA794 File Offset: 0x000F8994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122474, RefRangeEnd = 122475, XrefRangeStart = 122458, XrefRangeEnd = 122474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSeedReachedDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x000178ED File Offset: 0x00015AED
		public SowSeedTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000FA7C8 File Offset: 0x000F89C8
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x000178F6 File Offset: 0x00015AF6
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000FA7F0 File Offset: 0x000F89F0
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x00017915 File Offset: 0x00015B15
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000FA820 File Offset: 0x000F8A20
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x00017934 File Offset: 0x00015B34
		public unsafe SeedDefinition definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000FA850 File Offset: 0x000F8A50
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x00017953 File Offset: 0x00015B53
		public unsafe FunctionalSeed seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x000FA880 File Offset: 0x000F8A80
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00017972 File Offset: 0x00015B72
		public unsafe bool seedExitedVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial)) = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000FA8A8 File Offset: 0x000F8AA8
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x0001798D File Offset: 0x00015B8D
		public unsafe bool seedReachedDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination)) = value;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000FA8D0 File Offset: 0x000F8AD0
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x000179A8 File Offset: 0x00015BA8
		public unsafe bool successfullyPlanted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted)) = value;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000FA8F8 File Offset: 0x000F8AF8
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x000179C3 File Offset: 0x00015BC3
		public unsafe float weedSeedStationaryTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime)) = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000FA920 File Offset: 0x000F8B20
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x000179DE File Offset: 0x00015BDE
		public unsafe bool capRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved)) = value;
			}
		}

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeFieldInfoPtr_seedExitedVial;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeFieldInfoPtr_seedReachedDestination;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeFieldInfoPtr_successfullyPlanted;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedStationaryTime;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeFieldInfoPtr_capRemoved;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0;
	}
}
