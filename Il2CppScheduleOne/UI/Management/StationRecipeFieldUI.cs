using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.UI.Stations;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CD RID: 1741
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x06009C5F RID: 40031 RVA: 0x00279D18 File Offset: 0x00277F18
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldUI()
		{
			Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StationRecipeFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr);
			StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "RecipeEntry");
			StationRecipeFieldUI.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "None");
			StationRecipeFieldUI.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "Mixed");
			StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "ClearButton");
			StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682494);
			StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682495);
			StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682496);
			StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682497);
			StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682498);
			StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682499);
			StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682500);
			StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682501);
			StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682502);
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x06009C60 RID: 40032 RVA: 0x00279E60 File Offset: 0x00278060
		// (set) Token: 0x06009C61 RID: 40033 RVA: 0x00279EA0 File Offset: 0x002780A0
		public unsafe List<StationRecipeField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x00279EE4 File Offset: 0x002780E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277371, RefRangeEnd = 277372, XrefRangeStart = 277344, XrefRangeEnd = 277371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<StationRecipeField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x00279F28 File Offset: 0x00278128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277398, RefRangeEnd = 277399, XrefRangeStart = 277372, XrefRangeEnd = 277398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(StationRecipe newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x00279F6C File Offset: 0x0027816C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277410, RefRangeEnd = 277412, XrefRangeStart = 277399, XrefRangeEnd = 277410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x00279FA8 File Offset: 0x002781A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277412, XrefRangeEnd = 277456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x00279FDC File Offset: 0x002781DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277456, XrefRangeEnd = 277471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x0027A020 File Offset: 0x00278220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277471, XrefRangeEnd = 277486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x0027A054 File Offset: 0x00278254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277486, XrefRangeEnd = 277494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x0004CA70 File Offset: 0x0004AC70
		public StationRecipeFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06009C6A RID: 40042 RVA: 0x0027A090 File Offset: 0x00278290
		// (set) Token: 0x06009C6B RID: 40043 RVA: 0x0004CA79 File Offset: 0x0004AC79
		public unsafe List<StationRecipeField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x0027A0C0 File Offset: 0x002782C0
		// (set) Token: 0x06009C6D RID: 40045 RVA: 0x0004CA98 File Offset: 0x0004AC98
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x06009C6E RID: 40046 RVA: 0x0027A0F0 File Offset: 0x002782F0
		// (set) Token: 0x06009C6F RID: 40047 RVA: 0x0004CAB7 File Offset: 0x0004ACB7
		public unsafe GameObject None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x06009C70 RID: 40048 RVA: 0x0027A120 File Offset: 0x00278320
		// (set) Token: 0x06009C71 RID: 40049 RVA: 0x0004CAD6 File Offset: 0x0004ACD6
		public unsafe GameObject Mixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x06009C72 RID: 40050 RVA: 0x0027A150 File Offset: 0x00278350
		// (set) Token: 0x06009C73 RID: 40051 RVA: 0x0004CAF5 File Offset: 0x0004ACF5
		public unsafe GameObject ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400690A RID: 26890
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400690B RID: 26891
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x0400690C RID: 26892
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x0400690D RID: 26893
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x0400690E RID: 26894
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x0400690F RID: 26895
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0;

		// Token: 0x04006910 RID: 26896
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0;

		// Token: 0x04006911 RID: 26897
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0;

		// Token: 0x04006912 RID: 26898
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0;

		// Token: 0x04006913 RID: 26899
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006914 RID: 26900
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006915 RID: 26901
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0;

		// Token: 0x04006916 RID: 26902
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006917 RID: 26903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8F RID: 2959
		[ObfuscatedName("ScheduleOne.UI.Management.StationRecipeFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBEE RID: 56302 RVA: 0x00340650 File Offset: 0x0033E850
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr);
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9");
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682504);
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682505);
			}

			// Token: 0x0600DBEF RID: 56303 RVA: 0x003406CC File Offset: 0x0033E8CC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF0 RID: 56304 RVA: 0x00340708 File Offset: 0x0033E908
			[CallerCount(0)]
			public unsafe bool _Clicked_b__11_0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF1 RID: 56305 RVA: 0x0006B25C File Offset: 0x0006945C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004430 RID: 17456
			// (get) Token: 0x0600DBF2 RID: 56306 RVA: 0x00340758 File Offset: 0x0033E958
			// (set) Token: 0x0600DBF3 RID: 56307 RVA: 0x0006B265 File Offset: 0x00069465
			public unsafe static StationRecipeFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004431 RID: 17457
			// (get) Token: 0x0600DBF4 RID: 56308 RVA: 0x00340780 File Offset: 0x0033E980
			// (set) Token: 0x0600DBF5 RID: 56309 RVA: 0x0006B277 File Offset: 0x00069477
			public unsafe static Func<StationRecipe, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009371 RID: 37745
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009372 RID: 37746
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009373 RID: 37747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009374 RID: 37748
			private static readonly IntPtr NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0;
		}
	}
}
