using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067D RID: 1661
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x06009479 RID: 38009 RVA: 0x00262230 File Offset: 0x00260430
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeEntry()
		{
			Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "StationRecipeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr);
			StationRecipeEntry.NativeFieldInfoPtr_ValidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "ValidColor");
			StationRecipeEntry.NativeFieldInfoPtr_InvalidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "InvalidColor");
			StationRecipeEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Button");
			StationRecipeEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Icon");
			StationRecipeEntry.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "TitleLabel");
			StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "CookingTimeLabel");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientRects");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientQuantities");
			StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<IsValid>k__BackingField");
			StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<Recipe>k__BackingField");
			StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681677);
			StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681678);
			StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681679);
			StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681680);
			StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681681);
			StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681682);
			StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681683);
			StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681684);
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x002623C8 File Offset: 0x002605C8
		// (set) Token: 0x0600947B RID: 38011 RVA: 0x00262404 File Offset: 0x00260604
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600947C RID: 38012 RVA: 0x00262444 File Offset: 0x00260644
		// (set) Token: 0x0600947D RID: 38013 RVA: 0x00262484 File Offset: 0x00260684
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x002624C8 File Offset: 0x002606C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 266911, RefRangeEnd = 266915, XrefRangeStart = 266846, XrefRangeEnd = 266911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x0026250C File Offset: 0x0026070C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266978, RefRangeEnd = 266980, XrefRangeStart = 266915, XrefRangeEnd = 266978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshValidity(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00262550 File Offset: 0x00260750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267050, RefRangeEnd = 267051, XrefRangeStart = 266980, XrefRangeEnd = 267050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x002625A0 File Offset: 0x002607A0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x0004815E File Offset: 0x0004635E
		public StationRecipeEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x06009483 RID: 38019 RVA: 0x002625DC File Offset: 0x002607DC
		// (set) Token: 0x06009484 RID: 38020 RVA: 0x00048167 File Offset: 0x00046367
		public unsafe static Color ValidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&value));
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x002625F8 File Offset: 0x002607F8
		// (set) Token: 0x06009486 RID: 38022 RVA: 0x00048175 File Offset: 0x00046375
		public unsafe static Color InvalidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&value));
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x00262614 File Offset: 0x00260814
		// (set) Token: 0x06009488 RID: 38024 RVA: 0x00048183 File Offset: 0x00046383
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x00262644 File Offset: 0x00260844
		// (set) Token: 0x0600948A RID: 38026 RVA: 0x000481A2 File Offset: 0x000463A2
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x00262674 File Offset: 0x00260874
		// (set) Token: 0x0600948C RID: 38028 RVA: 0x000481C1 File Offset: 0x000463C1
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600948D RID: 38029 RVA: 0x002626A4 File Offset: 0x002608A4
		// (set) Token: 0x0600948E RID: 38030 RVA: 0x000481E0 File Offset: 0x000463E0
		public unsafe TextMeshProUGUI CookingTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600948F RID: 38031 RVA: 0x002626D4 File Offset: 0x002608D4
		// (set) Token: 0x06009490 RID: 38032 RVA: 0x000481FF File Offset: 0x000463FF
		public unsafe Il2CppReferenceArray<RectTransform> IngredientRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x06009491 RID: 38033 RVA: 0x00262704 File Offset: 0x00260904
		// (set) Token: 0x06009492 RID: 38034 RVA: 0x0004821E File Offset: 0x0004641E
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> IngredientQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x06009493 RID: 38035 RVA: 0x00262734 File Offset: 0x00260934
		// (set) Token: 0x06009494 RID: 38036 RVA: 0x0004823D File Offset: 0x0004643D
		public unsafe bool _IsValid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x06009495 RID: 38037 RVA: 0x0026275C File Offset: 0x0026095C
		// (set) Token: 0x06009496 RID: 38038 RVA: 0x00048258 File Offset: 0x00046458
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006428 RID: 25640
		private static readonly IntPtr NativeFieldInfoPtr_ValidColor;

		// Token: 0x04006429 RID: 25641
		private static readonly IntPtr NativeFieldInfoPtr_InvalidColor;

		// Token: 0x0400642A RID: 25642
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x0400642B RID: 25643
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400642C RID: 25644
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400642D RID: 25645
		private static readonly IntPtr NativeFieldInfoPtr_CookingTimeLabel;

		// Token: 0x0400642E RID: 25646
		private static readonly IntPtr NativeFieldInfoPtr_IngredientRects;

		// Token: 0x0400642F RID: 25647
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantities;

		// Token: 0x04006430 RID: 25648
		private static readonly IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;

		// Token: 0x04006431 RID: 25649
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04006432 RID: 25650
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04006433 RID: 25651
		private static readonly IntPtr NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0;

		// Token: 0x04006434 RID: 25652
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04006435 RID: 25653
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04006436 RID: 25654
		private static readonly IntPtr NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04006437 RID: 25655
		private static readonly IntPtr NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0;

		// Token: 0x04006438 RID: 25656
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0;

		// Token: 0x04006439 RID: 25657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5A RID: 2906
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA1D RID: 55837 RVA: 0x0033B648 File Offset: 0x00339848
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr);
				StationRecipeEntry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9");
				StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9__18_0");
				StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100681687);
				StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100681688);
			}

			// Token: 0x0600DA1E RID: 55838 RVA: 0x0033B6C4 File Offset: 0x003398C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA1F RID: 55839 RVA: 0x0033B700 File Offset: 0x00339900
			[CallerCount(0)]
			public unsafe int _GetIngredientsMatchDelta_b__18_0(StationRecipe.IngredientQuantity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA20 RID: 55840 RVA: 0x0006A37F File Offset: 0x0006857F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x0033B750 File Offset: 0x00339950
			// (set) Token: 0x0600DA22 RID: 55842 RVA: 0x0006A388 File Offset: 0x00068588
			public unsafe static StationRecipeEntry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AD RID: 17325
			// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x0033B778 File Offset: 0x00339978
			// (set) Token: 0x0600DA24 RID: 55844 RVA: 0x0006A39A File Offset: 0x0006859A
			public unsafe static Func<StationRecipe.IngredientQuantity, int> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe.IngredientQuantity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009273 RID: 37491
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009274 RID: 37492
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04009275 RID: 37493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009276 RID: 37494
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0;
		}

		// Token: 0x02000B5B RID: 2907
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA25 RID: 55845 RVA: 0x0033B7A0 File Offset: 0x003399A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100681689);
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100681690);
			}

			// Token: 0x0600DA26 RID: 55846 RVA: 0x0033B808 File Offset: 0x00339A08
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA27 RID: 55847 RVA: 0x0033B844 File Offset: 0x00339A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshValidity_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA28 RID: 55848 RVA: 0x0006A3AC File Offset: 0x000685AC
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AE RID: 17326
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x0033B894 File Offset: 0x00339A94
			// (set) Token: 0x0600DA2A RID: 55850 RVA: 0x0006A3B5 File Offset: 0x000685B5
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009277 RID: 37495
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04009278 RID: 37496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009279 RID: 37497
			private static readonly IntPtr NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA2B RID: 55851 RVA: 0x0033B8C4 File Offset: 0x00339AC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100681691);
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100681692);
			}

			// Token: 0x0600DA2C RID: 55852 RVA: 0x0033B92C File Offset: 0x00339B2C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA2D RID: 55853 RVA: 0x0033B968 File Offset: 0x00339B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIngredientsMatchDelta_b__1(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA2E RID: 55854 RVA: 0x0006A3D4 File Offset: 0x000685D4
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AF RID: 17327
			// (get) Token: 0x0600DA2F RID: 55855 RVA: 0x0033B9B8 File Offset: 0x00339BB8
			// (set) Token: 0x0600DA30 RID: 55856 RVA: 0x0006A3DD File Offset: 0x000685DD
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400927A RID: 37498
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x0400927B RID: 37499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400927C RID: 37500
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0;
		}
	}
}
