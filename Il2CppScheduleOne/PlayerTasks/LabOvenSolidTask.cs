using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020A RID: 522
	public class LabOvenSolidTask : Task
	{
		// Token: 0x06002B49 RID: 11081 RVA: 0x000F9770 File Offset: 0x000F7970
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenSolidTask()
		{
			Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "LabOvenSolidTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr);
			LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			LabOvenSolidTask.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "ingredient");
			LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "ingredientQuantity");
			LabOvenSolidTask.NativeFieldInfoPtr_stationItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "stationItems");
			LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "stationDraggables");
			LabOvenSolidTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668153);
			LabOvenSolidTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668154);
			LabOvenSolidTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668155);
			LabOvenSolidTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668156);
			LabOvenSolidTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668157);
			LabOvenSolidTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668158);
			LabOvenSolidTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668159);
			LabOvenSolidTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668160);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668161);
			LabOvenSolidTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668162);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668163);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668164);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668165);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668166);
			LabOvenSolidTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668167);
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000F9944 File Offset: 0x000F7B44
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x000F9984 File Offset: 0x000F7B84
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000F99C8 File Offset: 0x000F7BC8
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x000F9A04 File Offset: 0x000F7C04
		public unsafe LabOvenSolidTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79663, RefRangeEnd = 79664, XrefRangeStart = 79663, XrefRangeEnd = 79664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000F9A44 File Offset: 0x000F7C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121871, RefRangeEnd = 121872, XrefRangeStart = 121832, XrefRangeEnd = 121871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenSolidTask(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000F9A90 File Offset: 0x000F7C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121872, XrefRangeEnd = 121889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000F9ACC File Offset: 0x000F7CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121889, XrefRangeEnd = 121906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000F9B08 File Offset: 0x000F7D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121906, XrefRangeEnd = 121932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000F9B44 File Offset: 0x000F7D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121944, RefRangeEnd = 121945, XrefRangeStart = 121932, XrefRangeEnd = 121944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000F9B78 File Offset: 0x000F7D78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 121955, RefRangeEnd = 121962, XrefRangeStart = 121945, XrefRangeEnd = 121955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000F9BAC File Offset: 0x000F7DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121962, XrefRangeEnd = 121965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000F9BE0 File Offset: 0x000F7DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121965, XrefRangeEnd = 121973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PlaceItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000F9C14 File Offset: 0x000F7E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121973, XrefRangeEnd = 121976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000F9C48 File Offset: 0x000F7E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121976, XrefRangeEnd = 121977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PressButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000F9C7C File Offset: 0x000F7E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121977, XrefRangeEnd = 121983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepInstruction(LabOvenSolidTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00017728 File Offset: 0x00015928
		public LabOvenSolidTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x000F9CB4 File Offset: 0x000F7EB4
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x00017731 File Offset: 0x00015931
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000F9CE4 File Offset: 0x000F7EE4
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x00017750 File Offset: 0x00015950
		public unsafe LabOvenSolidTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000F9D0C File Offset: 0x000F7F0C
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x0001776B File Offset: 0x0001596B
		public unsafe ItemInstance ingredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x000F9D3C File Offset: 0x000F7F3C
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x0001778A File Offset: 0x0001598A
		public unsafe int ingredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity)) = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x000F9D64 File Offset: 0x000F7F64
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x000177A5 File Offset: 0x000159A5
		public unsafe Il2CppReferenceArray<StationItem> stationItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000F9D94 File Offset: 0x000F7F94
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000177C4 File Offset: 0x000159C4
		public unsafe Il2CppReferenceArray<Draggable> stationDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeFieldInfoPtr_ingredient;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeFieldInfoPtr_ingredientQuantity;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeFieldInfoPtr_stationItems;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeFieldInfoPtr_stationDraggables;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0;

		// Token: 0x020008E2 RID: 2274
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x04008533 RID: 34099
			OpenDoor,
			// Token: 0x04008534 RID: 34100
			PlaceItems,
			// Token: 0x04008535 RID: 34101
			CloseDoor,
			// Token: 0x04008536 RID: 34102
			PressButton
		}
	}
}
