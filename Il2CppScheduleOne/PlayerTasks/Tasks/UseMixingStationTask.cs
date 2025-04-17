using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000215 RID: 533
	public class UseMixingStationTask : Task
	{
		// Token: 0x06002C4D RID: 11341 RVA: 0x000FCCE8 File Offset: 0x000FAEE8
		// Note: this type is marked as 'beforefieldinit'.
		static UseMixingStationTask()
		{
			Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "UseMixingStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr);
			UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "items");
			UseMixingStationTask.NativeFieldInfoPtr_mixerItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "mixerItems");
			UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "ingredientPieces");
			UseMixingStationTask.NativeFieldInfoPtr_removedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "removedIngredients");
			UseMixingStationTask.NativeFieldInfoPtr_Jug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "Jug");
			UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668279);
			UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668280);
			UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668281);
			UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668282);
			UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668283);
			UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668284);
			UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668285);
			UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668286);
			UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668287);
			UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668288);
			UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668289);
			UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668290);
			UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668291);
			UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668292);
			UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668293);
			UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668294);
			UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668295);
			UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668296);
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x000FCF0C File Offset: 0x000FB10C
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x000FCF4C File Offset: 0x000FB14C
		public unsafe MixingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000FCF90 File Offset: 0x000FB190
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x000FCFCC File Offset: 0x000FB1CC
		public unsafe UseMixingStationTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79663, RefRangeEnd = 79664, XrefRangeStart = 79663, XrefRangeEnd = 79664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000FD00C File Offset: 0x000FB20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123618, XrefRangeEnd = 123622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000FD044 File Offset: 0x000FB244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123705, RefRangeEnd = 123706, XrefRangeStart = 123622, XrefRangeEnd = 123705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseMixingStationTask(MixingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000FD090 File Offset: 0x000FB290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123706, XrefRangeEnd = 123728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker CreateJug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr3) : null;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000FD0D0 File Offset: 0x000FB2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123728, XrefRangeEnd = 123738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000FD10C File Offset: 0x000FB30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123771, RefRangeEnd = 123772, XrefRangeStart = 123738, XrefRangeEnd = 123771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000FD140 File Offset: 0x000FB340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123772, XrefRangeEnd = 123779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000FD174 File Offset: 0x000FB374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123779, XrefRangeEnd = 123786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000FD1A8 File Offset: 0x000FB3A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123819, RefRangeEnd = 123823, XrefRangeStart = 123786, XrefRangeEnd = 123819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCombinedIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000FD1E4 File Offset: 0x000FB3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123823, XrefRangeEnd = 123824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000FD218 File Offset: 0x000FB418
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000FD24C File Offset: 0x000FB44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123824, XrefRangeEnd = 123842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000FD288 File Offset: 0x000FB488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123878, RefRangeEnd = 123879, XrefRangeStart = 123842, XrefRangeEnd = 123878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000FD2BC File Offset: 0x000FB4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123879, XrefRangeEnd = 123924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000FD2F8 File Offset: 0x000FB4F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123990, RefRangeEnd = 123992, XrefRangeStart = 123924, XrefRangeEnd = 123990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.__c__DisplayClass15_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00017EC5 File Offset: 0x000160C5
		public UseMixingStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000FD36C File Offset: 0x000FB56C
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00017ECE File Offset: 0x000160CE
		public unsafe MixingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000FD39C File Offset: 0x000FB59C
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x00017EED File Offset: 0x000160ED
		public unsafe UseMixingStationTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000FD3C4 File Offset: 0x000FB5C4
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00017F08 File Offset: 0x00016108
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000FD3F4 File Offset: 0x000FB5F4
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00017F27 File Offset: 0x00016127
		public unsafe List<StationItem> mixerItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000FD424 File Offset: 0x000FB624
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x00017F46 File Offset: 0x00016146
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000FD454 File Offset: 0x000FB654
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x00017F65 File Offset: 0x00016165
		public unsafe Il2CppReferenceArray<ItemInstance> removedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x000FD484 File Offset: 0x000FB684
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00017F84 File Offset: 0x00016184
		public unsafe Beaker Jug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr_mixerItems;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_removedIngredients;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeFieldInfoPtr_Jug;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_CreateJug_Private_Beaker_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrash_Private_Void_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0;

		// Token: 0x020008E8 RID: 2280
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400855E RID: 34142
			CombineIngredients,
			// Token: 0x0400855F RID: 34143
			StartMixing
		}

		// Token: 0x020008E9 RID: 2281
		[ObfuscatedName("ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : ValueType
		{
			// Token: 0x0600C4B0 RID: 50352 RVA: 0x002FE550 File Offset: 0x002FC750
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr);
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "station");
			}

			// Token: 0x0600C4B1 RID: 50353 RVA: 0x0005FB68 File Offset: 0x0005DD68
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C4B2 RID: 50354 RVA: 0x0005FB71 File Offset: 0x0005DD71
			public __c__DisplayClass15_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003D66 RID: 15718
			// (get) Token: 0x0600C4B3 RID: 50355 RVA: 0x002FE5A4 File Offset: 0x002FC7A4
			// (set) Token: 0x0600C4B4 RID: 50356 RVA: 0x0005FB83 File Offset: 0x0005DD83
			public unsafe UseMixingStationTask __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseMixingStationTask>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D67 RID: 15719
			// (get) Token: 0x0600C4B5 RID: 50357 RVA: 0x002FE5D4 File Offset: 0x002FC7D4
			// (set) Token: 0x0600C4B6 RID: 50358 RVA: 0x0005FBA2 File Offset: 0x0005DDA2
			public unsafe MixingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008560 RID: 34144
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008561 RID: 34145
			private static readonly IntPtr NativeFieldInfoPtr_station;
		}
	}
}
