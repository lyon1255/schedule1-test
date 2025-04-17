using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D8 RID: 1752
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D97 RID: 40343 RVA: 0x0027DA98 File Offset: 0x0027BC98
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationUIElement()
		{
			Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr);
			ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "RecipeEntry");
			ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "NoRecipe");
			ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682626);
			ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682627);
			ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682628);
			ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682629);
			ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682630);
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x0027DB68 File Offset: 0x0027BD68
		// (set) Token: 0x06009D99 RID: 40345 RVA: 0x0027DBA8 File Offset: 0x0027BDA8
		public unsafe ChemistryStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x0027DBEC File Offset: 0x0027BDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279434, RefRangeEnd = 279435, XrefRangeStart = 279424, XrefRangeEnd = 279434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ChemistryStation oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x0027DC30 File Offset: 0x0027BE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279435, XrefRangeEnd = 279452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D9C RID: 40348 RVA: 0x0027DC6C File Offset: 0x0027BE6C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D9D RID: 40349 RVA: 0x0004D54E File Offset: 0x0004B74E
		public ChemistryStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06009D9E RID: 40350 RVA: 0x0027DCA8 File Offset: 0x0027BEA8
		// (set) Token: 0x06009D9F RID: 40351 RVA: 0x0004D557 File Offset: 0x0004B757
		public unsafe ChemistryStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06009DA0 RID: 40352 RVA: 0x0027DCD8 File Offset: 0x0027BED8
		// (set) Token: 0x06009DA1 RID: 40353 RVA: 0x0004D576 File Offset: 0x0004B776
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06009DA2 RID: 40354 RVA: 0x0027DD08 File Offset: 0x0027BF08
		// (set) Token: 0x06009DA3 RID: 40355 RVA: 0x0004D595 File Offset: 0x0004B795
		public unsafe GameObject NoRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069D0 RID: 27088
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x040069D1 RID: 27089
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x040069D2 RID: 27090
		private static readonly IntPtr NativeFieldInfoPtr_NoRecipe;

		// Token: 0x040069D3 RID: 27091
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0;

		// Token: 0x040069D4 RID: 27092
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x040069D5 RID: 27093
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0;

		// Token: 0x040069D6 RID: 27094
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069D7 RID: 27095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
