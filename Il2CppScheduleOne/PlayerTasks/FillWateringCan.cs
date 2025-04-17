using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Property.Utilities.Water;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000206 RID: 518
	public class FillWateringCan : Task
	{
		// Token: 0x06002AFE RID: 11006 RVA: 0x000F8998 File Offset: 0x000F6B98
		// Note: this type is marked as 'beforefieldinit'.
		static FillWateringCan()
		{
			Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FillWateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr);
			FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "<TaskName>k__BackingField");
			FillWateringCan.NativeFieldInfoPtr_tap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "tap");
			FillWateringCan.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "instance");
			FillWateringCan.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "visuals");
			FillWateringCan.NativeFieldInfoPtr_audioPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "audioPlayed");
			FillWateringCan.NativeMethodInfoPtr_get_TaskName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668116);
			FillWateringCan.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668117);
			FillWateringCan.NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668118);
			FillWateringCan.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668119);
			FillWateringCan.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668120);
			FillWateringCan.NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668121);
			FillWateringCan.NativeMethodInfoPtr_HandleClickEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668122);
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000F8AB8 File Offset: 0x000F6CB8
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x000F8AF0 File Offset: 0x000F6CF0
		public new unsafe string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_get_TaskName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000F8B34 File Offset: 0x000F6D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121341, RefRangeEnd = 121342, XrefRangeStart = 121279, XrefRangeEnd = 121341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FillWateringCan(Tap _tap, WateringCanInstance _instance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_tap);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000F8B94 File Offset: 0x000F6D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121342, XrefRangeEnd = 121357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWateringCan.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000F8BD0 File Offset: 0x000F6DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121357, XrefRangeEnd = 121389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWateringCan.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000F8C0C File Offset: 0x000F6E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121389, XrefRangeEnd = 121391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000F8C4C File Offset: 0x000F6E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121391, XrefRangeEnd = 121393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_HandleClickEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000174A0 File Offset: 0x000156A0
		public FillWateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000F8C80 File Offset: 0x000F6E80
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000174A9 File Offset: 0x000156A9
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000F8CA8 File Offset: 0x000F6EA8
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000174C8 File Offset: 0x000156C8
		public unsafe Tap tap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_tap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_tap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000F8CD8 File Offset: 0x000F6ED8
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000174E7 File Offset: 0x000156E7
		public unsafe WateringCanInstance instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000F8D08 File Offset: 0x000F6F08
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00017506 File Offset: 0x00015706
		public unsafe WateringCanVisuals visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000F8D38 File Offset: 0x000F6F38
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00017525 File Offset: 0x00015725
		public unsafe bool audioPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_audioPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_audioPlayed)) = value;
			}
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_tap;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_audioPlayed;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_get_String_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_HandleClickEnd_Private_Void_0;
	}
}
