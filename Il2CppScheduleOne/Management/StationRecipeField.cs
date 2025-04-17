using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000399 RID: 921
	public class StationRecipeField : ConfigField
	{
		// Token: 0x06004841 RID: 18497 RVA: 0x001616B0 File Offset: 0x0015F8B0
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeField()
		{
			Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "StationRecipeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr);
			StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<SelectedRecipe>k__BackingField");
			StationRecipeField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "Options");
			StationRecipeField.NativeFieldInfoPtr_onRecipeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "onRecipeChanged");
			StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672229);
			StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672230);
			StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672231);
			StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672232);
			StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672233);
			StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672234);
			StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672235);
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x001617A8 File Offset: 0x0015F9A8
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x001617E8 File Offset: 0x0015F9E8
		public unsafe StationRecipe SelectedRecipe
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x0016182C File Offset: 0x0015FA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161990, XrefRangeEnd = 162005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x00161878 File Offset: 0x0015FA78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162010, RefRangeEnd = 162012, XrefRangeStart = 162005, XrefRangeEnd = 162010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x001618C8 File Offset: 0x0015FAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162012, XrefRangeEnd = 162016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00161910 File Offset: 0x0015FB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162016, XrefRangeEnd = 162028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr3) : null;
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00161950 File Offset: 0x0015FB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162044, RefRangeEnd = 162045, XrefRangeStart = 162028, XrefRangeEnd = 162044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(StationRecipeFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00022ED7 File Offset: 0x000210D7
		public StationRecipeField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x00161994 File Offset: 0x0015FB94
		// (set) Token: 0x0600484B RID: 18507 RVA: 0x00022EE0 File Offset: 0x000210E0
		public unsafe StationRecipe _SelectedRecipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x001619C4 File Offset: 0x0015FBC4
		// (set) Token: 0x0600484D RID: 18509 RVA: 0x00022EFF File Offset: 0x000210FF
		public unsafe List<StationRecipe> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x0600484E RID: 18510 RVA: 0x001619F4 File Offset: 0x0015FBF4
		// (set) Token: 0x0600484F RID: 18511 RVA: 0x00022F1E File Offset: 0x0002111E
		public unsafe UnityEvent<StationRecipe> onRecipeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeFieldInfoPtr__SelectedRecipe_k__BackingField;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeFieldInfoPtr_onRecipeChanged;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0;

		// Token: 0x02000976 RID: 2422
		[ObfuscatedName("ScheduleOne.Management.StationRecipeField+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600C9B5 RID: 51637 RVA: 0x0030D0A8 File Offset: 0x0030B2A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr);
				StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, "data");
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672236);
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672237);
			}

			// Token: 0x0600C9B6 RID: 51638 RVA: 0x0030D110 File Offset: 0x0030B310
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9B7 RID: 51639 RVA: 0x0030D14C File Offset: 0x0030B34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161987, XrefRangeEnd = 161990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9B8 RID: 51640 RVA: 0x00062156 File Offset: 0x00060356
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE3 RID: 16099
			// (get) Token: 0x0600C9B9 RID: 51641 RVA: 0x0030D19C File Offset: 0x0030B39C
			// (set) Token: 0x0600C9BA RID: 51642 RVA: 0x0006215F File Offset: 0x0006035F
			public unsafe StationRecipeFieldData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400887D RID: 34941
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400887E RID: 34942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400887F RID: 34943
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0;
		}
	}
}
