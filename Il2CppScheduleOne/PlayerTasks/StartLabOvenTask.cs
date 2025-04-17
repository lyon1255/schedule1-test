using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020E RID: 526
	public class StartLabOvenTask : Task
	{
		// Token: 0x06002BA2 RID: 11170 RVA: 0x000FA948 File Offset: 0x000F8B48
		// Note: this type is marked as 'beforefieldinit'.
		static StartLabOvenTask()
		{
			Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "StartLabOvenTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr);
			StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<Oven>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "ingredient");
			StartLabOvenTask.NativeFieldInfoPtr_pourRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourRoutine");
			StartLabOvenTask.NativeFieldInfoPtr_stationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "stationItem");
			StartLabOvenTask.NativeFieldInfoPtr_pourableModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourableModule");
			StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourAnimDone");
			StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668188);
			StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668189);
			StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668190);
			StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668191);
			StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668192);
			StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668193);
			StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668194);
			StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668195);
			StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668196);
			StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668197);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668198);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668199);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668200);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668201);
			StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668202);
			StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668203);
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000FAB44 File Offset: 0x000F8D44
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x000FAB84 File Offset: 0x000F8D84
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000FABC8 File Offset: 0x000F8DC8
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x000FAC04 File Offset: 0x000F8E04
		public unsafe StartLabOvenTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79663, RefRangeEnd = 79664, XrefRangeStart = 79663, XrefRangeEnd = 79664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 121043, RefRangeEnd = 121052, XrefRangeStart = 121043, XrefRangeEnd = 121052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000FAC44 File Offset: 0x000F8E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122538, RefRangeEnd = 122539, XrefRangeStart = 122486, XrefRangeEnd = 122538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLabOvenTask(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000FAC90 File Offset: 0x000F8E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122539, XrefRangeEnd = 122565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000FACCC File Offset: 0x000F8ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122565, XrefRangeEnd = 122582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000FAD08 File Offset: 0x000F8F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122582, XrefRangeEnd = 122609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x000FAD44 File Offset: 0x000F8F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122609, XrefRangeEnd = 122613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000FAD78 File Offset: 0x000F8F78
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 122623, RefRangeEnd = 122632, XrefRangeStart = 122613, XrefRangeEnd = 122623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000FADAC File Offset: 0x000F8FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122632, XrefRangeEnd = 122635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000FADE0 File Offset: 0x000F8FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122635, XrefRangeEnd = 122636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_Pour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000FAE14 File Offset: 0x000F9014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122636, XrefRangeEnd = 122639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000FAE48 File Offset: 0x000F9048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122639, XrefRangeEnd = 122640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PressButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000FAE7C File Offset: 0x000F907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122640, XrefRangeEnd = 122645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayPourAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000FAEBC File Offset: 0x000F90BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122645, XrefRangeEnd = 122651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000179F9 File Offset: 0x00015BF9
		public StartLabOvenTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000FAEF4 File Offset: 0x000F90F4
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00017A02 File Offset: 0x00015C02
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000FAF24 File Offset: 0x000F9124
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00017A21 File Offset: 0x00015C21
		public unsafe StartLabOvenTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000FAF4C File Offset: 0x000F914C
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00017A3C File Offset: 0x00015C3C
		public unsafe ItemInstance ingredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000FAF7C File Offset: 0x000F917C
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00017A5B File Offset: 0x00015C5B
		public unsafe Coroutine pourRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000FAFAC File Offset: 0x000F91AC
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00017A7A File Offset: 0x00015C7A
		public unsafe StationItem stationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000FAFDC File Offset: 0x000F91DC
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x00017A99 File Offset: 0x00015C99
		public unsafe PourableModule pourableModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000FB00C File Offset: 0x000F920C
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x00017AB8 File Offset: 0x00015CB8
		public unsafe bool pourAnimDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone)) = value;
			}
		}

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_ingredient;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr_pourRoutine;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr_stationItem;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeFieldInfoPtr_pourableModule;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeFieldInfoPtr_pourAnimDone;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0;

		// Token: 0x020008E3 RID: 2275
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x04008538 RID: 34104
			OpenDoor,
			// Token: 0x04008539 RID: 34105
			Pour,
			// Token: 0x0400853A RID: 34106
			CloseDoor,
			// Token: 0x0400853B RID: 34107
			PressButton
		}

		// Token: 0x020008E4 RID: 2276
		[ObfuscatedName("ScheduleOne.PlayerTasks.StartLabOvenTask+<PlayPourAnimation>d__24")]
		public sealed class _PlayPourAnimation_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600C482 RID: 50306 RVA: 0x002FDC5C File Offset: 0x002FBE5C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayPourAnimation_d__24()
			{
				Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<PlayPourAnimation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>1__state");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>2__current");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>4__this");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<pourTime>5__2");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<i>5__3");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668204);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668205);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668206);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668207);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668208);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668209);
			}

			// Token: 0x0600C483 RID: 50307 RVA: 0x002FDD64 File Offset: 0x002FBF64
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayPourAnimation_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C484 RID: 50308 RVA: 0x002FDDAC File Offset: 0x002FBFAC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C485 RID: 50309 RVA: 0x002FDDE0 File Offset: 0x002FBFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122475, XrefRangeEnd = 122481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D5A RID: 15706
			// (get) Token: 0x0600C486 RID: 50310 RVA: 0x002FDE1C File Offset: 0x002FC01C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C487 RID: 50311 RVA: 0x002FDE5C File Offset: 0x002FC05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122481, XrefRangeEnd = 122486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D5B RID: 15707
			// (get) Token: 0x0600C488 RID: 50312 RVA: 0x002FDE90 File Offset: 0x002FC090
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C489 RID: 50313 RVA: 0x0005FA0C File Offset: 0x0005DC0C
			public _PlayPourAnimation_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D55 RID: 15701
			// (get) Token: 0x0600C48A RID: 50314 RVA: 0x002FDED0 File Offset: 0x002FC0D0
			// (set) Token: 0x0600C48B RID: 50315 RVA: 0x0005FA15 File Offset: 0x0005DC15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D56 RID: 15702
			// (get) Token: 0x0600C48C RID: 50316 RVA: 0x002FDEF8 File Offset: 0x002FC0F8
			// (set) Token: 0x0600C48D RID: 50317 RVA: 0x0005FA30 File Offset: 0x0005DC30
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D57 RID: 15703
			// (get) Token: 0x0600C48E RID: 50318 RVA: 0x002FDF28 File Offset: 0x002FC128
			// (set) Token: 0x0600C48F RID: 50319 RVA: 0x0005FA4F File Offset: 0x0005DC4F
			public unsafe StartLabOvenTask __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenTask>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D58 RID: 15704
			// (get) Token: 0x0600C490 RID: 50320 RVA: 0x002FDF58 File Offset: 0x002FC158
			// (set) Token: 0x0600C491 RID: 50321 RVA: 0x0005FA6E File Offset: 0x0005DC6E
			public unsafe float _pourTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2)) = value;
				}
			}

			// Token: 0x17003D59 RID: 15705
			// (get) Token: 0x0600C492 RID: 50322 RVA: 0x002FDF80 File Offset: 0x002FC180
			// (set) Token: 0x0600C493 RID: 50323 RVA: 0x0005FA89 File Offset: 0x0005DC89
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400853C RID: 34108
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400853D RID: 34109
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400853E RID: 34110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400853F RID: 34111
			private static readonly IntPtr NativeFieldInfoPtr__pourTime_5__2;

			// Token: 0x04008540 RID: 34112
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008541 RID: 34113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008542 RID: 34114
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008543 RID: 34115
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008544 RID: 34116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008545 RID: 34117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008546 RID: 34118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
